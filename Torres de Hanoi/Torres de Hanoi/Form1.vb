Public Class Form1

    Private Sub BtAPorEl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtAPorEl.Click
        Dim myFrm As New Form2
        Me.Hide()
        If myFrm.ShowDialog() = DialogResult.None Then
        End If
        Me.Show()
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class