Imports System

'Confeccionar una clase Persona que tenga como atributos el nombre y la edad (definir las propiedades para poder acceder a dichos atributos).
'Definir como responsabilidad un método para imprimir.
'Plantear una segunda clase Empleado que herede de la clase Persona. Añadir un atributo sueldo ( y su propiedad) y el método para imprimir su sueldo.
'Definir un objeto de la clase Persona y llamar a sus métodos y propiedades. 
'También crear un objeto de la clase Empleado y llamar a sus métodos y propiedades.
Module Program
    Public Class Persona
        Protected _nombre As String
        Protected _edad As Integer

        Public Property Nombre() As String
            Get
                Return _nombre
            End Get
            Set(ByVal value As String)
                _nombre = value
            End Set
        End Property

        Public Property Edad() As Integer
            Get
                Return _edad
            End Get
            Set(ByVal value As Integer)
                _edad = value
            End Set
        End Property
        Public Sub Imprimir()
            Console.WriteLine("El nombre del empleado es: " & Nombre & " y su edad es de: " & Edad)
        End Sub
    End Class
    Public Class Empleado
        Inherits Persona
        Private _sueldo As Single
        Public Property Sueldo() As Single
            Get
                Return _sueldo
            End Get
            Set(ByVal value As Single)
                _sueldo = value
            End Set
        End Property
        Public Overloads Sub Imprimir()
            MyBase.Imprimir()
            Console.WriteLine("Su sueldo es de: " & Sueldo)
        End Sub
    End Class


    Sub Main()
        Dim pj1 As New Persona()
        pj1.Nombre = "Juan"
        pj1.Edad = 25
        pj1.Imprimir()

        Dim pj2 As New Empleado()
        pj2.Nombre = "Jere"
        pj2.Edad = 24
        pj2.Sueldo = 230000
        pj2.Imprimir()
    End Sub
End Module
