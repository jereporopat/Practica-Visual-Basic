Imports System

'Escribir un programa que solicite ingresar 10 notas de alumnos y nos informe cuántos tienen notas mayores o iguales a 7 y cuántos menores.
Module Program
    Sub Main()
        Dim x, nota, notaAp, notaDp As Integer
        x = 1
        notaAp = 0
        notaDp = 0

        Do While x < 11
            Console.WriteLine("Ingrese nota: ")
            nota = Console.ReadLine()
            If nota < 7 Then
                notaDp = notaDp + 1
            End If
            If nota >= 7 Then
                notaAp = notaAp + 1
            End If
            x = x + 1
        Loop

        Console.WriteLine("La cant de alumnos aprobados es de: ")
        Console.WriteLine(notaAp)
        Console.WriteLine("La cant de alumnos desaprobados es de: ")
        Console.WriteLine(notaDp)
    End Sub
End Module