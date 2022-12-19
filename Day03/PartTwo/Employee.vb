Namespace PartTwo 'untuk grouping, meskipun nama class sama, jika nama group berbeda, dianggap berbeda
    Public Class Employee
        Private _empId As Integer
        Private _firstName As String
        Private _lastName As String
        Private _joinDate As DateTime
        Private _basicSalary As Double
        Private _totalSalary As Double
        Private _id As Integer = New Random().NextInt64(1, 10)

        'declare constructor
        'didapat dari ctrl + . (dot), lalu pilih constructor
        'memilih field
        'untuk membuat objek
        'menginisialisasi value pada saat pertama kali object dibuat
        Public Sub New(empId As Integer, firstName As String, lastName As String, joinDate As Date, basicSalary As Double)
            _empId = empId
            _firstName = firstName
            _lastName = lastName
            _joinDate = joinDate
            _basicSalary = basicSalary
            _totalSalary = basicSalary
        End Sub

        'default constructor
        'jika tidak terdapat data yang diinput
        Public Sub New()
        End Sub

        'overload constructor
        'tidak memerlukan semua field dipilih dan digunakan
        'empId tidak dipilih dalam pembuatan, tetapi dirandom didalam 
        'satu kelas bisa memilih lebih dari satu constructor
        Public Sub New(firstName As String, lastName As String, joinDate As Date,
                       basicSalary As Double)
            _empId = New Random().NextInt64(1, 10) '_id (sama aja)
            _firstName = firstName
            _lastName = lastName
            _joinDate = joinDate
            _basicSalary = basicSalary
            _totalSalary = basicSalary
        End Sub

        'penulisan overloads merupakan optional
        Public Overloads Sub UpSalary(up As Double, pph As Double, discount As Double)

        End Sub

        Public Overloads Sub UpSalary(up As Double, pph As String)

        End Sub

        'method untuk mengubah field
        'didapat dari block field, ctrl + . (dot), pilih encapsulate, field dan property sama
        'tidak bisa digunakan jika tidak terdapat objek
        'property bisa dipakai berulang kali digunakan
        Public Property EmpId As Integer
            Get
                Return _empId
            End Get
            Set(value As Integer)
                _empId = value
            End Set
        End Property

        Public Property FirstName As String
            Get
                Return _firstName
            End Get
            Set(value As String)
                _firstName = value
            End Set
        End Property

        Public Property LastName As String
            Get
                Return _lastName
            End Get
            Set(value As String)
                _lastName = value
            End Set
        End Property

        Public Property JoinDate As Date
            Get
                Return _joinDate
            End Get
            Set(value As Date)
                _joinDate = value
            End Set
        End Property

        'gunakan overridable agar bisa melakukan override property di child class
        Public Overridable Property BasicSalary As Double
            Get
                Return _basicSalary
            End Get
            Set(value As Double)
                _basicSalary = value
            End Set
        End Property

        Public Property TotalSalary As Double
            Get
                Return _totalSalary
            End Get
            Set(value As Double)
                _totalSalary = value
            End Set
        End Property

        'overrides
        'untuk membuat method yang bisa diinheritkan pada child class

        Public Overrides Function ToString() As String 'gunakan ctrl+ . (dot) untuk membuat override to string
            'gunakan $ (dollar) untuk menggantikan concat
            Return $"empId : {Me.EmpId}, firstName : {FirstName}, lastName : {LastName}, joinDate : {JoinDate}, basicSalary : {BasicSalary}"
        End Function 'Me. boleh dipakai seperti this.


    End Class
End Namespace

