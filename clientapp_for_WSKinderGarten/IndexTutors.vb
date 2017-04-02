Public Class IndexTutors
    Dim clientForWs As New WsKinderGarten.Service
    Dim dataTutors As New DataSet
    Private Sub IndexTutors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dataTutors = clientForWs.WS_get_all_tutors

        Me.DataGridView1.DataSource = dataTutors.Tables(1)
    End Sub
End Class