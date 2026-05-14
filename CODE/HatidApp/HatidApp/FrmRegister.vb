Imports System.Data.SqlClient

Public Class FrmRegister
    ' Database Connection String using the relative path for HatidDB.mdf
    Dim connStr As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\HatidDB.mdf;Integrated Security=True"

    Private Sub FrmRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Protects the password by showing dots
        txtPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        ' 1. Validation: Ensure no fields are empty
        If txtStudentID.Text = "" Or txtFullName.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' 2. The User Agreement Pop-up
        Dim agreementMessage As String = "HATID-AGAD USER AGREEMENT" & vbCrLf & vbCrLf &
            "By clicking YES, you agree to the following:" & vbCrLf &
            "- Your Student ID and Name will be stored in our database." & vbCrLf &
            "- This account is locked to this specific device (Device Binding)." & vbCrLf &
            "- You are responsible for all deliveries made under this ID." & vbCrLf &
            "- Any food tampering will lead to an immediate ban and NTC disciplinary action." & vbCrLf & vbCrLf &
            "Do you accept these terms?"

        Dim result As DialogResult = MessageBox.Show(agreementMessage, "Data Privacy & Terms", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        ' 3. Only proceed to database logic if they click YES
        If result = DialogResult.Yes Then
            SaveUserToDatabase()
        Else
            MessageBox.Show("Registration cancelled. You must agree to the terms to use Hatid-Agad.", "Consent Required", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
    End Sub

    ' Separated logic for better organization and to avoid errors
    Private Sub SaveUserToDatabase()
        Try
            Using conn As New SqlConnection(connStr)
                conn.Open()

                ' Check if Student ID already exists
                Dim checkCmd As New SqlCommand("SELECT COUNT(*) FROM [User] WHERE StudentID = @id", conn)
                checkCmd.Parameters.AddWithValue("@id", txtStudentID.Text)

                If CInt(checkCmd.ExecuteScalar()) > 0 Then
                    MessageBox.Show("This Student ID is already registered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    ' Insert new student record
                    Dim insertCmd As New SqlCommand("INSERT INTO [User] (StudentID, Password, FullName) VALUES (@id, @pass, @name)", conn)
                    insertCmd.Parameters.AddWithValue("@id", txtStudentID.Text)
                    insertCmd.Parameters.AddWithValue("@pass", txtPassword.Text)
                    insertCmd.Parameters.AddWithValue("@name", txtFullName.Text)

                    insertCmd.ExecuteNonQuery()
                    MessageBox.Show("Registration Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Switch to Login form
                    Me.Hide()
                    FrmLogin.Show()
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        FrmLogin.Show()
    End Sub
End Class