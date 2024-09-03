Imports System


'Realizar un programa que permita cargar dos listas de 15 valores cada una. Informar con un mensaje cual de las dos listas tiene un valor acumulado mayor (mensajes "Lista 1 mayor", "Lista 2 mayor", "Listas iguales")
'Tener en cuenta que puede haber dos o más estructuras repetitivas en un algoritmo.
Module Program
    Sub Main()
        Dim acumulador1, acumulador2, suma1, suma2, x, y As Integer
        x = 0
        y = 0
        suma1 = 0
        suma2 = 0
        acumulador1 = 0
        acumulador2 = 0

        Do While x < 15
            Console.WriteLine("Ingrese valor para lista 1: ")
            acumulador1 = Console.ReadLine()
            suma1 = suma1 + acumulador1
            x = x + 1
        Loop

        Do While y < 15
            Console.WriteLine("Ingrese valor para lista 2: ")
            acumulador2 = Console.ReadLine()
            suma2 = suma2 + acumulador2
            y = y + 1
        Loop

        Console.WriteLine("La suma de los valores de la lista 1 es de: " & suma1)
        Console.WriteLine("La suma de los valores de la lista 2 es de: " & suma2)

        If suma1 = suma2 Then
            Console.WriteLine("Los valores de la lista son iguales")
        ElseIf suma1 > suma2 Then
            Console.WriteLine("La lista 1 es mayor a la lista 2")
        Else
            Console.WriteLine("La lista 2 es mayor a la lista 1")
        End If
    End Sub
End Module
