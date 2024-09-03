Imports System

'Realizar un programa que acumule (sume) valores ingresados por teclado hasta ingresar el 9999 (no sumar dicho valor, indica que ha finalizado la carga). Imprimir el valor acumulado e informar si dicho valor es cero, mayor a cero o menor a cero
Module Program
    Sub Main()
        Dim suma, valor As Integer
        suma = 0

        Do
            Console.WriteLine("Ingrese valor: ")
            valor = Console.ReadLine()
            If valor = 9999 Then
                suma = suma - 9999
            End If
            suma = valor + suma
        Loop While valor <> 9999
        Console.WriteLine("El valor acumulado es de: " & suma)
        If suma > 0 Then
            Console.WriteLine("La suma es mayor a 0")
        Else
            Console.WriteLine("La suma es menor a 0")
        End If
    End Sub
End Module

