Imports System.Data.SqlClient

Public Class FrmRegister
    ' Use the exact same absolute path as in FrmLogin.vb
    Dim connStr As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\HATID-AGAD_SDG8_PROJECT\CODE\HatidApp\HatidApp\HatidDB.mdf;Integrated Security=True"
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim query As String = "INSERT INTO [User] (StudentID, Password, FullName, AccountStatus, UserRole) VALUES (@ID, @Pass, @Name, 'Active', 'Student')"

        Try
            Using conn As New SqlConnection(connStr)
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ID", txtStudentID.Text)
                    cmd.Parameters.AddWithValue("@Pass", txtPassword.Text)
                    cmd.Parameters.AddWithValue("@Name", txtFullName.Text)
                    conn.Open()
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Account created successfully!", "Success")

                    ' FIND THE HIDDEN LOGIN FORM AND SHOW IT
                    For Each frm As Form In Application.OpenForms
                        If TypeOf frm Is FrmLogin Then
                            frm.Show()
                            Exit For
                        End If
                    Next

                    Me.Close()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Registration Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        ' Show the login form
        FrmLogin.Show()
    End Sub

    Private Sub FrmRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class