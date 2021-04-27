Public Class FormJeu

    Dim random As New Random 'pour generer aleatoirement le placement des cartes

    '-----------------------------------------------------------------------------------------------
    'Load
    '-----------------------------------------------------------------------------------------------

    Private Sub FormJeu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each lbl In PnlCarte.Controls
            lbl.text = ""
        Next lbl

        Me.ControlBox = False
        Debug.WriteLine("je suis dans le load")
        afficheNomJoueur()
        Dim ListeCartes As List(Of PictureBox)
        'Dim img As Image = My.Resources.Card2  exemple pour changer les images
        'LabelImg1.Image = img
    End Sub

    Private Sub afficheNomJoueur()
        LblJoueurModif.Text = FormMenu.ComboBoxNom.Text
    End Sub

    Private Sub LabelImg1_Click(sender As Object, e As EventArgs) Handles LabelImg1.Click

    End Sub
End Class