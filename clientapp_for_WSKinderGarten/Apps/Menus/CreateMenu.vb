Public Class CreateMenu

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim name As String = txtNameMenu.Text
        Dim price As String = txtPriceMenu.Text
        Dim idMenu As String = ""
        If name <> "" And price <> "" Then
            price = CDbl(price)
            Dim clientWs As New WsKinderGarten.Service
            Dim specificMenu As New DataSet
            Try

                clientWs.WS_create_menu(name, price)
                MsgBox("Menú creado correctamente, ahora puedes agregar platillos a este menú ")
                txtContinu.Text = "Agregar platillos a: " + name + "."
                btnAddSaucer.Visible = True
                specificMenu = clientWs.WS_find_menu(name)

                'Retrieve id of menu for the next Form
                idMenu = specificMenu.Tables(4).Rows(0)("id").ToString
                CreateSaucer.txtIdMenu.Text = idMenu
            Catch ex As Exception

            End Try
        Else
            MsgBox("Debes de llenar todos los campos")
        End If
        
    End Sub

    Private Sub btnAddSaucer_Click(sender As Object, e As EventArgs) Handles btnAddSaucer.Click
        CreateSaucer.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class