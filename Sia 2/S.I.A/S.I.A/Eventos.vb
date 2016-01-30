Public Class Eventos

    Private Sub Eventos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        infDep.Visible = False
        InfCult.Visible = False

    End Sub

    
    Private Sub btDep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btDep.Click
        infDep.Visible = True
        InfCult.Visible = False
    End Sub

    Private Sub btCult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCult.Click
        InfCult.Visible = True
        infDep.Visible = False
    End Sub
End Class