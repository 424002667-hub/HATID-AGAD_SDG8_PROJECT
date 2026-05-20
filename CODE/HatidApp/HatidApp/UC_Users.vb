Imports System.Data.SqlClient

Public Class UC_Users
    ' Relative database directory to prevent file path locking across devices
    Private connStr As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\HatidDB.mdf;Integrated Security=True"

    ' Runs automatically when this sub-view is loaded onto the panel
    Private Sub UC_Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshUserGrid()
    End Sub

    ' Pulls raw registration records and maps them cleanly onto your DataGridView
    Public Sub RefreshUserGrid()
        Using conn As New SqlConnection(connStr)
            ' Select only relevant display data (never display raw user passwords in plain view!)
            Dim query As String = "SELECT StudentID, FullName FROM [User]"

            Using adapter As New SqlDataAdapter(query, conn)
                Dim dt As New DataTable()

                Try
                    conn.Open()
                    adapter.Fill(dt)
                    dgvUsers.DataSource = dt

                    ' Nice UI Column Stretching
                    dgvUsers.Columns(0).HeaderText = "Student ID"
                    dgvUsers.Columns(1).HeaderText = "Full Name"
                    dgvUsers.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

                Catch ex As Exception
                    MessageBox.Show("Error loading user directory: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub
End Class