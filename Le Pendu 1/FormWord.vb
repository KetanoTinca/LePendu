Imports System
Imports System.IO
Public Class FormWord
    Dim CuvCorect As Integer = 0
    Dim CatCorect As Integer = 0
    Dim pd As Integer = 0
    Dim cat As Integer
    Dim bttnX As Button
    Dim yes As Integer = 0

    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Short

    Private Sub CheckButt(z As Char)
        If z = "A" Then
            bttnX = btnA
        ElseIf z = "B" Then
            bttnX = btnB
        ElseIf z = "C" Then
            bttnX = btnC
        ElseIf z = "D" Then
            bttnX = btnD
        ElseIf z = "E" Then
            bttnX = btnE
        ElseIf z = "F" Then
            bttnX = btnF
        ElseIf z = "G" Then
            bttnX = btnG
        ElseIf z = "H" Then
            bttnX = btnH
        ElseIf z = "I" Then
            bttnX = btnI
        ElseIf z = "J" Then
            bttnX = btnJ
        ElseIf z = "K" Then
            bttnX = btnK
        ElseIf z = "L" Then
            bttnX = btnL
        ElseIf z = "M" Then
            bttnX = btnM
        ElseIf z = "N" Then
            bttnX = btnN
        ElseIf z = "O" Then
            bttnX = btnO
        ElseIf z = "P" Then
            bttnX = btnP
        ElseIf z = "Q" Then
            bttnX = btnQ
        ElseIf z = "R" Then
            bttnX = btnR
        ElseIf z = "S" Then
            bttnX = btnS
        ElseIf z = "T" Then
            bttnX = btnT
        ElseIf z = "U" Then
            bttnX = btnU
        ElseIf z = "V" Then
            bttnX = btnV
        ElseIf z = "W" Then
            bttnX = btnW
        ElseIf z = "X" Then
            bttnX = bttnX
        ElseIf z = "Y" Then
            bttnX = btnY
        ElseIf z = "Z" Then
            bttnX = btnZ
        End If
    End Sub

    Private Sub CheckImage()
        Dim cuvant As Integer
        If a = 1 Then
            PicHangman.Image = My.Resources.sfoara1
        ElseIf a = 2 Then
            PicHangman.Image = My.Resources.corp
        ElseIf a = 3 Then
            PicHangman.Image = My.Resources.md
        ElseIf a = 4 Then
            PicHangman.Image = My.Resources.ms
        ElseIf a = 5 Then
            PicHangman.Image = My.Resources.pd
        ElseIf a = 6 Then
            PicHangman.Image = My.Resources.ps
            lblWord.Text = ""
            For cuvant = 0 To Word.Length - 1
                lblWord.Text += Word(cuvant) + " "
            Next
            If MessageBox.Show("Tu es mort! Desole!", "Le Pendu") = MsgBoxResult.Ok Then
                If MessageBox.Show("Voulez-vous choisir une autre catégorie?", "Le Pendu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Me.Visible = False
                    FormCat.Visible = True
                    CuvCorect = 0
                    go = 1
                    PicHangman.Image = My.Resources.sfoara_fara_cap
                Else
                    lblWrong.Text = ""
                    Again()
                    a = 0
                    pd = 0
                    CuvCorect = 0
                    Coins = 10
                    lblCoins.Text = "Crédit:" + CStr(Coins)
                End If
            End If
        End If
        a += 1
    End Sub

    Private Sub CheckChar(Ch As Char, btn As Button)
        Dim i As Integer
        If go = 0 Then
            If pd = 0 Then
                btn.Visible = False
            Else
                pd = 0
            End If

            If Word.Contains(Ch) Then
                yes = 1
                lblWord.Text = ""
                lblWord.Text = Word(0)
                For i = 1 To Word.Length - 1
                    If Word(i) = Ch Then
                        lblWord.Text += " " + Ch
                        ChArray(i) = Ch
                    ElseIf ChArray(i) = "b" Then
                        lblWord.Text += " _"
                    ElseIf ChArray(i) = "a" Then
                        lblWord.Text += "  "
                    ElseIf ChArray(i) = "c" Then
                        lblWord.Text += " '"
                    ElseIf ChArray(i) = "d" Then
                        lblWord.Text += " -"
                    Else
                        lblWord.Text += " " + ChArray(i)
                    End If
                Next
            Else
                lblWrong.Text += " " + Ch
                CheckImage()
            End If

            If go = 0 Then
                If Not lblWord.Text.Contains("_") Then
                    CuvCorect += 1
                    If CuvCorect = 20 Then
                        lblCount.Text = "Bons Mots: " + CStr(CuvCorect) + " /20"
                        btnEnable(False)
                        If MsgBox("Félicitations, vous avez gagné!") = MsgBoxResult.Ok Then
                            If MessageBox.Show("Voulez-vous jouer à nouveau?", "Le Pendu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                                FormCat.Visible = True
                                Me.Visible = False
                                Count = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
                                Reset()
                                lblCount.Text = "Bons Mots: 0 /20"
                                CuvCorect = 0
                                CatCorect += 1
                                If CatCorect = 10 Then
                                    MsgBox("Félicitations")
                                End If
                                go = 1
                                pd = 1
                            Else
                                End
                            End If
                        End If
                    Else
                        MessageBox.Show("Bon Courage!", "Le Pendu")
                        btnHint.Enabled = False
                        btnHnt.Enabled = False
                        btnEnable(False)
                        Button2.Visible = True
                        Coins += 2
                        lblCount.Text = "Bons Mots: " + CStr(CuvCorect) + " /20"
                        go = 1
                    End If
                End If

            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Reset()
        a = 1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub FormWord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.Untitled_3
        labelWord()
        lblWord.BackColor = Color.Transparent
    End Sub

    Private Sub btnA_Click(sender As Object, e As EventArgs) Handles btnA.Click
        CheckChar("A", btnA)
    End Sub

    Private Sub btnB_Click(sender As Object, e As EventArgs) Handles btnB.Click
        CheckChar("B", btnB)
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        CheckChar("C", btnC)
    End Sub

    Private Sub btnD_Click(sender As Object, e As EventArgs) Handles btnD.Click
        CheckChar("D", btnD)
    End Sub

    Private Sub btnE_Click(sender As Object, e As EventArgs) Handles btnE.Click
        CheckChar("E", btnE)
    End Sub

    Private Sub btnF_Click(sender As Object, e As EventArgs) Handles btnF.Click
        CheckChar("F", btnF)
    End Sub

    Private Sub btnG_Click(sender As Object, e As EventArgs) Handles btnG.Click
        CheckChar("G", btnG)
    End Sub

    Private Sub btnH_Click(sender As Object, e As EventArgs) Handles btnH.Click
        CheckChar("H", btnH)
    End Sub

    Private Sub btnI_Click(sender As Object, e As EventArgs) Handles btnI.Click
        CheckChar("I", btnI)
    End Sub

    Private Sub btnJ_Click(sender As Object, e As EventArgs) Handles btnJ.Click
        CheckChar("J", btnJ)
    End Sub

    Private Sub btnK_Click(sender As Object, e As EventArgs) Handles btnK.Click
        CheckChar("K", btnK)
    End Sub

    Private Sub btnL_Click(sender As Object, e As EventArgs) Handles btnL.Click
        CheckChar("L", btnL)
    End Sub

    Private Sub btnM_Click(sender As Object, e As EventArgs) Handles btnM.Click
        CheckChar("M", btnM)
    End Sub

    Private Sub btnN_Click(sender As Object, e As EventArgs) Handles btnN.Click
        CheckChar("N", btnN)
    End Sub

    Private Sub btnO_Click(sender As Object, e As EventArgs) Handles btnO.Click
        CheckChar("O", btnO)
    End Sub

    Private Sub btnP_Click(sender As Object, e As EventArgs) Handles btnP.Click
        CheckChar("P", btnP)
    End Sub

    Private Sub btnQ_Click(sender As Object, e As EventArgs) Handles btnQ.Click
        CheckChar("Q", btnQ)
    End Sub

    Private Sub btnR_Click(sender As Object, e As EventArgs) Handles btnR.Click
        CheckChar("R", btnR)
    End Sub

    Private Sub btnS_Click(sender As Object, e As EventArgs) Handles btnS.Click
        CheckChar("S", btnS)
    End Sub

    Private Sub btnT_Click(sender As Object, e As EventArgs) Handles btnT.Click
        CheckChar("T", btnT)
    End Sub

    Private Sub btnU_Click(sender As Object, e As EventArgs) Handles btnU.Click
        CheckChar("U", btnU)
    End Sub

    Private Sub btnV_Click(sender As Object, e As EventArgs) Handles btnV.Click
        CheckChar("V", btnV)
    End Sub

    Private Sub btnW_Click(sender As Object, e As EventArgs) Handles btnW.Click
        CheckChar("W", btnW)
    End Sub

    Private Sub btnX_Click(sender As Object, e As EventArgs) Handles btnX.Click
        CheckChar("X", btnX)
    End Sub

    Private Sub btnY_Click(sender As Object, e As EventArgs) Handles btnY.Click
        CheckChar("Y", btnY)
    End Sub

    Private Sub btnZ_Click(sender As Object, e As EventArgs) Handles btnZ.Click
        CheckChar("Z", btnZ)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Visible = False
        FormCat.Visible = True
        ChArray = ""
        lblCount.Text = "Bons Mots: 0 /20"
        lblWrong.Text = ""
        PicHangman.Image = My.Resources.sfoara_fara_cap
        CuvCorect = 0
        Coins = 10
        ' ResetColors()
        Button2.Visible = False
        btnHint.Enabled = True
        a = 1
    End Sub

    Private Sub FormWord_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        End
    End Sub

    Private Sub btnHint_Click(sender As Object, e As EventArgs) Handles btnHint.Click
        Dim rd As Integer = 0
        Dim z As Integer
        Dim Random As New System.Random()
        Randomize()
        If (Coins - 3 >= 0) Then
            Coins = Coins - 3
            While rd = 0
                z = Random.Next(1, ChArray.Length)
                CheckButt(Word(z))
                If ChArray(z) = "b" Then
                    CheckChar(Word(z), bttnX)
                    If yes = 1 Then
                        rd = 1
                        yes = 0
                    End If
                End If
            End While
            lblCoins.Text = "Crédit:" + CStr(Coins)
        Else
            MessageBox.Show("Crédit insufisent", "Le Pendu")
            btnHint.Enabled = False
        End If

    End Sub

    Private Sub btnA_MouseEnter(sender As Object, e As EventArgs) Handles btnA.MouseEnter
        Me.btnA.Image = My.Resources.a1
    End Sub

    Private Sub btnB_MouseEnter(sender As Object, e As EventArgs) Handles btnB.MouseEnter
        Me.btnB.Image = My.Resources.b1

    End Sub

    Private Sub btnC_MouseEnter(sender As Object, e As EventArgs) Handles btnC.MouseEnter
        Me.btnC.Image = My.Resources.c1
    End Sub

    Private Sub btnD_MouseEnter(sender As Object, e As EventArgs) Handles btnD.MouseEnter
        Me.btnD.Image = My.Resources.d1
    End Sub

    Private Sub btnE_MouseEnter(sender As Object, e As EventArgs) Handles btnE.MouseEnter
        Me.btnE.Image = My.Resources.e1
    End Sub

    Private Sub btnF_MouseEnter(sender As Object, e As EventArgs) Handles btnF.MouseEnter
        Me.btnF.Image = My.Resources.f1
    End Sub

    Private Sub btnG_MouseEnter(sender As Object, e As EventArgs) Handles btnG.MouseEnter
        Me.btnG.Image = My.Resources.g1
    End Sub

    Private Sub btnH_MouseEnter(sender As Object, e As EventArgs) Handles btnH.MouseEnter
        Me.btnH.Image = My.Resources.h1
    End Sub

    Private Sub btnI_MouseEnter(sender As Object, e As EventArgs) Handles btnI.MouseEnter
        Me.btnI.Image = My.Resources.i1
    End Sub

    Private Sub btnJ_MouseEnter(sender As Object, e As EventArgs) Handles btnJ.MouseEnter
        Me.btnJ.Image = My.Resources.j1
    End Sub

    Private Sub btnK_MouseEnter(sender As Object, e As EventArgs) Handles btnK.MouseEnter
        Me.btnK.Image = My.Resources.k1
    End Sub

    Private Sub btnL_MouseEnter(sender As Object, e As EventArgs) Handles btnL.MouseEnter
        Me.btnL.Image = My.Resources.l1
    End Sub

    Private Sub btnM_MouseEnter(sender As Object, e As EventArgs) Handles btnM.MouseEnter
        Me.btnM.Image = My.Resources.m1
    End Sub

    Private Sub btnN_MouseEnter(sender As Object, e As EventArgs) Handles btnN.MouseEnter
        Me.btnN.Image = My.Resources.n1

    End Sub

    Private Sub btnO_MouseEnter(sender As Object, e As EventArgs) Handles btnO.MouseEnter
        Me.btnO.Image = My.Resources.o1

    End Sub

    Private Sub btnP_MouseEnter(sender As Object, e As EventArgs) Handles btnP.MouseEnter
        Me.btnP.Image = My.Resources.p1

    End Sub

    Private Sub btnQ_MouseEnter(sender As Object, e As EventArgs) Handles btnQ.MouseEnter
        Me.btnQ.Image = My.Resources.q1

    End Sub

    Private Sub btnR_MouseEnter(sender As Object, e As EventArgs) Handles btnR.MouseEnter
        Me.btnR.Image = My.Resources.r1

    End Sub

    Private Sub btnS_MouseEnter(sender As Object, e As EventArgs) Handles btnS.MouseEnter
        Me.btnS.Image = My.Resources.s1

    End Sub

    Private Sub btnT_MouseEnter(sender As Object, e As EventArgs) Handles btnT.MouseEnter
        Me.btnT.Image = My.Resources.t1

    End Sub

    Private Sub btnU_MouseEnter(sender As Object, e As EventArgs) Handles btnU.MouseEnter
        Me.btnU.Image = My.Resources.u1

    End Sub

    Private Sub btnV_MouseEnter(sender As Object, e As EventArgs) Handles btnV.MouseEnter
        Me.btnV.Image = My.Resources.v1

    End Sub

    Private Sub btnW_MouseEnter(sender As Object, e As EventArgs) Handles btnW.MouseEnter
        Me.btnW.Image = My.Resources.w1

    End Sub

    Private Sub btnX_MouseEnter(sender As Object, e As EventArgs) Handles btnX.MouseEnter
        Me.btnX.Image = My.Resources.x1

    End Sub

    Private Sub btnY_MouseEnter(sender As Object, e As EventArgs) Handles btnY.MouseEnter
        Me.btnY.Image = My.Resources.y1

    End Sub

    Private Sub btnZ_MouseEnter(sender As Object, e As EventArgs) Handles btnZ.MouseEnter
        Me.btnZ.Image = My.Resources.z1

    End Sub

    Private Sub Button3_MouseEnter(sender As Object, e As EventArgs) Handles Button3.MouseEnter
        Me.Button3.Image = My.Resources.arriere1

    End Sub

    Private Sub Button2_MouseEnter(sender As Object, e As EventArgs) Handles Button2.MouseEnter
        Me.Button2.Image = My.Resources.sageata1

    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Me.Button1.Image = My.Resources.sort1

    End Sub

    Private Sub btnHint_MouseEnter(sender As Object, e As EventArgs) Handles btnHint.MouseEnter
        Me.btnHint.Image = My.Resources.btnh


    End Sub

    Private Sub btnHnt_MouseEnter(sender As Object, e As EventArgs) Handles btnHnt.MouseEnter
        Me.btnHnt.Image = My.Resources.semn1

    End Sub

    Private Sub btnA_MouseLeave(sender As Object, e As EventArgs) Handles btnA.MouseLeave
        Me.btnA.Image = My.Resources.a
    End Sub

    Private Sub btnB_MouseLeave(sender As Object, e As EventArgs) Handles btnB.MouseLeave
        Me.btnB.Image = My.Resources.b

    End Sub

    Private Sub btnC_MouseLeave(sender As Object, e As EventArgs) Handles btnC.MouseLeave
        Me.btnC.Image = My.Resources.c
    End Sub

    Private Sub btnD_MouseLeave(sender As Object, e As EventArgs) Handles btnD.MouseLeave
        Me.btnD.Image = My.Resources.d
    End Sub

    Private Sub btnE_MouseLeave(sender As Object, e As EventArgs) Handles btnE.MouseLeave
        Me.btnE.Image = My.Resources.e
    End Sub

    Private Sub btnF_MouseLeave(sender As Object, e As EventArgs) Handles btnF.MouseLeave
        Me.btnF.Image = My.Resources.f
    End Sub

    Private Sub btnG_MouseLeave(sender As Object, e As EventArgs) Handles btnG.MouseLeave
        Me.btnG.Image = My.Resources.g
    End Sub

    Private Sub btnH_MouseLeave(sender As Object, e As EventArgs) Handles btnH.MouseLeave
        Me.btnH.Image = My.Resources.h
    End Sub

    Private Sub btnI_MouseLeave(sender As Object, e As EventArgs) Handles btnI.MouseLeave
        Me.btnI.Image = My.Resources.i
    End Sub

    Private Sub btnJ_MouseLeave(sender As Object, e As EventArgs) Handles btnJ.MouseLeave
        Me.btnJ.Image = My.Resources.j
    End Sub

    Private Sub btnK_MouseLeave(sender As Object, e As EventArgs) Handles btnK.MouseLeave
        Me.btnK.Image = My.Resources.k
    End Sub

    Private Sub btnL_MouseLeave(sender As Object, e As EventArgs) Handles btnL.MouseLeave
        Me.btnL.Image = My.Resources.l
    End Sub

    Private Sub btnM_MouseLeave(sender As Object, e As EventArgs) Handles btnM.MouseLeave
        Me.btnM.Image = My.Resources.m
    End Sub

    Private Sub btnN_MouseLeave(sender As Object, e As EventArgs) Handles btnN.MouseLeave
        Me.btnN.Image = My.Resources.n

    End Sub

    Private Sub btnO_MouseLeave(sender As Object, e As EventArgs) Handles btnO.MouseLeave
        Me.btnO.Image = My.Resources.o

    End Sub

    Private Sub btnP_MouseLeave(sender As Object, e As EventArgs) Handles btnP.MouseLeave
        Me.btnP.Image = My.Resources.p

    End Sub

    Private Sub btnQ_MouseLeave(sender As Object, e As EventArgs) Handles btnQ.MouseLeave
        Me.btnQ.Image = My.Resources.q

    End Sub

    Private Sub btnR_MouseLeave(sender As Object, e As EventArgs) Handles btnR.MouseLeave
        Me.btnR.Image = My.Resources.r

    End Sub

    Private Sub btnS_MouseLeave(sender As Object, e As EventArgs) Handles btnS.MouseLeave
        Me.btnS.Image = My.Resources.s

    End Sub

    Private Sub btnT_MouseLeave(sender As Object, e As EventArgs) Handles btnT.MouseLeave
        Me.btnT.Image = My.Resources.t

    End Sub

    Private Sub btnU_MouseLeave(sender As Object, e As EventArgs) Handles btnU.MouseLeave
        Me.btnU.Image = My.Resources.u

    End Sub

    Private Sub btnV_MouseLeave(sender As Object, e As EventArgs) Handles btnV.MouseLeave
        Me.btnV.Image = My.Resources.v

    End Sub

    Private Sub btnW_MouseLeave(sender As Object, e As EventArgs) Handles btnW.MouseLeave
        Me.btnW.Image = My.Resources.w

    End Sub

    Private Sub btnX_MouseLeave(sender As Object, e As EventArgs) Handles btnX.MouseLeave
        Me.btnX.Image = My.Resources.x

    End Sub

    Private Sub btnY_MouseLeave(sender As Object, e As EventArgs) Handles btnY.MouseLeave
        Me.btnY.Image = My.Resources.y

    End Sub

    Private Sub btnZ_MouseLeave(sender As Object, e As EventArgs) Handles btnZ.MouseLeave
        Me.btnZ.Image = My.Resources.z

    End Sub

    Private Sub Button3_MouseLeave(sender As Object, e As EventArgs) Handles Button3.MouseLeave
        Me.Button3.Image = My.Resources.arriere

    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Me.Button2.Image = My.Resources.sageata

    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Me.Button1.Image = My.Resources.Sortie2


    End Sub

    Private Sub btnHint_MouseLeave(sender As Object, e As EventArgs) Handles btnHint.MouseLeave
        Me.btnHint.Image = My.Resources.btnh

    End Sub

    Private Sub btnHnt_MouseLeave(sender As Object, e As EventArgs) Handles btnHnt.MouseLeave
        Me.btnHnt.Image = My.Resources.semn

    End Sub

    Private Sub btnHnt_Click(sender As Object, e As EventArgs) Handles btnHnt.Click
        If Coins - 5 >= 0 Then
            Coins -= 5
            lblCoins.Text = "Crédit:" + CStr(Coins)
            MessageBox.Show(hints(kl), "Le Pendu")
            btnHnt.Enabled = False
        Else
            MsgBox("Crédit insufisent")
            btnHnt.Enabled = False
        End If
    End Sub

    
End Class