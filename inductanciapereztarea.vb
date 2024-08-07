Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("ingrese el valor de inductancia")
        Dim inductancia As Double = Console.ReadLine()
        Console.WriteLine("ingrese el valor de frecuencia")
        Dim frecuencia As Double = Console.ReadLine()
        Dim xl As Double
        Dim pi As Double = 3.1416
        xl = 2 * pi * frecuencia * inductancia
        Console.WriteLine("la reactancia xl es igual a:" & xl)



    End Sub
End Module
Imports Microsoft.VisualBasic

Public Class Class1

End Class
