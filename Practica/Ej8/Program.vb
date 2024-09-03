Imports System



'En un banco se procesan datos de las cuentas corrientes de sus clientes. De cada cuenta corriente se conoce: número de cuenta y saldo actual. El ingreso de datos debe finalizar al ingresar un valor negativo en el número de cuenta.
'Se pide confeccionar un programa que lea los datos de las cuentas corrientes e informe
'a)De cada cuenta: número de cuenta y estado de la cuenta según su saldo, sabiendo que:
'Estado de la cuenta	'Acreedor' si el saldo es >0.
'			'Deudor' si el saldo es <0.
'			'Nulo' si el saldo es =0.
'b) La suma total de los saldos acreedores
Module Program
    Sub Main()
        Dim numCuenta, saldAct, sumAc As Integer
        sumAc = 0
        numCuenta = 0

        Do
            Console.WriteLine("Ingrese numero de cuenta: ")
            numCuenta = Console.ReadLine()
            Console.WriteLine("Ingrese saldo actual: ")
            saldAct = Console.ReadLine()
            Console.WriteLine("----------------------------------")
            Console.WriteLine("ESTADO DE LA CUENTA")
            Console.WriteLine("Num de cuenta: " & numCuenta)
            If saldAct > 0 Then
                Console.WriteLine("Acreedor")
                sumAc = sumAc + saldAct
            ElseIf saldAct < 0 Then
                Console.WriteLine("Deudor")
            Else
                Console.WriteLine("Nulo")
            End If
            Console.WriteLine("----------------------------------")
        Loop While numCuenta <> -1
        Console.WriteLine("La suma total de los saldos acreedores es de: " & sumAc)



    End Sub
End Module