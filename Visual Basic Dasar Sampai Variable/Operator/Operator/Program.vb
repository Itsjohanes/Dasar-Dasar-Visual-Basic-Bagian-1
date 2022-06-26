Imports System

Module Program
    Sub Main(args As String())
        Dim Tinggi, Berat, BMI As Single
        Dim teks1, teks2 As String
        Console.WriteLine("Masukan tinggi kamu")
        Tinggi = Console.ReadLine()
        Console.WriteLine("Masukan berat kamu")
        Berat = Console.ReadLine()
        BMI = (Berat) / (Tinggi ^ 2)
        teks1 = "Halo "
        teks2 = "Nilai BMI anda "
        Console.WriteLine(teks1 & teks2 & BMI)
        Console.ReadLine()




    End Sub
End Module
