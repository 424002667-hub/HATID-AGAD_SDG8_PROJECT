Imports System.Data.SqlClient

Public Class UC_Marketplace
    ' Use your established connection string to HatidDB.mdf
    Dim connStr As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\HatidDB.mdf;Integrated Security=True"

    ' Form Load event to show current active listings immediately
    Private Sub UC_Marketplace_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMarketplaceFeed()
    End Sub

    ' Method to fetch active food listings on campus from the database
    Private Sub LoadMarketplaceFeed()
        Try
            Using conn As New SqlConnection(connStr)
                ' We select active listings and order them so the freshest items appear on top
                Dim query As String = "SELECT ProductName AS [Food Item], Price, SellerLocation AS [Floor/Room] FROM Marketplace WHERE ItemStatus = 'Available' ORDER BY ListingID DESC"
                Using cmd As New SqlCommand(query, conn)
                    Using adapter As New SqlDataAdapter(cmd)
                        Dim dt As New DataTable()
                        adapter.Fill(dt)
                        dgvMarketplace.DataSource = dt
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading marketplace: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' The Gold Action Button Click Logic
    Private Sub btnPostProduct_Click(sender As Object, e As EventArgs) Handles btnPostProduct.Click
        ' 1. Safety Validation: Don't allow blank listings
        If String.IsNullOrWhiteSpace(txtProductName.Text) OrElse
           String.IsNullOrWhiteSpace(txtProductPrice.Text) OrElse
           String.IsNullOrWhiteSpace(txtSellerLocation.Text) Then
            MessageBox.Show("Please fill out all fields! Don't forget your location so you don't disrupt classes.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' 2. Price Validation: Ensure it's a valid cash number
        Dim price As Decimal
        If Not Decimal.TryParse(txtProductPrice.Text, price) OrElse price <= 0 Then
            MessageBox.Show("Please enter a valid price amount.", "Invalid Price", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' 3. Insert into HatidDB
        Try
            Using conn As New SqlConnection(connStr)
                Dim query As String = "INSERT INTO Marketplace (ProductName, Price, SellerLocation, ItemStatus) VALUES (@ProdName, @Price, @Location, 'Available')"
                Using cmd As New SqlCommand(query, conn)
                    ' Bind inputs securely to prevent SQL injection
                    cmd.Parameters.AddWithValue("@ProdName", txtProductName.Text.Trim())
                    cmd.Parameters.AddWithValue("@Price", price)
                    cmd.Parameters.AddWithValue("@Location", txtSellerLocation.Text.Trim())

                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("⚡ Food listing posted successfully! Students on your floor can now see your product.", "Marketplace Update", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' 4. Clean up inputs and refresh the live mobile feed
            txtProductName.Clear()
            txtProductPrice.Clear()
            txtSellerLocation.Clear()
            LoadMarketplaceFeed()

        Catch ex As Exception
            MessageBox.Show("Failed to post item: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class