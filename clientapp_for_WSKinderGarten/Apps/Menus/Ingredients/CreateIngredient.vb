Public Class CreateIngredient

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ingredient As String = txtIngredientName.Text

        If ingredient <> "" Then
            Dim clientWs As New WsKinderGarten.Service
            Try
                clientWs.WS_create_ingredient(ingredient)
                MsgBox("Ingrediente registrado con exito")
                txtIngredientName.Text = ""
            Catch ex As Exception
                MsgBox("Ha surgido un error")
            End Try
        Else
            MsgBox("El campo: nombre de ingrediente, es necesario")
        End If
    End Sub
End Class