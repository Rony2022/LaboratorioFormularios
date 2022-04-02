Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        Dim pr1, pr2, pr3, r, porcentaje As Decimal
        pr1 = txtp1.Text
        pr2 = txtp2.Text
        pr3 = txtp3.Text
        r = total(pr1, pr2, pr3)
        MsgBox("La suma Total de la Cuenta es: $" & total(pr1, pr2, pr3), MsgBoxStyle.Information, Title:="TOTAL DE LA CUENTA")
        des(pr1, pr2, pr3, r)
        MsgBox("El valor total del IVA es: $" & calculodeiva(r, porcentaje), MsgBoxStyle.Information, Title:="TOTAL IVA")


    End Sub
    Function total(pr1, pr2, pr3) As Decimal
        Dim r As Decimal
        r = pr1 + pr2 + pr3
        Return r
    End Function

    Sub des(p1 As Decimal, p2 As Decimal, p3 As Decimal, total As Decimal)
        If (total >= 25.1 And total <= 99.99) Then
            MsgBox("Obtuvo un descuento de: 5% $" & total * 0.05, MsgBoxStyle.Information, Title:="DESCUENTO APLICADO")
        ElseIf (total >= 100 And total <= 149.99) Then
            MsgBox("Obtuvo un descuento de: 10% $" & total * 0.1, MsgBoxStyle.Information, Title:="DESCUENTO APLICADO")
        ElseIf (total >= 150.1) Then
            MsgBox("Obtuvo un descuento de: 15%  $" & total * 0.15, MsgBoxStyle.Information, Title:="DESCUENTO APLICADO")
        Else
            MsgBox("No Obtuvo ningun descuento")
        End If
    End Sub
    Function calculodeiva(r, porcentaje) As Decimal
        Dim iva As Decimal
        iva = (r - porcentaje) * 0.13
        Return (iva)
    End Function

End Class
