Public Class IndexTutors
    Dim clientForWs As New WsKinderGarten.Service
    Dim dataTutors As New DataSet
    Public Function updateDataGridTutors() As Boolean
        Try
            dataTutors = clientForWs.WS_get_all_tutors

            Me.DataGridView1.DataSource = dataTutors.Tables(1)
        Catch ex As Exception

        End Try
        Return True
    End Function
    Private Sub IndexTutors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dataTutors = clientForWs.WS_get_all_tutors

        Me.DataGridView1.DataSource = dataTutors.Tables(1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CreateTutor.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        UpdateTutor.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DeleteTutor.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If txtForFindTutor.Text = "" Then
            MsgBox("Ingresa una matricula para buscar un alumno")
            txtForFindTutor.BackColor = Color.Red
        Else
            Try
                dataTutors = clientForWs.WS_find_tutor(txtForFindTutor.Text)
                Me.DataGridView1.DataSource = dataTutors.Tables(1)
                Me.txtForFindTutor.BackColor = DefaultBackColor
            Catch ex As Exception
                MsgBox("Surgión un error, vuelve a intentarlo más tarde")
            End Try
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        updatedataGridTutors()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        CreateAccount.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        CreatePhone.Show()
    End Sub
End Class