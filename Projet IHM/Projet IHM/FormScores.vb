Public Class FormScores
    '@brief Permet d'enlever le ComboBox, de sélectionner le bon BorderStyle, de tailler la fenêtre,
    'et de griser et de remplir la ListBoxScores
    '@param[in] sender et e
    Private Sub FormScores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Enlève le ControlBox
        Me.ControlBox = False
        'Permet de pouvoir déplacer la fenêtre, mais de ne pas pouvoir la redimensionner
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        'Adapte la taille de la fenêtre automatiquement
        Me.AutoSize = True

        ListBoxScores.Enabled = False
        remplirListBoxScores()
    End Sub

    '@brief Permet de remplir la ListBoxScores avec le score des personnes enregistrées
    '@see le module traitementsJoueurs.vb
    Private Sub remplirListBoxScores()
        'Vide la ListBoxScores pour pouvoir partir d'une liste vierge
        ListBoxScores.Items.Clear()
        'On remplie la ListBoxScores avec les informations de chaque Joueur
        For Each item As Joueur In traitementsJoueurs.tabJoueurs
            'Permet de ne pas écrire si le nom est nul, à cause du vbNewLine
            If Not item.nom = vbNullString Then
                ListBoxScores.Items.Add(item.nom & " a trouvé " & item.serie & " carte(s) en " & item.temps _
                                        & " secondes. Il a joué " & item.nbparties & " partie(s) pour un total de " _
                                        & item.cumulTemps & " secondes.")
            End If
        Next

        'Si la liste est vide
        If ListBoxScores.Items.Count = 0 Then
            ListBoxScores.Items.Add("Aucun score n'est sauvegardé pour l'instant ! Si vous en avez un, veuillez recharger le programme.")
        End If
    End Sub

    '@brief Permet de revenir au menu principal
    '@param[in] sender et e
    Private Sub retourMenu(sender As Object, e As EventArgs) Handles BtnRetour.Click
        Me.Hide()
        FormMenu.Show()
    End Sub
End Class