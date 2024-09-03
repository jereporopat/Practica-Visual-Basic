Imports System

'Cargar un vector de n elementos (n se carga por teclado). imprimir el menor y un mensaje si se repite dentro del vector.
Module Program
    Public Class numeros
        Private vector() As Integer
        Private menor As Integer
        Private repite As Integer

        Public Sub Cargar()
            Dim tam As Integer
            Dim f As Integer

            Console.WriteLine("Cuantos numeros desea cargar?: ")
            tam = Console.ReadLine()
            ReDim vector(tam - 1)
            For f = 0 To vector.GetUpperBound(0)
                Console.WriteLine("Ingrese numero: ")
                vector(f) = Console.ReadLine()
            Next
        End Sub
        Public Sub Calcular()
            menor = vector(0)
            Dim f As Integer
            For f = 0 To vector.GetUpperBound(0)
                If vector(f) < menor Then
                    menor = vector(f)
                End If
            Next
            Console.WriteLine("El menor numero es: " & menor)
        End Sub
        Public Sub Repetido()
            repite = vector(0)
            Dim f As Integer
            For f = 0 To vector.GetUpperBound(0)
                If vector(f) = repite Then
                    Console.WriteLine("El numero se repite en el vector")
                End If
            Next
        End Sub
    End Class
    Sub Main()
        Dim num As New numeros()
        num.Cargar()
        num.Calcular()
        num.Repetido()
    End Sub
End Module