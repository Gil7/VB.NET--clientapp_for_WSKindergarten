Public Class CreateCharge
    Dim WsClient As New WsKinderGarten.Service
    Dim results As New DataSet
    Dim enrollment As String
    Dim students As DataSet
    Dim aux As Integer
    Dim fillDataGridWith As New DataSet
    'Private Function amountWithFormat(month As String) As Double


    'End Function
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDni.KeyPress

    End Sub

    Private Sub txtDni_KeyUp(sender As Object, e As KeyEventArgs) Handles txtDni.KeyUp
        Dim dniToSearch As String = txtDni.Text
        Try
            results = WsClient.WS_find_accounts(dniToSearch)
            Me.DataGridView1.DataSource = results.Tables(3)
            aux = CInt(results.Tables(3).Rows(0)("id"))
        Catch ex As Exception

        End Try

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtDni.TextChanged

    End Sub

    Private Sub txtOptionMonth_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dni As String = txtDni.Text
        Dim enrollment As String = txtEnrollment.Text
        Dim current_date As String = DateTime.Now.ToString("yyyy-MM-dd")
        Dim date_i As String = DateTimePicker1.Value.ToString("yyyy-MM-dd")
        Dim date_f As String = DateTimePicker2.Value.ToString("yyyy-MM-dd")
        Dim total As Double

        If dni <> "" And enrollment <> "" Then
            Try
                total = WsClient.WS_get_amount(enrollment, date_i, date_f)
                WsClient.WS_create_charge(total, dni, enrollment, aux, current_date)
                MsgBox("Cargo realizado correctamente")
            Catch ex As Exception

            End Try
        Else
            MsgBox("Debes de llenar todos los campos")
        End If
    End Sub
End Class