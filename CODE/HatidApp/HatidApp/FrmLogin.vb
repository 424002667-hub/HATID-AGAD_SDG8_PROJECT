Imports System.Data.SqlClient
Public Class FrmLogin

    ' This handles the Exit button
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Application.Exit()
    End Sub

    ' This allows you to drag the black window
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub FrmLogin_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub FrmLogin_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub FrmLogin_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim connString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\HatidDB.mdf;Integrated Security=True"
        Dim conn As New SqlConnection(connString)

        Try
            conn.Open()
            ' Change "Users" to "[User]" (singular and with brackets)
            Dim query As String = "SELECT COUNT(*) FROM [User] WHERE StudentID = @id AND Password = @pass"
            Dim cmd As New SqlCommand(query, conn)

            ' Use parameters to prevent SQL Injection (Safety first!)
            cmd.Parameters.AddWithValue("@id", txtUsername.Text)
            cmd.Parameters.AddWithValue("@pass", txtPassword.Text)

            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            If count > 0 Then
                MessageBox.Show("Login Successful! Welcome to Hatid-Agad.")

            Else
                MessageBox.Show("Invalid Student ID or Password. Please try again.")
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Application.Exit()
    End Sub

    ' Inside FrmLogin
    Private Sub btnGoToRegister_Click(sender As Object, e As EventArgs) Handles btnGoToRegister.Click
        Me.Hide()
        FrmRegister.Show()
    End Sub
End Class