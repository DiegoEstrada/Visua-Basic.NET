Imports MySql.Data.MySqlClient
Public Class Alumnos
    Public devuelveme As Boolean
    Dim conex As New MySqlConnection("data source=localhost;user id=root; password=admin;database=sia")
    Dim da As MySqlDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Dim consu As String
    Public ma As Integer


    Dim comando As MySqlCommand

    Private Sub Alumnos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GroupBox1.Visible = False
        gpDia.Visible = False

    End Sub
    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RadioButton3_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RPA.CheckedChanged

    End Sub

    Private Sub btRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btRegresar.Click
        Dim myfrm As New Principal
        Me.Hide()
        If myfrm.ShowDialog() = Windows.Forms.DialogResult.None Then
        End If
        Me.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        GroupBox1.Visible = True
        gpDia.Visible = True

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cultu.Click
        Dim myfrm As New Eventos
        Me.Hide()
        GroupBox1.Visible = False
        gpDia.Visible = False
        If myfrm.ShowDialog() = Windows.Forms.DialogResult.None Then
        End If
        Me.Show()


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim myfrm As New Documentos  'Abre el formulario donde se movera el gato y el raton
        Me.Hide()
        If myfrm.ShowDialog() = Windows.Forms.DialogResult.None Then
        End If
        Me.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim myfrm As New Eventos
        Me.Hide()
        If myfrm.ShowDialog() = Windows.Forms.DialogResult.None Then

        End If
        Me.Show()
    End Sub

    Private Sub HP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HP.Click
        If JCR.Checked = True Then
            If Lunes.Checked = True Then
                ma = 1
            Else
                If Martes.Checked = True Then
                    ma = 2
                Else
                    If Miercoles.Checked = True Then
                        ma = 3
                    Else
                        If Jueves.Checked = True Then
                            ma = 4
                        Else
                            If Viernes.Checked = True Then
                                ma = 5
                            End If
                        End If
                    End If
                End If

            End If
        End If
        If GNI.Checked = True Then
            If Lunes.Checked = True Then
                ma = 6
            Else
                If Martes.Checked = True Then
                    ma = 7
                Else
                    If Miercoles.Checked = True Then
                        ma = 8
                    Else
                        If Jueves.Checked = True Then
                            ma = 9
                        Else
                            If Viernes.Checked = True Then
                                ma = 10
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If RPA.Checked = True Then
            If Lunes.Checked = True Then
                ma = 11
            Else
                If Martes.Checked = True Then
                    ma = 12
                Else
                    If Miercoles.Checked Then
                        ma = 13
                    Else
                        If Jueves.Checked Then
                            ma = 14
                        Else
                            If Viernes.Checked = True Then
                                ma = 15
                            End If
                        End If
                    End If

                End If
            End If
        End If
        If MCR.Checked = True Then
            If Lunes.Checked = True Then
                ma = 16
            Else
                If Martes.Checked = True Then
                    ma = 17
                Else
                    If Miercoles.Checked = True Then
                        ma = 18
                    Else
                        If Jueves.Checked = True Then
                            ma = 19
                        Else
                            If Viernes.Checked = True Then
                                ma = 20
                            End If
                        End If
                    End If

                End If
            End If
        End If
        Call mostrar()

    End Sub
    Private Sub mostrar()
        Try
            Select Case ma
                Case 1 : sql = "SELECT profesor.Nombre_Profesor,profesor.Materia, grupo.id_Grupo, relacion.Dia, relacion.Hora, relacion.id_Salon FROM profesor,grupo, relacion, salon Where relacion.id_Grupo = grupo.id_Grupo and relacion.Clave_Profesor = profesor.Clave_Profesor and salon.id_Salon = relacion.id_Salon and profesor.Nombre_Profesor like 'Javier Carrillo Rodriguez' and relacion.Dia like 'Lunes' ORDER BY relacion.Hora "
                Case 2 : sql = "SELECT profesor.Nombre_Profesor,profesor.Materia, grupo.id_Grupo, relacion.Dia, relacion.Hora, relacion.id_Salon FROM profesor,grupo, relacion, salon Where relacion.id_Grupo = grupo.id_Grupo and relacion.Clave_Profesor = profesor.Clave_Profesor and salon.id_Salon = relacion.id_Salon and profesor.Nombre_Profesor like 'Javier Carrillo Rodriguez' and relacion.Dia like 'Martes' ORDER BY relacion.Hora "
                Case 3 : sql = "SELECT profesor.Nombre_Profesor,profesor.Materia, grupo.id_Grupo, relacion.Dia, relacion.Hora, relacion.id_Salon FROM profesor,grupo, relacion, salon Where relacion.id_Grupo = grupo.id_Grupo and relacion.Clave_Profesor = profesor.Clave_Profesor and salon.id_Salon = relacion.id_Salon and profesor.Nombre_Profesor like 'Javier Carrillo Rodriguez' and relacion.Dia like 'Miercoles' ORDER BY relacion.Hora "
                Case 4 : sql = "SELECT profesor.Nombre_Profesor,profesor.Materia, grupo.id_Grupo, relacion.Dia, relacion.Hora, relacion.id_Salon FROM profesor,grupo, relacion, salon Where relacion.id_Grupo = grupo.id_Grupo and relacion.Clave_Profesor = profesor.Clave_Profesor and salon.id_Salon = relacion.id_Salon and profesor.Nombre_Profesor like 'Javier Carrillo Rodriguez' and relacion.Dia like 'Jueves' ORDER BY relacion.Hora "
                Case 5 : sql = "SELECT profesor.Nombre_Profesor,profesor.Materia, grupo.id_Grupo, relacion.Dia, relacion.Hora, relacion.id_Salon FROM profesor,grupo, relacion, salon Where relacion.id_Grupo = grupo.id_Grupo and relacion.Clave_Profesor = profesor.Clave_Profesor and salon.id_Salon = relacion.id_Salon and profesor.Nombre_Profesor like 'Javier Carrillo Rodriguez' and relacion.Dia like 'Viernes' ORDER BY relacion.Hora "
                Case 6 : sql = "SELECT profesor.Nombre_Profesor,profesor.Materia, grupo.id_Grupo, relacion.Dia, relacion.Hora, relacion.id_Salon FROM profesor,grupo, relacion, salon Where relacion.id_Grupo = grupo.id_Grupo and relacion.Clave_Profesor = profesor.Clave_Profesor and salon.id_Salon = relacion.id_Salon and profesor.Nombre_Profesor like 'Maria Guadalupe Nava Ibarra' and relacion.Dia like 'Lunes' ORDER BY relacion.Hora "
                Case 7 : sql = "SELECT profesor.Nombre_Profesor,profesor.Materia, grupo.id_Grupo, relacion.Dia, relacion.Hora, relacion.id_Salon FROM profesor,grupo, relacion, salon Where relacion.id_Grupo = grupo.id_Grupo and relacion.Clave_Profesor = profesor.Clave_Profesor and salon.id_Salon = relacion.id_Salon and profesor.Nombre_Profesor like 'Maria Guadalupe Nava Ibarra' and relacion.Dia like 'Martes' ORDER BY relacion.Hora "
                Case 8 : sql = "SELECT profesor.Nombre_Profesor,profesor.Materia, grupo.id_Grupo, relacion.Dia, relacion.Hora, relacion.id_Salon FROM profesor,grupo, relacion, salon Where relacion.id_Grupo = grupo.id_Grupo and relacion.Clave_Profesor = profesor.Clave_Profesor and salon.id_Salon = relacion.id_Salon and profesor.Nombre_Profesor like 'Maria Guadalupe Nava Ibarra' and relacion.Dia like 'Miercoles' ORDER BY relacion.Hora "
                Case 9 : sql = "SELECT profesor.Nombre_Profesor,profesor.Materia, grupo.id_Grupo, relacion.Dia, relacion.Hora, relacion.id_Salon FROM profesor,grupo, relacion, salon Where relacion.id_Grupo = grupo.id_Grupo and relacion.Clave_Profesor = profesor.Clave_Profesor and salon.id_Salon = relacion.id_Salon and profesor.Nombre_Profesor like 'Maria Guadalupe Nava Ibarra' and relacion.Dia like 'Jueves' ORDER BY relacion.Hora "
                Case 10 : sql = "SELECT profesor.Nombre_Profesor,profesor.Materia, grupo.id_Grupo, relacion.Dia, relacion.Hora, relacion.id_Salon FROM profesor,grupo, relacion, salon Where relacion.id_Grupo = grupo.id_Grupo and relacion.Clave_Profesor = profesor.Clave_Profesor and salon.id_Salon = relacion.id_Salon and profesor.Nombre_Profesor like 'Maria Guadalupe Nava Ibarra' and relacion.Dia like 'Viernes' ORDER BY relacion.Hora "
                Case 11 : sql = "SELECT profesor.Nombre_Profesor,profesor.Materia, grupo.id_Grupo, relacion.Dia, relacion.Hora, relacion.id_Salon FROM profesor,grupo, relacion, salon Where relacion.id_Grupo = grupo.id_Grupo and relacion.Clave_Profesor = profesor.Clave_Profesor and salon.id_Salon = relacion.id_Salon and profesor.Nombre_Profesor like 'Rosa Maria Perez Angeles' and relacion.Dia like 'Lunes' ORDER BY relacion.Hora "
                Case 12 : sql = "SELECT profesor.Nombre_Profesor,profesor.Materia, grupo.id_Grupo, relacion.Dia, relacion.Hora, relacion.id_Salon FROM profesor,grupo, relacion, salon Where relacion.id_Grupo = grupo.id_Grupo and relacion.Clave_Profesor = profesor.Clave_Profesor and salon.id_Salon = relacion.id_Salon and profesor.Nombre_Profesor like 'Rosa Maria Perez Angeles' and relacion.Dia like 'Martes' ORDER BY relacion.Hora "
                Case 13 : sql = "SELECT profesor.Nombre_Profesor,profesor.Materia, grupo.id_Grupo, relacion.Dia, relacion.Hora, relacion.id_Salon FROM profesor,grupo, relacion, salon Where relacion.id_Grupo = grupo.id_Grupo and relacion.Clave_Profesor = profesor.Clave_Profesor and salon.id_Salon = relacion.id_Salon and profesor.Nombre_Profesor like 'Rosa Maria Perez Angeles' and relacion.Dia like 'Miercoles' ORDER BY relacion.Hora "
                Case 14 : sql = "SELECT profesor.Nombre_Profesor,profesor.Materia, grupo.id_Grupo, relacion.Dia, relacion.Hora, relacion.id_Salon FROM profesor,grupo, relacion, salon Where relacion.id_Grupo = grupo.id_Grupo and relacion.Clave_Profesor = profesor.Clave_Profesor and salon.id_Salon = relacion.id_Salon and profesor.Nombre_Profesor like 'Rosa Maria Perez Angeles' and relacion.Dia like 'Jueves' ORDER BY relacion.Hora "
                Case 15 : sql = "SELECT profesor.Nombre_Profesor,profesor.Materia, grupo.id_Grupo, relacion.Dia, relacion.Hora, relacion.id_Salon FROM profesor,grupo, relacion, salon Where relacion.id_Grupo = grupo.id_Grupo and relacion.Clave_Profesor = profesor.Clave_Profesor and salon.id_Salon = relacion.id_Salon and profesor.Nombre_Profesor like 'Rosa Maria Perez Angeles' and relacion.Dia like 'Viernes' ORDER BY relacion.Hora "
                Case 16 : sql = "SELECT profesor.Nombre_Profesor,profesor.Materia, grupo.id_Grupo, relacion.Dia, relacion.Hora, relacion.id_Salon FROM profesor,grupo, relacion, salon Where relacion.id_Grupo = grupo.id_Grupo and relacion.Clave_Profesor = profesor.Clave_Profesor and salon.id_Salon = relacion.id_Salon and profesor.Nombre_Profesor like 'Miroslava Cardenas Rivera' and relacion.Dia like 'Lunes' ORDER BY relacion.Hora "
                Case 17 : sql = "SELECT profesor.Nombre_Profesor,profesor.Materia, grupo.id_Grupo, relacion.Dia, relacion.Hora, relacion.id_Salon FROM profesor,grupo, relacion, salon Where relacion.id_Grupo = grupo.id_Grupo and relacion.Clave_Profesor = profesor.Clave_Profesor and salon.id_Salon = relacion.id_Salon and profesor.Nombre_Profesor like 'Miroslava Cardenas Rivera' and relacion.Dia like 'Martes' ORDER BY relacion.Hora "
                Case 18 : sql = "SELECT profesor.Nombre_Profesor,profesor.Materia, grupo.id_Grupo, relacion.Dia, relacion.Hora, relacion.id_Salon FROM profesor,grupo, relacion, salon Where relacion.id_Grupo = grupo.id_Grupo and relacion.Clave_Profesor = profesor.Clave_Profesor and salon.id_Salon = relacion.id_Salon and profesor.Nombre_Profesor like 'Miroslava Cardenas Rivera' and relacion.Dia like 'Miercoles' ORDER BY relacion.Hora "
                Case 19 : sql = "SELECT profesor.Nombre_Profesor,profesor.Materia, grupo.id_Grupo, relacion.Dia, relacion.Hora, relacion.id_Salon FROM profesor,grupo, relacion, salon Where relacion.id_Grupo = grupo.id_Grupo and relacion.Clave_Profesor = profesor.Clave_Profesor and salon.id_Salon = relacion.id_Salon and profesor.Nombre_Profesor like 'Miroslava Cardenas Rivera' and relacion.Dia like 'Jueves' ORDER BY relacion.Hora "
                Case 20 : sql = "SELECT profesor.Nombre_Profesor,profesor.Materia, grupo.id_Grupo, relacion.Dia, relacion.Hora, relacion.id_Salon FROM profesor,grupo, relacion, salon Where relacion.id_Grupo = grupo.id_Grupo and relacion.Clave_Profesor = profesor.Clave_Profesor and salon.id_Salon = relacion.id_Salon and profesor.Nombre_Profesor like 'Miroslava Cardenas Rivera' and relacion.Dia like 'Viernes' ORDER BY relacion.Hora "
            End Select
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox("Error")

        End Try
    End Sub

    Private Sub Datos_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.RowEnter
        sql = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class