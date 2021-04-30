Public Class FormJeu

    Dim random As New Random 'pour generer aleatoirement le placement des cartes

    Dim liste() As Integer = {0, 0, 0, 0, 1, 1, 1, 1, 2, 2, 2, 2, 3, 3, 3, 3, 4, 4, 4, 4}
    Dim tabMelangé As Integer() = New Integer(liste.Length - 1) {}
    '-----------------------------------------------------------------------------------------------
    'Load
    '-----------------------------------------------------------------------------------------------

    Private Sub FormJeu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each lbl In PnlCarte.Controls
            lbl.text = ""
        Next lbl

        Me.ControlBox = False

        afficheNomJoueur()
        Dim ListeCartes As List(Of PictureBox)
        'Dim img As Image = My.Resources.Card2  exemple pour changer les images
        'LabelImg1.Image = img

        'LabelImg1.Image = ImageList.Images(1)


        melanger(liste)
        attribuer()

    End Sub

    Private Sub afficheNomJoueur()
        LblJoueurModif.Text = FormMenu.ComboBoxNom.Text
    End Sub


    Private Sub melanger(liste)

        Dim ind As Integer() = New Integer(liste.Length - 1) {}
        Dim index As Integer


        For i As Integer = 0 To liste.Length - 1
            ind(i) = 0
        Next

        For i As Integer = 0 To liste.Length - 1
            Do
                index = random.[Next](liste.Length)
            Loop While ind(index) <> 0

            ind(index) = 1
            tabMelangé(i) = liste(index)
        Next

        For i As Integer = 0 To tabMelangé.Length - 1
            Debug.WriteLine(tabMelangé(i))
        Next
        Debug.WriteLine("------")


    End Sub
    Private Sub attribuer()
        For i As Integer = 0 To PnlCarte.Controls.Count - 1
            PnlCarte.Controls(i).Tag = tabMelangé(i)
        Next
    End Sub

    Private Sub click_carte(sender As Object, e As EventArgs) Handles LabelImg1.Click, LabelImg3.Click, LabelImg2.Click, LabelImg9.Click, LabelImg8.Click, LabelImg7.Click, LabelImg6.Click, LabelImg5.Click, LabelImg4.Click, LabelImg20.Click, LabelImg19.Click, LabelImg18.Click, LabelImg17.Click, LabelImg16.Click, LabelImg15.Click, LabelImg14.Click, LabelImg13.Click, LabelImg12.Click, LabelImg11.Click, LabelImg10.Click
        Debug.WriteLine(sender.Tag)
        'LabelImg1.Image = ImageList.Images(1)
        sender.image = ImageList.Images(sender.tag) 'permet d'afficher la carte
    End Sub


End Class