Public Class IndexConsumptions
    Dim clientWS As New WsKinderGarten.Service

    Dim dataConsumptions As New DataSet
    Public Function loadDataGrid() As Boolean
        Try
            dataConsumptions = clientWS.WS_get_all_consumptions
            Me.DataGridView1.DataSource = dataConsumptions.Tables(7)
        Catch ex As Exception

        End Try
        Return True
    End Function
    Private Sub IndexConsumptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDataGrid()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CreateConsumption.Show()
    End Sub
End Class