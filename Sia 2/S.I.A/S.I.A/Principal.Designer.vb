<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.ipnlogo = New System.Windows.Forms.PictureBox()
        Me.cecytlogo = New System.Windows.Forms.PictureBox()
        Me.lblIPN = New System.Windows.Forms.Label()
        Me.lblcecyt = New System.Windows.Forms.Label()
        Me.lblSIA = New System.Windows.Forms.Label()
        Me.lblInstrucciones = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SIA = New System.Windows.Forms.Button()
        CType(Me.ipnlogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cecytlogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ipnlogo
        '
        Me.ipnlogo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ipnlogo.Image = CType(resources.GetObject("ipnlogo.Image"), System.Drawing.Image)
        Me.ipnlogo.Location = New System.Drawing.Point(30, 24)
        Me.ipnlogo.Margin = New System.Windows.Forms.Padding(2)
        Me.ipnlogo.Name = "ipnlogo"
        Me.ipnlogo.Size = New System.Drawing.Size(107, 145)
        Me.ipnlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ipnlogo.TabIndex = 0
        Me.ipnlogo.TabStop = False
        '
        'cecytlogo
        '
        Me.cecytlogo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cecytlogo.Image = CType(resources.GetObject("cecytlogo.Image"), System.Drawing.Image)
        Me.cecytlogo.Location = New System.Drawing.Point(1062, 24)
        Me.cecytlogo.Margin = New System.Windows.Forms.Padding(2)
        Me.cecytlogo.Name = "cecytlogo"
        Me.cecytlogo.Size = New System.Drawing.Size(107, 145)
        Me.cecytlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cecytlogo.TabIndex = 1
        Me.cecytlogo.TabStop = False
        '
        'lblIPN
        '
        Me.lblIPN.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblIPN.AutoSize = True
        Me.lblIPN.Font = New System.Drawing.Font("Monotype Corsiva", 25.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIPN.ForeColor = System.Drawing.Color.White
        Me.lblIPN.Location = New System.Drawing.Point(359, 24)
        Me.lblIPN.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblIPN.Name = "lblIPN"
        Me.lblIPN.Size = New System.Drawing.Size(423, 43)
        Me.lblIPN.TabIndex = 2
        Me.lblIPN.Text = "Instituto Politecnico Nacional"
        '
        'lblcecyt
        '
        Me.lblcecyt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblcecyt.AutoSize = True
        Me.lblcecyt.Font = New System.Drawing.Font("Monotype Corsiva", 25.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcecyt.ForeColor = System.Drawing.Color.White
        Me.lblcecyt.Location = New System.Drawing.Point(267, 96)
        Me.lblcecyt.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcecyt.Name = "lblcecyt"
        Me.lblcecyt.Size = New System.Drawing.Size(599, 86)
        Me.lblcecyt.TabIndex = 3
        Me.lblcecyt.Text = "Centro de Estudios Cietificos y Tecnologicos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "               Num. 8 ""Narciso Bass" & _
            "ols""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblSIA
        '
        Me.lblSIA.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSIA.AutoSize = True
        Me.lblSIA.Font = New System.Drawing.Font("Monotype Corsiva", 25.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSIA.ForeColor = System.Drawing.Color.White
        Me.lblSIA.Location = New System.Drawing.Point(326, 203)
        Me.lblSIA.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSIA.Name = "lblSIA"
        Me.lblSIA.Size = New System.Drawing.Size(481, 43)
        Me.lblSIA.TabIndex = 4
        Me.lblSIA.Text = "Sistema de Información Académica"
        '
        'lblInstrucciones
        '
        Me.lblInstrucciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInstrucciones.AutoSize = True
        Me.lblInstrucciones.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstrucciones.ForeColor = System.Drawing.Color.White
        Me.lblInstrucciones.Location = New System.Drawing.Point(183, 277)
        Me.lblInstrucciones.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblInstrucciones.Name = "lblInstrucciones"
        Me.lblInstrucciones.Size = New System.Drawing.Size(801, 84)
        Me.lblInstrucciones.TabIndex = 5
        Me.lblInstrucciones.Text = "Este Sistema te facilitara el acceso a la informacion del CECyT que sea de tu int" & _
            "eres" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                           Porfavor selecciona la opción que te correspo" & _
            "nde:"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Maroon
        Me.Button1.Location = New System.Drawing.Point(141, 387)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(398, 237)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Alumnos del C.E.C.yT."
        Me.Button1.UseVisualStyleBackColor = False
        '
        'SIA
        '
        Me.SIA.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SIA.BackColor = System.Drawing.Color.White
        Me.SIA.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SIA.ForeColor = System.Drawing.Color.Maroon
        Me.SIA.Location = New System.Drawing.Point(683, 387)
        Me.SIA.Margin = New System.Windows.Forms.Padding(2)
        Me.SIA.Name = "SIA"
        Me.SIA.Size = New System.Drawing.Size(398, 237)
        Me.SIA.TabIndex = 7
        Me.SIA.Text = "Visitantes"
        Me.SIA.UseVisualStyleBackColor = False
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(1186, 654)
        Me.Controls.Add(Me.SIA)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblInstrucciones)
        Me.Controls.Add(Me.lblSIA)
        Me.Controls.Add(Me.lblcecyt)
        Me.Controls.Add(Me.lblIPN)
        Me.Controls.Add(Me.cecytlogo)
        Me.Controls.Add(Me.ipnlogo)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "S.I.A."
        CType(Me.ipnlogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cecytlogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ipnlogo As System.Windows.Forms.PictureBox
    Friend WithEvents cecytlogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblIPN As System.Windows.Forms.Label
    Friend WithEvents lblcecyt As System.Windows.Forms.Label
    Friend WithEvents lblSIA As System.Windows.Forms.Label
    Friend WithEvents lblInstrucciones As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SIA As System.Windows.Forms.Button

End Class
