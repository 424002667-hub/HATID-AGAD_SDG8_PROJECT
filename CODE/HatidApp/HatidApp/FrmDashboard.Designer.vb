<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.btnNavRunner = New System.Windows.Forms.Button()
        Me.btnNavMarket = New System.Windows.Forms.Button()
        Me.btnNavVerify = New System.Windows.Forms.Button()
        Me.btnNavPool = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnViewUsers = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlTopBar = New System.Windows.Forms.Panel()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblSectionTitle = New System.Windows.Forms.Label()
        Me.pnlMainContent = New System.Windows.Forms.Panel()
        Me.pnlCardUsers = New System.Windows.Forms.Panel()
        Me.lblTotalUsersCount = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tmrClock = New System.Windows.Forms.Timer(Me.components)
        Me.pnlSidebar.SuspendLayout()
        Me.pnlTopBar.SuspendLayout()
        Me.pnlMainContent.SuspendLayout()
        Me.pnlCardUsers.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.Color.MidnightBlue
        Me.pnlSidebar.Controls.Add(Me.btnNavRunner)
        Me.pnlSidebar.Controls.Add(Me.btnNavMarket)
        Me.pnlSidebar.Controls.Add(Me.btnNavVerify)
        Me.pnlSidebar.Controls.Add(Me.btnNavPool)
        Me.pnlSidebar.Controls.Add(Me.btnLogout)
        Me.pnlSidebar.Controls.Add(Me.btnViewUsers)
        Me.pnlSidebar.Controls.Add(Me.btnHome)
        Me.pnlSidebar.Controls.Add(Me.lblWelcome)
        Me.pnlSidebar.Controls.Add(Me.Label1)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebar.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(156, 571)
        Me.pnlSidebar.TabIndex = 0
        '
        'btnNavRunner
        '
        Me.btnNavRunner.BackColor = System.Drawing.Color.Gold
        Me.btnNavRunner.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavRunner.ForeColor = System.Drawing.Color.Black
        Me.btnNavRunner.Location = New System.Drawing.Point(9, 418)
        Me.btnNavRunner.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNavRunner.Name = "btnNavRunner"
        Me.btnNavRunner.Size = New System.Drawing.Size(141, 43)
        Me.btnNavRunner.TabIndex = 8
        Me.btnNavRunner.Text = "🚴 Runner Mode"
        Me.btnNavRunner.UseVisualStyleBackColor = False
        '
        'btnNavMarket
        '
        Me.btnNavMarket.BackColor = System.Drawing.Color.Gold
        Me.btnNavMarket.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavMarket.ForeColor = System.Drawing.Color.Black
        Me.btnNavMarket.Location = New System.Drawing.Point(9, 362)
        Me.btnNavMarket.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNavMarket.Name = "btnNavMarket"
        Me.btnNavMarket.Size = New System.Drawing.Size(141, 43)
        Me.btnNavMarket.TabIndex = 7
        Me.btnNavMarket.Text = "🛍️ Marketplace"
        Me.btnNavMarket.UseVisualStyleBackColor = False
        '
        'btnNavVerify
        '
        Me.btnNavVerify.BackColor = System.Drawing.Color.Gold
        Me.btnNavVerify.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavVerify.ForeColor = System.Drawing.Color.Black
        Me.btnNavVerify.Location = New System.Drawing.Point(9, 306)
        Me.btnNavVerify.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNavVerify.Name = "btnNavVerify"
        Me.btnNavVerify.Size = New System.Drawing.Size(141, 43)
        Me.btnNavVerify.TabIndex = 6
        Me.btnNavVerify.Text = "🔐 Verify Order"
        Me.btnNavVerify.UseVisualStyleBackColor = False
        '
        'btnNavPool
        '
        Me.btnNavPool.BackColor = System.Drawing.Color.Gold
        Me.btnNavPool.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavPool.ForeColor = System.Drawing.Color.Black
        Me.btnNavPool.Location = New System.Drawing.Point(9, 249)
        Me.btnNavPool.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNavPool.Name = "btnNavPool"
        Me.btnNavPool.Size = New System.Drawing.Size(141, 43)
        Me.btnNavPool.TabIndex = 5
        Me.btnNavPool.Text = "🚀 Delivery Pool"
        Me.btnNavPool.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Gold
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.ForeColor = System.Drawing.Color.Red
        Me.btnLogout.Location = New System.Drawing.Point(9, 531)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(102, 31)
        Me.btnLogout.TabIndex = 4
        Me.btnLogout.Text = "🚪 Log Out"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnViewUsers
        '
        Me.btnViewUsers.BackColor = System.Drawing.Color.Gold
        Me.btnViewUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewUsers.ForeColor = System.Drawing.Color.Black
        Me.btnViewUsers.Location = New System.Drawing.Point(9, 189)
        Me.btnViewUsers.Margin = New System.Windows.Forms.Padding(2)
        Me.btnViewUsers.Name = "btnViewUsers"
        Me.btnViewUsers.Size = New System.Drawing.Size(141, 43)
        Me.btnViewUsers.TabIndex = 3
        Me.btnViewUsers.Text = "👥 Registered Users"
        Me.btnViewUsers.UseVisualStyleBackColor = False
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.Color.Gold
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.ForeColor = System.Drawing.Color.Black
        Me.btnHome.Location = New System.Drawing.Point(9, 128)
        Me.btnHome.Margin = New System.Windows.Forms.Padding(2)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(141, 43)
        Me.btnHome.TabIndex = 2
        Me.btnHome.Text = "🏠 Home"
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.ForeColor = System.Drawing.Color.LightGray
        Me.lblWelcome.Location = New System.Drawing.Point(33, 51)
        Me.lblWelcome.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(83, 13)
        Me.lblWelcome.TabIndex = 1
        Me.lblWelcome.Text = "Welcome, User!"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(16, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 25)
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
        Me.pnlTopBar.Location = New System.Drawing.Point(156, 0)
        Me.pnlTopBar.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlTopBar.Name = "pnlTopBar"
        Me.pnlTopBar.Size = New System.Drawing.Size(604, 49)
        Me.pnlTopBar.TabIndex = 1
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(383, 26)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(63, 13)
        Me.lblDate.TabIndex = 2
        Me.lblDate.Text = "Date Today"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(384, 11)
        Me.lblTime.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(68, 13)
        Me.lblTime.TabIndex = 1
        Me.lblTime.Text = "00:00:00 AM"
        '
        'lblSectionTitle
        '
        Me.lblSectionTitle.AutoSize = True
        Me.lblSectionTitle.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSectionTitle.Location = New System.Drawing.Point(16, 11)
        Me.lblSectionTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSectionTitle.Name = "lblSectionTitle"
        Me.lblSectionTitle.Size = New System.Drawing.Size(197, 25)
        Me.lblSectionTitle.TabIndex = 0
        Me.lblSectionTitle.Text = "Dashboard Overview"
        '
        'pnlMainContent
        '
        Me.pnlMainContent.BackColor = System.Drawing.Color.White
        Me.pnlMainContent.Controls.Add(Me.pnlCardUsers)
        Me.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMainContent.Location = New System.Drawing.Point(156, 49)
        Me.pnlMainContent.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlMainContent.Name = "pnlMainContent"
        Me.pnlMainContent.Size = New System.Drawing.Size(604, 522)
        Me.pnlMainContent.TabIndex = 2
        '
        'pnlCardUsers
        '
        Me.pnlCardUsers.BackColor = System.Drawing.Color.LightSteelBlue
        Me.pnlCardUsers.Controls.Add(Me.lblTotalUsersCount)
        Me.pnlCardUsers.Controls.Add(Me.Label2)
        Me.pnlCardUsers.Location = New System.Drawing.Point(21, 24)
        Me.pnlCardUsers.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlCardUsers.Name = "pnlCardUsers"
        Me.pnlCardUsers.Size = New System.Drawing.Size(180, 98)
        Me.pnlCardUsers.TabIndex = 0
        '
        'lblTotalUsersCount
        '
        Me.lblTotalUsersCount.AutoSize = True
        Me.lblTotalUsersCount.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalUsersCount.Location = New System.Drawing.Point(3, 27)
        Me.lblTotalUsersCount.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTotalUsersCount.Name = "lblTotalUsersCount"
        Me.lblTotalUsersCount.Size = New System.Drawing.Size(38, 45)
        Me.lblTotalUsersCount.TabIndex = 1
        Me.lblTotalUsersCount.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 3)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Total Registered Users"
        '
        'tmrClock
        '
        Me.tmrClock.Enabled = True
        Me.tmrClock.Interval = 1000
        '
        'FrmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 571)
        Me.Controls.Add(Me.pnlMainContent)
        Me.Controls.Add(Me.pnlTopBar)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Margin = New System.Windows.Forms.Padding(2)
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
    Friend WithEvents btnViewUsers As Button
    Friend WithEvents lblSectionTitle As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents tmrClock As Timer
    Friend WithEvents pnlCardUsers As Panel
    Friend WithEvents lblTotalUsersCount As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnNavVerify As Button
    Friend WithEvents btnNavPool As Button
    Friend WithEvents btnNavMarket As Button
    Friend WithEvents btnNavRunner As Button
End Class
