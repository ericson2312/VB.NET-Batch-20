Imports System
Imports ConsoleApp1.Partone
Imports ConsoleApp1.PartTwo

Module Program
    Sub Main(args As String())
        'Console.WriteLine("Hello World!")
        'Dim n As Integer
        'Dim panjang, lebar As Integer
        'call method SayMyName
        'SayMyName()

        'call methon from ModuleVariables
        'ModuleVariables.StoreVariable()
        'ModuleVariables.SwapTwoVariable()
        'ModuleMath.OperationMath()
        'ModuleMath.BagiSisa()
        'ModuleDecision.OddEvenNumber()
        'ModuleDecision.Grade()
        'ModuleDecision.GradeCase()
        'ModuleDecision.WhoIsTheGreatest()
        'ModuleDateTime.ShowDate()
        'Console.Write("Enter n : ")
        'n = Console.ReadLine()
        'ModuleIteration.DoWhile(n)
        'ModuleIteration.DoWhileExit(n)
        'ModuleIteration.ForLoop(n)
        'Console.Write("Masukkan Panjang : ")
        'panjang = Console.ReadLine()
        'Console.Write("Masukkan Lebar : ")
        'lebar = Console.ReadLine()
        'ModuleIteration.KotakBintang(panjang, lebar)
        'ModulePartOne.InitEmployee()
        ModulePartTwo.InitEmployee()

    End Sub

    Sub SayMyName()
        'declaration variable
        Dim myName As String
        Console.Write("Enter your name : ")

        'ise readline 
        myName = Console.ReadLine()

        'display result with concat
        Console.WriteLine("Your name : " & myName)
    End Sub
End Module
