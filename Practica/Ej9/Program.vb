Imports System

'Desarrollar un programa que solicite la carga de 10 números e imprima la suma de los últimos 5 valores ingresados.
Module program
    Sub main()
        Dim f, suma, valor As Integer
        suma = 0

        For f = 1 To 10
            Console.WriteLine("ingrese valor: ")
            valor = Console.ReadLine()
        Next
        For f = 5 To 10
            suma += valor
        Next
        Console.WriteLine("la suma de los ultimos 5 numeros ingresados es de: " & suma)
    End Sub
End Module