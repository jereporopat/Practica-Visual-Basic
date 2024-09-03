Imports System

'Crear una matriz de 2 filas y 5 columnas. Realizar la carga de componentes por columna (es decir primero ingresar toda la primer columna, 
'luego la segunda columna y así sucesivamente)
'Imprimir luego la matriz.
Module Program
    Public Class matriz
        Private mat(4, 1) As Integer

        Public Sub Cargar()
            Dim f, c As Integer
            For c = 0 To 4
                For f = 0 To 1
                    Console.WriteLine("Ingrese componente: ")
                    mat(c, f) = Console.ReadLine()
                Next
            Next
        End Sub
        Public Sub Imprimir()
            Dim f, c As Integer
            For c = 0 To 4
                For f = 0 To 1
                    Console.WriteLine(mat(c, f) & " ")
                Next
                Console.WriteLine()
            Next
        End Sub
    End Class

    Sub Main()
        Dim objeto As New matriz()
        objeto.Cargar()
        objeto.Imprimir()

    End Sub
End Module