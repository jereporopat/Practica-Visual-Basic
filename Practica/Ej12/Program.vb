Imports System

'Implementar la clase Operacion. Se deben cargar dos valores enteros, calcular su suma, resta, multiplicación y división, cada una en un método, imprimir dichos resultados.
Module Program
    Public Class operacion
        Private numero1 As Integer
        Private numero2 As Integer
        Private sumaNum As Integer
        Private restaNum As Integer
        Private multi As Integer
        Private div As Single


        Public Sub carga()
            Console.WriteLine("Ingrese numero 1: ")
            numero1 = Console.ReadLine()
            Console.WriteLine("Ingrese numero 2: ")
            numero2 = Console.ReadLine()
        End Sub

        Public Sub suma()
            sumaNum = numero1 + numero2
            Console.WriteLine("La suma es de: " & sumaNum)
        End Sub
        Public Sub resta()
            restaNum = numero1 - numero2
            Console.WriteLine("La resta es de: " & restaNum)
        End Sub
        Public Sub multiplicacion()
            multi = numero1 * numero2
            Console.WriteLine("La multiplicacion es de: " & multi)
        End Sub
        Public Sub division()
            div = numero1 / numero2
            Console.WriteLine("La division es de: " & div)
        End Sub
    End Class
    Sub Main()
        Dim opera As New operacion()
        opera.carga()
        opera.suma()
        opera.resta()
        opera.multiplicacion()
        opera.division()
    End Sub
End Module