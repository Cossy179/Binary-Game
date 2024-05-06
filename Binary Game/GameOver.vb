Imports System.IO
Public Class GameOver
    Private Sub GameOver_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.game_over, AudioPlayMode.Background)
        Score_label.Text = Game.Score
        If Game.Easy = True Then

            Dim Easy_Score As String = "\\truro.local\Callywith\Students\ah330799\Documents\Visual Studio 2019\Projects\Binary Game\Binary Game\Easy_highscore.txt"
            Dim Easy_list As New List(Of Integer)
            Dim Easy_array As Integer()

            FileOpen(1, Easy_Score, OpenMode.Input)

            Do While Not EOF(1)
                Easy_list.Add(Integer.Parse(LineInput(1)))
            Loop

            Easy_array = Easy_list.ToArray

            Easy_array.Reverse()

            If Easy_array(0) < Int(Score_label.Text) Then
                NewHighscore_Label.Visible = True
            End If


        End If
        If Game.Medium = True Then
            Dim Medium_Score As String = "\\truro.local\Callywith\Students\ah330799\Documents\Visual Studio 2019\Projects\Binary Game\Binary Game\Med_highscore.txt"
            Dim Medium_list As New List(Of Integer)
            Dim Medium_array As Integer()

            FileOpen(1, Medium_Score, OpenMode.Input)

            Do While Not EOF(1)
                Medium_list.Add(Integer.Parse(LineInput(1)))
            Loop

            Medium_array = Medium_list.ToArray

            Medium_array.Reverse()

            If Medium_array(0) < Int(Score_label.Text) Then
                NewHighscore_Label.Visible = True
            End If
        End If
        If Game.Hard = True Then
            Dim Hard_Score As String = "\\truro.local\Callywith\Students\ah330799\Documents\Visual Studio 2019\Projects\Binary Game\Binary Game\Hard_highscore.txt"
            Dim Hard_list As New List(Of Integer)
            Dim Hard_array As Integer()

            FileOpen(1, Hard_Score, OpenMode.Input)

            Do While Not EOF(1)
                Hard_list.Add(Integer.Parse(LineInput(1)))
            Loop

            Hard_array = Hard_list.ToArray

            Hard_array.Reverse()

            If Hard_array(0) < Int(Score_label.Text) Then
                NewHighscore_Label.Visible = True
            End If
        End If
    End Sub

    Private Sub Yes_button_Click(sender As Object, e As EventArgs) Handles Yes_button.Click
        If Game.Easy = True Then
            Dim Easy_Score As String = "\\truro.local\Callywith\Students\ah330799\Documents\Visual Studio 2019\Projects\Binary Game\Binary Game\Easy_highscore.txt"
            Using writer As StreamWriter = New StreamWriter(Easy_Score, True)
                writer.WriteLine(Score_label.Text)
            End Using
        End If
        If Game.Medium = True Then
            Dim Medium_Score As String = "\\truro.local\Callywith\Students\ah330799\Documents\Visual Studio 2019\Projects\Binary Game\Binary Game\Med_highscore.txt"
            Using writer As StreamWriter = New StreamWriter(Medium_Score, True)
                writer.WriteLine(Score_label.Text)
            End Using
        End If
        If Game.Hard = True Then
            Dim Hard_Score As String = "\\truro.local\Callywith\Students\ah330799\Documents\Visual Studio 2019\Projects\Binary Game\Binary Game\Hard_highscore.txt"
            Using writer As StreamWriter = New StreamWriter(Hard_Score, True)
                writer.WriteLine(Score_label.Text)
            End Using
        End If
        Me.Close()
        Game.Close()
        Form1.Show()
    End Sub

    Private Sub No_button_Click(sender As Object, e As EventArgs) Handles No_button.Click
        Me.Close()
        Form1.Show()
    End Sub

End Class