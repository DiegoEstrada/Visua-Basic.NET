Public Class Form2
    Dim t As Integer
    Dim u As Integer
    Dim m As Integer
    Private NoDiscos As Short
    Private Disco() As Label 'Arreglo dinámico de label's.
    Private NoObjPrevios As Integer = 9 'Numero de controles existentes en tiempo de diseño.
    Private Mover As Boolean
    Private D As Label
    Private index As Integer
    Private _disco As Label
    'Declaración de nuevas variables.
    Private DiscosA() As Integer, DiscosB() As Integer, DiscosC() As Integer
    Private ND_TA As Integer, ND_TB As Integer, ND_TC As Integer
    Private TorreO As Integer, TorreD As Integer
    Private PosOrigX As Integer, PosOrigY As Integer

    Private Sub Form1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DoubleClick
        u = Val(Form1.txtNoDiscos.Text)
        CargarDiscos(u)
        Timer1.Enabled = True
    End Sub

    Public Sub CargarDiscos(ByVal n As Integer)
        Dim i As Short
        Dim ancho As Integer, pm As Integer
        pm = PosteA.Left + PosteA.Width / 2
        NoDiscos = n - 1
        ReDim Disco(n)
        ReDim DiscosA(n)
        For i = 0 To (u - 1)
            ancho = ancho + 30
        Next
        'Cargar Label's en tiempo de ejecución
        For i = 0 To (u - 1)
            D = New Label
            D.AutoSize = False
            AsignaColor(i + 1, D)
            D.Size = New Size(ancho, 12)
            D.Location = New Point(pm - ancho / 2, BaseA.Top - 20 * (i + 1))
            D.Visible = True
            D.Tag = i + 1
            AddHandler D.MouseLeave, AddressOf FueraDelDisco
            AddHandler D.MouseDown, AddressOf PresionaRaton
            AddHandler D.MouseUp, AddressOf SoltarRaton
            AddHandler D.MouseMove, AddressOf MoverRaton
            Me.Controls.Add(D)
            Disco(i) = Controls(i + NoObjPrevios)
            DiscosA(i) = i + 1
            ancho = ancho - 30
        Next
        'Inicializar nuevas variables.
        TorreO = 1 : TorreD = TorreO
        ND_TA = n : ND_TB = 0 : ND_TC = 0
    End Sub

    Private Sub AsignaColor(ByVal sColor As Integer, ByVal label As Label)
        Select Case sColor
            Case 1 : label.BackColor = Color.Yellow
            Case 2 : label.BackColor = Color.Blue
            Case 3 : label.BackColor = Color.Brown
            Case 4 : label.BackColor = Color.Gray
            Case 5 : label.BackColor = Color.Green
            Case 6 : label.BackColor = Color.Orange
            Case 7 : label.BackColor = Color.Pink
            Case 8 : label.BackColor = Color.Red
            Case 9 : label.BackColor = Color.Black
            Case 10 : label.BackColor = Color.Silver
            Case 11 : label.BackColor = Color.Purple
            Case 12 : label.BackColor = Color.Lime
            Case 13 : label.BackColor = Color.Violet
            Case 14 : label.BackColor = Color.Aqua
            Case 15 : label.BackColor = Color.Azure
        End Select
    End Sub

    Private Sub FueraDelDisco(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub PresionaRaton(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim D As Label
        D = sender
        Me.Cursor = Cursors.Hand
        'Identificar la torre de Origen.
        If (D.Left + D.Width) < PosteB.Left Then
            TorreO = 1 : TorreD = TorreO
        ElseIf (D.Left + D.Width) < PosteC.Left Then
            TorreO = 2 : TorreD = TorreO
        Else
            TorreO = 3 : TorreD = TorreO
        End If
        'Ver si estoy seleccionando el disco de arriba.
        Select Case TorreO
            Case 1
                If DiscosA(ND_TA - 1) = Val(D.Tag) Then
                    Mover = True 'Temporal
                End If
            Case 2
                If DiscosB(ND_TB - 1) = Val(D.Tag) Then
                    Mover = True 'Temporal
                End If
            Case 3
                If DiscosC(ND_TC - 1) = Val(D.Tag) Then
                    Mover = True 'Temporal
                End If
        End Select
        PosOrigX = D.Left : PosOrigY = D.Top
    End Sub

    Private Sub SoltarRaton(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim D As Label
        Dim MovValido As Boolean
        D = sender
        Me.Cursor = Cursors.Default
        'Si el movimiento estaba permitido, identificar en que torre solto.
        If Mover = True Then
            Mover = False
            'Identificar la torre de destino.
            If (D.Left + D.Width) < PosteB.Left Then
                TorreD = 1
            ElseIf (D.Left + D.Width) < PosteC.Left Then
                TorreD = 2
            Else
                TorreD = 3
            End If
        End If
        'Ver que solto en torres diferentes.
        If TorreO <> TorreD Then
            'El movimiento es válido.
            MovValido = False  '***************************************************************************************************
            Select Case TorreD
                Case 1
                    If ND_TA > 0 Then
                        If DiscosA(ND_TA - 1) < D.Tag Then
                            MovValido = True
                        End If
                    Else
                        MovValido = True
                    End If
                Case 2
                    If ND_TB > 0 Then
                        If DiscosB(ND_TB - 1) < D.Tag Then
                            MovValido = True
                        End If
                    Else
                        MovValido = True
                    End If
                Case 3
                    If ND_TC > 0 Then
                        If DiscosC(ND_TC - 1) < D.Tag Then
                            MovValido = True
                        End If
                    Else
                        MovValido = True
                    End If
            End Select
            If MovValido = True Then
                Select Case TorreO
                    Case 1 : ND_TA = ND_TA - 1 : ReDim Preserve DiscosA(ND_TA)
                    Case 2 : ND_TB = ND_TB - 1 : ReDim Preserve DiscosB(ND_TB)
                    Case 3 : ND_TC = ND_TC - 1 : ReDim Preserve DiscosC(ND_TC)
                End Select
                Select Case TorreD
                    Case 1 : ND_TA = ND_TA + 1 : ReDim Preserve DiscosA(ND_TA) : DiscosA(ND_TA - 1) = D.Tag
                        Call ColocarDiscoAutomatico(D, 1, ND_TA)
                    Case 2 : ND_TB = ND_TB + 1 : ReDim Preserve DiscosB(ND_TB) : DiscosB(ND_TB - 1) = D.Tag
                        Call ColocarDiscoAutomatico(D, 2, ND_TB)
                    Case 3 : ND_TC = ND_TC + 1 : ReDim Preserve DiscosC(ND_TC) : DiscosC(ND_TC - 1) = D.Tag
                        Call ColocarDiscoAutomatico(D, 3, ND_TC)
                End Select
            Else
                D.Left = PosOrigX : D.Top = PosOrigY
            End If
        Else
            D.Left = PosOrigX : D.Top = PosOrigY
        End If
        If MovValido = True Then
            m = m + 1
        End If
        If ND_TA = 0 And ND_TC = u Then
            MsgBox("Acabaste en  " & Val(t) & "  segundos")
            MsgBox("Acabaste en  " & Val(m) & "  Movimintos")
        End If
    End Sub

    Private Sub MoverRaton(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim index As Integer
        Dim D As Label
        D = sender
        index = Val(D.Tag) - 1
        If Mover = True Then
            Disco(index).Left = Disco(index).Left + e.X
            Disco(index).Top = Disco(index).Top + e.Y
        End If
    End Sub

    Private Sub ColocarDiscoAutomatico(ByRef d As Label, ByVal T As Integer, ByVal i As Integer)
        Dim base As Integer
        Select Case T
            Case 1 : base = BaseA.Top
            Case 2 : base = BaseB.Top
            Case 3 : base = BaseC.Top
        End Select
        base = base - 20 * i
        d.Top = base
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        t = t + 1
    End Sub
End Class
