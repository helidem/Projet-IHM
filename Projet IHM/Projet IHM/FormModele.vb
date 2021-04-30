Public Class FormModele
    Private Cartes As New List(Of Label)
    Private ListeChoix As New List(Of Label)
    Private IndexConcordants As New List(Of Integer) 'store les "index" qui coincident
    Private nombreDeCopie As Integer ' nombre de copies
    Private Sub btnTwoMatches_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTwoMatches.Click
        SetupCartes(5, 2) 'permet de jouer avec 2 cartes
    End Sub

    Private Sub btnThreeMatches_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThreeMatches.Click
        SetupCartes(5, 3) 'permet de jouer avec 3 cartes
    End Sub
    Private Sub SetupCartes(ByVal nbSerie As Integer, ByVal nbCopie As Integer)
        ' Start by calculating the number of cards that will be displayed. This is number of card variations times copies per card.
        ' Resize our cards array to fit all these cards.

        nombreDeCopie = nbCopie

        ' Clear  game data
        ClearGame()

        ' compteur dans ImageList
        Dim imageListIndex As Integer = 0
        Dim length As Integer = nbCopie * nbSerie

        ' step nbCopie.
        For i As Integer = 0 To length - 1 Step nbCopie

            ' Makes copies of each card and tag each card with the index from the image list
            For j As Integer = 1 To nbCopie
                Dim lblCard As Label = New Label()
                'assigne l'image de "dos"
                lblCard.Image = ImageList1.Images(ImageList1.Images.Count - 1)

                'memorise dans le champ tag l'image à afficher
                lblCard.Tag = imageListIndex
                AddHandler lblCard.Click, AddressOf Me.CarteFlip_Click

                Cartes.Add(lblCard)
            Next

            imageListIndex += 1
        Next
        ' Battre les index cartes(champ tag)
        Shuffle(Cartes)

        ' Affiche 5 cartes / ligne
        AfficheCarte(5)

    End Sub
    'initialise le jeu
    Private Sub ClearGame()
        If Cartes.Count > 0 Then
            For i As Integer = 0 To Cartes.Count - 1
                Me.Controls.Remove(Cartes(i))
            Next
        End If

        ' Clear la liste de Cartes et la liste Choix .
        Cartes.Clear()
        ListeChoix.Clear()

    End Sub
    ' Bat la liste des controls Labels aleatoirement avec le Fisher-Yates algorithm
    Private Sub Shuffle(ByRef LesCartes As List(Of Label))
        Dim r As Random = New Random()
        For i = 0 To LesCartes.Count - 1
            Dim index As Integer = r.Next(i, LesCartes.Count)

            ' simple permutation
            If i <> index Then
                Dim temp As Label = LesCartes(i)
                LesCartes(i) = LesCartes(index)
                LesCartes(index) = temp
            End If
        Next
    End Sub

    Private Sub AfficheCarte(ByVal cartesParLigne As Integer)
        Dim startX As Integer = 50
        Dim startY As Integer = 100
        Dim sizeCarte As New Size(100, 100)
        Dim separator As Integer = 20
        For i As Integer = 0 To Cartes.Count - 1
            Cartes(i).Top = startY
            Cartes(i).Left = startX
            Cartes(i).Size = sizeCarte
            Me.Controls.Add(Cartes(i))

            Cartes(i).Visible = True

            startX += sizeCarte.Width + separator

            If (i + 1) Mod cartesParLigne = 0 Then
                startX = 50
                startY = startY + 166
            End If
        Next
    End Sub

    Private Sub CarteFlip_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim picture As Label = CType(sender, Label)
        Dim idTag As Integer = CType(picture.Tag, Integer)

        If Not ListeChoix.Contains(picture) And Not IndexConcordants.Contains(idTag) Then
            ListeChoix.Add(picture)
            MontreCarte(picture)

            If ListeChoix.Count = nombreDeCopie Then
                If ConcordanceChoix() Then

                    IndexConcordants.Add(idTag)
                Else
                    Threading.Thread.Sleep(1000)

                    ' Cache les choix faits
                    For i As Integer = 0 To ListeChoix.Count - 1
                        CacheCarte(ListeChoix(i))
                    Next
                End If

                ' Efface tous les choix
                ListeChoix.Clear()
            End If
        End If
    End Sub
    'on affiche l'image correpondant au  "tag"
    Private Sub MontreCarte(ByVal carte As Label)
        carte.Image = ImageList1.Images(Convert.ToInt32(carte.Tag))
        Me.Refresh()
    End Sub
    'on affiche l'image du  "dos" simplement
    Private Sub CacheCarte(ByVal carte As Label)
        carte.Image = ImageList1.Images(ImageList1.Images.Count - 1)
    End Sub
    ' Verifie à chaque clic que les cartes choisies coincident(compare précédent et suivant) 
    ' renvoi True ou  False
    Private Function ConcordanceChoix() As Boolean
        For i As Integer = 1 To ListeChoix.Count - 1
            Dim c1 As Integer = CType(ListeChoix(i - 1).Tag, Integer)
            Dim c2 As Integer = CType(ListeChoix(i).Tag, Integer)

            If c1 <> c2 Then
                Return False
            End If
        Next

        Return True
    End Function
End Class