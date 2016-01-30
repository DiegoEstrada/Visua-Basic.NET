Imports MySql.Data.MySqlClient
Public Class Horario
    Dim conex As New MySqlConnection("data source=localhost;user id=root; password=admin;database=sia")
    Dim da As MySqlDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Private Sub Horario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call Mostrar()

    End Sub
    Private Sub Mostrar()
        Try
            sql = "SELECT profesor.Nombre_Profesor,profesor.Materia, grupo.id_Grupo, relacion.Dia, relacion.Hora, relacion.id_Salon FROM profesor,grupo, relacion, salon Where relacion.id_Grupo = grupo.id_Grupo and relacion.Clave_Profesor = profesor.Clave_Profesor and salon.id_Salon = relacion.id_Salon and grupo.id_Grupo like '6IM12' "
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox("Error")

        End Try
    End Sub

    Private Sub DataGridView1_RowEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.RowEnter
        sql = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()
    End Sub
End Class