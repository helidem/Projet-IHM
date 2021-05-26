Public Class FormMenu

    '-----------------------------------------------------------------------------------------------
    'Load
    '-----------------------------------------------------------------------------------------------

    '@brief Permet d'enlever le ComboBox, de sélectionner le bon BorderStyle, de tailler la fenêtre,
    'et de griser le BtnJouer
    '@param[in] sender et e
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

    '@brief Vérifie que le nom rentré comporte des lettres ou des tirets à chaque KeyPress
    '@param[in] sender et e
    Private Sub ComboBoxName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBoxNom.KeyPress

        If e.KeyChar = vbBack Or e.KeyChar = "-" Then
            Exit Sub
        End If

        If Not Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    '@brief Vérifie que la longueur du nom est bel et bien comrpise entre 3 et 14 a chaque TextChanged
    '@param[in] sender et e
    Private Sub ComboBoxName_TextChanged(sender As Object, e As EventArgs) Handles ComboBoxNom.TextChanged
        BtnJouer.Enabled = False

        If ComboBoxNom.Text.Length > 2 And ComboBoxNom.Text.Length < 15 Then
            BtnJouer.Enabled = True
        End If
    End Sub

    '@brief Met le nom en ProperCase a chaque LostFocus
    '@param[in] sender et e
    Private Sub ComboBoxNom_LostFocus(sender As Object, e As EventArgs) Handles ComboBoxNom.LostFocus
        sender.Text = StrConv(sender.Text, vbProperCase)
    End Sub

    '-----------------------------------------------------------------------------------------------
    'Bouton Jouer
    '-----------------------------------------------------------------------------------------------

    '@brief Permet le lancement du jeu sur le clique de BtnJouer
    '@param[in] sender et e
    Private Sub BtnJouer_Click(sender As Object, e As EventArgs) Handles BtnJouer.Click
        FormJeu.Show()
        Me.Hide()
    End Sub

    '-----------------------------------------------------------------------------------------------
    'Bouton Quitter
    '-----------------------------------------------------------------------------------------------

    '@brief Permet de quitter l'application sur le clique de BtnQuitter
    '@param[in] sender et e
    Private Sub BtnQuitter_Click(sender As Object, e As EventArgs) Handles BtnQuitter.Click
        If MsgBox("Voulez-vous quitter l'application ?",
                  vbCritical + vbYesNo + vbDefaultButton2, "Vous allez quitter l'application") = vbYes Then
            Me.Close()
        End If
    End Sub

    '@brief Permet d'afficher le formulaire des scores
    '@param[in] sender et e
    Private Sub BtnScores_Click(sender As Object, e As EventArgs) Handles BtnScores.Click
        Me.Hide()
        FormSauvegardeNom.Show()
    End Sub
End Class
