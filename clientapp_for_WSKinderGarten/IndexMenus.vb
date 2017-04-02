Public Class IndexMenus
    Dim clientWS As New WsKinderGarten.Service
    Dim dataMenus As New DataSet
    Private Sub IndexMenus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dataMenus = clientWS.WS_get_all_menus

            Me.DataGridView1.DataSource = dataMenus.Tables(4)
        Catch ex As Exception

        End Try
    End Sub
End Class