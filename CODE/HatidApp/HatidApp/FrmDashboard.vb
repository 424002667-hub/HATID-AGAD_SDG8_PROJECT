Imports System.Data.SqlClient

Public Class FrmDashboard
    ' Points directly to your database file automatically
    Private connStr As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\HATID-AGAD_SDG8_PROJECT\CODE\HatidApp\HatidApp\HatidDB.mdf;Integrated Security=True"

    ' These variables store the information passed from the Login Form
    Public Property LoggedInUser As String = "User"
    Public Property UserRole As String
    Public Property LoggedInStudentID As String

    ' Helper method to cleanly switch custom views into the main content panel workspace
    Private Sub SwitchControl(ByVal uc As UserControl)
        pnlMainContent.Controls.Clear()
        uc.Dock = DockStyle.Fill
        pnlMainContent.Controls.Add(uc)
    End Sub

    ' 1. What happens when the Dashboard opens
    Private Sub FrmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the welcome message
        lblWelcome.Text = "Welcome, " & LoggedInUser
        AppDomain.CurrentDomain.SetData("DataDirectory", "C:\HATID-AGAD_SDG8_PROJECT\CODE\HatidApp\HatidApp")
        ' Initialize the clock
        lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt")
        lblDate.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy")

        ' Load your database stats
        LoadDashboardStats()

        ' SECURITY: Hide the Registered Users button if the user is not an Admin
        If UserRole <> "Admin" Then
            btnViewUsers.Visible = False
        End If
    End Sub

    ' 2. The Live Clock Logic
    Private Sub tmrClock_Tick(sender As Object, e As EventArgs) Handles tmrClock.Tick
        lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt")
        lblDate.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy")
    End Sub

    ' 3. Count Total Registered Students from HatidDB.mdf
    Public Sub LoadDashboardStats()
        Dim query As String = "SELECT COUNT(*) FROM [User] WHERE AccountStatus = 'Active'"

        Using conn As New SqlConnection(connStr)
            conn.Open()
            Using cmd As New SqlCommand(query, conn)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                ' Update your label/text control here
                lblTotalUsersCount.Text = count.ToString()
            End Using
        End Using
    End Sub

    ' 4. Home Button Click
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        lblSectionTitle.Text = "Dashboard Overview"
        pnlMainContent.Controls.Clear()
        pnlMainContent.Controls.Add(pnlCardUsers)
        LoadDashboardStats()
    End Sub

    ' 5. Registered Users Button Click
    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnViewUsers.Click
        ' Double-check security
        If UserRole = "Admin" Then
            lblSectionTitle.Text = "Registered Users Directory"
            SwitchControl(New UC_Users())
        Else
            MessageBox.Show("Unauthorized access.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' 6. Delivery Pool Button Click
    Private Sub btnNavPool_Click(sender As Object, e As EventArgs) Handles btnNavPool.Click
        lblSectionTitle.Text = "Active Campus Delivery Pool"
        SwitchControl(New UC_DeliveryPool())
    End Sub

    ' 7. Student Marketplace Button Click
    Private Sub btnNavMarket_Click(sender As Object, e As EventArgs) Handles btnNavMarket.Click
        lblSectionTitle.Text = "Student Seller Marketplace"
        SwitchControl(New UC_Marketplace())
    End Sub

    ' 8. Verify Order Button Click
    Private Sub btnNavVerify_Click(sender As Object, e As EventArgs) Handles btnNavVerify.Click
        lblSectionTitle.Text = "Secure Order Verification Handshake"
        SwitchControl(New UC_OrderDetails())
    End Sub

    ' 9. Runner Mode Sidebar Button Click
    Private Sub btnNavRunner_Click(sender As Object, e As EventArgs) Handles btnNavRunner.Click
        lblSectionTitle.Text = "Available Runner Delivery Pool"
        SwitchControl(New UC_RunnerPool())
    End Sub

    ' 10. Log Out Button Logic
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim response = MessageBox.Show("Are you sure you want to log out of Hatid-Agad?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = DialogResult.Yes Then
            Dim loginForm As New FrmLogin()
            loginForm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub pnlMainContent_Paint(sender As Object, e As PaintEventArgs) Handles pnlMainContent.Paint
    End Sub
End Class