<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnUsers = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlTopBar = New System.Windows.Forms.Panel()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblSectionTitle = New System.Windows.Forms.Label()
        Me.pnlMainContent = New System.Windows.Forms.Panel()
        Me.tmrClock = New System.Windows.Forms.Timer(Me.components)
        Me.pnlCardUsers = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTotalUsersCount = New System.Windows.Forms.Label()
        Me.pnlSidebar.SuspendLayout()
        Me.pnlTopBar.SuspendLayout()
        Me.pnlMainContent.SuspendLayout()
        Me.pnlCardUsers.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.Color.MidnightBlue
        Me.pnlSidebar.Controls.Add(Me.btnLogout)
        Me.pnlSidebar.Controls.Add(Me.btnUsers)
        Me.pnlSidebar.Controls.Add(Me.btnHome)
        Me.pnlSidebar.Controls.Add(Me.lblWelcome)
        Me.pnlSidebar.Controls.Add(Me.Label1)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(220, 553)
        Me.pnlSidebar.TabIndex = 0
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Gold
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.ForeColor = System.Drawing.Color.Red
        Me.btnLogout.Location = New System.Drawing.Point(12, 503)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(136, 38)
        Me.btnLogout.TabIndex = 4
        Me.btnLogout.Text = "🚪 Log Out"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnUsers
        '
        Me.btnUsers.BackColor = System.Drawing.Color.Gold
        Me.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsers.ForeColor = System.Drawing.Color.Black
        Me.btnUsers.Location = New System.Drawing.Point(12, 203)
        Me.btnUsers.Name = "btnUsers"
        Me.btnUsers.Size = New System.Drawing.Size(188, 53)
        Me.btnUsers.TabIndex = 3
        Me.btnUsers.Text = "👥 Registered Users"
        Me.btnUsers.UseVisualStyleBackColor = False
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.Color.Gold
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.ForeColor = System.Drawing.Color.Black
        Me.btnHome.Location = New System.Drawing.Point(12, 134)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(188, 53)
        Me.btnHome.TabIndex = 2
        Me.btnHome.Text = "🏠 Home"
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.ForeColor = System.Drawing.Color.LightGray
        Me.lblWelcome.Location = New System.Drawing.Point(45, 44)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(103, 16)
        Me.lblWelcome.TabIndex = 1
        Me.lblWelcome.Text = "Welcome, User!"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(23, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "HATID-AGAD"
        '
        'pnlTopBar
        '
        Me.pnlTopBar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlTopBar.Controls.Add(Me.lblDate)
        Me.pnlTopBar.Controls.Add(Me.lblTime)
        Me.pnlTopBar.Controls.Add(Me.lblSectionTitle)
        Me.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopBar.Location = New System.Drawing.Point(220, 0)
        Me.pnlTopBar.Name = "pnlTopBar"
        Me.pnlTopBar.Size = New System.Drawing.Size(762, 60)
        Me.pnlTopBar.TabIndex = 1
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(664, 28)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(79, 16)
        Me.lblDate.TabIndex = 2
        Me.lblDate.Text = "Date Today"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(665, 9)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(78, 16)
        Me.lblTime.TabIndex = 1
        Me.lblTime.Text = "00:00:00 AM"
        '
        'lblSectionTitle
        '
        Me.lblSectionTitle.AutoSize = True
        Me.lblSectionTitle.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSectionTitle.Location = New System.Drawing.Point(22, 13)
        Me.lblSectionTitle.Name = "lblSectionTitle"
        Me.lblSectionTitle.Size = New System.Drawing.Size(236, 31)
        Me.lblSectionTitle.TabIndex = 0
        Me.lblSectionTitle.Text = "Dashboard Overview"
        '
        'pnlMainContent
        '
        Me.pnlMainContent.BackColor = System.Drawing.Color.White
        Me.pnlMainContent.Controls.Add(Me.pnlCardUsers)
        Me.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMainContent.Location = New System.Drawing.Point(220, 60)
        Me.pnlMainContent.Name = "pnlMainContent"
        Me.pnlMainContent.Size = New System.Drawing.Size(762, 493)
        Me.pnlMainContent.TabIndex = 2
        '
        'tmrClock
        '
        Me.tmrClock.Enabled = True
        Me.tmrClock.Interval = 1000
        '
        'pnlCardUsers
        '
        Me.pnlCardUsers.BackColor = System.Drawing.Color.LightSteelBlue
        Me.pnlCardUsers.Controls.Add(Me.lblTotalUsersCount)
        Me.pnlCardUsers.Controls.Add(Me.Label2)
        Me.pnlCardUsers.Location = New System.Drawing.Point(28, 41)
        Me.pnlCardUsers.Name = "pnlCardUsers"
        Me.pnlCardUsers.Size = New System.Drawing.Size(240, 120)
        Me.pnlCardUsers.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Total Registered Users"
        '
        'lblTotalUsersCount
        '
        Me.lblTotalUsersCount.AutoSize = True
        Me.lblTotalUsersCount.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalUsersCount.Location = New System.Drawing.Point(4, 33)
        Me.lblTotalUsersCount.Name = "lblTotalUsersCount"
        Me.lblTotalUsersCount.Size = New System.Drawing.Size(46, 54)
        Me.lblTotalUsersCount.TabIndex = 1
        Me.lblTotalUsersCount.Text = "0"
        '
        'FrmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 553)
        Me.Controls.Add(Me.pnlMainContent)
        Me.Controls.Add(Me.pnlTopBar)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Name = "FrmDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hatid-Agad Dashboard"
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlSidebar.PerformLayout()
        Me.pnlTopBar.ResumeLayout(False)
        Me.pnlTopBar.PerformLayout()
        Me.pnlMainContent.ResumeLayout(False)
        Me.pnlCardUsers.ResumeLayout(False)
        Me.pnlCardUsers.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents lblWelcome As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlTopBar As Panel
    Friend WithEvents pnlMainContent As Panel
    Friend WithEvents btnHome As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnUsers As Button
    Friend WithEvents lblSectionTitle As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents tmrClock As Timer
    Friend WithEvents pnlCardUsers As Panel
    Friend WithEvents lblTotalUsersCount As Label
    Friend WithEvents Label2 As Label
End Class
