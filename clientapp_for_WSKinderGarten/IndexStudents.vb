Public Class IndexStudents
    Dim clientForWs As New WsKinderGarten.Service
    Dim dataStudents As New DataSet
    Public Function updateDataGridStudents() As Boolean
        Try
            dataStudents = clientForWs.WS_get_all_students

            Me.DataGridView1.DataSource = dataStudents.Tables(0)
        Catch ex As Exception

        End Try
        Return True
    End Function
    Private Sub IndexStudents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dataStudents = clientForWs.WS_get_all_students

        Me.DataGridView1.DataSource = dataStudents.Tables(0)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CreateStudent.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        UpdateStudent.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DeleteStudent.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If txtForFindStudent.Text = "" Then
            MsgBox("Ingresa una matricula para buscar un alumno")
            txtForFindStudent.BackColor = Color.Red
        Else
            Try
                dataStudents = clientForWs.WS_find_student(txtForFindStudent.Text)
                Me.DataGridView1.DataSource = dataStudents.Tables(0)
                Me.txtForFindStudent.BackColor = DefaultBackColor
            Catch ex As Exception
                MsgBox("Surgión un error, vuelve a intentarlo más tarde")
            End Try
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        updateDataGridStudents()
    End Sub
End Class