Module ModuleDecision
    Sub OddEvenNumber()
        Dim num As Integer
        Console.Write("Enter a number : ")
        num = Console.ReadLine()
        If num Mod 2 = 0 Then
            Console.WriteLine("Even Number")
        Else
            Console.WriteLine("Odd Number")
        End If
    End Sub

    'Multiple if
    Sub Grade()
        Dim grade As Integer
        Dim tryAgain As Char
A:
        Console.Write("Enter a number : ")
        grade = Console.ReadLine()

        If grade < 50 Then
            Console.WriteLine("E")
        ElseIf (grade >= 50) And (grade <= 60) Then
            Console.WriteLine("D")
        Else
            Console.WriteLine("Pass")
        End If

        Console.WriteLine("Try Again?(Y/N)")
        tryAgain = Console.ReadLine()

        If tryAgain = "Y" Then
            GoTo A
        End If

    End Sub

    Sub GradeCase()
        Dim grade As Integer
        Console.Write("Enter a number : ")
        grade = Console.ReadLine()
        Select Case grade
            Case < 50
                Console.WriteLine("E")
            Case 50 To 60 'pakai To untuk case || 50 dan 60 termasuk ke dalam case
                Console.WriteLine("D")
            Case 61 To 70
                Console.WriteLine("C")
            Case Else
                Console.WriteLine("Pass")
        End Select
    End Sub

    Sub WhoIsTheGreatest()
        Dim num As Integer
        Dim rand As New Random()
        Console.Write("Enter value between (1 - 10) : ")
        num = Console.ReadLine()

        If (num > 10) Or (num <= 0) Then
            Console.WriteLine("Out Of range")
        Else
            Dim guess As Integer = rand.NextInt64(1, 11) 'max value tidak include
            Console.WriteLine("Your Input : " & num & vbCrLf & "Computer : " & guess)

            If (num < guess) Then
                Console.WriteLine("You Lose")
            ElseIf (num = guess) Then
                Console.WriteLine("It is a draw")
            Else
                Console.WriteLine("You Win")
            End If
        End If
    End Sub
End Module
