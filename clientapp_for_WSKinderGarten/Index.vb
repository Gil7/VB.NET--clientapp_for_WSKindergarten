Public Class Index

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        IndexStudents.Show()
    End Sub

    Private Sub Index_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        IndexTutors.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        IndexMenus.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        IndexCharges.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        IndexConsumptions.Show()
    End Sub
End Class
