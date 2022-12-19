Namespace PartTwo
    Module ModulePartTwo
        Sub InitEmployee()

            'create object employee with encapsulation
            Dim emp1 As New Employee(1, "Ericson", "Wen", DateTime.Now, 5_000)

            Console.WriteLine(emp1.ToString())

            emp1.FirstName = "Code"
            emp1.BasicSalary = 6_000
            Console.WriteLine(emp1.ToString())

            Dim emp2 As New Employee("Bootcamp", "Id", DateTime.Now, 10_000)
            Console.WriteLine(emp2.ToString())

            'create object programmer
            Dim emp3 As New Programmer("Code", "ID", DateAndTime.Now, 15_000, 1_000)
            Console.WriteLine(emp3.ToString())

            emp3.BasicSalary = 20_000
            emp3.Transportasi = 2_000
            Console.WriteLine(emp3.ToString())
        End Sub
    End Module
End Namespace
