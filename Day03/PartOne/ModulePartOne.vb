Namespace Partone
    Module ModulePartOne
        Sub InitEmployee()

            'create object employee without encapsulation
            Dim emp1 As New Employee With {
                .empId = 1,
                .firstName = "Ericson",
                .lastName = "Wen",
                .joinDate = #12/12/2002 08:00:00 AM#,
                .basicSalary = 5_000_000
            }
            'display EmployeeInfo
            Console.WriteLine(emp1.ToString())

            emp1.basicSalary = 4_000_000
            Console.WriteLine(emp1.ToString())

        End Sub
    End Module
End Namespace
