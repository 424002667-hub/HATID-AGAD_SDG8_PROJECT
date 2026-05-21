Imports System.Data.SqlClient

Public Class FrmLogin
    Dim connStr As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\HatidDB.mdf;Integrated Security=True"

    ' 1. LOGIN BUTTON
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Using conn As New SqlConnection(connStr)
            Dim query As String = "SELECT UserRole FROM [User] WHERE StudentID = @ID AND Password = @Pass"
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ID", txtStudentID.Text)
                cmd.Parameters.AddWithValue("@Pass", txtPassword.Text)
                conn.Open()
                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing Then
                    Dim dash As New FrmDashboard()
                    dash.UserRole = result.ToString().Trim()
                    dash.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Invalid ID or Password.")
                End If
            End Using
        End Using
    End Sub

    ' 2. CREATE ACCOUNT LINK (Assuming btnGoToRegister)
    Private Sub btnGoToRegister_Click(sender As Object, e As EventArgs) Handles btnGoToRegister.Click
        Dim reg As New FrmRegister()
        reg.Show()
        Me.Hide()
    End Sub

    ' 3. "X" BUTTON CLOSE LOGIC
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Application.Exit()
    End Sub

    ' 4. ENSURE FORM CLOSES COMPLETELY
    Private Sub FrmLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
End Class