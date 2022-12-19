Namespace Partone 'untuk grouping, meskipun nama class sama, jika nama group berbeda, dianggap berbeda
    Public Class Employee
        Public empId As Integer
        Public firstName As String
        Public lastName As String
        Public joinDate As DateTime
        Public basicSalary As Double

        Public Overrides Function ToString() As String 'gunakan ctrl+ . (dot) untuk membuat override to string
            'gunakan $ (dollar) untuk menggantikan concat
            Return $"empId : {empId}, firstName : {firstName}, lastName : {lastName}, joinDate : {joinDate}, basicSalary : {basicSalary}"
        End Function
    End Class
End Namespace

'encapsulation
'setiap field yang ada dikelas hanya boleh diuabh oleh method 