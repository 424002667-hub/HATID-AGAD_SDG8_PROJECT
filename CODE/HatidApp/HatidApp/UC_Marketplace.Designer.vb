<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Marketplace
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtProductPrice = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSellerLocation = New System.Windows.Forms.TextBox()
        Me.btnPostProduct = New System.Windows.Forms.Button()
        Me.dgvMarketplace = New System.Windows.Forms.DataGridView()
        CType(Me.dgvMarketplace, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(360, 73)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Product Name:"
        '
        'txtProductName
        '
        Me.txtProductName.Location = New System.Drawing.Point(145, 109)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(173, 22)
        Me.txtProductName.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(58, 180)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Price (₱):"
        '
        'txtProductPrice
        '
        Me.txtProductPrice.Location = New System.Drawing.Point(145, 178)
        Me.txtProductPrice.Name = "txtProductPrice"
        Me.txtProductPrice.Size = New System.Drawing.Size(174, 22)
        Me.txtProductPrice.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 246)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Your Floor / Room:"
        '
        'txtSellerLocation
        '
        Me.txtSellerLocation.Location = New System.Drawing.Point(169, 246)
        Me.txtSellerLocation.Name = "txtSellerLocation"
        Me.txtSellerLocation.Size = New System.Drawing.Size(150, 22)
        Me.txtSellerLocation.TabIndex = 6
        '
        'btnPostProduct
        '
        Me.btnPostProduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPostProduct.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnPostProduct.Location = New System.Drawing.Point(79, 297)
        Me.btnPostProduct.Name = "btnPostProduct"
        Me.btnPostProduct.Size = New System.Drawing.Size(186, 64)
        Me.btnPostProduct.TabIndex = 7
        Me.btnPostProduct.Text = "🚀 Post Food Listing"
        Me.btnPostProduct.UseVisualStyleBackColor = False
        '
        'dgvMarketplace
        '
        Me.dgvMarketplace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMarketplace.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvMarketplace.Location = New System.Drawing.Point(0, 367)
        Me.dgvMarketplace.Name = "dgvMarketplace"
        Me.dgvMarketplace.RowHeadersWidth = 51
        Me.dgvMarketplace.RowTemplate.Height = 24
        Me.dgvMarketplace.Size = New System.Drawing.Size(360, 273)
        Me.dgvMarketplace.TabIndex = 8
        '
        'UC_Marketplace
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgvMarketplace)
        Me.Controls.Add(Me.btnPostProduct)
        Me.Controls.Add(Me.txtSellerLocation)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtProductPrice)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtProductName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UC_Marketplace"
        Me.Size = New System.Drawing.Size(360, 640)
        CType(Me.dgvMarketplace, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtProductPrice As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSellerLocation As TextBox
    Friend WithEvents btnPostProduct As Button
    Friend WithEvents dgvMarketplace As DataGridView
End Class
