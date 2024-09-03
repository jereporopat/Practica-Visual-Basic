Imports System

'Confeccionar una clase para administrar una matriz irregular de 5 filas y 1 columna la primer fila, 2 columnas la segunda fila
'y así sucesivamente hasta 5 columnas la última fila (crearla sin la intervención del operador)
'Realizar la carga por teclado e imprimir posteriormente.
Module Program
    Public Class datos
        Private matIr()() As Integer
        Public Sub Cargar()
            matIr = New Integer(4)() {}
            Dim f, c As Integer
            For f = 0 To matIr.GetUpperBound(0)
                matIr(f) = New Integer(f) {}
                For c = 0 To matIr(f).GetUpperBound(0)
                    Console.WriteLine("Ingrese componente: ")
                    matIr(f)(c) = Console.ReadLine()
                Next
            Next
        End Sub
        Public Sub Imprimir()
            Dim f, c As New Integer
            For f = 0 To matIr.GetUpperBound(0)
                For c = 0 To matIr(f).GetUpperBound(0)
                    Console.WriteLine(matIr(f)(c) & " ")
                Next
                Console.WriteLine()
            Next
        End Sub
    End Class
    Sub Main()
        Dim elemento As New datos
        elemento.Cargar()
        elemento.Imprimir()
    End Sub
End Module