Imports System

'Definir dos vectores paralelos de 5 elementos, en uno se almacenan los nombres de productos y en el otro sus precios.
'Permitir ingresar un valor y mostrar todos los nombres de productos que tienen un precio menor al valor ingresado.
Module Program
    Public Class elementos
        Private nombres(4) As String
        Private precios(4) As Integer
        Private minimo As Integer

        Public Sub Carga()
            Dim f As Integer

            Console.WriteLine("Ingrese valor minimo: ")
            minimo = Console.ReadLine()
            For f = 0 To nombres.GetUpperBound(0)
                Console.WriteLine("Ingrese nombre: ")
                nombres(f) = Console.ReadLine()
                Console.WriteLine("Ingrese precios: ")
                precios(f) = Console.ReadLine()
            Next
        End Sub
        Public Sub calcular()
            For f = 0 To precios.GetUpperBound(0)
                If precios(f) < minimo Then
                    Console.WriteLine(nombres(f))
                End If
            Next
        End Sub

    End Class
    Sub Main()
        Dim elemento As New elementos
        elemento.Carga()
        elemento.calcular()
    End Sub
End Module