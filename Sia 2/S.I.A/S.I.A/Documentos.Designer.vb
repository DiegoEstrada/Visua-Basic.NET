<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Documentos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Documentos))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblintscred = New System.Windows.Forms.Label()
        Me.lblConstancia = New System.Windows.Forms.Label()
        Me.lblservicio = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblinscripocion = New System.Windows.Forms.Label()
        Me.btRegresar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Credencializacion"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(912, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Constancia"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(882, 285)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Inscripcion"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(12, 285)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(169, 23)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Tramite del servicio social "
        Me.Button5.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblintscred)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(537, 210)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblservicio)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 332)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(537, 282)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblConstancia)
        Me.GroupBox3.Location = New System.Drawing.Point(664, 52)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(494, 205)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'lblintscred
        '
        Me.lblintscred.ForeColor = System.Drawing.Color.White
        Me.lblintscred.Location = New System.Drawing.Point(17, 26)
        Me.lblintscred.Name = "lblintscred"
        Me.lblintscred.Size = New System.Drawing.Size(474, 170)
        Me.lblintscred.TabIndex = 0
        Me.lblintscred.Text = resources.GetString("lblintscred.Text")
        '
        'lblConstancia
        '
        Me.lblConstancia.ForeColor = System.Drawing.Color.White
        Me.lblConstancia.Location = New System.Drawing.Point(10, 17)
        Me.lblConstancia.Name = "lblConstancia"
        Me.lblConstancia.Size = New System.Drawing.Size(474, 170)
        Me.lblConstancia.TabIndex = 1
        Me.lblConstancia.Text = resources.GetString("lblConstancia.Text")
        '
        'lblservicio
        '
        Me.lblservicio.ForeColor = System.Drawing.Color.White
        Me.lblservicio.Location = New System.Drawing.Point(31, 56)
        Me.lblservicio.Name = "lblservicio"
        Me.lblservicio.Size = New System.Drawing.Size(474, 170)
        Me.lblservicio.TabIndex = 1
        Me.lblservicio.Text = resources.GetString("lblservicio.Text")
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblinscripocion)
        Me.GroupBox4.Location = New System.Drawing.Point(637, 332)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(537, 282)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "GroupBox4"
        '
        'lblinscripocion
        '
        Me.lblinscripocion.ForeColor = System.Drawing.Color.White
        Me.lblinscripocion.Location = New System.Drawing.Point(31, 56)
        Me.lblinscripocion.Name = "lblinscripocion"
        Me.lblinscripocion.Size = New System.Drawing.Size(474, 170)
        Me.lblinscripocion.TabIndex = 1
        Me.lblinscripocion.Text = resources.GetString("lblinscripocion.Text")
        '
        'btRegresar
        '
        Me.btRegresar.Location = New System.Drawing.Point(554, 619)
        Me.btRegresar.Name = "btRegresar"
        Me.btRegresar.Size = New System.Drawing.Size(75, 23)
        Me.btRegresar.TabIndex = 8
        Me.btRegresar.Text = "Regresar "
        Me.btRegresar.UseVisualStyleBackColor = True
        '
        'Documentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(1186, 654)
        Me.Controls.Add(Me.btRegresar)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Documentos"
        Me.Text = " "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblintscred As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblConstancia As System.Windows.Forms.Label
    Friend WithEvents lblservicio As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lblinscripocion As System.Windows.Forms.Label
    Friend WithEvents btRegresar As System.Windows.Forms.Button
End Class
