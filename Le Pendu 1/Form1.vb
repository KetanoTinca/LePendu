Public Class FormMain

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        End
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Me.Visible = False
        FormCat.Visible = True
    End Sub

    Private Sub btnQuit_MouseEnter(sender As Object, e As EventArgs) Handles btnQuit.MouseEnter
        Me.btnQuit.Image = My.Resources.omolog_Sortie

    End Sub
    Private Sub btnQuit_MouseLeave(sender As Object, e As EventArgs) Handles btnQuit.MouseLeave
        Me.btnQuit.Image = My.Resources.Sortie

    End Sub

    Private Sub btnPlay_MouseEnter(sender As Object, e As EventArgs) Handles btnPlay.MouseEnter
        Me.btnPlay.Image = My.Resources.omolog_Joue

    End Sub
    Private Sub btnPlay_MouseLeave(sender As Object, e As EventArgs) Handles btnPlay.MouseLeave
        Me.btnPlay.Image = My.Resources.Joue

    End Sub
End Class
