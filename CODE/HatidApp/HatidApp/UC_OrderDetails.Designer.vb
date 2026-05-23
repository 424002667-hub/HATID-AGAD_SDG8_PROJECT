<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_OrderDetails
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
        Me.pnlDetailsHeader = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlVerificationCard = New System.Windows.Forms.Panel()
        Me.btnConfirmHandshake = New System.Windows.Forms.Button()
        Me.txtSealCode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblOrderSummary = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbRating = New System.Windows.Forms.ComboBox()
        Me.btnSubmitRating = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pnlDetailsHeader.SuspendLayout()
        Me.pnlVerificationCard.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlDetailsHeader
        '
        Me.pnlDetailsHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.pnlDetailsHeader.Controls.Add(Me.Label1)
        Me.pnlDetailsHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlDetailsHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlDetailsHeader.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlDetailsHeader.Name = "pnlDetailsHeader"
        Me.pnlDetailsHeader.Size = New System.Drawing.Size(270, 41)
        Me.pnlDetailsHeader.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(63, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ORDER VERIFICATION"
        '
        'pnlVerificationCard
        '
        Me.pnlVerificationCard.BackColor = System.Drawing.Color.White
        Me.pnlVerificationCard.Controls.Add(Me.btnConfirmHandshake)
        Me.pnlVerificationCard.Controls.Add(Me.txtSealCode)
        Me.pnlVerificationCard.Controls.Add(Me.Label2)
        Me.pnlVerificationCard.Controls.Add(Me.lblOrderSummary)
        Me.pnlVerificationCard.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlVerificationCard.Location = New System.Drawing.Point(0, 41)
        Me.pnlVerificationCard.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlVerificationCard.Name = "pnlVerificationCard"
        Me.pnlVerificationCard.Size = New System.Drawing.Size(270, 260)
        Me.pnlVerificationCard.TabIndex = 1
        '
        'btnConfirmHandshake
        '
        Me.btnConfirmHandshake.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnConfirmHandshake.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnConfirmHandshake.Location = New System.Drawing.Point(74, 173)
        Me.btnConfirmHandshake.Margin = New System.Windows.Forms.Padding(2)
        Me.btnConfirmHandshake.Name = "btnConfirmHandshake"
        Me.btnConfirmHandshake.Size = New System.Drawing.Size(121, 45)
        Me.btnConfirmHandshake.TabIndex = 3
        Me.btnConfirmHandshake.Text = "🔐 Confirm Handshake and Release Cash"
        Me.btnConfirmHandshake.UseVisualStyleBackColor = False
        '
        'txtSealCode
        '
        Me.txtSealCode.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSealCode.Location = New System.Drawing.Point(138, 77)
        Me.txtSealCode.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSealCode.MaxLength = 4
        Me.txtSealCode.Name = "txtSealCode"
        Me.txtSealCode.Size = New System.Drawing.Size(98, 36)
        Me.txtSealCode.TabIndex = 2
        Me.txtSealCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 77)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 30)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter 4-Digit " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Secure Seal Code:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblOrderSummary
        '
        Me.lblOrderSummary.AutoSize = True
        Me.lblOrderSummary.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderSummary.Location = New System.Drawing.Point(17, 15)
        Me.lblOrderSummary.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOrderSummary.Name = "lblOrderSummary"
        Me.lblOrderSummary.Size = New System.Drawing.Size(234, 21)
        Me.lblOrderSummary.TabIndex = 0
        Me.lblOrderSummary.Text = "Loading active order details..."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(11, 358)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Rate Runner Experience:"
        '
        'cmbRating
        '
        Me.cmbRating.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRating.FormattingEnabled = True
        Me.cmbRating.Items.AddRange(New Object() {"5 - Excellent & Fast", "4 - Good Service", "3 - Average Run", "2 - Slow / Disturbed Class", "1 - Damaged Seal / Late"})
        Me.cmbRating.Location = New System.Drawing.Point(148, 348)
        Me.cmbRating.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbRating.Name = "cmbRating"
        Me.cmbRating.Size = New System.Drawing.Size(107, 29)
        Me.cmbRating.TabIndex = 3
        '
        'btnSubmitRating
        '
        Me.btnSubmitRating.BackColor = System.Drawing.Color.Gray
        Me.btnSubmitRating.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnSubmitRating.Location = New System.Drawing.Point(92, 434)
        Me.btnSubmitRating.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSubmitRating.Name = "btnSubmitRating"
        Me.btnSubmitRating.Size = New System.Drawing.Size(104, 33)
        Me.btnSubmitRating.TabIndex = 4
        Me.btnSubmitRating.Text = "⭐ Submit Reputation Score"
        Me.btnSubmitRating.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 200
        '
        'UC_OrderDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Controls.Add(Me.btnSubmitRating)
        Me.Controls.Add(Me.cmbRating)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pnlVerificationCard)
        Me.Controls.Add(Me.pnlDetailsHeader)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "UC_OrderDetails"
        Me.Size = New System.Drawing.Size(270, 520)
        Me.pnlDetailsHeader.ResumeLayout(False)
        Me.pnlDetailsHeader.PerformLayout()
        Me.pnlVerificationCard.ResumeLayout(False)
        Me.pnlVerificationCard.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlDetailsHeader As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlVerificationCard As Panel
    Friend WithEvents lblOrderSummary As Label
    Friend WithEvents btnConfirmHandshake As Button
    Friend WithEvents txtSealCode As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbRating As ComboBox
    Friend WithEvents btnSubmitRating As Button
    Friend WithEvents Timer1 As Timer
End Class
