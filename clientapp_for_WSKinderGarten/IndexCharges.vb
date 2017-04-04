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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CreateCharge.Show()
    End Sub
End Class