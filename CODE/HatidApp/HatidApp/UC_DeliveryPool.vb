Imports System.Data.SqlClient

Public Class UC_DeliveryPool
    ' Ensure your connection string matches your actual project setup
    Dim connStr As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\HatidDB.mdf;Integrated Security=True"

    ' Loads the open requests table
    Public Sub LoadDeliveryPool()
        Try
            Using conn As New SqlConnection(connStr)
                ' We added SealCode here so the database knows exactly what to look for
                Dim query As String = "SELECT RequestID AS [ID], FoodRequest AS [Order], DeliveryFee AS [Fee (₱)], DropoffLocation AS [Deliver To] FROM [DeliveryPool] WHERE RunnerStatus = 'Pending' ORDER BY RequestID DESC"

                Using adapter As New SqlDataAdapter(query, conn)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    dgvDeliveryPool.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading pool data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UC_DeliveryPool_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDeliveryPool()
    End Sub

    ' REQUEST DELIVERY RUN BUTTON CLICK
    Private Sub btnRequestDelivery_Click(sender As Object, e As EventArgs) Handles btnRequestDelivery.Click
        ' 1. Basic Validation
        If String.IsNullOrWhiteSpace(txtFoodRequest.Text) OrElse
           String.IsNullOrWhiteSpace(txtDeliveryFee.Text) OrElse
           String.IsNullOrWhiteSpace(txtDropoff.Text) Then

            MessageBox.Show("Please fill out all fields before submitting.", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' 2. Generate the random 4-digit security code
        Dim rand As New Random()
        Dim generatedPIN As String = rand.Next(1000, 9999).ToString()

        Try
            Using conn As New SqlConnection(connStr)
                ' 3. INSERT query including the SealCode column that you added to the database
                Dim query As String = "INSERT INTO DeliveryPool (FoodRequest, DeliveryFee, DropoffLocation, RunnerStatus, SealCode) VALUES (@Food, @Fee, @Loc, 'Pending', @Code)"

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Food", txtFoodRequest.Text.Trim())
                    cmd.Parameters.AddWithValue("@Fee", Convert.ToDecimal(txtDeliveryFee.Text.Trim()))
                    cmd.Parameters.AddWithValue("@Loc", txtDropoff.Text.Trim())
                    cmd.Parameters.AddWithValue("@Code", generatedPIN)

                    conn.Open()
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Delivery run posted! Your Secure Seal Code is: " & generatedPIN, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' 4. Clear fields and refresh the table
                    txtFoodRequest.Clear()
                    txtDeliveryFee.Clear()
                    txtDropoff.Clear()

                    LoadDeliveryPool()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Database Error: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class