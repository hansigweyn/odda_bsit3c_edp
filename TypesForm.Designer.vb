<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TypesForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TypesForm))
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.TypesBackButton = New Guna.UI2.WinForms.Guna2TileButton()
        Me.Guna2PictureBox3 = New Guna.UI2.WinForms.Guna2PictureBox()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(1173, 666)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 1
        Me.Guna2PictureBox1.TabStop = False
        '
        'TypesBackButton
        '
        Me.TypesBackButton.BackColor = System.Drawing.Color.Transparent
        Me.TypesBackButton.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.TypesBackButton.BorderRadius = 5
        Me.TypesBackButton.BorderThickness = 5
        Me.TypesBackButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.TypesBackButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.TypesBackButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.TypesBackButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.TypesBackButton.FillColor = System.Drawing.Color.Transparent
        Me.TypesBackButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TypesBackButton.ForeColor = System.Drawing.Color.Transparent
        Me.TypesBackButton.Location = New System.Drawing.Point(42, 574)
        Me.TypesBackButton.Name = "TypesBackButton"
        Me.TypesBackButton.Size = New System.Drawing.Size(143, 54)
        Me.TypesBackButton.TabIndex = 10
        Me.TypesBackButton.Text = "Guna2TileButton3"
        Me.TypesBackButton.UseTransparentBackground = True
        '
        'Guna2PictureBox3
        '
        Me.Guna2PictureBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2PictureBox3.Image = CType(resources.GetObject("Guna2PictureBox3.Image"), System.Drawing.Image)
        Me.Guna2PictureBox3.ImageRotate = 0!
        Me.Guna2PictureBox3.Location = New System.Drawing.Point(0, 0)
        Me.Guna2PictureBox3.Name = "Guna2PictureBox3"
        Me.Guna2PictureBox3.Size = New System.Drawing.Size(1173, 666)
        Me.Guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox3.TabIndex = 9
        Me.Guna2PictureBox3.TabStop = False
        '
        'TypesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1173, 666)
        Me.Controls.Add(Me.TypesBackButton)
        Me.Controls.Add(Me.Guna2PictureBox3)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Name = "TypesForm"
        Me.Text = "TypesForm"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents TypesBackButton As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents Guna2PictureBox3 As Guna.UI2.WinForms.Guna2PictureBox
End Class
