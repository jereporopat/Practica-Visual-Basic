Imports System

'Se realiza la carga de 10 valores enteros por teclado. Se desea conocer
'a) La cantidad de valores ingresados negativos.
'b) La cantidad de valores ingresados positivos.
'c) La cantidad de múltiplos de 15.
'd) El valor acumulado de los números ingresados que son pares.
Module Program
    Sub Main()
        Dim f, valor, contPos, contNeg, mult, acumPares As Integer
        contNeg = 0
        contPos = 0
        mult = 0
        acumPares = 0

        For f = 1 To 10
            Console.WriteLine("Ingrese valor: ")
            valor = Console.ReadLine()

            If valor < 0 Then
                contNeg += 1
            Else
                contPos += 1
            End If
            If valor Mod 15 = 0 Then
                mult += 1
            End If
            If valor Mod 2 = 0 Then
                acumPares = acumPares + valor
            End If
        Next
        Console.WriteLine("La cantidad de valores ingresados negativos es de: " & contNeg)
        Console.WriteLine("La cantidad de valores ingresados positivos es de: " & contPos)
        Console.WriteLine("la cantidad de multiplos de 15 es de: " & mult)
        Console.WriteLine("El valor acumulado de los numeros ingresados que son pares es de: " & acumPares)
    End Sub
End Module
