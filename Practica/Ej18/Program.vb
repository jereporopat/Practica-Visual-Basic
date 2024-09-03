Imports System

'Desarrollar un programa que permita ingresar un vector de n elementos, ingresar n por teclado.
'Luego imprimir la suma de todos sus elementos
Module Program
    Public Class elementos
        Private vector() As Integer
        Private suma As Integer

        Public Sub cargar()
            Dim tam As Integer
            Dim f As Integer

            Console.WriteLine("Cuantos elementos desea ingresar?: ")
            tam = Console.ReadLine()
            ReDim vector(tam - 1)
            For f = 0 To vector.GetUpperBound(0)
                Console.WriteLine("Ingrese numero: ")
                vector(f) = Console.ReadLine()
            Next
        End Sub
        Public Sub Calcular()
            For f = 0 To vector.GetUpperBound(0)
                suma += vector(f)
            Next
        End Sub
        Public Sub Imprimir()
            Console.WriteLine(suma)
        End Sub
    End Class
    Sub Main()
        Dim elemento As New elementos
        elemento.cargar()
        elemento.Calcular()
        elemento.Imprimir()
    End Sub
End Module
