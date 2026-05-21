<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Users
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.dgvUsers = New System.Windows.Forms.DataGridView()
        Me.pnlUserActions = New System.Windows.Forms.Panel()
        Me.btnDeleteUser = New System.Windows.Forms.Button()
        Me.btnUpdateUser = New System.Windows.Forms.Button()
        Me.txtManageName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtManageID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.btnBanUser = New System.Windows.Forms.Button()
        Me.btnLiftRestriction = New System.Windows.Forms.Button()
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlUserActions.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvUsers
        '
        Me.dgvUsers.AllowUserToAddRows = False
        Me.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsers.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvUsers.Location = New System.Drawing.Point(0, 120)
        Me.dgvUsers.Name = "dgvUsers"
        Me.dgvUsers.RowHeadersWidth = 51
        Me.dgvUsers.RowTemplate.Height = 24
        Me.dgvUsers.Size = New System.Drawing.Size(760, 380)
        Me.dgvUsers.TabIndex = 0
        '
        'pnlUserActions
        '
        Me.pnlUserActions.Controls.Add(Me.btnLiftRestriction)
        Me.pnlUserActions.Controls.Add(Me.btnBanUser)
        Me.pnlUserActions.Controls.Add(Me.btnDeleteUser)
        Me.pnlUserActions.Controls.Add(Me.btnUpdateUser)
        Me.pnlUserActions.Controls.Add(Me.txtManageName)
        Me.pnlUserActions.Controls.Add(Me.Label2)
        Me.pnlUserActions.Controls.Add(Me.txtManageID)
        Me.pnlUserActions.Controls.Add(Me.Label1)
        Me.pnlUserActions.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlUserActions.Location = New System.Drawing.Point(0, 0)
        Me.pnlUserActions.Name = "pnlUserActions"
        Me.pnlUserActions.Size = New System.Drawing.Size(760, 100)
        Me.pnlUserActions.TabIndex = 1
        '
        'btnDeleteUser
        '
        Me.btnDeleteUser.BackColor = System.Drawing.Color.Orange
        Me.btnDeleteUser.Location = New System.Drawing.Point(662, 15)
        Me.btnDeleteUser.Name = "btnDeleteUser"
        Me.btnDeleteUser.Size = New System.Drawing.Size(95, 36)
        Me.btnDeleteUser.TabIndex = 5
        Me.btnDeleteUser.Text = "❌ Delete"
        Me.btnDeleteUser.UseVisualStyleBackColor = False
        '
        'btnUpdateUser
        '
        Me.btnUpdateUser.BackColor = System.Drawing.Color.Blue
        Me.btnUpdateUser.Location = New System.Drawing.Point(552, 15)
        Me.btnUpdateUser.Name = "btnUpdateUser"
        Me.btnUpdateUser.Size = New System.Drawing.Size(95, 36)
        Me.btnUpdateUser.TabIndex = 4
        Me.btnUpdateUser.Text = "✏️ Update"
        Me.btnUpdateUser.UseVisualStyleBackColor = False
        '
        'txtManageName
        '
        Me.txtManageName.Location = New System.Drawing.Point(123, 57)
        Me.txtManageName.Name = "txtManageName"
        Me.txtManageName.Size = New System.Drawing.Size(246, 22)
        Me.txtManageName.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Full Name:"
        '
        'txtManageID
        '
        Me.txtManageID.Location = New System.Drawing.Point(123, 21)
        Me.txtManageID.Name = "txtManageID"
        Me.txtManageID.ReadOnly = True
        Me.txtManageID.Size = New System.Drawing.Size(246, 22)
        Me.txtManageID.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student ID:"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'btnBanUser
        '
        Me.btnBanUser.BackColor = System.Drawing.Color.Crimson
        Me.btnBanUser.Location = New System.Drawing.Point(552, 64)
        Me.btnBanUser.Name = "btnBanUser"
        Me.btnBanUser.Size = New System.Drawing.Size(95, 36)
        Me.btnBanUser.TabIndex = 6
        Me.btnBanUser.Text = "🚫 Ban User"
        Me.btnBanUser.UseVisualStyleBackColor = False
        '
        'btnLiftRestriction
        '
        Me.btnLiftRestriction.BackColor = System.Drawing.Color.Green
        Me.btnLiftRestriction.Location = New System.Drawing.Point(662, 64)
        Me.btnLiftRestriction.Name = "btnLiftRestriction"
        Me.btnLiftRestriction.Size = New System.Drawing.Size(95, 36)
        Me.btnLiftRestriction.TabIndex = 7
        Me.btnLiftRestriction.Text = "✅ Restore"
        Me.btnLiftRestriction.UseVisualStyleBackColor = False
        '
        'UC_Users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnlUserActions)
        Me.Controls.Add(Me.dgvUsers)
        Me.Name = "UC_Users"
        Me.Size = New System.Drawing.Size(760, 500)
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlUserActions.ResumeLayout(False)
        Me.pnlUserActions.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvUsers As DataGridView
    Friend WithEvents pnlUserActions As Panel
    Friend WithEvents txtManageID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDeleteUser As Button
    Friend WithEvents btnUpdateUser As Button
    Friend WithEvents txtManageName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents btnBanUser As Button
    Friend WithEvents btnLiftRestriction As Button
End Class
