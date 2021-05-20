Public Class FormMenu

    '-----------------------------------------------------------------------------------------------
    'Load
    '-----------------------------------------------------------------------------------------------

    Private Sub FormMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Enlève le ControlBox
        Me.ControlBox = False
        'Permet de pouvoir déplacer la fenêtre, mais de ne pas pouvoir la redimensionner
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        'Adapte la taille de la fenêtre automatiquement
        Me.AutoSize = True

        BtnJouer.Enabled = False
    End Sub

    '-----------------------------------------------------------------------------------------------
    'ComboBox Nom
    '-----------------------------------------------------------------------------------------------

    Private Sub ComboBoxName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBoxNom.KeyPress

        If e.KeyChar = vbBack Or e.KeyChar = "-" Then
            Exit Sub
        End If

        If Not Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub ComboBoxName_TextChanged(sender As Object, e As EventArgs) Handles ComboBoxNom.TextChanged
        BtnJouer.Enabled = False

        If ComboBoxNom.Text.Length > 2 Then
            BtnJouer.Enabled = True
        End If
    End Sub
    Private Sub ComboBoxNom_LostFocus(sender As Object, e As EventArgs) Handles ComboBoxNom.LostFocus
        sender.Text = StrConv(sender.Text, vbProperCase)
    End Sub

    '-----------------------------------------------------------------------------------------------
    'Bouton Jouer
    '-----------------------------------------------------------------------------------------------

    Private Sub BtnJouer_Click(sender As Object, e As EventArgs) Handles BtnJouer.Click
        FormJeu.Show()
        Me.Hide()
    End Sub

    '-----------------------------------------------------------------------------------------------
    'Bouton Quitter
    '-----------------------------------------------------------------------------------------------

    Private Sub BtnQuitter_Click(sender As Object, e As EventArgs) Handles BtnQuitter.Click
        If MsgBox("Voulez-vous quitter l'application ?",
                  vbCritical + vbYesNo + vbDefaultButton2, "Vous allez quitter l'application") = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub BtnScores_Click(sender As Object, e As EventArgs) Handles BtnScores.Click
        Me.Hide()
        FormSauvegardeNom.Show()
    End Sub
End Class
