Module ModuleDateTime
    Sub ShowDate()
        'susunan tipe data date (bulan/tanggal/tahun), waktu, dan PM atau AM 
        'pakai # untuk penulisan variabel dengan tipe data date
        Dim date1 As Date = #12/15/2022 10:53:01 AM#
        Console.WriteLine("Date 1 : " & date1)

        Dim lusa As Date
        lusa = date1.AddDays(2)
        Console.WriteLine("Lusa : " & lusa)

        Dim currentDate As Date
        currentDate = Date.Now
        Console.WriteLine("Current Date : " & currentDate)

        'untuk mengekstrak tanggal, bulan, dan tahun
        Dim tanggal, bulan, tahun As Integer
        tanggal = Day(currentDate)
        bulan = Month(currentDate)
        tahun = Year(currentDate)
        Console.WriteLine("Tanggal : " & tanggal)
        Console.WriteLine("Bulan : " & bulan)
        Console.WriteLine("Tahun : " & tahun)
    End Sub
End Module
