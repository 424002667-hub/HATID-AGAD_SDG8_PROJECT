Imports System.Data.SqlClient

Public Class UC_RunnerPool
    ' Absolute path ensuring the connection points to the correct database file
    ' Replace the hardcoded path with this relative path
    ' Use the exact path to your project's database file
    ' Paste this EXACT line into every UserControl or Form that connects to the DB
    ' Paste this EXACT line into every UserControl or Form that connects to the DB
    Private connStr As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\HATID-AGAD_SDG8_PROJECT\CODE\HatidApp\HatidApp\HatidDB.mdf;Integrated Security=True"
    Private Sub UC_RunnerPool_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAvailableOrders()
    End Sub

    ' Refresh data automatically whenever the Runner Mode tab becomes visible
    Private Sub UC_RunnerPool_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible Then
            LoadAvailableOrders()
        End If
    End Sub

    ' Fetches only 'Pending' orders to display in the Runner grid
    Public Sub LoadAvailableOrders()
        Try
            Using conn As New SqlConnection(connStr)
                Dim query As String = "SELECT * FROM DeliveryPool WHERE RunnerStatus = 'Pending'"
                Dim da As New SqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                da.Fill(dt)
                dgvRunnerPool.DataSource = dt

                ' Check if it actually found anything
                If dt.Rows.Count = 0 Then
                    MessageBox.Show("Debug: No 'Pending' orders found in the database at: " & connStr)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Database Connection Error: " & ex.Message)
        End Try
    End Sub

    ' Handles claiming the delivery and updating status to 'Out for Delivery'
    Private Sub btnAcceptOrder_Click(sender As Object, e As EventArgs) Handles btnAcceptOrder.Click
        If dgvRunnerPool.CurrentRow Is Nothing Then
            MessageBox.Show("Please click on an active order line from the table list first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim selectedID As Integer = Convert.ToInt32(dgvRunnerPool.CurrentRow.Cells(0).Value)

        Try
            Using conn As New SqlConnection(connStr)
                ' Only update if still marked as 'Pending' to prevent double-claiming
                ' Ensure there are no extra spaces here
                Dim query As String = "UPDATE DeliveryPool SET RunnerStatus = 'Out for Delivery' WHERE RequestID = @ID"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ID", selectedID)
                    conn.Open()

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Order successfully claimed! Head over to the order verification tab once delivered.", "Delivery Claimed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ' Refresh the grid to remove the claimed item
                        LoadAvailableOrders()
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