Imports System


'Confeccionaremos un programa que permita crear una matriz irregular y luego imprimir la matriz en forma completa.
Module Program
    Public Class datos
        Private mat()() As Integer
        Public Sub Cargar()
            Dim filas, f, c As Integer
            Console.WriteLine("Cuantas filas tiene la matriz?: ")
            filas = Console.ReadLine()
            mat = New Integer(filas - 1)() {}
            For f = 0 To mat.GetUpperBound(0)
                Console.WriteLine("Cuantos elementos tiene la fila " & f & ": ")
                Dim elemento As Integer = Console.ReadLine()
                mat(f) = New Integer(elemento - 1) {}
                For c = 0 To mat(f).GetUpperBound(0)
                    Console.WriteLine("Ingrese componente: ")
                    mat(f)(c) = Console.ReadLine()
                Next
            Next
        End Sub
        Public Sub Imprimir()
            Dim f, c As Integer
            For f = 0 To mat.GetUpperBound(0)
                For c = 0 To mat(f).GetUpperBound(0)
                    Console.WriteLine(mat(f)(c) & " ")
                Next
                Console.WriteLine()
            Next
            Console.ReadKey()
        End Sub

    End Class
    Sub Main()
        Dim numero As New datos
        numero.Cargar()
        numero.Imprimir()
    End Sub
End Module