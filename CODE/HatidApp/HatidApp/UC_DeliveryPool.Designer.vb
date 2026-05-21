<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_DeliveryPool
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
        Me.pnlPoolHeader = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlRequestInput = New System.Windows.Forms.Panel()
        Me.btnRequestDelivery = New System.Windows.Forms.Button()
        Me.txtDropoff = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDeliveryFee = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFoodRequest = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvDeliveryPool = New System.Windows.Forms.DataGridView()
        Me.pnlPoolHeader.SuspendLayout()
        Me.pnlRequestInput.SuspendLayout()
        CType(Me.dgvDeliveryPool, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlPoolHeader
        '
        Me.pnlPoolHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.pnlPoolHeader.Controls.Add(Me.Label1)
        Me.pnlPoolHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlPoolHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlPoolHeader.Name = "pnlPoolHeader"
        Me.pnlPoolHeader.Size = New System.Drawing.Size(360, 50)
        Me.pnlPoolHeader.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(77, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "HATID-AGAD DELIVERY POOL"
        '
        'pnlRequestInput
        '
        Me.pnlRequestInput.BackColor = System.Drawing.Color.White
        Me.pnlRequestInput.Controls.Add(Me.btnRequestDelivery)
        Me.pnlRequestInput.Controls.Add(Me.txtDropoff)
        Me.pnlRequestInput.Controls.Add(Me.Label4)
        Me.pnlRequestInput.Controls.Add(Me.txtDeliveryFee)
        Me.pnlRequestInput.Controls.Add(Me.Label3)
        Me.pnlRequestInput.Controls.Add(Me.txtFoodRequest)
        Me.pnlRequestInput.Controls.Add(Me.Label2)
        Me.pnlRequestInput.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlRequestInput.Location = New System.Drawing.Point(0, 50)
        Me.pnlRequestInput.Name = "pnlRequestInput"
        Me.pnlRequestInput.Size = New System.Drawing.Size(360, 240)
        Me.pnlRequestInput.TabIndex = 1
        '
        'btnRequestDelivery
        '
        Me.btnRequestDelivery.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRequestDelivery.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnRequestDelivery.Location = New System.Drawing.Point(96, 179)
        Me.btnRequestDelivery.Name = "btnRequestDelivery"
        Me.btnRequestDelivery.Size = New System.Drawing.Size(147, 45)
        Me.btnRequestDelivery.TabIndex = 6
        Me.btnRequestDelivery.Text = "🚀 Request Delivery Run"
        Me.btnRequestDelivery.UseVisualStyleBackColor = False
        '
        'txtDropoff
        '
        Me.txtDropoff.Location = New System.Drawing.Point(182, 129)
        Me.txtDropoff.Name = "txtDropoff"
        Me.txtDropoff.Size = New System.Drawing.Size(100, 22)
        Me.txtDropoff.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Deliver to (Floor/Room):"
        '
        'txtDeliveryFee
        '
        Me.txtDeliveryFee.Location = New System.Drawing.Point(162, 70)
        Me.txtDeliveryFee.Name = "txtDeliveryFee"
        Me.txtDeliveryFee.Size = New System.Drawing.Size(113, 22)
        Me.txtDeliveryFee.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Delivery Fee (₱):"
        '
        'txtFoodRequest
        '
        Me.txtFoodRequest.Location = New System.Drawing.Point(162, 24)
        Me.txtFoodRequest.Name = "txtFoodRequest"
        Me.txtFoodRequest.Size = New System.Drawing.Size(155, 22)
        Me.txtFoodRequest.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "What do you need?"
        '
        'dgvDeliveryPool
        '
        Me.dgvDeliveryPool.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDeliveryPool.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDeliveryPool.Location = New System.Drawing.Point(0, 290)
        Me.dgvDeliveryPool.Name = "dgvDeliveryPool"
        Me.dgvDeliveryPool.RowHeadersWidth = 51
        Me.dgvDeliveryPool.RowTemplate.Height = 24
        Me.dgvDeliveryPool.Size = New System.Drawing.Size(360, 350)
        Me.dgvDeliveryPool.TabIndex = 2
        '
        'UC_DeliveryPool
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Controls.Add(Me.dgvDeliveryPool)
        Me.Controls.Add(Me.pnlRequestInput)
        Me.Controls.Add(Me.pnlPoolHeader)
        Me.Name = "UC_DeliveryPool"
        Me.Size = New System.Drawing.Size(360, 640)
        Me.pnlPoolHeader.ResumeLayout(False)
        Me.pnlPoolHeader.PerformLayout()
        Me.pnlRequestInput.ResumeLayout(False)
        Me.pnlRequestInput.PerformLayout()
        CType(Me.dgvDeliveryPool, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlPoolHeader As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlRequestInput As Panel
    Friend WithEvents dgvDeliveryPool As DataGridView
    Friend WithEvents txtFoodRequest As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnRequestDelivery As Button
    Friend WithEvents txtDropoff As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDeliveryFee As TextBox
    Friend WithEvents Label3 As Label
End Class
