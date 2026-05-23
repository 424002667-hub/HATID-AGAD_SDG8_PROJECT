Imports System.Data.SqlClient

Public Class UC_OrderDetails
    Private connStr As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\HATID-AGAD_SDG8_PROJECT\CODE\HatidApp\HatidApp\HatidDB.mdf;Integrated Security=True"
    Private Sub UC_OrderDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Start the timer to check for status updates automatically
        Timer1.Start()
        CheckActiveOrders()
    End Sub

    ' Timer tick to refresh the order status every 2 seconds
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        CheckActiveOrders()
    End Sub

    ' Displays the latest order if the status is 'Out for Delivery'
    ' Ensure this method is PUBLIC
    ' In UC_OrderDetails.vb
    Public Sub CheckActiveOrders()
        Try
            Using conn As New SqlConnection(connStr) ' Use the new hardcoded connStr
                conn.Open()
                ' Ensure the status matches exactly what is in your database
                Dim query As String = "SELECT TOP 1 FoodRequest FROM DeliveryPool WHERE RunnerStatus = 'Out for Delivery' ORDER BY RequestID DESC"

                Using cmd As New SqlCommand(query, conn)
                    Dim result = cmd.ExecuteScalar()

                    ' Update your UI safely without a MessageBox
                    If result IsNot Nothing Then
                        lblOrderSummary.Text = "ACTIVE ORDER: " & result.ToString()
                    Else
                        lblOrderSummary.Text = "Status: [IDLE]"
                    End If
                End Using
            End Using
        Catch ex As Exception
            ' Log to output window instead of popping up boxes
            Debug.WriteLine("Database Error: " & ex.Message)
        End Try
    End Sub

    ' Verification Handshake Logic
    Private Sub btnConfirmHandshake_Click(sender As Object, e As EventArgs) Handles btnConfirmHandshake.Click
        Dim enteredCode As String = txtSealCode.Text.Trim()

        Try
            Using conn As New SqlConnection(connStr)
                Dim query As String = "SELECT SealCode FROM DeliveryPool WHERE RunnerStatus = 'Out for Delivery' AND SealCode = @EnteredCode"

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@EnteredCode", enteredCode)
                    conn.Open()

                    Dim result = cmd.ExecuteScalar()

                    If result IsNot Nothing Then
                        MessageBox.Show("Handshake Successful! Verification Complete.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Invalid Seal Code. Please try again.", "Verification Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("System Error during handshake: " & ex.Message)
        End Try
    End Sub

    ' Submit Rating Function
    Private Sub btnSubmitRating_Click(sender As Object, e As EventArgs) Handles btnSubmitRating.Click
        If cmbRating.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a rating first.")
            Return
        End If

        Dim parentForm As FrmDashboard = CType(Me.FindForm(), FrmDashboard)
        Dim studentID As String = parentForm.LoggedInStudentID

        ' Update line 79 to look exactly like this:
        Dim query As String = "INSERT INTO Ratings (StudentID, RatingValue, DateSubmitted) VALUES (@ID, @Rating, @Date)"
        Using conn As New SqlConnection(connStr)
            ' Write the full query string directly here to prevent truncation
            Dim sql As String = "INSERT INTO Ratings (StudentID, RatingValue, DateSubmitted) VALUES (@ID, @Rating, @Date)"

            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@ID", studentID)
                cmd.Parameters.AddWithValue("@Rating", Convert.ToInt32(cmbRating.SelectedItem.ToString().Substring(0, 1)))
                cmd.Parameters.AddWithValue("@Date", DateTime.Now)

                conn.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("Reputation score submitted successfully!")
            End Using
        End Using
    End Sub

    Private Sub pnlVerificationCard_Paint(sender As Object, e As PaintEventArgs) Handles pnlVerificationCard.Paint

    End Sub
End Class