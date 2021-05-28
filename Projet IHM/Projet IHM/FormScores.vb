Public Class FormScores
    Private Sub FormScores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ListBox1.Items.Clear()
        For Each item As Joueur In tabJoueur
            If Not item.nom = vbNullString Then
                ListBox1.Items.Add(item.nom & " a trouvé " & item.cartes & " cartes en " & item.temps & "s. Il a joué " & item.nbparties & " parties pour un total de " & item.cumultemps & "s")
            End If
        Next
    End Sub
End Class