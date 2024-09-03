Imports System

'Se desea guardar los sueldos de 5 operarios.
Module Program
    Public Class sueldoVector
        Private sueldos(4) As Integer
        Public Sub Cargar()
            Dim f As Integer
            For f = 0 To 4
                Console.WriteLine("Ingrese sueldo: ")
                sueldos(f) = Console.ReadLine()
            Next
        End Sub
        Public Sub Imprimir()
            Dim f As Integer
            For f = 0 To 4
                Console.WriteLine("Los sueldos son: " & sueldos(f))
            Next
        End Sub
    End Class
    Sub Main()
        Dim sueldo As New sueldoVector()
        sueldo.Cargar()
        sueldo.Imprimir()
    End Sub
End Module
