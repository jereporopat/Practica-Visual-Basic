Imports System

'Confeccionar una clase que represente un empleado. Definir como atributos su nombre y su sueldo.
'Confeccionar los métodos para la carga, otro para imprimir sus datos y por último uno que imprima un mensaje si debe pagar impuestos (si el sueldo supera a 3000)
Module Program
    Public Class empleado
        Private nombre As String
        Private sueldo As Integer

        Public Sub carga()
            Console.WriteLine("Ingrese nombre: ")
            nombre = Console.ReadLine()
            Console.WriteLine("Ingrese sueldo: ")
            sueldo = Console.ReadLine()
        End Sub

        Public Sub imprimir()
            Console.WriteLine("------------------------------")
            Console.WriteLine("El nombre es: " & nombre)
            Console.WriteLine("El sueldo es de: " & sueldo)
            Console.WriteLine("------------------------------")
        End Sub

        Public Sub impuestos()
            If sueldo > 3000 Then
                Console.WriteLine("Usted debe pagar impuestos")
            End If
        End Sub
    End Class
    Sub Main()
        Dim empleado As New empleado()
        empleado.carga()
        empleado.imprimir()
        empleado.impuestos()
    End Sub
End Module