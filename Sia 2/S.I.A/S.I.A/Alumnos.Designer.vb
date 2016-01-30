<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alumnos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Cultu = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GNI = New System.Windows.Forms.RadioButton()
        Me.RPA = New System.Windows.Forms.RadioButton()
        Me.MCR = New System.Windows.Forms.RadioButton()
        Me.JCR = New System.Windows.Forms.RadioButton()
        Me.HP = New System.Windows.Forms.Button()
        Me.btRegresar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.gpDia = New System.Windows.Forms.GroupBox()
        Me.Viernes = New System.Windows.Forms.RadioButton()
        Me.Jueves = New System.Windows.Forms.RadioButton()
        Me.Miercoles = New System.Windows.Forms.RadioButton()
        Me.Martes = New System.Windows.Forms.RadioButton()
        Me.Lunes = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpDia.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Myriad Pro", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(465, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bienvenido alumno."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Myriad Pro", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(432, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(322, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "En este programa podrás consultar:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Myriad Pro", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(52, 89)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Horarios de profesores"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Cultu
        '
        Me.Cultu.Font = New System.Drawing.Font("Myriad Pro", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cultu.ForeColor = System.Drawing.Color.Black
        Me.Cultu.Location = New System.Drawing.Point(565, 89)
        Me.Cultu.Name = "Cultu"
        Me.Cultu.Size = New System.Drawing.Size(163, 23)
        Me.Cultu.TabIndex = 3
        Me.Cultu.Text = "Eventos culturales y deportivos"
        Me.Cultu.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Myriad Pro", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(950, 89)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(104, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Tramites escolares"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GNI)
        Me.GroupBox1.Controls.Add(Me.RPA)
        Me.GroupBox1.Controls.Add(Me.MCR)
        Me.GroupBox1.Controls.Add(Me.JCR)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(52, 122)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(281, 115)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Profesores"
        '
        'GNI
        '
        Me.GNI.AutoSize = True
        Me.GNI.Location = New System.Drawing.Point(7, 43)
        Me.GNI.Name = "GNI"
        Me.GNI.Size = New System.Drawing.Size(136, 17)
        Me.GNI.TabIndex = 8
        Me.GNI.TabStop = True
        Me.GNI.Text = "Guadalupe Nava Ibarra"
        Me.GNI.UseVisualStyleBackColor = True
        '
        'RPA
        '
        Me.RPA.AutoSize = True
        Me.RPA.Location = New System.Drawing.Point(7, 66)
        Me.RPA.Name = "RPA"
        Me.RPA.Size = New System.Drawing.Size(152, 17)
        Me.RPA.TabIndex = 7
        Me.RPA.TabStop = True
        Me.RPA.Text = "Rosa María Pérez Ángeles"
        Me.RPA.UseVisualStyleBackColor = True
        '
        'MCR
        '
        Me.MCR.AutoSize = True
        Me.MCR.Location = New System.Drawing.Point(7, 89)
        Me.MCR.Name = "MCR"
        Me.MCR.Size = New System.Drawing.Size(152, 17)
        Me.MCR.TabIndex = 8
        Me.MCR.TabStop = True
        Me.MCR.Text = "Miroslava Cárdenas Rivera"
        Me.MCR.UseVisualStyleBackColor = True
        '
        'JCR
        '
        Me.JCR.AutoSize = True
        Me.JCR.Location = New System.Drawing.Point(7, 20)
        Me.JCR.Name = "JCR"
        Me.JCR.Size = New System.Drawing.Size(138, 17)
        Me.JCR.TabIndex = 0
        Me.JCR.TabStop = True
        Me.JCR.Text = "Javier Carrillo Rodriguez" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.JCR.UseVisualStyleBackColor = True
        '
        'HP
        '
        Me.HP.ForeColor = System.Drawing.Color.Black
        Me.HP.Location = New System.Drawing.Point(119, 44)
        Me.HP.Name = "HP"
        Me.HP.Size = New System.Drawing.Size(75, 23)
        Me.HP.TabIndex = 9
        Me.HP.Text = "Continuar"
        Me.HP.UseVisualStyleBackColor = True
        '
        'btRegresar
        '
        Me.btRegresar.Font = New System.Drawing.Font("Myriad Pro", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btRegresar.Location = New System.Drawing.Point(1010, 610)
        Me.btRegresar.Margin = New System.Windows.Forms.Padding(2)
        Me.btRegresar.Name = "btRegresar"
        Me.btRegresar.Size = New System.Drawing.Size(140, 33)
        Me.btRegresar.TabIndex = 22
        Me.btRegresar.Text = "Regresar al menu principal"
        Me.btRegresar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(52, 270)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1098, 335)
        Me.DataGridView1.TabIndex = 23
        '
        'gpDia
        '
        Me.gpDia.Controls.Add(Me.HP)
        Me.gpDia.Controls.Add(Me.Viernes)
        Me.gpDia.Controls.Add(Me.Jueves)
        Me.gpDia.Controls.Add(Me.Miercoles)
        Me.gpDia.Controls.Add(Me.Martes)
        Me.gpDia.Controls.Add(Me.Lunes)
        Me.gpDia.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.gpDia.Location = New System.Drawing.Point(339, 128)
        Me.gpDia.Name = "gpDia"
        Me.gpDia.Size = New System.Drawing.Size(200, 100)
        Me.gpDia.TabIndex = 24
        Me.gpDia.TabStop = False
        Me.gpDia.Text = "Selecciona un dia de la semana:"
        '
        'Viernes
        '
        Me.Viernes.AutoSize = True
        Me.Viernes.Location = New System.Drawing.Point(7, 82)
        Me.Viernes.Name = "Viernes"
        Me.Viernes.Size = New System.Drawing.Size(60, 17)
        Me.Viernes.TabIndex = 4
        Me.Viernes.TabStop = True
        Me.Viernes.Text = "Viernes"
        Me.Viernes.UseVisualStyleBackColor = True
        '
        'Jueves
        '
        Me.Jueves.AutoSize = True
        Me.Jueves.Location = New System.Drawing.Point(7, 67)
        Me.Jueves.Name = "Jueves"
        Me.Jueves.Size = New System.Drawing.Size(59, 17)
        Me.Jueves.TabIndex = 3
        Me.Jueves.TabStop = True
        Me.Jueves.Text = "Jueves"
        Me.Jueves.UseVisualStyleBackColor = True
        '
        'Miercoles
        '
        Me.Miercoles.AutoSize = True
        Me.Miercoles.Location = New System.Drawing.Point(7, 50)
        Me.Miercoles.Name = "Miercoles"
        Me.Miercoles.Size = New System.Drawing.Size(70, 17)
        Me.Miercoles.TabIndex = 2
        Me.Miercoles.TabStop = True
        Me.Miercoles.Text = "Miercoles"
        Me.Miercoles.UseVisualStyleBackColor = True
        '
        'Martes
        '
        Me.Martes.AutoSize = True
        Me.Martes.Location = New System.Drawing.Point(6, 31)
        Me.Martes.Name = "Martes"
        Me.Martes.Size = New System.Drawing.Size(57, 17)
        Me.Martes.TabIndex = 1
        Me.Martes.TabStop = True
        Me.Martes.Text = "Martes"
        Me.Martes.UseVisualStyleBackColor = True
        '
        'Lunes
        '
        Me.Lunes.AutoSize = True
        Me.Lunes.Location = New System.Drawing.Point(7, 14)
        Me.Lunes.Name = "Lunes"
        Me.Lunes.Size = New System.Drawing.Size(54, 17)
        Me.Lunes.TabIndex = 0
        Me.Lunes.TabStop = True
        Me.Lunes.Text = "Lunes"
        Me.Lunes.UseVisualStyleBackColor = True
        '
        'Alumnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(1186, 654)
        Me.Controls.Add(Me.gpDia)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btRegresar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Cultu)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Alumnos"
        Me.Text = "Alumnos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpDia.ResumeLayout(False)
        Me.gpDia.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Cultu As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GNI As System.Windows.Forms.RadioButton
    Friend WithEvents RPA As System.Windows.Forms.RadioButton
    Friend WithEvents MCR As System.Windows.Forms.RadioButton
    Friend WithEvents JCR As System.Windows.Forms.RadioButton
    Friend WithEvents btRegresar As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents HP As System.Windows.Forms.Button
    Friend WithEvents gpDia As System.Windows.Forms.GroupBox
    Friend WithEvents Viernes As System.Windows.Forms.RadioButton
    Friend WithEvents Jueves As System.Windows.Forms.RadioButton
    Friend WithEvents Miercoles As System.Windows.Forms.RadioButton
    Friend WithEvents Martes As System.Windows.Forms.RadioButton
    Friend WithEvents Lunes As System.Windows.Forms.RadioButton
End Class
