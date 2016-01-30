
Public Class Principal

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblcecyt.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSIA.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SIA.Click
        Dim myfrm As New Visitantes 'Abre el formulario donde se movera el gato y el raton
        Me.Hide()
        If myfrm.ShowDialog() = Windows.Forms.DialogResult.None Then
        End If
        Me.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim myfrm As New Alumnos
        Me.Hide()
        If myfrm.ShowDialog() = Windows.Forms.DialogResult.None Then

        End If
        Me.Show()
    End Sub

    Private Sub Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
