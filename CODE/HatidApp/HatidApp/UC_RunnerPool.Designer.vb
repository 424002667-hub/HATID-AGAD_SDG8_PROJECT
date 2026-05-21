<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_RunnerPool
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
        Me.dgvRunnerPool = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAcceptOrder = New System.Windows.Forms.Button()
        CType(Me.dgvRunnerPool, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvRunnerPool
        '
        Me.dgvRunnerPool.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRunnerPool.Location = New System.Drawing.Point(20, 97)
        Me.dgvRunnerPool.Name = "dgvRunnerPool"
        Me.dgvRunnerPool.RowHeadersWidth = 51
        Me.dgvRunnerPool.RowTemplate.Height = 24
        Me.dgvRunnerPool.Size = New System.Drawing.Size(336, 238)
        Me.dgvRunnerPool.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(380, 60)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(27, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(329, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "RUNNER MODE: AVAILABLE DELIVERIES"
        '
        'btnAcceptOrder
        '
        Me.btnAcceptOrder.BackColor = System.Drawing.Color.Gold
        Me.btnAcceptOrder.Location = New System.Drawing.Point(104, 386)
        Me.btnAcceptOrder.Name = "btnAcceptOrder"
        Me.btnAcceptOrder.Size = New System.Drawing.Size(158, 59)
        Me.btnAcceptOrder.TabIndex = 2
        Me.btnAcceptOrder.Text = "🚴 Claim Selected Order"
        Me.btnAcceptOrder.UseVisualStyleBackColor = False
        '
        'UC_RunnerPool
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnAcceptOrder)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgvRunnerPool)
        Me.Name = "UC_RunnerPool"
        Me.Size = New System.Drawing.Size(380, 550)
        CType(Me.dgvRunnerPool, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvRunnerPool As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAcceptOrder As Button
End Class
