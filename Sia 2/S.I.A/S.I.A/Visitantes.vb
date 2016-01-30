Public Class Visitantes
    Dim color As Integer
    Private Sub GroupBox1_Enter(sender As System.Object, e As System.EventArgs)
    End Sub

    Private Sub RadioButton54_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles P3.CheckedChanged
    End Sub

    Private Sub Visitantes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        GPSalonesA.Visible = False
        GPSalonesB.Visible = False
        GPSalonesC.Visible = False
        GPProvisionales.Visible = False
        btcolor.Visible = False
        btcolor2.Visible = False
        Timer1.Enabled = True

    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles btcontinuarprovisional.Click

    End Sub

    Private Sub RadioButton24_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdbA.CheckedChanged

    End Sub
    Private Sub RadioButton33_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles A11.CheckedChanged

    End Sub

    Private Sub btContinuarPrincipal_Click(sender As System.Object, e As System.EventArgs) Handles btContinuarPrincipal.Click
        If rdbA.Checked = True Then
            GPSalonesA.Visible = True
            GPSalonesB.Visible = False
            GPSalonesC.Visible = False
            GPProvisionales.Visible = False
            btcolor.Top = 340
            btcolor.Left = 1026
            btcolor.Visible = True
            btcolor2.Visible = False

        Else
            If rdbB.Checked = True Then
                GPSalonesB.Visible = True
                GPSalonesA.Visible = False
                GPSalonesC.Visible = False
                GPProvisionales.Visible = False
                btcolor.Top = 344
                btcolor.Left = 926
                btcolor.Visible = True
                btcolor2.Visible = False
            Else
                If rdbC.Checked = True Then
                    GPSalonesC.Visible = True
                    GPSalonesA.Visible = False
                    GPSalonesB.Visible = False
                    GPProvisionales.Visible = False
                    btcolor.Top = 322
                    btcolor.Left = 871
                    btcolor.Visible = True
                    btcolor2.Visible = False
                Else
                    If rdbProvisionales.Checked = True Then
                        GPProvisionales.Visible = True
                        GPSalonesA.Visible = False
                        GPSalonesB.Visible = False
                        GPSalonesC.Visible = False
                        btcolor.Top = 313
                        btcolor.Left = 963
                        btcolor.Visible = True
                        btcolor2.Visible = False
                    Else
                        If rdbBaños.Checked = True Then
                            GPProvisionales.Visible = False
                            GPSalonesA.Visible = False
                            GPSalonesB.Visible = False
                            GPSalonesC.Visible = False
                            btcolor.Top = 340
                            btcolor.Left = 1005
                            btcolor.Visible = True
                            btcolor2.Top = 340
                            btcolor2.Left = 946
                            btcolor2.Visible = True

                        Else
                            If rdbAuditorio.Checked = True Then
                                GPProvisionales.Visible = False
                                GPSalonesA.Visible = False
                                GPSalonesB.Visible = False
                                GPSalonesC.Visible = False
                                btcolor2.Visible = False
                                btcolor.Top = 463
                                btcolor.Left = 905
                                btcolor.Visible = True
                            Else
                                If rdbEnfermeria.Checked = True Then
                                    GPProvisionales.Visible = False
                                    GPSalonesA.Visible = False
                                    GPSalonesB.Visible = False
                                    GPSalonesC.Visible = False
                                    btcolor2.Visible = False
                                    btcolor.Top = 403
                                    btcolor.Left = 976
                                    btcolor.Visible = True
                                Else
                                    If rdbCafe.Checked = True Then
                                        GPProvisionales.Visible = False
                                        GPSalonesA.Visible = False
                                        GPSalonesB.Visible = False
                                        GPSalonesC.Visible = False
                                        btcolor2.Visible = False
                                        btcolor.Top = 407
                                        btcolor.Left = 876
                                        btcolor.Visible = True
                                    Else
                                        If rdbBiblioteca.Checked = True Then
                                            GPProvisionales.Visible = False
                                            GPSalonesA.Visible = False
                                            GPSalonesB.Visible = False
                                            GPSalonesC.Visible = False
                                            btcolor2.Visible = False
                                            btcolor.Top = 389
                                            btcolor.Left = 975
                                            btcolor.Visible = True
                                        Else
                                            If rdbAcademias.Checked = True Then
                                                GPProvisionales.Visible = False
                                                GPSalonesA.Visible = False
                                                GPSalonesB.Visible = False
                                                GPSalonesC.Visible = False
                                                btcolor2.Visible = False
                                                btcolor.Top = 389
                                                btcolor.Left = 975
                                                btcolor.Visible = True
                                            Else
                                                If rdbTallerDibujo.Checked = True Then
                                                    GPProvisionales.Visible = False
                                                    GPSalonesA.Visible = False
                                                    GPSalonesB.Visible = False
                                                    GPSalonesC.Visible = False
                                                    btcolor2.Visible = False
                                                    btcolor.Top = 428
                                                    btcolor.Left = 969
                                                    btcolor.Visible = True
                                                Else
                                                    If rdbLabCompu.Checked = True Then
                                                        GPProvisionales.Visible = False
                                                        GPSalonesA.Visible = False
                                                        GPSalonesB.Visible = False
                                                        GPSalonesC.Visible = False
                                                        btcolor2.Visible = False
                                                        btcolor.Top = 357
                                                        btcolor.Left = 922
                                                        btcolor.Visible = True
                                                    Else
                                                        If rdbGobierno.Checked = True Then
                                                            GPProvisionales.Visible = False
                                                            GPSalonesA.Visible = False
                                                            GPSalonesB.Visible = False
                                                            GPSalonesC.Visible = False
                                                            btcolor2.Visible = False
                                                            btcolor.Top = 462
                                                            btcolor.Left = 1034
                                                            btcolor.Visible = True
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                End If
            End If
            End If
        End If
    End Sub

    Private Sub P1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles P1.CheckedChanged

    End Sub

    Private Sub btRegresar_Click(sender As System.Object, e As System.EventArgs) Handles btRegresar.Click
        Dim myfrm As New Principal 'Abre el formulario
        Me.Hide()
        If myfrm.ShowDialog() = Windows.Forms.DialogResult.None Then

        End If
        Me.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        color = CInt(Int((6 * Rnd()) + 1))

        Select Case (color)
            Case 0 : btcolor.BackColor = Drawing.Color.BlueViolet : btcolor2.BackColor = Drawing.Color.White
            Case 1 : btcolor.BackColor = Drawing.Color.Red : btcolor2.BackColor = Drawing.Color.OrangeRed
            Case 2 : btcolor.BackColor = Drawing.Color.Cyan : btcolor2.BackColor = Drawing.Color.OrangeRed
            Case 3 : btcolor.BackColor = Drawing.Color.Coral : btcolor2.BackColor = Drawing.Color.OrangeRed
            Case 4 : btcolor.BackColor = Drawing.Color.OrangeRed : btcolor2.BackColor = Drawing.Color.Coral
            Case 5 : btcolor.BackColor = Drawing.Color.Yellow : btcolor2.BackColor = Drawing.Color.Cyan
            Case 6 : btcolor.BackColor = Drawing.Color.White : btcolor2.BackColor = Drawing.Color.BlueViolet
        End Select
    End Sub

    Private Sub btDocumentos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btDocumentos.Click
        Dim myfrm As New Documentos
        Me.Hide()
        If myfrm.ShowDialog() = Windows.Forms.DialogResult.None Then
        End If
        Me.Show()
    End Sub

    Private Sub btHorarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btHorarios.Click
        Dim myfrm As New Horario 'Abre el formulario donde se movera el gato y el raton
        Me.Hide()
        If myfrm.ShowDialog() = Windows.Forms.DialogResult.None Then
        End If
        Me.Show()
    End Sub
End Class