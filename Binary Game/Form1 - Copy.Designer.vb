<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits MetroFramework.Forms.MetroForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Playbttn = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Highscore_tab = New MetroFramework.Controls.MetroTabControl()
        Me.EasyTabPage = New MetroFramework.Controls.MetroTabPage()
        Me.Easy_highscorelabel5 = New System.Windows.Forms.Label()
        Me.Easy_highscorelabel4 = New System.Windows.Forms.Label()
        Me.Easy_highscorelabel3 = New System.Windows.Forms.Label()
        Me.Easy_highscorelabel2 = New System.Windows.Forms.Label()
        Me.Easy_highscorelabel1 = New System.Windows.Forms.Label()
        Me.MedTabPage = New MetroFramework.Controls.MetroTabPage()
        Me.Medium_highscorelabel5 = New System.Windows.Forms.Label()
        Me.Medium_highscorelabel4 = New System.Windows.Forms.Label()
        Me.Medium_highscorelabel3 = New System.Windows.Forms.Label()
        Me.Medium_highscorelabel2 = New System.Windows.Forms.Label()
        Me.Medium_highscorelabel1 = New System.Windows.Forms.Label()
        Me.HardTabPage = New MetroFramework.Controls.MetroTabPage()
        Me.Hard_highscorelabel5 = New System.Windows.Forms.Label()
        Me.Hard_highscorelabel4 = New System.Windows.Forms.Label()
        Me.Hard_highscorelabel3 = New System.Windows.Forms.Label()
        Me.Hard_highscorelabel2 = New System.Windows.Forms.Label()
        Me.Hard_highscorelabel1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Highscore_tab.SuspendLayout()
        Me.EasyTabPage.SuspendLayout()
        Me.MedTabPage.SuspendLayout()
        Me.HardTabPage.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Elephant", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(191, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(324, 55)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Binary Game"
        '
        'Playbttn
        '
        Me.Playbttn.BackColor = System.Drawing.Color.DimGray
        Me.Playbttn.Font = New System.Drawing.Font("Bernard MT Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Playbttn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Playbttn.Location = New System.Drawing.Point(201, 139)
        Me.Playbttn.Name = "Playbttn"
        Me.Playbttn.Size = New System.Drawing.Size(125, 53)
        Me.Playbttn.TabIndex = 1
        Me.Playbttn.Text = "Play"
        Me.Playbttn.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DimGray
        Me.Button2.Font = New System.Drawing.Font("Bernard MT Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button2.Location = New System.Drawing.Point(201, 234)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(125, 53)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Instructions"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DimGray
        Me.Button3.Font = New System.Drawing.Font("Bernard MT Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button3.Location = New System.Drawing.Point(201, 331)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(125, 53)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Quit"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Highscore_tab
        '
        Me.Highscore_tab.Controls.Add(Me.EasyTabPage)
        Me.Highscore_tab.Controls.Add(Me.MedTabPage)
        Me.Highscore_tab.Controls.Add(Me.HardTabPage)
        Me.Highscore_tab.Location = New System.Drawing.Point(469, 148)
        Me.Highscore_tab.Name = "Highscore_tab"
        Me.Highscore_tab.SelectedIndex = 0
        Me.Highscore_tab.Size = New System.Drawing.Size(209, 277)
        Me.Highscore_tab.TabIndex = 6
        Me.Highscore_tab.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'EasyTabPage
        '
        Me.EasyTabPage.Controls.Add(Me.Easy_highscorelabel5)
        Me.EasyTabPage.Controls.Add(Me.Easy_highscorelabel4)
        Me.EasyTabPage.Controls.Add(Me.Easy_highscorelabel3)
        Me.EasyTabPage.Controls.Add(Me.Easy_highscorelabel2)
        Me.EasyTabPage.Controls.Add(Me.Easy_highscorelabel1)
        Me.EasyTabPage.HorizontalScrollbarBarColor = True
        Me.EasyTabPage.Location = New System.Drawing.Point(4, 35)
        Me.EasyTabPage.Name = "EasyTabPage"
        Me.EasyTabPage.Size = New System.Drawing.Size(201, 238)
        Me.EasyTabPage.TabIndex = 0
        Me.EasyTabPage.Text = "Easy"
        Me.EasyTabPage.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.EasyTabPage.VerticalScrollbarBarColor = True
        '
        'Easy_highscorelabel5
        '
        Me.Easy_highscorelabel5.AutoSize = True
        Me.Easy_highscorelabel5.BackColor = System.Drawing.Color.Transparent
        Me.Easy_highscorelabel5.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Easy_highscorelabel5.ForeColor = System.Drawing.Color.Lime
        Me.Easy_highscorelabel5.Location = New System.Drawing.Point(3, 148)
        Me.Easy_highscorelabel5.Name = "Easy_highscorelabel5"
        Me.Easy_highscorelabel5.Size = New System.Drawing.Size(119, 21)
        Me.Easy_highscorelabel5.TabIndex = 6
        Me.Easy_highscorelabel5.Text = "No Highscore"
        '
        'Easy_highscorelabel4
        '
        Me.Easy_highscorelabel4.AutoSize = True
        Me.Easy_highscorelabel4.BackColor = System.Drawing.Color.Transparent
        Me.Easy_highscorelabel4.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Easy_highscorelabel4.ForeColor = System.Drawing.Color.Lime
        Me.Easy_highscorelabel4.Location = New System.Drawing.Point(3, 117)
        Me.Easy_highscorelabel4.Name = "Easy_highscorelabel4"
        Me.Easy_highscorelabel4.Size = New System.Drawing.Size(119, 21)
        Me.Easy_highscorelabel4.TabIndex = 5
        Me.Easy_highscorelabel4.Text = "No Highscore"
        '
        'Easy_highscorelabel3
        '
        Me.Easy_highscorelabel3.AutoSize = True
        Me.Easy_highscorelabel3.BackColor = System.Drawing.Color.Transparent
        Me.Easy_highscorelabel3.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Easy_highscorelabel3.ForeColor = System.Drawing.Color.Lime
        Me.Easy_highscorelabel3.Location = New System.Drawing.Point(3, 83)
        Me.Easy_highscorelabel3.Name = "Easy_highscorelabel3"
        Me.Easy_highscorelabel3.Size = New System.Drawing.Size(119, 21)
        Me.Easy_highscorelabel3.TabIndex = 4
        Me.Easy_highscorelabel3.Text = "No Highscore"
        '
        'Easy_highscorelabel2
        '
        Me.Easy_highscorelabel2.AutoSize = True
        Me.Easy_highscorelabel2.BackColor = System.Drawing.Color.Transparent
        Me.Easy_highscorelabel2.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Easy_highscorelabel2.ForeColor = System.Drawing.Color.Lime
        Me.Easy_highscorelabel2.Location = New System.Drawing.Point(3, 51)
        Me.Easy_highscorelabel2.Name = "Easy_highscorelabel2"
        Me.Easy_highscorelabel2.Size = New System.Drawing.Size(119, 21)
        Me.Easy_highscorelabel2.TabIndex = 3
        Me.Easy_highscorelabel2.Text = "No Highscore"
        '
        'Easy_highscorelabel1
        '
        Me.Easy_highscorelabel1.AutoSize = True
        Me.Easy_highscorelabel1.BackColor = System.Drawing.Color.Transparent
        Me.Easy_highscorelabel1.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Easy_highscorelabel1.ForeColor = System.Drawing.Color.Lime
        Me.Easy_highscorelabel1.Location = New System.Drawing.Point(3, 17)
        Me.Easy_highscorelabel1.Name = "Easy_highscorelabel1"
        Me.Easy_highscorelabel1.Size = New System.Drawing.Size(119, 21)
        Me.Easy_highscorelabel1.TabIndex = 2
        Me.Easy_highscorelabel1.Text = "No Highscore"
        '
        'MedTabPage
        '
        Me.MedTabPage.Controls.Add(Me.Medium_highscorelabel5)
        Me.MedTabPage.Controls.Add(Me.Medium_highscorelabel4)
        Me.MedTabPage.Controls.Add(Me.Medium_highscorelabel3)
        Me.MedTabPage.Controls.Add(Me.Medium_highscorelabel2)
        Me.MedTabPage.Controls.Add(Me.Medium_highscorelabel1)
        Me.MedTabPage.HorizontalScrollbarBarColor = True
        Me.MedTabPage.Location = New System.Drawing.Point(4, 35)
        Me.MedTabPage.Name = "MedTabPage"
        Me.MedTabPage.Size = New System.Drawing.Size(201, 238)
        Me.MedTabPage.TabIndex = 1
        Me.MedTabPage.Text = "Medium"
        Me.MedTabPage.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MedTabPage.VerticalScrollbarBarColor = True
        '
        'Medium_highscorelabel5
        '
        Me.Medium_highscorelabel5.AutoSize = True
        Me.Medium_highscorelabel5.BackColor = System.Drawing.Color.Transparent
        Me.Medium_highscorelabel5.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Medium_highscorelabel5.ForeColor = System.Drawing.Color.Lime
        Me.Medium_highscorelabel5.Location = New System.Drawing.Point(3, 148)
        Me.Medium_highscorelabel5.Name = "Medium_highscorelabel5"
        Me.Medium_highscorelabel5.Size = New System.Drawing.Size(119, 21)
        Me.Medium_highscorelabel5.TabIndex = 7
        Me.Medium_highscorelabel5.Text = "No Highscore"
        '
        'Medium_highscorelabel4
        '
        Me.Medium_highscorelabel4.AutoSize = True
        Me.Medium_highscorelabel4.BackColor = System.Drawing.Color.Transparent
        Me.Medium_highscorelabel4.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Medium_highscorelabel4.ForeColor = System.Drawing.Color.Lime
        Me.Medium_highscorelabel4.Location = New System.Drawing.Point(3, 115)
        Me.Medium_highscorelabel4.Name = "Medium_highscorelabel4"
        Me.Medium_highscorelabel4.Size = New System.Drawing.Size(119, 21)
        Me.Medium_highscorelabel4.TabIndex = 6
        Me.Medium_highscorelabel4.Text = "No Highscore"
        '
        'Medium_highscorelabel3
        '
        Me.Medium_highscorelabel3.AutoSize = True
        Me.Medium_highscorelabel3.BackColor = System.Drawing.Color.Transparent
        Me.Medium_highscorelabel3.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Medium_highscorelabel3.ForeColor = System.Drawing.Color.Lime
        Me.Medium_highscorelabel3.Location = New System.Drawing.Point(3, 83)
        Me.Medium_highscorelabel3.Name = "Medium_highscorelabel3"
        Me.Medium_highscorelabel3.Size = New System.Drawing.Size(119, 21)
        Me.Medium_highscorelabel3.TabIndex = 5
        Me.Medium_highscorelabel3.Text = "No Highscore"
        '
        'Medium_highscorelabel2
        '
        Me.Medium_highscorelabel2.AutoSize = True
        Me.Medium_highscorelabel2.BackColor = System.Drawing.Color.Transparent
        Me.Medium_highscorelabel2.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Medium_highscorelabel2.ForeColor = System.Drawing.Color.Lime
        Me.Medium_highscorelabel2.Location = New System.Drawing.Point(3, 51)
        Me.Medium_highscorelabel2.Name = "Medium_highscorelabel2"
        Me.Medium_highscorelabel2.Size = New System.Drawing.Size(119, 21)
        Me.Medium_highscorelabel2.TabIndex = 4
        Me.Medium_highscorelabel2.Text = "No Highscore"
        '
        'Medium_highscorelabel1
        '
        Me.Medium_highscorelabel1.AutoSize = True
        Me.Medium_highscorelabel1.BackColor = System.Drawing.Color.Transparent
        Me.Medium_highscorelabel1.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Medium_highscorelabel1.ForeColor = System.Drawing.Color.Lime
        Me.Medium_highscorelabel1.Location = New System.Drawing.Point(3, 17)
        Me.Medium_highscorelabel1.Name = "Medium_highscorelabel1"
        Me.Medium_highscorelabel1.Size = New System.Drawing.Size(119, 21)
        Me.Medium_highscorelabel1.TabIndex = 3
        Me.Medium_highscorelabel1.Text = "No Highscore"
        '
        'HardTabPage
        '
        Me.HardTabPage.Controls.Add(Me.Hard_highscorelabel5)
        Me.HardTabPage.Controls.Add(Me.Hard_highscorelabel4)
        Me.HardTabPage.Controls.Add(Me.Hard_highscorelabel3)
        Me.HardTabPage.Controls.Add(Me.Hard_highscorelabel2)
        Me.HardTabPage.Controls.Add(Me.Hard_highscorelabel1)
        Me.HardTabPage.HorizontalScrollbarBarColor = True
        Me.HardTabPage.Location = New System.Drawing.Point(4, 35)
        Me.HardTabPage.Name = "HardTabPage"
        Me.HardTabPage.Size = New System.Drawing.Size(201, 238)
        Me.HardTabPage.TabIndex = 2
        Me.HardTabPage.Text = "Hard"
        Me.HardTabPage.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.HardTabPage.VerticalScrollbarBarColor = True
        '
        'Hard_highscorelabel5
        '
        Me.Hard_highscorelabel5.AutoSize = True
        Me.Hard_highscorelabel5.BackColor = System.Drawing.Color.Transparent
        Me.Hard_highscorelabel5.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hard_highscorelabel5.ForeColor = System.Drawing.Color.Lime
        Me.Hard_highscorelabel5.Location = New System.Drawing.Point(3, 148)
        Me.Hard_highscorelabel5.Name = "Hard_highscorelabel5"
        Me.Hard_highscorelabel5.Size = New System.Drawing.Size(119, 21)
        Me.Hard_highscorelabel5.TabIndex = 7
        Me.Hard_highscorelabel5.Text = "No Highscore"
        '
        'Hard_highscorelabel4
        '
        Me.Hard_highscorelabel4.AutoSize = True
        Me.Hard_highscorelabel4.BackColor = System.Drawing.Color.Transparent
        Me.Hard_highscorelabel4.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hard_highscorelabel4.ForeColor = System.Drawing.Color.Lime
        Me.Hard_highscorelabel4.Location = New System.Drawing.Point(3, 116)
        Me.Hard_highscorelabel4.Name = "Hard_highscorelabel4"
        Me.Hard_highscorelabel4.Size = New System.Drawing.Size(119, 21)
        Me.Hard_highscorelabel4.TabIndex = 6
        Me.Hard_highscorelabel4.Text = "No Highscore"
        '
        'Hard_highscorelabel3
        '
        Me.Hard_highscorelabel3.AutoSize = True
        Me.Hard_highscorelabel3.BackColor = System.Drawing.Color.Transparent
        Me.Hard_highscorelabel3.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hard_highscorelabel3.ForeColor = System.Drawing.Color.Lime
        Me.Hard_highscorelabel3.Location = New System.Drawing.Point(3, 83)
        Me.Hard_highscorelabel3.Name = "Hard_highscorelabel3"
        Me.Hard_highscorelabel3.Size = New System.Drawing.Size(119, 21)
        Me.Hard_highscorelabel3.TabIndex = 5
        Me.Hard_highscorelabel3.Text = "No Highscore"
        '
        'Hard_highscorelabel2
        '
        Me.Hard_highscorelabel2.AutoSize = True
        Me.Hard_highscorelabel2.BackColor = System.Drawing.Color.Transparent
        Me.Hard_highscorelabel2.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hard_highscorelabel2.ForeColor = System.Drawing.Color.Lime
        Me.Hard_highscorelabel2.Location = New System.Drawing.Point(3, 51)
        Me.Hard_highscorelabel2.Name = "Hard_highscorelabel2"
        Me.Hard_highscorelabel2.Size = New System.Drawing.Size(119, 21)
        Me.Hard_highscorelabel2.TabIndex = 4
        Me.Hard_highscorelabel2.Text = "No Highscore"
        '
        'Hard_highscorelabel1
        '
        Me.Hard_highscorelabel1.AutoSize = True
        Me.Hard_highscorelabel1.BackColor = System.Drawing.Color.Transparent
        Me.Hard_highscorelabel1.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hard_highscorelabel1.ForeColor = System.Drawing.Color.Lime
        Me.Hard_highscorelabel1.Location = New System.Drawing.Point(3, 19)
        Me.Hard_highscorelabel1.Name = "Hard_highscorelabel1"
        Me.Hard_highscorelabel1.Size = New System.Drawing.Size(119, 21)
        Me.Hard_highscorelabel1.TabIndex = 3
        Me.Hard_highscorelabel1.Text = "No Highscore"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Elephant", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(510, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 25)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "HighScores"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-3, 538)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(772, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(-3, -5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(772, 31)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 570)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Highscore_tab)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Playbttn)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(762, 570)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(762, 570)
        Me.Name = "Form1"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.TransparencyKey = System.Drawing.Color.Silver
        Me.Highscore_tab.ResumeLayout(False)
        Me.EasyTabPage.ResumeLayout(False)
        Me.EasyTabPage.PerformLayout()
        Me.MedTabPage.ResumeLayout(False)
        Me.MedTabPage.PerformLayout()
        Me.HardTabPage.ResumeLayout(False)
        Me.HardTabPage.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Playbttn As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Highscore_tab As MetroFramework.Controls.MetroTabControl
    Friend WithEvents EasyTabPage As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MedTabPage As MetroFramework.Controls.MetroTabPage
    Friend WithEvents HardTabPage As MetroFramework.Controls.MetroTabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents Easy_highscorelabel1 As Label
    Friend WithEvents Medium_highscorelabel1 As Label
    Friend WithEvents Hard_highscorelabel1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Easy_highscorelabel5 As Label
    Friend WithEvents Easy_highscorelabel4 As Label
    Friend WithEvents Easy_highscorelabel3 As Label
    Friend WithEvents Easy_highscorelabel2 As Label
    Friend WithEvents Medium_highscorelabel5 As Label
    Friend WithEvents Medium_highscorelabel4 As Label
    Friend WithEvents Medium_highscorelabel3 As Label
    Friend WithEvents Medium_highscorelabel2 As Label
    Friend WithEvents Hard_highscorelabel2 As Label
    Friend WithEvents Hard_highscorelabel5 As Label
    Friend WithEvents Hard_highscorelabel4 As Label
    Friend WithEvents Hard_highscorelabel3 As Label
End Class
