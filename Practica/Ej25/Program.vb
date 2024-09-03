Imports System

'Crear una matriz de n * m filas (cargar n y m por teclado) Intercambiar la primer fila con la segundo. Imprimir luego la matriz.
Module Program
    Public Class datos
        Private matriz(,) As Integer

        Public Sub Cargar()
            Dim filas, columnas As Integer
            Console.WriteLine("Cuantas filas desea cargar?: ")
            filas = Console.ReadLine()
            Console.WriteLine("Cuantas columnas desea cargar?: ")
            columnas = Console.ReadLine()
            ReDim matriz(filas - 1, columnas - 1)
            Dim f, c As Integer
            For f = 0 To matriz.GetUpperBound(0)
                For c = 0 To matriz.GetUpperBound(1)
                    Console.WriteLine("Ingrese elemento: ")
                    matriz(f, c) = Console.ReadLine()
                Next
            Next
        End Sub
        Public Sub Intercambio()
            Dim c As Integer
            For c = 0 To matriz.GetUpperBound(0)
                Dim aux As Integer = matriz(0, c)
                matriz(0, c) = matriz(1, c)
                matriz(1, c) = aux
            Next
        End Sub
        Public Sub Imprimir()
            Dim f, c As Integer
            For f = 0 To matriz.GetUpperBound(0)
                For c = 0 To matriz.GetUpperBound(0)
                    Console.WriteLine(matriz(f, c) & " ")
                Next
                Console.WriteLine()
            Next
        End Sub
    End Class
    Sub Main()
        Dim ma As New datos()
        ma.Cargar()
        ma.Intercambio()
        ma.Imprimir()
    End Sub
End Module
