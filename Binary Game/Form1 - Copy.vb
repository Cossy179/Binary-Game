Public Class Form1
    Dim easy_dic As New Dictionary(Of String, String)
    Dim Medium_dic As New Dictionary(Of String, Integer)
    Dim Hard_dic As New Dictionary(Of String, Integer)

    Dim lines As Integer



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Instructions.Show()
    End Sub

    Private Sub Playbttn_Click(sender As Object, e As EventArgs) Handles Playbttn.Click
        Difficulty_select.Show()
        Me.Hide()
    End Sub



    Private Sub Form1_Load() Handles MyBase.Load

        My.Computer.Audio.Play(My.Resources.Music, AudioPlayMode.BackgroundLoop) 'Starts Music

        Dim Easy_highscore As String = "\\truro.local\Callywith\Students\ah330799\Documents\Visual Studio 2019\Projects\Binary Game\Binary Game\Easy_highscore.txt" 'String with easy txt file directory

        'Dim all variables
        Dim myListLabel As New List(Of Label) 'list of label names
        Dim data As New List(Of Integer) 'List for values in file
        Dim array As Integer() 'To convert List to array for sorting
        Dim lines As Integer 'Count the amount of lines in file

        'Adding all the easy labels in the myListLabel
        myListLabel.Add(Easy_highscorelabel1)
        myListLabel.Add(Easy_highscorelabel2)
        myListLabel.Add(Easy_highscorelabel3)
        myListLabel.Add(Easy_highscorelabel4)
        myListLabel.Add(Easy_highscorelabel5)

        FileOpen(1, Easy_highscore, OpenMode.Input) 'Opens Easy txt file

        'Loops til end of file
        Do While Not EOF(1)
            data.Add(Integer.Parse(LineInput(1))) 'Reads the line and adds it to the list
            lines += 1 'Increments lines by 1
        Loop

        array = data.ToArray 'Changes data into an array


        array = Module1.Main(array) 'Sets array as the returned array from the sort algorthim 


        System.Array.Reverse(array) 'reverses the array

        'Loops 5 times
        For i As Integer = 0 To 4
            myListLabel(i).Text = array(i) 'Sets i label to the i value in array
        Next

        FileClose(1) 'Close File



        Dim Med_highscore As String = "\\truro.local\Callywith\Students\ah330799\Documents\Visual Studio 2019\Projects\Binary Game\Binary Game\Med_highscore.txt" 'String with Medium txt file directory

        FileOpen(1, Med_highscore, OpenMode.Input) 'Opens Medium txt file

        'Dim all variables
        Dim myListLabel2 As New List(Of Label)
        Dim data2 As New List(Of Integer)
        Dim array2 As Integer()
        Dim Lines2 As Integer

        'Adding all the Medium labels in the myListLabel2
        myListLabel2.Add(Medium_highscorelabel1)
        myListLabel2.Add(Medium_highscorelabel2)
        myListLabel2.Add(Medium_highscorelabel3)
        myListLabel2.Add(Medium_highscorelabel4)
        myListLabel2.Add(Medium_highscorelabel5)

        'Loops til end of file
        Do While Not EOF(1)
            data2.Add(Integer.Parse(LineInput(1)))
            Lines2 += 1
        Loop

        array2 = data2.ToArray 'Changes data2 into an array2


        array2 = Module1.Main(array2) 'Sets array2 as the returned array2 from the sort algorthim 


        System.Array.Reverse(array2) 'reverses the array2


        For i As Integer = 0 To 4
            myListLabel2(i).Text = array2(i) 'Sets i label to the i value in array2
        Next
        FileClose(1) 'Close File

        Dim Hard_highscore As String = "\\truro.local\Callywith\Students\ah330799\Documents\Visual Studio 2019\Projects\Binary Game\Binary Game\Hard_highscore.txt" 'String with Hard txt file directory

        FileOpen(1, Hard_highscore, OpenMode.Input) 'Opens Hard txt file

        'Dim all variables
        Dim myListLabel3 As New List(Of Label)
        Dim data3 As New List(Of Integer)
        Dim array3 As Integer()
        Dim Lines3 As Integer

        'Adding all the Hard labels in the myListLabel3
        myListLabel3.Add(Hard_highscorelabel1)
        myListLabel3.Add(Hard_highscorelabel2)
        myListLabel3.Add(Hard_highscorelabel3)
        myListLabel3.Add(Hard_highscorelabel4)
        myListLabel3.Add(Hard_highscorelabel5)

        'Loops til end of file
        Do While Not EOF(1)
            data3.Add(Integer.Parse(LineInput(1)))
            Lines3 += 1
        Loop

        array3 = data3.ToArray 'Changes data3 into an array3


        array3 = Module1.Main(array3) 'Sets array2 as the returned array2 from the sort algorthim 


        System.Array.Reverse(array3) 'reverses the array3


        For i As Integer = 0 To 4
            myListLabel3(i).Text = array3(i) 'Sets i label to the i value in array2
        Next
        FileClose(1) 'Close File
    End Sub
End Class
