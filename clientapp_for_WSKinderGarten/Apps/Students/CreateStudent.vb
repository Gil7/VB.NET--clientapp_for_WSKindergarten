Public Class CreateStudent

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim enrollment As String = txtEnrollmentStudent.Text
        Dim name As String = txtNameStudent.Text
        Dim flastname As String = txtLastnameFStudent.Text
        Dim slastname As String = txtLastnameMStudent.Text
        Dim admissionDate As String = DateTimePickerAdmission.Value.ToString("yyyy-MM-dd")

        If enrollment = "" Or name = "" Or flastname = "" Or slastname = "" Then
            MsgBox("Todos los campos deben de ser rellenados.")

        Else
            Dim clientWS As New WsKinderGarten.Service
            Dim student As New DataSet
            Dim response As String
            Try
                response = clientWS.WS_create_student(enrollment, name, flastname, slastname, admissionDate, admissionDate)
                If response = "success" Then
                    MsgBox("El estudiante " + name + "a sido registrado correctamente")
                    IndexStudents.updateDataGridStudents()
                End If
            Catch ex As Exception
                MsgBox("ha surgido un error")
            End Try
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class