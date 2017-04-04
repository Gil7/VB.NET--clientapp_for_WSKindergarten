Public Class CreateConsumption
    Dim clientWS As New WsKinderGarten.Service
    Dim dataMenus As New DataSet
    Private Sub CreateConsumption_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
        Try
            dataMenus = clientWS.WS_get_all_menus
            Me.DataGridView1.DataSource = dataMenus.Tables(4)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim matricula As String = txtEnrollment.Text
        Dim menu_id As String = txtMenuId.Text
        Dim dateM As String = DateTimePicker.Value.ToString("yyyy-MM-dd")

        If matricula <> "" And menu_id <> "" Then

            Try
                clientWS.WS_create_consumption(matricula, menu_id, dateM)
                MsgBox("Consumo al estudiante con matricula " + matricula + " se realizó correctamente")
                IndexConsumptions.loadDataGrid()
            Catch ex As Exception

            End Try
        End If
    End Sub
End Class