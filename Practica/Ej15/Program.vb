Imports System

'Definir un vector de 5 componentes de tipo Single que representen las alturas de 5 personas.
'Obtener el promedio de las mismas. Contar cuántas personas son más altas que el promedio y cuántas más bajas.
Module Program
    Public Class alturas
        Private alturasVector(4) As Single
        Private prom As Single
        Public Sub Cargar()
            Dim f As Integer
            For f = 0 To 4
                Console.WriteLine("Ingrese altura de la persona: ")
                alturasVector(f) = Console.ReadLine()
            Next
        End Sub
        Public Sub Promedio()
            Dim f As Integer
            Dim suma As Integer
            For f = 0 To 4
                suma = alturasVector(f) + suma
            Next
            prom = suma / 5
            Console.WriteLine("El promedio de alturas es de: " & prom)
        End Sub
        Public Sub PersonasAltas()
            Dim contAl, contMen As Integer
            contAl = 0
            contMen = 0
            Dim f As Integer
            For f = 0 To 4
                If alturasVector(f) > prom Then
                    contAl += 1
                Else
                    contMen += 1
                End If
            Next
            Console.WriteLine("Cantidad de personas mas altas que el promedio: " & contAl)
            Console.WriteLine("Cantidad de personas mas bajas que el promedio: " & contMen)

        End Sub
    End Class
    Sub Main()
        Dim altura As New alturas()
        altura.Cargar()
        altura.Promedio()
        altura.PersonasAltas()
    End Sub
End Module
