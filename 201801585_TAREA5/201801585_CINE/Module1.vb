Imports System.Math
Module Module1
    Public V_Funcion(8) As String
    Public V_Cine(8) As String
    Public V_Entradas(8) As String
    Public V_Subtotal(8) As String
    Public V_Descuento1(8) As String
    Public V_Descuento2(8) As String
    Public V_Total(8) As String
    Public indice As Byte = 0

    Public Entradas As Double = 0
    Public Subtotal As Double = 0
    Public Descuento1 As Double = 0
    Public Descuento2 As Double = 0
    Public Total As Double = 0

    Function F_Subtotal(Funcion As String, Cine As String) As Double
        Entradas = Val(Form1.txbEntradas.Text)
        Select Case Cine
            Case "A"
                Select Case Funcion
                    Case "1"
                        Subtotal = 30
                    Case "2"
                        Subtotal = 35
                    Case "3"
                        Subtotal = 40
                    Case "4"
                        Subtotal = 40
                End Select
            Case "B"
                Select Case Funcion
                    Case "1"
                        Subtotal = 24
                    Case "2"
                        Subtotal = 34
                    Case "3"
                        Subtotal = 44
                    Case "4"
                        Subtotal = 44
                End Select
            Case "C"
                Select Case Funcion
                    Case "1"
                        Subtotal = 35
                    Case "2"
                        Subtotal = 40
                    Case "3"
                        Subtotal = 50
                    Case "4"
                        Subtotal = 50
                End Select
        End Select
        Subtotal = Round(Subtotal * Entradas, 2)
        Return Subtotal
    End Function

    Function F_Descuento1(Funcion As String, Cine As String) As Double
        If (Funcion = "3" Or Funcion = "4") And (Cine = "C" Or Cine = "B") Then
            Descuento1 = 5.5 / 100
        ElseIf (Funcion = "1") And (Cine = "C" Or Cine = "B") Then
            Descuento1 = 3 / 100
        ElseIf (Funcion = "2") And (Cine = "A") Then
            Descuento1 = 1.5 / 100
        Else
            Descuento1 = 0
        End If
        Descuento1 = Round(Descuento1 * Subtotal, 2)
        Return Descuento1
    End Function

    Function F_Descuento2(Subtotal As Double) As Double
        Select Case Subtotal
            Case 100 To 300
                Descuento2 = 2 / 100
            Case 300.01 To 500
                Descuento2 = 4 / 100
            Case 500.01 To 1000
                Descuento2 = 6 / 100
            Case Else
                Descuento2 = 0
        End Select
        Descuento2 = Round(Descuento2 * Subtotal, 2)
        Return Descuento2
    End Function

    Function F_Total(Subtotal As Double, D1 As Double, D2 As Double) As Double
        Total = Round(Subtotal - D1 - D2, 2)
        Return Total
    End Function
    Sub Imprimir()
        Form1.ltbFuncion.Items.Add(V_Funcion(indice))
        Form1.ltbCine.Items.Add(V_Cine(indice))
        Form1.ltbEntradas.Items.Add(V_Entradas(indice))
        Form1.ltbSubtotal.Items.Add("Q" + V_Subtotal(indice))
        Form1.ltbD1.Items.Add("Q" + V_Descuento1(indice))
        Form1.ltbD2.Items.Add("Q" + V_Descuento2(indice))
        Form1.ltbTotal.Items.Add("Q" + V_Total(indice))
        indice = indice + 1
    End Sub

    Sub LEntradas()
        Form1.cmbCine.Text = ""
        Form1.cmbFuncion.Text = ""
        Form1.txbEntradas.Clear()
    End Sub

    Sub LResultados()
        Form1.ltbFuncion.Items.Clear()
        Form1.ltbCine.Items.Clear()
        Form1.ltbEntradas.Items.Clear()
        Form1.ltbSubtotal.Items.Clear()
        Form1.ltbD1.Items.Clear()
        Form1.ltbD2.Items.Clear()
        Form1.ltbTotal.Items.Clear()
        indice = 0

    End Sub

    Sub LVectores()
        ReDim V_Funcion(8), V_Cine(8), V_Entradas(8), V_Subtotal(8), V_Descuento1(8), V_Descuento2(8), V_Total(8)
        'Se limpian los resultados también para que no siga imprimiendo mas de 9 resultados
        LResultados()
    End Sub
End Module
