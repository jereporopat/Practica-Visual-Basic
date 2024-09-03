Imports System

'De un operario se conoce su sueldo y los años de antigüedad. Se pide confeccionar un programa que lea los datos de entrada e informe
'a) Si el sueldo es inferior a 500 y su antigüedad es igual o superior a 10 años, otorgarle un aumento del 20 %, mostrar el sueldo a pagar.
'b)Si el sueldo es inferior a 500 pero su antigüedad es menor a 10 años, otorgarle un aumento de 5 %.
'c) Si el sueldo es mayor o igual a 500 mostrar el sueldo en pantalla sin cambios.
Module Program
    Sub Main()
        Dim sueldo, añosAntiguedad As Integer
        Dim aumento, sueldoTotal As Single

        Console.WriteLine("Ingrese sueldo: ")
        sueldo = Console.ReadLine()
        Console.WriteLine("Ingrese años de antiguedad: ")
        añosAntiguedad = Console.ReadLine()

        If sueldo < 500 And añosAntiguedad >= 10 Then
            aumento = sueldo * 0.2
            sueldoTotal = sueldo + aumento
        End If
        If sueldo < 500 And añosAntiguedad < 10 Then
            aumento = sueldo * 0.05
            sueldoTotal = sueldo + aumento
        End If
        If sueldo >= 500 Then
            sueldoTotal = sueldo
        End If
        Console.WriteLine("Sueldo a pagar: ")
        Console.WriteLine(sueldoTotal)
    End Sub
End Module