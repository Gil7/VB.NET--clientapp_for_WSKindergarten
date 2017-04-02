<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IndexStudents
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtForFindStudent = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(71, 158)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(416, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(632, 41)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Registrar nuevo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(632, 106)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Actualizar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(632, 188)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Eliminar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(298, 115)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Buscar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Matricula"
        '
        'txtForFindStudent
        '
        Me.txtForFindStudent.Location = New System.Drawing.Point(163, 115)
        Me.txtForFindStudent.Name = "txtForFindStudent"
        Me.txtForFindStudent.Size = New System.Drawing.Size(100, 20)
        Me.txtForFindStudent.TabIndex = 6
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(395, 115)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "Ver Todos"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'IndexStudents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 490)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.txtForFindStudent)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "IndexStudents"
        Me.Text = "IndexStudents"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtForFindStudent As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
End Class
