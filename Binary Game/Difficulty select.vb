Public Class Difficulty_select
    Private Sub backbttn_Click(sender As Object, e As EventArgs) Handles backbttn.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Easybttn_Click(sender As Object, e As EventArgs) Handles Easybttn.Click
        Game.Show()
        Game.Easy_mode()
        Game.Easy = True
        Game.Answer_box.Enabled = True
        Me.Hide()
    End Sub

    Private Sub Medbuttn_Click(sender As Object, e As EventArgs) Handles Medbuttn.Click
        Game.Show()
        Game.Medium_mode()
        Game.Medium = True
        Game.Answer_box.Enabled = True
        Me.Hide()
    End Sub

    Private Sub Hardbttn_Click(sender As Object, e As EventArgs) Handles Hardbttn.Click
        Game.Show()
        Game.Hard_mode()
        Game.Hard = True
        Game.Answer_box.Enabled = True
        Me.Hide()
    End Sub
End Class