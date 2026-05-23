Imports System.Data.SqlClient

Public Class UC_OrderDetails
    ' Database Connection
    Dim connStr As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\HatidDB.mdf;Integrated Security=True"

    Public currentStudentID As String = "1"

    Private Sub UC_OrderDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckActiveOrders()
    End Sub

    ' 1. Displays the latest active order and the Secret Seal Code
    Public Sub CheckActiveOrders()
        Try
            Using conn As New SqlConnection(connStr)
                Dim query As String = "SELECT TOP 1 FoodRequest, RunnerStatus, SealCode FROM DeliveryPool WHERE RunnerStatus != 'Completed' ORDER BY RequestID DESC"
                Using cmd As New SqlCommand(query, conn)
                    conn.Open()
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim order As String = reader("FoodRequest").ToString()
                            Dim status As String = reader("RunnerStatus").ToString().ToUpper()
                            Dim code As String = reader("SealCode").ToString()
                            lblOrderSummary.Text = "Active Order: " & order & vbCrLf &
                                                   "Current Status: " & status & vbCrLf &
                                                   "Your Secure Seal Code: " & code
                        Else
                            lblOrderSummary.Text = "Status: [IDLE] - No active delivery runs."
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            lblOrderSummary.Text = "System Ready."
        End Try
    End Sub

    ' 2. The Verification Handshake
    Private Sub btnConfirmHandshake_Click(sender As Object, e As EventArgs) Handles btnConfirmHandshake.Click
        Dim enteredCode As String = txtSealCode.Text.Trim()
        If enteredCode.Length <> 4 Then
            MessageBox.Show("Please enter the correct 4-digit Secure Seal Code.", "Invalid Code", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Using conn As New SqlConnection(connStr)
                Dim query As String = "UPDATE TOP (1) DeliveryPool SET RunnerStatus = 'Completed' WHERE RunnerStatus = 'Out for Delivery' AND SealCode = @EnteredCode"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@EnteredCode", enteredCode)
                    conn.Open()
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("✅ Secure Handshake Verified! Order Completed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtSealCode.Clear()
                        CheckActiveOrders()
                    Else
                        MessageBox.Show("❌ Invalid Seal Code!", "Security Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Database Error: " & ex.Message)
        End Try
    End Sub

    ' 3. Submit Rating Function
    Private Sub btnSubmitRating_Click(sender As Object, e As EventArgs) Handles btnSubmitRating.Click
        If cmbRating.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a rating first.")
            Return
        End If

        Dim query As String = "INSERT INTO [Ratings] (StudentID, RatingValue) VALUES (@ID, @Rating)"
        Using conn As New SqlConnection(connStr)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ID", currentStudentID)
                cmd.Parameters.AddWithValue("@Rating", Convert.ToInt32(cmbRating.SelectedItem.ToString().Substring(0, 1)))
                conn.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("Reputation score submitted successfully!")
            End Using
        End Using
    End Sub
End Class