Imports System
Imports System.IO
Public Class FormCat
    Dim v() As Integer = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
    Dim c As Integer = 0
    Dim ix As Integer
    Private Sub NWord()
        Dim l As Integer
        For l = 0 To 5
            If Count(l) = 1 Then
                Count(l) = 0
            End If
        Next


        Try
            Dim Random As New System.Random()
            Randomize()
            While c <> 1
                ix = Random.Next(0, 20)
                If Count(ix) <> 1 Then
                    c = 1
                    kl = ix
                    Count(ix) = 1
                End If
            End While
            'ix = Random Words dupa dificultate
            Word = Words(ix)
            ChArray = Word.ToCharArray
            'Cuvantul care este ales 
            Me.Visible = False
            FormWord.Visible = True
            labelWord()
            Coins = 10
            go = 0
            FormWord.btnHnt.Enabled = True
            btnVisible()
            btnEnable(True)
            FormWord.lblWrong.Text = ""
            a = 1
        Catch ex As Exception
            MsgBox("Quelque chose ne marche pas.Essayez de nouveau,s'il vous plaît!")
        End Try

    End Sub

    Private Sub FormCat_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        End
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Visible = False
        FormMain.Visible = True
    End Sub

    Private Sub btnCat1_Click(sender As Object, e As EventArgs) Handles btnCat1.Click
        FormWord.BackgroundImage = My.Resources._1
        Words = Cat1
        hints = hnts1
        FormWord.lblSubject.Text = "Catégorie: La Maison"
        If v(1) = 0 Then
            NWord()
            v(1) = 1
        Else
            Again()
            Me.Visible = False
            FormWord.Visible = True
            FormWord.btnHnt.Enabled = True
        End If
    End Sub

    Private Sub btnCat2_Click(sender As Object, e As EventArgs) Handles btnCat2.Click
        FormWord.BackgroundImage = My.Resources._2
        Words = Cat2
        hints = hnts2
        FormWord.lblSubject.Text = "Catégorie: Vêtements"
        FormWord.lblWord.ForeColor = Color.Black

        If v(2) = 0 Then
            NWord()
            v(2) = 1

        Else
            Again()
            Me.Visible = False

            FormWord.Visible = True
            FormWord.btnHnt.Enabled = True
        End If
    End Sub

    Private Sub btnCat3_Click(sender As Object, e As EventArgs) Handles btnCat3.Click
        FormWord.BackgroundImage = My.Resources._3
        Words = Cat3
        hints = hnts3
        FormWord.lblSubject.Text = "Catégorie : Fournitures "

        If v(3) = 0 Then
            NWord()
            v(3) = 1

        Else
            Again()
            FormWord.btnHnt.Enabled = True
            Me.Visible = False
            FormWord.Visible = True
        End If
    End Sub


    Private Sub btnCat4_Click(sender As Object, e As EventArgs) Handles btnCat4.Click
        FormWord.BackgroundImage = My.Resources._4
        Words = Cat4
        hints = hnts4
        FormWord.lblSubject.Text = "Catégorie : Famille "

        If v(4) = 0 Then
            NWord()
            v(4) = 1

        Else
            Again()
            Me.Visible = False
            FormWord.Visible = True
            FormWord.btnHnt.Enabled = True
        End If
    End Sub


    Private Sub btnCat5_Click(sender As Object, e As EventArgs) Handles btnCat5.Click
        FormWord.BackgroundImage = My.Resources._5
        Words = Cat5
        hints = hnts5
        FormWord.lblSubject.Text = "Catégorie : Animaux "

        If v(5) = 0 Then
            NWord()
            v(5) = 1

        Else
            Again()
            Me.Visible = False
            FormWord.Visible = True
            FormWord.btnHnt.Enabled = True
        End If
    End Sub


    Private Sub btnCat6_Click(sender As Object, e As EventArgs) Handles btnCat6.Click
        FormWord.BackgroundImage = My.Resources._6
        Words = Cat6
        hints = hnts6
        FormWord.lblSubject.Text = "Catégorie: Qualités et Défauts"

        If v(6) = 0 Then
            NWord()
            v(6) = 1

        Else
            Again()
            Me.Visible = False
            FormWord.Visible = True
            FormWord.btnHnt.Enabled = True
        End If
    End Sub

    Private Sub btncat7_Click(sender As Object, e As EventArgs) Handles btncat7.Click
        FormWord.BackgroundImage = My.Resources._7
        Words = Cat7
        hints = hnts7
        FormWord.lblSubject.Text = "Catégorie: La Cuisine"

        If v(7) = 0 Then
            NWord()
            v(7) = 1
        Else
            Again()
            Me.Visible = False
            FormWord.Visible = True
            FormWord.btnHnt.Enabled = True
        End If
    End Sub

    Private Sub btncat8_Click(sender As Object, e As EventArgs) Handles btncat8.Click
        FormWord.BackgroundImage = My.Resources._8
        Words = Cat8
        hints = hnts8
        FormWord.lblSubject.Text = "Catégorie: Pays et Capitales"

        If v(8) = 0 Then
            NWord()
            v(8) = 1
        Else
            Again()
            Me.Visible = False
            FormWord.Visible = True
            FormWord.btnHnt.Enabled = True
        End If
    End Sub

    Private Sub btncat9_Click(sender As Object, e As EventArgs) Handles btncat9.Click
        FormWord.BackgroundImage = My.Resources._9
        Words = Cat9
        hints = hnts9
        FormWord.lblSubject.Text = "Catégorie: Environnement"

        If v(9) = 0 Then
            NWord()
            v(9) = 1
        Else
            Again()
            Me.Visible = False
            FormWord.Visible = True
            FormWord.btnHnt.Enabled = True
        End If
    End Sub

    Private Sub btncat10_Click(sender As Object, e As EventArgs) Handles btncat10.Click
        FormWord.BackgroundImage = My.Resources._10
        Words = Cat10
        hints = hnts10
        FormWord.lblSubject.Text = "Catégorie: Technologie"

        FormWord.lblWord.ForeColor = Color.Black
        If v(10) = 0 Then
            NWord()
            v(10) = 1
        Else
            Again()
            Me.Visible = False
            FormWord.Visible = True
            FormWord.btnHnt.Enabled = True
        End If
    End Sub

    Private Sub btnCat1_MouseLeave(sender As Object, e As EventArgs) Handles btnCat1.MouseLeave
        Me.btnCat1.Image = My.Resources.La_maison

    End Sub
    Private Sub btnCat2_MouseLeave(sender As Object, e As EventArgs) Handles btnCat2.MouseLeave
        Me.btnCat2.Image = My.Resources.vetements

    End Sub
    Private Sub btnCat3_MouseLeave(sender As Object, e As EventArgs) Handles btnCat3.MouseLeave
        Me.btnCat3.Image = My.Resources.Fournitures


    End Sub
    Private Sub btnCat4_MouseLeave(sender As Object, e As EventArgs) Handles btnCat4.MouseLeave
        Me.btnCat4.Image = My.Resources.Famille

    End Sub
    Private Sub btnCat5_MouseLeave(sender As Object, e As EventArgs) Handles btnCat5.MouseLeave
        Me.btnCat5.Image = My.Resources.Animaux


    End Sub
    Private Sub btnCat6_MouseLeave(sender As Object, e As EventArgs) Handles btnCat6.MouseLeave
        Me.btnCat6.Image = My.Resources.Qualités_et_défauts


    End Sub
    Private Sub btnCat7_MouseLeave(sender As Object, e As EventArgs) Handles btncat7.MouseLeave
        Me.btncat7.Image = My.Resources.La_cuisine


    End Sub
    Private Sub btnCat8_MouseLeave(sender As Object, e As EventArgs) Handles btncat8.MouseLeave
        Me.btncat8.Image = My.Resources.Pays_et_capitales

    End Sub
    Private Sub btnCat9_MouseLeave(sender As Object, e As EventArgs) Handles btncat9.MouseLeave
        Me.btncat9.Image = My.Resources.Environnement


    End Sub
    Private Sub btnCat10_MouseLeave(sender As Object, e As EventArgs) Handles btncat10.MouseLeave
        Me.btncat10.Image = My.Resources.Technologie


    End Sub
    Private Sub btnCat1_MouseEnter(sender As Object, e As EventArgs) Handles btnCat1.MouseEnter
        Me.btnCat1.Image = My.Resources.La_maison1

    End Sub
    Private Sub btnCat2_MouseEnter(sender As Object, e As EventArgs) Handles btnCat2.MouseEnter
        Me.btnCat2.Image = My.Resources.vetements1

    End Sub
    Private Sub btnCat3_MouseEnter(sender As Object, e As EventArgs) Handles btnCat3.MouseEnter
        Me.btnCat3.Image = My.Resources.Fournitures1


    End Sub
    Private Sub btnCat4_MouseEnter(sender As Object, e As EventArgs) Handles btnCat4.MouseEnter
        Me.btnCat4.Image = My.Resources.Famille1

    End Sub
    Private Sub btnCat5_MouseEnter(sender As Object, e As EventArgs) Handles btnCat5.MouseEnter
        Me.btnCat5.Image = My.Resources.Animaux1


    End Sub
    Private Sub btnCat6_MouseEnter(sender As Object, e As EventArgs) Handles btnCat6.MouseEnter
        Me.btnCat6.Image = My.Resources.Qualités_et_défauts1


    End Sub
    Private Sub btnCat7_MouseEnter(sender As Object, e As EventArgs) Handles btncat7.MouseEnter
        Me.btncat7.Image = My.Resources.La_cuisine1


    End Sub
    Private Sub btnCat8_MouseEnter(sender As Object, e As EventArgs) Handles btncat8.MouseEnter
        Me.btncat8.Image = My.Resources.Pays_et_capitales1

    End Sub
    Private Sub btnCat9_MouseEnter(sender As Object, e As EventArgs) Handles btncat9.MouseEnter
        Me.btncat9.Image = My.Resources.Environnement1


    End Sub
    Private Sub btnCat10_MouseEnter(sender As Object, e As EventArgs) Handles btncat10.MouseEnter
        Me.btncat10.Image = My.Resources.Technologie1


    End Sub



    Private Sub btnBack_MouseEnter(sender As Object, e As EventArgs) Handles btnBack.MouseEnter
        Me.btnBack.Image = My.Resources.arriere1
    End Sub

    Private Sub btnBack_MouseLeave(sender As Object, e As EventArgs) Handles btnBack.MouseLeave
        Me.btnBack.Image = My.Resources.arriere

    End Sub
End Class