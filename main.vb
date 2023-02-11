Imports System.IO
Module HelloWorld
	Sub Main()
    Console.WriteLine("Program Membaca File Teks")
    Console.WriteLine("=========================")

    'Membaca file teks
    Dim filePath As String = "hi.txt"
    If File.Exists(filePath) Then
        Console.WriteLine("File ditemukan.")
        Console.WriteLine("Isi file:")
        Dim lines() As String = File.ReadAllLines(filePath)
        For i As Integer = 0 To lines.Length - 1
            Console.WriteLine("Baris " & (i + 1) & ": " & lines(i))
            'Menggunakan percabangan untuk menentukan jenis baris
            Select Case lines(i)
                Case "Hello"
                    Console.WriteLine("Mengandung kata Hello")
                Case "World"
                    Console.WriteLine("Mengandung kata world")
                Case Else
                    Console.WriteLine("Mengandung kata lain")
            End Select
            'Menggunakan procedure untuk memproses baris
            ProsesBaris(lines(i))
        Next
    Else
        Console.WriteLine("File tidak ditemukan.")
    End If

    Console.ReadLine()
End Sub

Sub ProsesBaris(ByVal baris As String)
    'Menggunakan perulangan untuk memproses karakter pada baris
    For i As Integer = 0 To baris.Length - 1
        Console.WriteLine("Karakter " & (i + 1) & ": " & baris(i))
    Next
End Sub

End Module