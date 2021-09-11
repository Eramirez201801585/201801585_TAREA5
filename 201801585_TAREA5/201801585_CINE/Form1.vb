Public Class Form1
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If cmbCine.Text = "" Then
            MsgBox("Por favor seleccione el cine",, "Error")
            Exit Sub
        End If

        If cmbFuncion.Text = "" Then
            MsgBox("Por favor seleccione la función",, "Error")
            Exit Sub
        End If

        If txbEntradas.Text = "" Or IsNumeric(txbEntradas.Text) = False Then
            MsgBox("Por favor ingrese el número de entradas",, "Error")
            txbEntradas.Focus()
            Exit Sub
        End If

        If indice < 9 Then
            V_Entradas(indice) = Str(txbEntradas.Text)
            V_Funcion(indice) = cmbFuncion.SelectedItem
            V_Cine(indice) = cmbCine.SelectedItem
            V_Subtotal(indice) = Str(F_Subtotal(V_Funcion(indice), V_Cine(indice)))
            V_Descuento1(indice) = Str(F_Descuento1(V_Funcion(indice), V_Cine(indice)))
            V_Descuento2(indice) = Str(F_Descuento2(Subtotal))
            V_Total(indice) = Str(F_Total(Subtotal, Descuento1, Descuento2))

        ElseIf indice >= 9 Then
            MsgBox("Resultados llenos, por favor limpie los resultados",, "Error")
            Exit Sub
        End If
        Imprimir()
    End Sub

    Private Sub btnLEntradas_Click(sender As Object, e As EventArgs) Handles btnLEntradas.Click
        If MsgBox("¿Desea limpiar las entradas?", vbYesNo, "Advertencia") = MsgBoxResult.Yes Then
            LEntradas()
        End If
    End Sub

    Private Sub btnLResultados_Click(sender As Object, e As EventArgs) Handles btnLResultados.Click
        If MsgBox("¿Desea limpiar los resultados?", vbYesNo, "Advertencia") = MsgBoxResult.Yes Then
            LResultados()
        End If
    End Sub

    Private Sub btnLMemoria_Click(sender As Object, e As EventArgs) Handles btnLMemoria.Click
        If MsgBox("¿Desea limpiar la memoria en vectores?", vbYesNo, "Advertencia") = MsgBoxResult.Yes Then
            LVectores()
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If MsgBox("¿Desea salir?", vbYesNo, "Advertencia") = MsgBoxResult.Yes Then
            Close()
        End If
    End Sub
End Class
