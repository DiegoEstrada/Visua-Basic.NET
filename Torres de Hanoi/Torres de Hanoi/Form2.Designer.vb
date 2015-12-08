<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PosteA = New System.Windows.Forms.Label()
        Me.PosteB = New System.Windows.Forms.Label()
        Me.PosteC = New System.Windows.Forms.Label()
        Me.BaseA = New System.Windows.Forms.Label()
        Me.BaseB = New System.Windows.Forms.Label()
        Me.BaseC = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(91, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "A"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(454, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 33)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "B"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(839, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 33)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "C"
        '
        'PosteA
        '
        Me.PosteA.BackColor = System.Drawing.Color.DarkGray
        Me.PosteA.Location = New System.Drawing.Point(104, 86)
        Me.PosteA.Name = "PosteA"
        Me.PosteA.Size = New System.Drawing.Size(20, 327)
        Me.PosteA.TabIndex = 3
        '
        'PosteB
        '
        Me.PosteB.BackColor = System.Drawing.Color.DarkGray
        Me.PosteB.Location = New System.Drawing.Point(466, 86)
        Me.PosteB.Name = "PosteB"
        Me.PosteB.Size = New System.Drawing.Size(20, 327)
        Me.PosteB.TabIndex = 4
        '
        'PosteC
        '
        Me.PosteC.BackColor = System.Drawing.Color.DarkGray
        Me.PosteC.Location = New System.Drawing.Point(849, 86)
        Me.PosteC.Name = "PosteC"
        Me.PosteC.Size = New System.Drawing.Size(20, 327)
        Me.PosteC.TabIndex = 5
        '
        'BaseA
        '
        Me.BaseA.BackColor = System.Drawing.Color.DarkGray
        Me.BaseA.Location = New System.Drawing.Point(38, 413)
        Me.BaseA.Name = "BaseA"
        Me.BaseA.Size = New System.Drawing.Size(150, 13)
        Me.BaseA.TabIndex = 6
        '
        'BaseB
        '
        Me.BaseB.BackColor = System.Drawing.Color.DarkGray
        Me.BaseB.Location = New System.Drawing.Point(400, 413)
        Me.BaseB.Name = "BaseB"
        Me.BaseB.Size = New System.Drawing.Size(150, 13)
        Me.BaseB.TabIndex = 7
        '
        'BaseC
        '
        Me.BaseC.BackColor = System.Drawing.Color.DarkGray
        Me.BaseC.Location = New System.Drawing.Point(786, 413)
        Me.BaseC.Name = "BaseC"
        Me.BaseC.Size = New System.Drawing.Size(150, 13)
        Me.BaseC.TabIndex = 8
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(1055, 429)
        Me.Controls.Add(Me.BaseC)
        Me.Controls.Add(Me.BaseB)
        Me.Controls.Add(Me.BaseA)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PosteB)
        Me.Controls.Add(Me.PosteA)
        Me.Controls.Add(Me.PosteC)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Torres de Hanoi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PosteA As System.Windows.Forms.Label
    Friend WithEvents PosteB As System.Windows.Forms.Label
    Friend WithEvents PosteC As System.Windows.Forms.Label
    Friend WithEvents BaseA As System.Windows.Forms.Label
    Friend WithEvents BaseB As System.Windows.Forms.Label
    Friend WithEvents BaseC As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
