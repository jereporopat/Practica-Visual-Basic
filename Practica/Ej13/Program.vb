Imports System


'Confeccionar una clase que permita ingresar tres valores por teclado. Luego mostrar el mayor y el menor.
Module Program
    Public Class numero
        Public Function carga()
            Dim valor1, valor2 As Integer
            Console.WriteLine("Ingrese primer numero: ")
            valor1 = Console.ReadLine
            Console.WriteLine("Ingrese segundo numero: ")
            valor2 = Console.ReadLine
            Return (valor1, valor2)
        End Function
        Public Sub mayor(ByVal n1 As Integer, ByVal n2 As Integer)
            If n1 > n2 Then
                Console.WriteLine("El numero mas alto es: " & n1)
                Console.WriteLine("El numero mas bajo es de " & n2)
            Else
                Console.WriteLine("El numero mas alto es el de: " & n2)
                Console.WriteLine("El numero mas bajo es de: " & n1)
            End If
        End Sub
    End Class

    Sub Main()
        Dim numeros As New numero()
        Dim valores = numeros.carga()
        numeros.mayor(valores.Item1, valores.Item2)
    End Sub
End Module