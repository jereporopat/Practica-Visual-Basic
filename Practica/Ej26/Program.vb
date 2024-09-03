Imports System

'Se tiene la siguiente información:
'· Nombres de 4 empleados.
'· Ingresos en concepto de sueldo, cobrado por cada empleado, en los últimos 3 meses.
'Confeccionar un programa para

'a) Realizar la carga de la información mencionada.
'b) Generar un vector que contenga el ingreso acumulado en sueldos en los últimos 3 meses para cada empleado.
'c) Mostrar por pantalla el total pagado en sueldos a todos los empleados en los últimos 3 meses
'd) Obtener el nombre del empleado que tuvo el mayor ingreso acumulado
Module Program
    Public Class datos
        Private vecEmpleados(3) As String
        Private matSueldos(3, 2) As Integer
        Private vecSueldosTotal(3) As Integer

        Public Sub Cargar()
            Dim f, c As Integer
            For f = 0 To vecEmpleados.GetUpperBound(0)
                Console.WriteLine("Ingrese nombre del empleado: ")
                vecEmpleados(f) = Console.ReadLine()
                For c = 0 To matSueldos.GetUpperBound(1)
                    Console.WriteLine("Ingrese sueldo del empleado: ")
                    matSueldos(f, c) = Console.ReadLine()
                Next
            Next
        End Sub
        Public Sub Suma()
            Dim f, c As Integer
            For f = 0 To matSueldos.GetUpperBound(0)
                Dim suma As Integer = 0
                For c = 0 To matSueldos.GetUpperBound(1)
                    suma = suma + matSueldos(f, c)
                Next
                vecSueldosTotal(f) = suma
            Next
        End Sub
        Public Sub Imprimir()
            Console.WriteLine("------------------------------------------")
            Console.WriteLine("Sueldo total por empleados: ")
            Dim f As Integer
            For f = 0 To vecSueldosTotal.GetUpperBound(0)
                Console.WriteLine(vecEmpleados(f) & "-" & vecSueldosTotal(f))
            Next
        End Sub
        Public Sub MayorSueldo()
            Dim may As Integer = vecSueldosTotal(0)
            Dim nom As String = vecEmpleados(0)
            Dim f As Integer
            For f = 0 To vecSueldosTotal.GetUpperBound(0)
                If vecSueldosTotal(f) > may Then
                    may = vecSueldosTotal(f)
                    nom = vecEmpleados(f)
                End If
            Next
            Console.WriteLine("El empleado con mayor sueldo es: " & nom & " y su sueldo es de: " & may)
            Console.WriteLine("------------------------------------------")
        End Sub
    End Class
    Sub Main()
        Dim empleado As New datos()
        empleado.Cargar()
        empleado.Suma()
        empleado.Imprimir()
        empleado.MayorSueldo()
    End Sub
End Module