<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateStudent
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtEnrollmentStudent = New System.Windows.Forms.TextBox()
        Me.txtNameStudent = New System.Windows.Forms.TextBox()
        Me.txtLastnameFStudent = New System.Windows.Forms.TextBox()
        Me.txtLastnameMStudent = New System.Windows.Forms.TextBox()
        Me.DateTimePickerAdmission = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(254, 409)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Registrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(412, 409)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtEnrollmentStudent
        '
        Me.txtEnrollmentStudent.Location = New System.Drawing.Point(364, 47)
        Me.txtEnrollmentStudent.Name = "txtEnrollmentStudent"
        Me.txtEnrollmentStudent.Size = New System.Drawing.Size(240, 20)
        Me.txtEnrollmentStudent.TabIndex = 2
        '
        'txtNameStudent
        '
        Me.txtNameStudent.Location = New System.Drawing.Point(364, 89)
        Me.txtNameStudent.Name = "txtNameStudent"
        Me.txtNameStudent.Size = New System.Drawing.Size(240, 20)
        Me.txtNameStudent.TabIndex = 3
        '
        'txtLastnameFStudent
        '
        Me.txtLastnameFStudent.Location = New System.Drawing.Point(364, 144)
        Me.txtLastnameFStudent.Name = "txtLastnameFStudent"
        Me.txtLastnameFStudent.Size = New System.Drawing.Size(240, 20)
        Me.txtLastnameFStudent.TabIndex = 4
        '
        'txtLastnameMStudent
        '
        Me.txtLastnameMStudent.Location = New System.Drawing.Point(364, 211)
        Me.txtLastnameMStudent.Name = "txtLastnameMStudent"
        Me.txtLastnameMStudent.Size = New System.Drawing.Size(240, 20)
        Me.txtLastnameMStudent.TabIndex = 5
        '
        'DateTimePickerAdmission
        '
        Me.DateTimePickerAdmission.Location = New System.Drawing.Point(364, 284)
        Me.DateTimePickerAdmission.Name = "DateTimePickerAdmission"
        Me.DateTimePickerAdmission.Size = New System.Drawing.Size(240, 20)
        Me.DateTimePickerAdmission.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(187, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Matricula:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(187, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Nombre(s):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(187, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Apellido Paterno:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(192, 211)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Apellido Materno:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(192, 290)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Fecha de Ingreso"
        '
        'CreateStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 492)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePickerAdmission)
        Me.Controls.Add(Me.txtLastnameMStudent)
        Me.Controls.Add(Me.txtLastnameFStudent)
        Me.Controls.Add(Me.txtNameStudent)
        Me.Controls.Add(Me.txtEnrollmentStudent)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "CreateStudent"
        Me.Text = "CreateStudent"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtEnrollmentStudent As System.Windows.Forms.TextBox
    Friend WithEvents txtNameStudent As System.Windows.Forms.TextBox
    Friend WithEvents txtLastnameFStudent As System.Windows.Forms.TextBox
    Friend WithEvents txtLastnameMStudent As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePickerAdmission As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
