Public Class FormJeu

    Dim random As New Random 'pour generer aleatoirement le placement des cartes

    Dim liste() As Integer = {0, 0, 0, 0, 1, 1, 1, 1, 2, 2, 2, 2, 3, 3, 3, 3, 4, 4, 4, 4}
    Dim tabMelangé As Integer() = New Integer(liste.Length - 1) {}
    Dim TagcartesChoisies() As Integer = {-1, -1, -1, -1} '-1 : pas choisi
    Dim indexchoix As Integer
    Dim nomsCartesChoisies() As String = {"", "", "", ""}

    '-----------------------------------------------------------------------------------------------
    'Load
    '-----------------------------------------------------------------------------------------------

    Private Sub FormJeu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        retournerToutesLesCartes()
        For Each lbl In PnlCarte.Controls 'temporaire : enlever le texte via les prop
            lbl.text = ""
        Next lbl

        Me.ControlBox = False

        afficheNomJoueur()
        Dim ListeCartes As List(Of PictureBox)

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
    End Sub

    Private Sub attribuer()
        For i As Integer = 0 To PnlCarte.Controls.Count - 1
            PnlCarte.Controls(i).Tag = tabMelangé(i)
        Next
    End Sub

    Private Sub click_carte(sender As Object, e As EventArgs) Handles LabelImg1.Click, LabelImg3.Click, LabelImg2.Click, LabelImg9.Click, LabelImg8.Click, LabelImg7.Click, LabelImg6.Click, LabelImg5.Click, LabelImg4.Click, LabelImg20.Click, LabelImg19.Click, LabelImg18.Click, LabelImg17.Click, LabelImg16.Click, LabelImg15.Click, LabelImg14.Click, LabelImg13.Click, LabelImg12.Click, LabelImg11.Click, LabelImg10.Click
        Debug.WriteLine(sender.Tag)
        sender.image = ImageList.Images(sender.tag) 'permet d'afficher la carte

        If Not carteUnique(sender.name) Then
            Exit Sub
        Else
            nomsCartesChoisies(indexchoix) = sender.name
        End If

        TagcartesChoisies(indexchoix) = sender.tag

        If indexchoix = 0 Then
            premierchoix()
            Exit Sub
        End If

        If Not cartesEgales() Then
            retournerToutesLesCartes()

        Else
            indexchoix = indexchoix + 1
        End If

    End Sub

    Private Sub retournerToutesLesCartes()

        For Each carte As Label In PnlCarte.Controls
            carte.Image = ImageList.Images(5)
        Next carte
        indexchoix = 0

        'reinitialiser le tableau
        For i As Integer = 0 To nomsCartesChoisies.Length - 1
            nomsCartesChoisies(i) = ""
        Next
    End Sub


    Private Sub premierchoix()
        Debug.WriteLine("1st")
        indexchoix = indexchoix + 1
    End Sub


    Private Function cartesEgales() As Boolean

        If TagcartesChoisies(indexchoix) = TagcartesChoisies(indexchoix - 1) Then
            Return True
        End If

        Return False
    End Function


    Private Function carteUnique(ByVal name As String) As Boolean 'retourne faux si la caret a deja été choisie
        For i As Integer = 0 To nomsCartesChoisies.Length - 1
            If name = nomsCartesChoisies(i) Then
                Return False
            End If
        Next
        Return True
    End Function

End Class