Public Class IndexMenus
    Dim clientWS As New WsKinderGarten.Service
    Dim dataMenus As New DataSet

    Public Function loadDataGrid() As Boolean
        Try
            dataMenus = clientWS.WS_get_all_menus
            Me.DataGridView1.DataSource = dataMenus.Tables(4)
        Catch ex As Exception

        End Try
        Return True
    End Function
    Private Sub IndexMenus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDataGrid()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If txtForFindMenu.Text <> "" Then
            Dim clientWs As New WsKinderGarten.Service
            Dim dataMenu As New DataSet
            Try
                dataMenu = clientWs.WS_find_menu(txtForFindMenu.Text)
                Me.DataGridView1.DataSource = dataMenu.Tables(4)
                txtForFindMenu.BackColor = DefaultBackColor
            Catch ex As Exception

            End Try
        Else
            MsgBox("Debes de llenar el campo")
            txtForFindMenu.BackColor = Color.Red
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        loadDataGrid()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        CreateIngredient.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CreateMenu.Show()
    End Sub
End Class