Public Class DeleteStudent

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim clientWS As New WsKinderGarten.Service

        If TextBox1.Text = "" Then
            MsgBox("Ingresa una Matricula")
            Me.TextBox1.BackColor = Color.Red

        Else
            Try
                If MessageBox.Show("Esta seguro de eliminar al estudiante con matricula: " + TextBox1.Text, "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                    clientWS.WS_delete_student(TextBox1.Text.ToString)
                    MsgBox("Estudiante eliminado correctamente")
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

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class