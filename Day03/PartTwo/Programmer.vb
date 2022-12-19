Namespace PartTwo
    Public Class Programmer
        'melakukan inheritance dari parent : employee
        Inherits Employee

        Private _transportasi As Double

        Public Overrides Function ToString() As String
            Return $"{MyBase.ToString()}, tjTransportasi : {Transportasi}, totalSalary : {MyBase.TotalSalary}"
        End Function
        'mybase mengacu pada overrides pada class parent

        'untuk memunculkan construktor, pergi ke public class programmer
        'arahkan cursor ke sebelum huruf p pada programmmer
        'tekan ctrl+ . (dot) lalu pilih constructor dari parent
        '_transportasi = transportas didapatkan dari
        'mengarahkan cursor ke bagian paling belakang dari private _transportasi as double
        'ctrl + . (dot) dan pilih yang add optional parameter
        Public Sub New(firstName As String, lastName As String, joinDate As Date,
                       basicSalary As Double, Optional transportasi As Double = Nothing)
            MyBase.New(firstName, lastName, joinDate, basicSalary)
            _transportasi = transportasi
            MyBase.TotalSalary = MyBase.TotalSalary + _transportasi
        End Sub

        Public Property Transportasi As Double
            Get
                Return _transportasi
            End Get
            Set(value As Double)
                _transportasi = value
                MyBase.TotalSalary = value + MyBase.BasicSalary
            End Set
        End Property

        'override BasicSalary dari parent
        Public Overrides Property BasicSalary As Double
            Get
                Return MyBase.BasicSalary
            End Get
            Set(value As Double)
                MyBase.BasicSalary = value
                MyBase.TotalSalary = value + _transportasi
            End Set
        End Property

        Public Sub NaikGaji()
            UpSalary(1_000, "Discount")
            UpSalary(2_000, 5, 1)
        End Sub

    End Class

End Namespace

