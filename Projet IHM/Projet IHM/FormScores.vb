Public Class FormScores
    '@brief Permet d'afficher le score de chaque joueur
    '@param[in] sender et e
    Private Sub FormScores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Vide la ListBoxScores pour pouvoir partir d'une liste vierge
        ListBox1.Items.Clear()
        'On remplie la ListBoxScores avec les informations de chaque Joueur
        For Each item As Joueur In tabJoueurs
            If Not item.nom = vbNullString Then
                ListBox1.Items.Add(item.nom & " a trouvé " & item.cartes & " cartes en " & item.temps & "s. Il a joué " & item.nbparties & " parties pour un total de " & item.cumultemps & "s")
            End If
        Next
    End Sub
End Class