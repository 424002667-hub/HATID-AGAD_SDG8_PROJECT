Imports System.Data.SqlClient

Public Class FrmLogin
    ' Replace with the path to the file that you know has your credentials
    Dim connStr As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\HATID-AGAD_SDG8_PROJECT\CODE\HatidApp\HatidApp\HatidDB.mdf;Integrated Security=True"
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Using conn As New SqlConnection(connStr)
            Try
                conn.Open()
                ' Use parameters to avoid injection and ensure clean matching
                Dim query As String = "SELECT UserRole FROM [User] WHERE StudentID = @ID AND Password = @Pass"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.Add("@ID", SqlDbType.NVarChar).Value = txtStudentID.Text.Trim()
                    cmd.Parameters.Add("@Pass", SqlDbType.NVarChar).Value = txtPassword.Text.Trim()

                    Dim result As Object = cmd.ExecuteScalar()
                    If result IsNot Nothing Then
                        Dim dash As New FrmDashboard()
                        dash.UserRole = result.ToString().Trim()
                        dash.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("Login failed: ID or Password does not match.")
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Database error: " & ex.Message)
            End Try

        End Using
    End Sub
    Private Sub btnGoToRegister_Click(sender As Object, e As EventArgs) Handles btnGoToRegister.Click
        Dim reg As New FrmRegister()
        reg.Show()
        Me.Hide()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Application.Exit()
    End Sub

    Private Sub FrmLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
End Class