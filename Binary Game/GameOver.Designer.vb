<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameOver
    Inherits MetroFramework.Forms.MetroForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GameOver))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Score_label = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Yes_button = New System.Windows.Forms.Button()
        Me.No_button = New System.Windows.Forms.Button()
        Me.NewHighscore_Label = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-9, -11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(818, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(-18, 426)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(827, 31)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Elephant", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(221, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(345, 55)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "GAME OVER"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Elephant", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(308, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(207, 35)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Your Score Is:"
        '
        'Score_label
        '
        Me.Score_label.AutoSize = True
        Me.Score_label.Font = New System.Drawing.Font("Elephant", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Score_label.ForeColor = System.Drawing.Color.Lime
        Me.Score_label.Location = New System.Drawing.Point(382, 180)
        Me.Score_label.Name = "Score_label"
        Me.Score_label.Size = New System.Drawing.Size(52, 51)
        Me.Score_label.TabIndex = 13
        Me.Score_label.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Elephant", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Lime
        Me.Label3.Location = New System.Drawing.Point(161, 231)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(523, 35)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Would You Like To Save Your Score?"
        '
        'Yes_button
        '
        Me.Yes_button.BackColor = System.Drawing.Color.Lime
        Me.Yes_button.Font = New System.Drawing.Font("Bernard MT Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Yes_button.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Yes_button.Location = New System.Drawing.Point(206, 299)
        Me.Yes_button.Name = "Yes_button"
        Me.Yes_button.Size = New System.Drawing.Size(125, 53)
        Me.Yes_button.TabIndex = 15
        Me.Yes_button.Text = "Yes"
        Me.Yes_button.UseVisualStyleBackColor = False
        '
        'No_button
        '
        Me.No_button.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.No_button.Font = New System.Drawing.Font("Bernard MT Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.No_button.ForeColor = System.Drawing.SystemColors.ControlText
        Me.No_button.Location = New System.Drawing.Point(441, 299)
        Me.No_button.Name = "No_button"
        Me.No_button.Size = New System.Drawing.Size(125, 53)
        Me.No_button.TabIndex = 16
        Me.No_button.Text = "No"
        Me.No_button.UseVisualStyleBackColor = False
        '
        'NewHighscore_Label
        '
        Me.NewHighscore_Label.AutoSize = True
        Me.NewHighscore_Label.Font = New System.Drawing.Font("Elephant", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewHighscore_Label.ForeColor = System.Drawing.Color.Lime
        Me.NewHighscore_Label.Location = New System.Drawing.Point(167, 368)
        Me.NewHighscore_Label.Name = "NewHighscore_Label"
        Me.NewHighscore_Label.Size = New System.Drawing.Size(503, 55)
        Me.NewHighscore_Label.TabIndex = 17
        Me.NewHighscore_Label.Text = "NEW HIGHSCORE"
        Me.NewHighscore_Label.Visible = False
        '
        'GameOver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.NewHighscore_Label)
        Me.Controls.Add(Me.No_button)
        Me.Controls.Add(Me.Yes_button)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Score_label)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximumSize = New System.Drawing.Size(800, 450)
        Me.MinimumSize = New System.Drawing.Size(800, 450)
        Me.Name = "GameOver"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Score_label As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Yes_button As Button
    Friend WithEvents No_button As Button
    Friend WithEvents NewHighscore_Label As Label
End Class
