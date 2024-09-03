Imports System

'Confeccionar una clase que permita ingresar tres valores por teclado. Luego mostrar el mayor y el menor.
Module Program
    Public Class Numeros
        Public Sub cargar()
            Dim num1, num2, num3, mayorNum, menorNum As Integer
            Console.WriteLine("Ingrese primer numero: ")
            num1 = Console.ReadLine()
            Console.WriteLine("Ingrese segundo numero: ")
            num2 = Console.ReadLine()
            Console.WriteLine("Ingrese tercer numero: ")
            num3 = Console.ReadLine()
            mayorNum = mayor(num1, num2, num3)
            menorNum = menor(num1, num2, num3)
            Console.WriteLine("El mayor numero es: " & mayorNum)
            Console.WriteLine("El menor numero es: " & menorNum)
        End Sub
        Public Function mayor(ByVal num1 As Integer, ByVal num2 As Integer, ByVal num3 As Integer)
            Dim m As Integer
            If num1 > num2 And num1 > num3 Then
                m = num1
            ElseIf num2 > num3 Then
                m = num2
            Else
                m = num3
            End If
            Return m
        End Function
        Public Function menor(ByVal num1 As Integer, ByVal num2 As Integer, ByVal num3 As Integer)
            Dim m As Integer
            If num1 < num2 And num1 < num3 Then
                m = num1
            ElseIf num2 < num3 Then
                m = num2
            Else
                m = num3
            End If
            Return m
        End Function
    End Class
    Sub Main()
        Dim numero As New Numeros()
        numero.cargar()
    End Sub
End Module