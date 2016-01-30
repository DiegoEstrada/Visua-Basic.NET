<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Eventos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Eventos))
        Me.infDep = New System.Windows.Forms.Label()
        Me.InfCult = New System.Windows.Forms.Label()
        Me.btDep = New System.Windows.Forms.Button()
        Me.btCult = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'infDep
        '
        Me.infDep.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.infDep.ForeColor = System.Drawing.Color.White
        Me.infDep.Location = New System.Drawing.Point(67, 81)
        Me.infDep.Name = "infDep"
        Me.infDep.Size = New System.Drawing.Size(398, 388)
        Me.infDep.TabIndex = 0
        Me.infDep.Text = "Eventos deportivos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Partidos Femeniles" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Partidos Fut 7" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Partidos Futbol Rap" & _
            "ido" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Partidos de Interpolitécnico" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Partidos Futbol Americano" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'InfCult
        '
        Me.InfCult.AutoSize = True
        Me.InfCult.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InfCult.ForeColor = System.Drawing.Color.White
        Me.InfCult.Location = New System.Drawing.Point(596, 70)
        Me.InfCult.Name = "InfCult"
        Me.InfCult.Size = New System.Drawing.Size(440, 560)
        Me.InfCult.TabIndex = 1
        Me.InfCult.Text = resources.GetString("InfCult.Text")
        '
        'btDep
        '
        Me.btDep.Location = New System.Drawing.Point(100, 31)
        Me.btDep.Name = "btDep"
        Me.btDep.Size = New System.Drawing.Size(194, 23)
        Me.btDep.TabIndex = 2
        Me.btDep.Text = "Informacion sobre eventos deportivos"
        Me.btDep.UseVisualStyleBackColor = True
        '
        'btCult
        '
        Me.btCult.Location = New System.Drawing.Point(627, 31)
        Me.btCult.Name = "btCult"
        Me.btCult.Size = New System.Drawing.Size(194, 23)
        Me.btCult.TabIndex = 3
        Me.btCult.Text = "Informacion sobre eventos culturales" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btCult.UseVisualStyleBackColor = True
        '
        'Eventos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(1186, 654)
        Me.Controls.Add(Me.btCult)
        Me.Controls.Add(Me.btDep)
        Me.Controls.Add(Me.InfCult)
        Me.Controls.Add(Me.infDep)
        Me.Name = "Eventos"
        Me.Text = "Eventos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents infDep As System.Windows.Forms.Label
    Friend WithEvents InfCult As System.Windows.Forms.Label
    Friend WithEvents btDep As System.Windows.Forms.Button
    Friend WithEvents btCult As System.Windows.Forms.Button
End Class
