<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FilmsAndTvShowsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FilmsAndTvShowsForm))
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.FilmsAndTvShowsBackButton = New Guna.UI2.WinForms.Guna2TileButton()
        Me.Guna2PictureBox3 = New Guna.UI2.WinForms.Guna2PictureBox()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), System.Drawing.Image)
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(1173, 666)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox2.TabIndex = 2
        Me.Guna2PictureBox2.TabStop = False
        '
        'FilmsAndTvShowsBackButton
        '
        Me.FilmsAndTvShowsBackButton.BackColor = System.Drawing.Color.Transparent
        Me.FilmsAndTvShowsBackButton.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.FilmsAndTvShowsBackButton.BorderRadius = 5
        Me.FilmsAndTvShowsBackButton.BorderThickness = 5
        Me.FilmsAndTvShowsBackButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.FilmsAndTvShowsBackButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.FilmsAndTvShowsBackButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.FilmsAndTvShowsBackButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.FilmsAndTvShowsBackButton.FillColor = System.Drawing.Color.Transparent
        Me.FilmsAndTvShowsBackButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FilmsAndTvShowsBackButton.ForeColor = System.Drawing.Color.Transparent
        Me.FilmsAndTvShowsBackButton.Location = New System.Drawing.Point(42, 574)
        Me.FilmsAndTvShowsBackButton.Name = "FilmsAndTvShowsBackButton"
        Me.FilmsAndTvShowsBackButton.Size = New System.Drawing.Size(143, 54)
        Me.FilmsAndTvShowsBackButton.TabIndex = 6
        Me.FilmsAndTvShowsBackButton.Text = "Guna2TileButton3"
        Me.FilmsAndTvShowsBackButton.UseTransparentBackground = True
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
        Me.Guna2PictureBox3.TabIndex = 5
        Me.Guna2PictureBox3.TabStop = False
        '
        'FilmsAndTvShowsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1173, 666)
        Me.Controls.Add(Me.FilmsAndTvShowsBackButton)
        Me.Controls.Add(Me.Guna2PictureBox3)
        Me.Controls.Add(Me.Guna2PictureBox2)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Name = "FilmsAndTvShowsForm"
        Me.Text = "FilmsAndTvShowsForm"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents FilmsAndTvShowsBackButton As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents Guna2PictureBox3 As Guna.UI2.WinForms.Guna2PictureBox
End Class
