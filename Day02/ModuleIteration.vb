Module ModuleIteration
    'do while
    Sub DoWhile(n As Integer)
        Dim i As Integer = 1
        Do While i <= n
            Console.WriteLine("I = " & i)
            i += 1
        Loop
    End Sub

    Sub DoWhileExit(n As Integer)
        Dim i As Integer = 1
        Do While i <= n
            Console.WriteLine("I = " & i)
            If (i = 8) Then
                Exit Do
            Else
                i += 1
            End If
        Loop
    End Sub

    Sub ForLoop(n As Integer)
        For index = 1 To n
            Console.Write("* ")
        Next
    End Sub

    Sub KotakBintang(panjang As Integer, lebar As Integer)
        For x = 1 To lebar
            For y = 1 To panjang
                If (x = 1) Or (x = lebar) Then
                    If y = panjang Then
                        Console.WriteLine("*")
                    Else
                        Console.Write("* ")
                    End If
                Else
                    If y = 1 Then
                        Console.Write("* ")
                    ElseIf (y = panjang) Then
                        Console.WriteLine("*")
                    Else
                        Console.Write("  ")
                    End If
                End If
            Next
        Next
    End Sub

    Sub WhileDo()
        Dim i As Integer = 1

    End Sub
End Module
