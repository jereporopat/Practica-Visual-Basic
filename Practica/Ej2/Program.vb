Imports System

'Se ingresan por teclado tres números, si al menos uno de los valores ingresados es menor a 10, imprimir en pantalla la leyenda "Alguno de los números es menor a diez".
Module Program
    Sub Main()
        Dim num1, num2, num3 As Integer

        Console.WriteLine("Ingrese primer numero: ")
        num1 = Console.ReadLine()
        Console.WriteLine("Ingrese segundo numero: ")
        num2 = Console.ReadLine()
        Console.WriteLine("Ingrese tercer numero: ")
        num3 = Console.ReadLine()

        If num1 Or num2 Or num3 < 10 Then
            Console.WriteLine("Alguno de los números es menor a diez")
        End If
    End Sub
End Module
