Public Class CreateSaucer

    Private Sub btnAddSaucerToMenu_Click(sender As Object, e As EventArgs) Handles btnAddSaucerToMenu.Click
        Dim idMenu As Integer = CInt(txtIdMenu.Text)
        Dim name As String = txtNameSaucer.Text

        If name <> "" Then
            Dim clientWs As New WsKinderGarten.Service
            Try
                clientWs.WS_create_saucer(name, idMenu)
                MsgBox("Platillo agregado al menu")
            Catch ex As Exception

            End Try
        Else
            MsgBox("Debes de poner un nombre")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class