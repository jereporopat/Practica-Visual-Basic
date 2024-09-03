Imports System

'Cargar en un vector los nombres de 5 países y en otro vector paralelo la cantidad de habitantes del mismo. 
'Ordenar alfabéticamente e imprimir los resultados. Por último ordenar con respecto a la cantidad de habitantes (de mayor a menor) e imprimir nuevamente.
Module program
    Public Class datos
        Private vectorpaises(4) As String
        Private vectorhabitantes(4) As Integer
        Private vectorpaisesporhab(4) As String
        Private auxpaises As String
        Private auxhab As Integer

        Public Sub cargar()
            Dim f As Integer
            For f = 0 To vectorpaises.GetUpperBound(0)
                Console.WriteLine("ingrese nombre de pais: ")
                vectorpaises(f) = Console.ReadLine()
                Console.WriteLine("ingrese la cantidad de habitantes: ")
                vectorhabitantes(f) = Console.ReadLine()
            Next
        End Sub

        Public Sub ordenar()
            Dim f, k As Integer

            For f = 0 To vectorhabitantes.GetUpperBound(0) - 1
                For k = 0 To vectorhabitantes.GetUpperBound(0) - 1 - f
                    If vectorhabitantes(k) > vectorhabitantes(k + 1) Then
                        auxhab = vectorhabitantes(k)
                        auxpaises = vectorpaises(k)
                        vectorhabitantes(k) = vectorhabitantes(k + 1)
                        vectorpaises(k) = vectorpaises(k + 1)
                        vectorhabitantes(k + 1) = auxhab
                        vectorpaises(k + 1) = auxpaises
                    End If
                Next
            Next

            For f = 0 To vectorhabitantes.GetUpperBound(0)
                vectorpaisesporhab(f) = vectorpaises(f)
            Next

            For f = 0 To vectorpaises.GetUpperBound(0) - 1
                For k = 0 To vectorpaises.GetUpperBound(0) - 1 - f
                    If vectorpaises(k) > vectorpaises(k + 1) Then
                        auxpaises = vectorpaises(k)
                        vectorpaises(k) = vectorpaises(k + 1)
                        vectorpaises(k + 1) = auxpaises
                    End If
                Next
            Next

        End Sub

        Public Sub imprimir()
            Dim f As Integer
            Console.WriteLine("la lista de paises ordenada alfabeticamente es: ")
            For f = 0 To vectorpaises.GetUpperBound(0)
                Console.WriteLine(vectorpaises(f))
            Next
            Console.WriteLine("la lista de paises ordenada por habitantes es: ")
            For f = 0 To vectorhabitantes.GetUpperBound(0)
                Console.WriteLine(vectorpaisesporhab(f))
            Next
        End Sub

    End Class
    Sub main()
        Dim paises As New datos()
        paises.cargar()
        paises.ordenar()
        paises.imprimir()
    End Sub
End Module