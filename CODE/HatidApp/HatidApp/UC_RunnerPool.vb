Imports System.Data.SqlClient

Public Class UC_RunnerPool
    Dim connStr As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\HatidDB.mdf;Integrated Security=True"

    ' Automatically pulls up open delivery runs when this screen loads
    Private Sub UC_RunnerPool_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAvailableOrders()
    End Sub

    Public Sub LoadAvailableOrders()
        Try
            Using conn As New SqlConnection(connStr)
                ' Filters strictly for 'Pending' orders so claimed ones move out of the pool
                Dim query As String = "SELECT RequestID AS [ID], FoodRequest AS [Order], DeliveryFee AS [Fee (₱)], DropoffLocation AS [Deliver To] FROM [DeliveryPool] WHERE RunnerStatus = 'Pending' ORDER BY RequestID DESC"

                Using adapter As New SqlDataAdapter(query, conn)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    dgvRunnerPool.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading runner pool: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Code that runs when the runner claims a delivery item
    Private Sub btnAcceptOrder_Click(sender As Object, e As EventArgs) Handles btnAcceptOrder.Click
        If dgvRunnerPool.CurrentRow Is Nothing Then
            MessageBox.Show("Please click on an active order line from the table list first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Grabs the RequestID primary key from column index 0
        Dim selectedID As Integer = Convert.ToInt32(dgvRunnerPool.CurrentRow.Cells(0).Value)

        Try
            Using conn As New SqlConnection(connStr)
                Dim query As String = "UPDATE DeliveryPool SET RunnerStatus = 'Out for Delivery' WHERE RequestID = @ID AND RunnerStatus = 'Pending'"

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ID", selectedID)
                    conn.Open()

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Order successfully claimed! Head over to the order verification tab once delivered.", "Delivery Claimed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        LoadAvailableOrders() ' Instantly refreshes the table row out of view
                    Else
                        MessageBox.Show("This order has already been taken by someone else.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Database link error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class