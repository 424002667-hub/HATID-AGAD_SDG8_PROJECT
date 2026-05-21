Imports System.Data.SqlClient

Public Class UC_Users
    ' Database Connection String targeting your local HatidDB container
    Dim connStr As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\HatidDB.mdf;Integrated Security=True"

    ' Runs immediately when the admin user manager view loads
    Private Sub UC_Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUserGrid()
    End Sub

    ' Method to fetch accounts matching your custom User schema structure
    Public Sub LoadUserGrid()
        Try
            Using conn As New SqlConnection(connStr)
                Dim query As String = "SELECT StudentID, FullName, AccountStatus FROM [User]"
                Using cmd As New SqlCommand(query, conn)
                    Using adapter As New SqlDataAdapter(cmd)
                        Dim dt As New DataTable()
                        adapter.Fill(dt)
                        dgvUsers.DataSource = dt
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading user records: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Action logic to restrict a student runner using their StudentID
    Private Sub btnBanUser_Click(sender As Object, e As EventArgs) Handles btnBanUser.Click
        If dgvUsers.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a student record from the table first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Extracts the StudentID string from column row cell index 0
        Dim targetStudentID As String = dgvUsers.CurrentRow.Cells(0).Value.ToString()

        Dim confirm As DialogResult = MessageBox.Show("Are you sure you want to restrict account access for Student ID: " & targetStudentID & "?", "Confirm Security Restriction", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirm = DialogResult.Yes Then
            Try
                Using conn As New SqlConnection(connStr)
                    Dim query As String = "UPDATE [User] SET AccountStatus = 'Banned' WHERE StudentID = @StudentID"
                    Using cmd As New SqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@StudentID", targetStudentID)
                        conn.Open()
                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                MessageBox.Show("🚫 Student account access suspended. System logs updated.", "Account Suspended", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadUserGrid()

            Catch ex As Exception
                MessageBox.Show("Error restricting user account: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    ' Action logic to restore a restricted student runner using their StudentID
    Private Sub btnLiftRestriction_Click(sender As Object, e As EventArgs) Handles btnLiftRestriction.Click
        If dgvUsers.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a student record from the table first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim targetStudentID As String = dgvUsers.CurrentRow.Cells(0).Value.ToString()

        Try
            Using conn As New SqlConnection(connStr)
                Dim query As String = "UPDATE [User] SET AccountStatus = 'Active' WHERE StudentID = @StudentID"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@StudentID", targetStudentID)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("✅ Account restrictions cleared. Access restored.", "Status Restored", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadUserGrid()

        Catch ex As Exception
            MessageBox.Show("Error restoring user account: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class