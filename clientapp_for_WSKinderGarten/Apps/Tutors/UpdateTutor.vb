Public Class UpdateTutor

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dni As String = txtDniTutor.Text
        Dim name As String = txtNameTutor.Text
        Dim flastname As String = txtLastnameFTutor.Text
        Dim slastname As String = txtLastnameMTutor.Text
        Dim address As String = txtBoxAddress.Text
        Dim relationship As String = ComboBox1.Text
        Dim enrollment_student As String = txtStudent.Text

        Dim validation As Boolean = CreateTutor.validate_fields(dni, name, flastname, slastname, address, relationship, enrollment_student, "default")
        If validation Then
            Try
                Dim clientWs As New WsKinderGarten.Service
                clientWs.WS_update_tutor(dni, name, flastname, slastname, address, relationship, enrollment_student)
                MsgBox("Tutor actualizado con exito!")
                IndexTutors.updateDataGridTutors()
            Catch ex As Exception
                MsgBox("Surgio un error")
            End Try
        Else
            MsgBox("Debes de llenar todos los campos")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class