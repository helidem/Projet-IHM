Public Class FormMenu
    '@brief Permet d'enlever le ComboBox, de sélectionner le bon BorderStyle, de tailler la fenêtre,
    'de griser le BtnJouer, de récupérer les joueurs, d'intitialiser les options et d'actualiser le ComboBoxNom
    '@param[in] sender et e
    '@see traitementsJoueurs.
    '()
    '@see traitementsOptions.initOption()
    '@see actualiserComboBoxNom()
    Private Sub FormMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Enlève le ControlBox
        Me.ControlBox = False
        'Permet de pouvoir déplacer la fenêtre, mais de ne pas pouvoir la redimensionner
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        'Adapte la taille de la fenêtre automatiquement
        Me.AutoSize = True

        traitementsJoueurs.recupererJoueurs()
        traitementsOptions.initOption()

        BtnJouer.Enabled = False

        actualiserComboBoxNom()
    End Sub

    '-----------------------------------------------------------------------------------------------
    'ComboBox Nom
    '-----------------------------------------------------------------------------------------------

    '@brief Permet d'actualiser le ComboBoxNom avec le nom des joueurs
    '@see le module traitementsJoueurs.vb
    Private Sub actualiserComboBoxNom()
        ComboBoxNom.Items.Clear()
        For Each item As Joueur In traitementsJoueurs.tabJoueurs
            'Permet de ne pas écrire si le nom est nul, à cause du vbNewLine
            If Not item.nom = vbNullString Then
                ComboBoxNom.Items.Add(item.nom)
            End If
        Next
    End Sub

    '@brief Vérifie que le nom entré comporte des lettres ou des tirets à chaque KeyPress
    '@param[in] sender et e
    Private Sub ckTxtCB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBoxNom.KeyPress
        If e.KeyChar = vbBack Or e.KeyChar = "-" Then
            Exit Sub
        End If

        If Not Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    '@brief Vérifie que la longueur du nom est bel et bien comrpise entre 3 et 14 a chaque TextChanged
    '@param[in] sender et e
    Private Sub ckLenghtCB_TextChanged(sender As Object, e As EventArgs) Handles ComboBoxNom.TextChanged
        BtnJouer.Enabled = False

        If ComboBoxNom.Text.Length > 2 And ComboBoxNom.Text.Length < 15 Then
            BtnJouer.Enabled = True
        End If
    End Sub

    '@brief Met le nom en ProperCase a chaque LostFocus
    '@param[in] sender et e
    Private Sub properCaseCB_LostFocus(sender As Object, e As EventArgs) Handles ComboBoxNom.LostFocus
        sender.Text = StrConv(sender.Text, vbProperCase)
    End Sub

    '-----------------------------------------------------------------------------------------------
    'Bouton Jouer, Options, Scores et Quitter
    '-----------------------------------------------------------------------------------------------

    '@brief Permet le lancement du jeu
    '@param[in] sender et e
    Private Sub jouerUnePartie(sender As Object, e As EventArgs) Handles BtnJouer.Click
        FormJeu.Show()
        Me.Hide()
    End Sub

    '@brief Permet l'ouverture des options
    '@param[in] sender et e
    Private Sub ouvertureOptions(sender As Object, e As EventArgs) Handles BtnOptions.Click
        Me.Hide()
        FormOptions.Show()
    End Sub

    '@brief Permet d'afficher le formulaire des scores
    '@param[in] sender et e
    Private Sub ouvertureScores(sender As Object, e As EventArgs) Handles BtnScores.Click
        Me.Hide()
        FormScores.Show()
    End Sub

    '@brief Permet de quitter l'application
    '@param[in] sender et e
    Private Sub quitterAppli(sender As Object, e As EventArgs) Handles BtnQuitter.Click
        If MsgBox("Voulez-vous quitter l'application ?",
                  vbCritical + vbYesNo + vbDefaultButton2, "Vous allez quitter l'application") = vbYes Then
            Me.Close()
        End If
    End Sub
End Class
