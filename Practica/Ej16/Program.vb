Imports System


'Se tienen las notas del primer parcial de los alumnos de dos cursos, el curso A y el curso B, 
'cada curso cuenta con 5 alumnos.
'Realizar un programa que muestre el curso que obtuvo el mayor promedio general
Module Program
    Public Class alumnos
        Private alumnosA(4) As Single
        Private alumnosB(4) As Single
        Private sumaA As Integer
        Private sumaB As Integer
        Private promA As Single
        Private promB As Single

        Public Sub cargar()
            sumaA = 0
            sumaB = 0
            Dim f As Integer
            For f = 0 To 4
                Console.WriteLine("Ingrese la nota de los alumnos del curso A: ")
                alumnosA(f) = Console.ReadLine()
                sumaA = sumaA + alumnosA(f)
            Next
            For f = 0 To 4
                Console.WriteLine("Ingrese la nota de los alumnos del curso B: ")
                alumnosB(f) = Console.ReadLine()
                sumaB = sumaB + alumnosB(f)
            Next
        End Sub
        Public Sub promedio()
            promA = sumaA / 5
            promB = sumaB / 5
            If promA > promB Then
                Console.WriteLine("El curso con mayor promedio es el curso A")
            Else
                Console.WriteLine("El curso con mayor promedio es el curso B")
            End If
        End Sub

    End Class
    Sub Main()
        Dim alumno As New alumnos()
        alumno.cargar()
        alumno.promedio()

    End Sub
End Module