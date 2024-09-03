Imports System

'Cargar un vector de n elementos de tipo entero (n se ingresa por teclado)
'Ordenar posteriormente el vector e imprimirlo
Module program
    Public Class Elementos
        Private vector() As Integer
        Private num As Integer
        Private aux As Integer
        Private tam As Integer

        Public Sub Cargar()
            Console.WriteLine("Ingrese cantidad de mumeros a cargar: ")
            tam = Console.ReadLine()
            ReDim vector(tam - 1)
            Dim f As Integer
            For f = 0 To vector.GetUpperBound(0)
                Console.WriteLine("Ingrese numero: ")
                vector(f) = Console.ReadLine()
            Next
        End Sub
        Public Sub Ordenar()
            Dim aux, f, k As Integer
            For f = 0 To vector.GetUpperBound(0) - 1
                For k = 0 To vector.GetUpperBound(0) - 1 - f
                    If vector(k) > vector(k + 1) Then
                        aux = vector(k)
                        vector(k) = vector(k + 1)
                        vector(k + 1) = aux
                    End If
                Next
            Next
        End Sub
        Public Sub Imprimir()
            Dim f As Integer
            Console.WriteLine("La lista de vectores ordenada es: ")
            For f = 0 To vector.GetUpperBound(0)
                Console.WriteLine(vector(f))
            Next
        End Sub
    End Class
    Sub main()
        Dim num As New Elementos()
        num.Cargar()
        num.Ordenar()
        num.Imprimir()

    End Sub
End Module