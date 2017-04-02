Public Class CreateTutor
    Public Function validate_fields(fdni As String, fname As String, fflastname As String, fslastname As String,
                                    faddress As String, frelationship As String, fenrollment_student As String, fphone As String) As Boolean

        If fdni = "" Or fname = "" Or fflastname = "" Or fslastname = "" Or faddress = "" Or frelationship = "" Or fenrollment_student = "" Or fphone = "" Then
            Return False

        Else
            Return True
        End If
    End Function
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dni As String = txtDniTutor.Text
        Dim name As String = txtNameTutor.Text
        Dim flastname As String = txtLastnameFTutor.Text
        Dim slastname As String = txtLastnameMTutor.Text
        Dim address As String = txtBoxAddress.Text
        Dim relationship As String = ComboBox1.Text
        Dim enrollment_student As String = txtStudent.Text
        Dim phone As String = txtPhone.Text

        Dim validation As Boolean = validate_fields(dni, name, flastname, slastname, address, relationship, enrollment_student, phone)
        If validation Then
            Try
                Dim clientWs As New WsKinderGarten.Service
                clientWs.WS_create_tutor(dni, name, flastname, slastname, address, relationship, enrollment_student)
                clientWs.WS_create_phone(phone, dni)
                MsgBox("Tutor registrado con exito!")
                IndexTutors.updateDataGridTutors()
            Catch ex As Exception
                MsgBox("Surgio un error")
            End Try
        Else
            MsgBox("Debes de llenar todos los campos")
        End If

    End Sub
End Class