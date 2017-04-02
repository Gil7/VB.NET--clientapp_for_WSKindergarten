Public Class DeleteTutor

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim clientWS As New WsKinderGarten.Service

        If TextBox1.Text = "" Then
            MsgBox("Ingresa el Dni del tutor a eliminar")
            Me.TextBox1.BackColor = Color.Red

        Else
            Try
                If MessageBox.Show("Esta seguro de eliminar tutor con DNI : " + TextBox1.Text, "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                    clientWS.WS_delete_tutor(TextBox1.Text.ToString)
                    MsgBox("Tutor eliminado correctamente")
                    IndexStudents.updateDataGridStudents()
                    Me.TextBox1.BackColor = DefaultBackColor
                End If

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class