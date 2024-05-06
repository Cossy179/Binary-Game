Public Class Game

    Public Easy, Medium, Hard As Boolean
    Public Medium_locked As Boolean = True
    Public Hard_locked As Boolean = True
    Public Score As Integer

    Dim i As Integer



    '60 seconds for timer
    Private CountDownTimer As Integer = 60

    'Handle for every time the timer ticks in the 1000ms interval
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Timer_Label.Text = FormatDateTime(DateAdd(DateInterval.Second, -1, DateTime.Parse(Timer_Label.Text)), DateFormat.LongTime) 'COUNTDOWN -1

        CountDownTimer -= 1
        MetroProgressBar1.Value = CountDownTimer

        'COUNTDOWN when the timer reaches 0
        If MetroProgressBar1.Value = 0 Then
            Timer1.Enabled = False
            Answer_box.Enabled = False
            'Checking if Easy mode is True and Score is greater than or equal to 5
            If Medium_locked = True And Score >= 5 And Easy = True Then
                'Medium is Unlocked
                MessageBox.Show("You have unlocked Medium")
                Difficulty_select.Medbuttn.Enabled = True
                Difficulty_select.Medbuttn.Text = "Medium"
                Medium_locked = False
                GameOver.Show()
                Me.Close()
            Else
                GameOver.Show()
                Me.Close()
            End If
            'Checking if Medium mode is True and Score is greater than or equal to 5
            If Hard_locked = True And Score >= 5 And Medium = True Then
                'Hard is Unlocked
                MessageBox.Show("You have unlocked Hard")
                Difficulty_select.Hardbttn.Enabled = True
                Difficulty_select.Hardbttn.Text = "Hard"
                Hard_locked = False
                GameOver.Show()
                Me.Close()
            Else
                GameOver.Show()
                Me.Close()
            End If
        End If
    End Sub


    'COUNTDOWN to start automatically
    Private Sub Game() Handles MyBase.Load


        Timer_Label.Text = "0:01:00"

        MetroProgressBar1.Maximum = CountDownTimer
        MetroProgressBar1.Value = CountDownTimer

        Timer1.Enabled = True
    End Sub

    Public Sub Easy_mode()
        i = CInt(Math.Floor((15 - 1 + 1) * Rnd())) + 1 'Generate a random Denary number
        Dim s As String = Convert.ToString(i, 2).PadLeft(4, "0"c) '4 bit binary number generated from i 
        Binary_label.Text = s 'Set the binary number to the label
    End Sub
    Public Sub Medium_mode()
        i = CInt(Math.Floor((63 - 1 + 1) * Rnd())) + 1 'Generate a random Denary number
        Dim s As String = Convert.ToString(i, 2).PadLeft(6, "0"c) '6 bit binary number generated from i 
        Binary_label.Text = s 'Set the binary number to the label
    End Sub

    'Handle for when the back button is clicked
    Private Sub Backbttn_Click(sender As Object, e As EventArgs) Handles Backbttn.Click
        Form1.Show()
        Me.Close()
    End Sub

    Public Sub Hard_mode()
        i = CInt(Math.Floor((255 - 1 + 1) * Rnd())) + 1 'Generate a random Denary number
        Dim s As String = Convert.ToString(i, 2).PadLeft(8, "0"c) '8 bit binary number generated from i 
        Binary_label.Text = s 'Set the binary number to the label
    End Sub

    'When the Submit button is clicked
    Private Sub Submit_button_Click(sender As Object, e As EventArgs) Handles Submit_button.Click
        If Answer_box.Text = "" Then 'Presence check on the answer box
        Else
            If Int(Answer_box.Text) = i Then 'Checks if the answer in the text box is equal to the Denary number
                My.Computer.Audio.Play(My.Resources.Yay, AudioPlayMode.Background)
                'Generates a new question based of the difficulty selected
                If Easy = True Then
                    Easy_mode() 'Generates easy question
                ElseIf Medium = True Then
                    Medium_mode() 'Generates Medium question
                ElseIf Hard = True Then
                    Hard_mode() 'Generate Hard question
                End If
                Score += 1 'Increments the score by 1
                Score_label.Text = Score 'Update Score label
            Else
                My.Computer.Audio.Play(My.Resources.lose, AudioPlayMode.Background)


            End If
            Answer_box.Clear()
        End If

    End Sub
End Class