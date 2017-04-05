Public Class CreatePhone

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim phone As String = txtPhone.Text
        Dim dni As String = txtDni.Text

        If phone <> "" And dni <> "" Then
            Dim WsClient As New WsKinderGarten.Service
            Try
                WsClient.WS_create_phone(phone, dni)
                txtDni.Text = ""
                txtPhone.Text = ""
                MsgBox("Telefono agregado correctamente al tutor con dni: " + dni)


            Catch ex As Exception
                MsgBox("Ha surgido un error")
            End Try
        Else
            MsgBox("Debes de llenar todos los campos")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class