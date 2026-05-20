Imports System.Data.SqlClient

Public Class FrmDashboard
    ' Points directly to your database file automatically, no matter what device you open it on
    Private connStr As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\HatidDB.mdf;Integrated Security=True"

    ' This variable stores the username passed from your Login Form
    Public Property LoggedInUser As String = "User"

    ' 1. What happens when the Dashboard opens
    Private Sub FrmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the welcome message using the passed username
        lblWelcome.Text = "Welcome, " & LoggedInUser

        ' Initialize the clock text immediately so it doesn't look blank at startup
        lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt")
        lblDate.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy")

        ' Load your database stats
        LoadDashboardStats()
    End Sub

    ' 2. The Live Clock Logic (Triggers every 1 second via tmrClock)
    Private Sub tmrClock_Tick(sender As Object, e As EventArgs) Handles tmrClock.Tick
        lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt")
        lblDate.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy")
    End Sub

    ' 3. Count Total Registered Students from HatidDB.mdf
    Public Sub LoadDashboardStats()
        Using conn As New SqlConnection(connStr)
            Try
                conn.Open()

                Dim queryUsers As String = "SELECT COUNT(*) FROM [User]"

                Using cmd As New SqlCommand(queryUsers, conn)
                    Dim totalUsers As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    ' LINK TO YOUR VISUAL LABEL: 
                    ' This takes the number from the database and updates your text element!
                    lblTotalUsersCount.Text = totalUsers.ToString()
                End Using

            Catch ex As Exception
                ' Prevents crashing if the file is locked, displaying a gentle warning instead
                MessageBox.Show("Could not sync live stats: " & ex.Message, "Database Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End Using
    End Sub

    ' 4. Home Button Click
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        lblSectionTitle.Text = "Dashboard Overview"

        ' 1. Clear out any User Controls (like the Registered Users table)
        pnlMainContent.Controls.Clear()

        ' 2. Re-add your analytics card back to the screen
        pnlMainContent.Controls.Add(pnlCardUsers)

        ' 3. Refresh the database count numbers
        LoadDashboardStats()
    End Sub

    ' 5. Registered Users Button Click (Swaps the content panel view)
    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        ' Update the top bar title
        lblSectionTitle.Text = "Registered Users Directory"

        ' Clear whatever is currently taking up space in our central content container
        pnlMainContent.Controls.Clear()

        ' Initialize an instance of our dynamic data grid sub-view user control
        Dim userView As New UC_Users()

        ' Align it to take up the full available white content canvas space 
        userView.Dock = DockStyle.Fill

        ' Drop it directly into our view panel container and render it active
        pnlMainContent.Controls.Add(userView)
    End Sub

    ' 6. Log Out Button Logic
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim response = MessageBox.Show("Are you sure you want to log out of Hatid-Agad?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If response = DialogResult.Yes Then
            ' Show the login window back to the screen
            FrmLogin.Show()
            ' Close this dashboard form completely
            Me.Close()
        End If
    End Sub
End Class