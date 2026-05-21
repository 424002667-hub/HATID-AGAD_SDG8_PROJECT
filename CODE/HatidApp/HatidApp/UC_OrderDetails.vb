Imports System.Data.SqlClient

Public Class UC_OrderDetails
    Dim connStr As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\HatidDB.mdf;Integrated Security=True"

    Private Sub UC_OrderDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckActiveOrders()
    End Sub

    ' 1. Displays the latest active order and the Secret Seal Code
    Public Sub CheckActiveOrders()
        Try
            Using conn As New SqlConnection(connStr)
                ' Fetch the order status and the SealCode from the database
                Dim query As String = "SELECT TOP 1 FoodRequest, RunnerStatus, SealCode FROM DeliveryPool WHERE RunnerStatus != 'Completed' ORDER BY RequestID DESC"

                Using cmd As New SqlCommand(query, conn)
                    conn.Open()
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim order As String = reader("FoodRequest").ToString()
                            Dim status As String = reader("RunnerStatus").ToString().ToUpper()
                            Dim code As String = reader("SealCode").ToString()

                            ' Displaying details to the user
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

    ' 2. The Verification Handshake (The Security Check)
    Private Sub btnConfirmHandshake_Click(sender As Object, e As EventArgs) Handles btnConfirmHandshake.Click
        Dim enteredCode As String = txtSealCode.Text.Trim()

        ' Simple security check
        If enteredCode.Length <> 4 Then
            MessageBox.Show("Please enter the correct 4-digit Secure Seal Code.", "Invalid Code", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Using conn As New SqlConnection(connStr)
                ' ONLY mark as completed if the status is 'Out for Delivery' AND the code matches
                Dim query As String = "UPDATE TOP (1) DeliveryPool SET RunnerStatus = 'Completed' WHERE RunnerStatus = 'Out for Delivery' AND SealCode = @EnteredCode"

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@EnteredCode", enteredCode)
                    conn.Open()

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("✅ Secure Handshake Verified! Order Completed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtSealCode.Clear()
                        CheckActiveOrders() ' Refresh screen
                    Else
                        MessageBox.Show("❌ Invalid Seal Code! The runner or code is incorrect.", "Security Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub pnlVerificationCard_Paint(sender As Object, e As PaintEventArgs) Handles pnlVerificationCard.Paint

    End Sub
End Class