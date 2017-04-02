Public Class IndexConsumptions
    Dim clientWS As New WsKinderGarten.Service

    Dim dataConsumptions As New DataSet

    Private Sub IndexConsumptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dataConsumptions = clientWS.WS_get_all_consumptions
            Me.DataGridView1.DataSource = dataConsumptions.Tables(7)
        Catch ex As Exception

        End Try
    End Sub
End Class