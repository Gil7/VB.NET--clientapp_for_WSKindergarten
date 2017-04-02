Public Class IndexStudents
    Dim clientForWs As New WsKinderGarten.Service
    Dim dataStudents As New DataSet
    Private Sub IndexStudents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dataStudents = clientForWs.WS_get_all_students

        Me.DataGridView1.DataSource = dataStudents.Tables(0)
    End Sub
End Class