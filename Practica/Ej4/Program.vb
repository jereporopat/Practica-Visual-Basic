Imports System

'Escribir un programa en el cual: dada una lista de tres valores numéricos distintos se calcule e informe su rango de variación (debe mostrar el mayor y el menor de ellos)
Module Program
    Sub Main()
        Dim num1, num2, num3 As Integer

        Console.WriteLine("Ingrese primer numero: ")
        num1 = Console.ReadLine()
        Console.WriteLine("Ingrese segundo numero: ")
        num2 = Console.ReadLine()
        Console.WriteLine("Ingrese tercer numero: ")
        num3 = Console.ReadLine()

        Console.WriteLine("El mayor es: ")
        If num1 > num2 And num1 > num3 Then
            Console.WriteLine(num1)
        Else
            If num2 > num3 Then
                Console.WriteLine(num2)
            Else
                Console.WriteLine(num3)
            End If
        End If

        Console.WriteLine("El menor es: ")
        If num1 < num2 And num1 < num3 Then
            Console.WriteLine(num1)
        Else
            If num2 < num3 Then
                Console.WriteLine(num2)
            Else
                Console.WriteLine(num3)
            End If
        End If
    End Sub
End Module
