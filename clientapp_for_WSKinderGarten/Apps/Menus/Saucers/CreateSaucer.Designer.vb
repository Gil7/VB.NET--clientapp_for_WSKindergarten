<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSaucer
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
        Me.txtIdMenu = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNameSaucer = New System.Windows.Forms.TextBox()
        Me.btnAddSaucerToMenu = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'txtIdMenu
        '
        Me.txtIdMenu.AutoSize = True
        Me.txtIdMenu.Location = New System.Drawing.Point(40, 41)
        Me.txtIdMenu.Name = "txtIdMenu"
        Me.txtIdMenu.Size = New System.Drawing.Size(54, 13)
        Me.txtIdMenu.TabIndex = 0
        Me.txtIdMenu.Text = "txtIdMenu"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(128, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre del platillo"
        '
        'txtNameSaucer
        '
        Me.txtNameSaucer.Location = New System.Drawing.Point(250, 113)
        Me.txtNameSaucer.Name = "txtNameSaucer"
        Me.txtNameSaucer.Size = New System.Drawing.Size(223, 20)
        Me.txtNameSaucer.TabIndex = 2
        '
        'btnAddSaucerToMenu
        '
        Me.btnAddSaucerToMenu.Location = New System.Drawing.Point(263, 217)
        Me.btnAddSaucerToMenu.Name = "btnAddSaucerToMenu"
        Me.btnAddSaucerToMenu.Size = New System.Drawing.Size(195, 23)
        Me.btnAddSaucerToMenu.TabIndex = 3
        Me.btnAddSaucerToMenu.Text = "Agregar a Menú"
        Me.btnAddSaucerToMenu.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(324, 413)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Terminar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(578, 240)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 95)
        Me.ListBox1.TabIndex = 5
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(578, 131)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 6
        '
        'CreateSaucer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 492)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnAddSaucerToMenu)
        Me.Controls.Add(Me.txtNameSaucer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtIdMenu)
        Me.Name = "CreateSaucer"
        Me.Text = "CreateSaucer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtIdMenu As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNameSaucer As System.Windows.Forms.TextBox
    Friend WithEvents btnAddSaucerToMenu As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
