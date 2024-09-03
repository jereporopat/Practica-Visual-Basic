Imports System


'En una empresa de 4 empleados se necesita realizar las siguientes operatorias
'a) Ingresar los nombres de los empleados con sus respectivos sueldos.
'b) Imprimir los nombres de empleados que cobran menos de $2500
'c) Indicar cuántos cobran más de $3500.
'e) Imprimir el importe total que debe tener la empresa para abonar el sueldo a sus empleados.
Module Program
    Public Class empleados
        Private nombre(3) As String
        Private sueldo(3) As Integer
        Public Sub Cargar()
            Dim f As Integer
            For f = 0 To nombre.GetUpperBound(0)
                Console.WriteLine("Ingrese nombre de empleados: ")
                nombre(f) = Console.ReadLine()
                Console.WriteLine("Ingrese sueldo de empleado: ")
                sueldo(f) = Console.ReadLine()
            Next
        End Sub
        Public Sub Calculos()
            Dim f As Integer
            Dim total As Integer
            Console.WriteLine("Los empleados que cobran menos de 2500 son: ")
            For f = 0 To nombre.GetUpperBound(0)
                If sueldo(f) < 2500 Then
                    Console.WriteLine(nombre(f))
                End If
            Next
            Console.WriteLine("Los empleados que cobran mas de 3500 son: ")
            For f = 0 To nombre.GetUpperBound(0)
                If sueldo(f) > 3500 Then
                    Console.WriteLine(nombre(f))
                End If
            Next
            For f = 0 To nombre.GetUpperBound(0)
                total += sueldo(f)
            Next
            Console.WriteLine("La suma total para abonar es de: " & total)
        End Sub
        Public Sub Imprimir()
            Dim f As Integer
            Console.WriteLine("LISTA DE EMPLEADOS")
            Console.WriteLine("----------------------------------------")
            For f = 0 To nombre.GetUpperBound(0)
                Console.WriteLine("NOMBRE: " & nombre(f))
                Console.WriteLine("SUELDO: " & sueldo(f))
                Console.WriteLine("----------------------------------------")
            Next
        End Sub
    End Class
    Sub Main()
        Dim empleado As New empleados()
        empleado.Cargar()
        empleado.Calculos()
        empleado.Imprimir()
    End Sub
End Module

