Imports System.Data.SqlClient

Public Class FrmRegister
    ' Database Connection String using the relative path for HatidDB.mdf
    Dim connStr As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\HatidDB.mdf;Integrated Security=True"

    Private Sub FrmRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' This ensures the password cannot be seen (shows dots only)
        txtPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        ' 1. Basic Validation
        If txtStudentID.Text = "" Or txtPassword.Text = "" Or txtFullName.Text = "" Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        Try
            Using conn As New SqlConnection(connStr)
                conn.Open()

                ' 2. Check if Student ID already exists in your User table
                Dim checkCmd As New SqlCommand("SELECT COUNT(*) FROM [User] WHERE StudentID = @id", conn)
                checkCmd.Parameters.AddWithValue("@id", txtStudentID.Text)

                If CInt(checkCmd.ExecuteScalar()) > 0 Then
                    MessageBox.Show("This Student ID is already registered.")
                Else
                    ' 3. Insert new student (Role removed to match your database)
                    Dim insertCmd As New SqlCommand("INSERT INTO [User] (StudentID, Password, FullName) VALUES (@id, @pass, @name)", conn)
                    insertCmd.Parameters.AddWithValue("@id", txtStudentID.Text)
                    insertCmd.Parameters.AddWithValue("@pass", txtPassword.Text)
                    insertCmd.Parameters.AddWithValue("@name", txtFullName.Text)

                    insertCmd.ExecuteNonQuery()
                    MessageBox.Show("Registration Successful!")

                    ' 4. Hide current form and show Login
                    Me.Hide()
                    FrmLogin.Show()
                End If
            End Using
        Catch ex As Exception
            ' This will catch any remaining issues with table or column names
            MessageBox.Show("Database Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        FrmLogin.Show()
    End Sub

    ' Empty events kept to prevent designer errors
    Private Sub txtFullName_TextChanged(sender As Object, e As EventArgs) Handles txtFullName.TextChanged
    End Sub
    Private Sub lblStudentID_Click(sender As Object, e As EventArgs) Handles lblStudentID.Click
    End Sub
    Private Sub txtStudentID_TextChanged(sender As Object, e As EventArgs) Handles txtStudentID.TextChanged
    End Sub
    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
    End Sub
    Private Sub lblPassword_Click(sender As Object, e As EventArgs) Handles lblPassword.Click
    End Sub

End Class