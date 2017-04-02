Public Class IndexCharges
    Dim clientWS As New WsKinderGarten.Service

    Dim dataCharges As New DataSet

    Private Sub IndexCharges_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dataCharges = clientWS.WS_get_all_charges
            Me.DataGridView1.DataSource = dataCharges.Tables(9)
        Catch ex As Exception

        End Try
    End Sub
End Class