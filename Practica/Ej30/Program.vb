Imports System

'Plantear una clase Club y otra clase Socio.
'La clase Socio debe tener los siguientes atributos privados: nombre y la antigüedad en el club (en años). 
'En el constructor pedir la carga del nombre y su antigüedad. La clase Club debe tener como atributos 3 objetos de la clase Socio. 
'Definir una responsabilidad para imprimir el nombre del socio con mayor antigüedad en el club.
Module Program
    Public Class Socio
        Private nombre As String
        Private antiguedad As Integer
        Public Sub New()
            Console.WriteLine("Ingrese nombre: ")
            nombre = Console.ReadLine()
            Console.WriteLine("Ingrese antiguedad: ")
            antiguedad = Console.ReadLine()
        End Sub
        Public Function RetornarValor() As Integer
            Return antiguedad
        End Function
        Public Function RetornarAntiguedad() As String
            Return nombre
        End Function
    End Class
    Public Class Club
        Private cliente1, cliente2, cliente3 As Socio
        Public Sub New()
            cliente1 = New Socio()
            cliente2 = New Socio()
            cliente3 = New Socio()
        End Sub
        Public Sub Imprimir()
            If cliente1.RetornarValor() > cliente2.RetornarValor() And cliente1.RetornarValor() > cliente3.RetornarValor() Then
                Console.WriteLine("--------------------------------------------")
                Console.WriteLine("El cliente con mayor antiguedad en el clube es: " & cliente1.RetornarAntiguedad)
            ElseIf cliente2.RetornarValor > cliente3.RetornarValor Then
                Console.WriteLine("El cliente con mayor antiguedad en el clube es: " & cliente2.RetornarAntiguedad)
            Else
                Console.WriteLine("El cliente con mayor antiguedad en el clube es: " & cliente3.RetornarAntiguedad)
                Console.WriteLine("--------------------------------------------")
            End If
        End Sub
    End Class
    Sub Main()
        Dim pj = New Club()
        pj.Imprimir()
    End Sub
End Module