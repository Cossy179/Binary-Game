<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Difficulty_select
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Hardbttn = New System.Windows.Forms.Button()
        Me.Medbuttn = New System.Windows.Forms.Button()
        Me.Easybttn = New System.Windows.Forms.Button()
        Me.backbttn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Elephant", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(158, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(324, 55)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Binary Game"
        '
        'Hardbttn
        '
        Me.Hardbttn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Hardbttn.Enabled = False
        Me.Hardbttn.Font = New System.Drawing.Font("Bernard MT Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hardbttn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Hardbttn.Location = New System.Drawing.Point(269, 354)
        Me.Hardbttn.Name = "Hardbttn"
        Me.Hardbttn.Size = New System.Drawing.Size(125, 53)
        Me.Hardbttn.TabIndex = 6
        Me.Hardbttn.Text = "Locked"
        Me.Hardbttn.UseVisualStyleBackColor = False
        '
        'Medbuttn
        '
        Me.Medbuttn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Medbuttn.Enabled = False
        Me.Medbuttn.Font = New System.Drawing.Font("Bernard MT Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Medbuttn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Medbuttn.Location = New System.Drawing.Point(269, 257)
        Me.Medbuttn.Name = "Medbuttn"
        Me.Medbuttn.Size = New System.Drawing.Size(125, 53)
        Me.Medbuttn.TabIndex = 5
        Me.Medbuttn.Text = "Locked"
        Me.Medbuttn.UseVisualStyleBackColor = False
        '
        'Easybttn
        '
        Me.Easybttn.BackColor = System.Drawing.Color.Lime
        Me.Easybttn.Font = New System.Drawing.Font("Bernard MT Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Easybttn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Easybttn.Location = New System.Drawing.Point(269, 162)
        Me.Easybttn.Name = "Easybttn"
        Me.Easybttn.Size = New System.Drawing.Size(125, 53)
        Me.Easybttn.TabIndex = 4
        Me.Easybttn.Text = " Easy"
        Me.Easybttn.UseVisualStyleBackColor = False
        '
        'backbttn
        '
        Me.backbttn.BackColor = System.Drawing.Color.DimGray
        Me.backbttn.Font = New System.Drawing.Font("Bernard MT Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backbttn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.backbttn.Location = New System.Drawing.Point(269, 457)
        Me.backbttn.Name = "backbttn"
        Me.backbttn.Size = New System.Drawing.Size(125, 53)
        Me.backbttn.TabIndex = 7
        Me.backbttn.Text = "Back"
        Me.backbttn.UseVisualStyleBackColor = False
        '
        'Difficulty_select
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(663, 569)
        Me.ControlBox = False
        Me.Controls.Add(Me.backbttn)
        Me.Controls.Add(Me.Hardbttn)
        Me.Controls.Add(Me.Medbuttn)
        Me.Controls.Add(Me.Easybttn)
        Me.Controls.Add(Me.Label1)
        Me.MaximumSize = New System.Drawing.Size(663, 569)
        Me.MinimumSize = New System.Drawing.Size(663, 569)
        Me.Name = "Difficulty_select"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Hardbttn As Button
    Friend WithEvents Medbuttn As Button
    Friend WithEvents Easybttn As Button
    Friend WithEvents backbttn As Button
End Class
