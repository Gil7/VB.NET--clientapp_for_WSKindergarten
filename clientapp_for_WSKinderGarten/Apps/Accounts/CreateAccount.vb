Public Class CreateAccount

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim accout As String = txtAccount.Text
        Dim dni As String = txtDni.Text

        If accout <> "" And dni <> "" Then
            Dim WsClient As New WsKinderGarten.Service
            Try
                WsClient.WS_create_account(accout, dni)
                txtAccount.Text = ""
                txtDni.Text = ""
                MsgBox("Cuenta agregada al tutor con Dni: " + dni)
            Catch ex As Exception
                MsgBox("Ha surgido un error")
            End Try
        Else
            MsgBox("Todos los campos son necesarios")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class