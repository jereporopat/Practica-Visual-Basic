Imports System

'Plantear una clase Club y otra clase Socio.
'La clase Socio debe tener los siguientes atributos privados: nombre y la antigüedad en el club (en años)
'Definir dos propiedades para poder acceder al nombre y la antigüedad del socio(no permitir cargar un valor negativo en la antigüedad).
'La clase Club debe tener como atributos 3 objetos de la clase Socio. Definir una responsabilidad para imprimir el nombre del socio con mayor antigüedad en el club.

Module Program
    Public Class Socio
        Private _nombre As String
        Private _antiguedad As Integer
        Public Property Nombre() As String
            Set(ByVal value As String)
                _nombre = value
            End Set
            Get
                Return _nombre
            End Get
        End Property
        Public Property Antiguedad() As Integer
            Set(ByVal value As Integer)
                If value >= 0 Then
                    _antiguedad = value
                Else
                    Console.WriteLine("No se puede ingresar un valor negativo")
                End If
            End Set
            Get
                Return _antiguedad
            End Get
        End Property
    End Class
    Public Class Club
        Private pj1, pj2, pj3 As Socio
        Public Sub New()
            pj1 = New Socio()
            pj1.Nombre = "Jere"
            pj1.Antiguedad = 20
            pj2 = New Socio()
            pj2.Nombre = "Juan"
            pj2.Antiguedad = 10
            pj3 = New Socio()
            pj3.Nombre = "Pepe"
            pj3.Antiguedad = 5
        End Sub
        Public Sub MayorAntiguedad()
            If pj1.Antiguedad > pj2.Antiguedad And pj1.Antiguedad > pj3.Antiguedad Then
                Console.WriteLine("El socio con mayor antiguedad es: " & pj1.Nombre)
            ElseIf pj2.Antiguedad > pj3.Antiguedad Then
                Console.WriteLine("El socio con mayor antiguedad es: " & pj2.Nombre)
            Else
                Console.WriteLine("El socio con mayor antiguedad es: " & pj3.Nombre)
            End If
        End Sub
    End Class
    Sub Main()
        Dim usuario As New Club()
        usuario.MayorAntiguedad()
    End Sub
End Module