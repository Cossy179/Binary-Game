<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Game
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Game))
        Me.Timer_Label = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MetroProgressBar1 = New MetroFramework.Controls.MetroProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Binary_label = New System.Windows.Forms.Label()
        Me.Submit_button = New MetroFramework.Controls.MetroButton()
        Me.Answer_box = New MetroFramework.Controls.MetroTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Score_label = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Backbttn = New MetroFramework.Controls.MetroButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer_Label
        '
        Me.Timer_Label.AutoSize = True
        Me.Timer_Label.BackColor = System.Drawing.Color.Transparent
        Me.Timer_Label.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Timer_Label.ForeColor = System.Drawing.Color.Lime
        Me.Timer_Label.Location = New System.Drawing.Point(332, 379)
        Me.Timer_Label.Name = "Timer_Label"
        Me.Timer_Label.Size = New System.Drawing.Size(96, 21)
        Me.Timer_Label.TabIndex = 0
        Me.Timer_Label.Text = "00:01:00"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'MetroProgressBar1
        '
        Me.MetroProgressBar1.Location = New System.Drawing.Point(3, 424)
        Me.MetroProgressBar1.Name = "MetroProgressBar1"
        Me.MetroProgressBar1.Size = New System.Drawing.Size(795, 23)
        Me.MetroProgressBar1.TabIndex = 1
        Me.MetroProgressBar1.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Elephant", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(226, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(324, 55)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Binary Game"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Elephant", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(312, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 41)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Binary:"
        '
        'Binary_label
        '
        Me.Binary_label.AutoSize = True
        Me.Binary_label.BackColor = System.Drawing.Color.DimGray
        Me.Binary_label.Font = New System.Drawing.Font("Comic Sans MS", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Binary_label.ForeColor = System.Drawing.Color.Lime
        Me.Binary_label.Location = New System.Drawing.Point(328, 145)
        Me.Binary_label.Name = "Binary_label"
        Me.Binary_label.Size = New System.Drawing.Size(100, 45)
        Me.Binary_label.TabIndex = 4
        Me.Binary_label.Text = "0000"
        '
        'Submit_button
        '
        Me.Submit_button.Location = New System.Drawing.Point(319, 300)
        Me.Submit_button.Name = "Submit_button"
        Me.Submit_button.Size = New System.Drawing.Size(131, 45)
        Me.Submit_button.TabIndex = 5
        Me.Submit_button.Text = "Submit"
        Me.Submit_button.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'Answer_box
        '
        Me.Answer_box.Location = New System.Drawing.Point(319, 255)
        Me.Answer_box.Name = "Answer_box"
        Me.Answer_box.Size = New System.Drawing.Size(131, 23)
        Me.Answer_box.TabIndex = 6
        Me.Answer_box.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Elephant", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Lime
        Me.Label3.Location = New System.Drawing.Point(312, 202)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 41)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Denary:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Elephant", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Lime
        Me.Label4.Location = New System.Drawing.Point(600, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 35)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Score:"
        '
        'Score_label
        '
        Me.Score_label.AutoSize = True
        Me.Score_label.Font = New System.Drawing.Font("Elephant", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Score_label.ForeColor = System.Drawing.Color.Lime
        Me.Score_label.Location = New System.Drawing.Point(632, 155)
        Me.Score_label.Name = "Score_label"
        Me.Score_label.Size = New System.Drawing.Size(36, 35)
        Me.Score_label.TabIndex = 9
        Me.Score_label.Text = "0"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-6, -9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(813, 25)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Backbttn
        '
        Me.Backbttn.Location = New System.Drawing.Point(23, 29)
        Me.Backbttn.Name = "Backbttn"
        Me.Backbttn.Size = New System.Drawing.Size(131, 45)
        Me.Backbttn.TabIndex = 11
        Me.Backbttn.Text = "Back"
        Me.Backbttn.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.Backbttn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Score_label)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Answer_box)
        Me.Controls.Add(Me.Submit_button)
        Me.Controls.Add(Me.Binary_label)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MetroProgressBar1)
        Me.Controls.Add(Me.Timer_Label)
        Me.Name = "Game"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer_Label As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents MetroProgressBar1 As MetroFramework.Controls.MetroProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Binary_label As Label
    Friend WithEvents Submit_button As MetroFramework.Controls.MetroButton
    Friend WithEvents Answer_box As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Score_label As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Backbttn As MetroFramework.Controls.MetroButton
End Class
