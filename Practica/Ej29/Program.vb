Imports System

'Confeccionar una clase que represente un empleado. Definir como atributos su nombre y su sueldo.
'En el constructor cargar los atributos y luego en otro método imprimir sus datos y por último uno que imprima un mensaje 
'si debe pagar impuestos (si el sueldo supera a 3000)

Module Program
    Public Class Datos
        Private nombre As String
        Private sueldo As Integer

        Public Sub New()
            Console.WriteLine("Ingrese nombre: ")
            nombre = Console.ReadLine()
            Console.WriteLine("Ingrese sueldo: ")
            sueldo = Console.ReadLine()
        End Sub
        Public Sub Imprimir()
            Console.WriteLine("----------------------")
            Console.WriteLine("Nombre del empleado: " & nombre)
            Console.WriteLine("Sueldo: " & sueldo)
            If sueldo > 3000 Then
                Console.WriteLine("El empleado debe pagar impuestos")
            End If
            Console.WriteLine("----------------------")
        End Sub
    End Class
    Sub Main()
        Dim empleado As New Datos
        empleado.Imprimir()
    End Sub
End Module