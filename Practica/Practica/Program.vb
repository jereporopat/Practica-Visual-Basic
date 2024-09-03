Imports System

'Realizar un programa que pida cargar una fecha cualquiera, luego verificar si dicha fecha corresponde a Navidad.
Module Program
    Sub Main()
        Dim dia, mes, año As Integer

        Console.WriteLine("Ingrese dia: ")
        dia = Console.ReadLine()
        Console.WriteLine("Ingrese mes: ")
        mes = Console.ReadLine()
        Console.WriteLine("Ingrese año: ")
        año = Console.ReadLine()

        If dia = 25 And mes = 12 And año <> 0 Then
            Console.Write("Es navidad")
        End If
    End Sub
End Module