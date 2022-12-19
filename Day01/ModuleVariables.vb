Module ModuleVariables
    'Declaration is a process reserve a portion in main memory for strong content variable
    'Primitive Data Trype : Boolean, Byte, Short, Integer, Long, Single, Double, Decimal & Char
    Sub StoreVariable()
        Dim number As Integer = 200
        Dim myName As String = "Bootcamp.NET"
        Console.WriteLine("Number : " & number & ", myName : " & myName)
        myName = "CodeId"
        Console.WriteLine("myName : " & myName)
    End Sub

    'store constant variable
    'Beda const dengan variable, variable masih bisa diganti tetapi const tidak bisa
    'jika mengganti nilai dari const, maka akan terjadi error
    Sub StoreConstant()
        Const PHI = 3.14159
        Console.WriteLine("Phi : " & PHI)
    End Sub

    'variable a, b, c
    'a adalah value1 dan b adalah value 2, sedangkan c adalah temporary variable
    Sub SwapTwoVariable()
        Dim a, b, c As Integer
        Console.Write("Value A : ")
        a = Console.ReadLine()

        Console.Write("Value B : ")
        b = Console.ReadLine()

        Console.WriteLine("Before : a = " & a & ", b = " & b)

        c = a
        a = b
        b = c

        Console.WriteLine("After : a = " & a & ", b = " & b)
    End Sub
End Module
