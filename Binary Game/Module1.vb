Module Module1
    Sub merging(ByVal a() As Integer, ByVal low As Integer, ByVal mid As Integer, ByVal high As Integer)

        Dim l1 As Integer = 0
        Dim l2 As Integer = 0
        Dim i As Integer = 0
        Dim b As Integer() = New Integer(4) {}

        l1 = low
        l2 = mid + 1
        i = low

        While (l1 <= mid AndAlso l2 <= high)
            If (a(l1) <= a(l2)) Then
                b(i) = a(l1)
                l1 = l1 + 1
            Else
                b(i) = a(l2)
                l2 = l2 + 1
            End If
            i = i + 1
        End While

        While (l1 <= mid)
            b(i) = a(l1)
            i = i + 1
            l1 = l1 + 1
        End While

        While (l2 <= high)
            b(i) = a(l2)
            i = i + 1
            l2 = l2 + 1
        End While

        For i = low To high Step 1
            a(i) = b(i)
        Next

    End Sub

    Sub sort(ByVal a() As Integer, ByVal low As Integer, ByVal high As Integer)
        Dim mid As Integer = 0

        If (low < high) Then
            mid = (low + high) \ 2
            sort(a, low, mid)
            sort(a, mid + 1, high)
            merging(a, low, mid, high)
        Else
            GoTo out
        End If
out:
        Console.Write("")
    End Sub
    Function Main(ByVal arr() As Integer)



        sort(arr, 0, 4)
        Return arr
    End Function
End Module