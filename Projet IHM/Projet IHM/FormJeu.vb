Public Class FormJeu

    '-----------------------------------------------------------------------------------------------
    'Variables globales
    '-----------------------------------------------------------------------------------------------

    'Pour générer aléatoirement le placement des cartes
    Dim random As New Random

    'Tableau servant à associer un numéro à une carte
    Dim liste() As Integer = {0, 0, 0, 0, 1, 1, 1, 1, 2, 2, 2, 2, 3, 3, 3, 3, 4, 4, 4, 4}
    'Tableau précédent, mais mélangé dans la fonction mélanger
    Dim tabMelange As Integer() = New Integer(liste.Length - 1) {}

    'Tableau mémorisant le tag des cartes sélectionnées simultanéments
    'Initialisé à -1, car aucune carte n'est sélectionnée
    Dim tagCartesChoisies() As Integer = {-1, -1, -1, -1}
    'Retient l'index du tableau précédent
    Dim indexChoix As Integer

    'Tableau mémorisant le nom des cartes sélectionnées simultanéments
    'Initialisé à "", car aucune carte n'est sélectionnée
    Dim nomsCartesChoisies() As String = {"", "", "", ""}

    'Tableau mémorisant le tag des cartes trouvées
    'Initialisé à -1, car aucune série n'a été trouvée
    Dim seriesTerminees() As Integer = {-1, -1, -1, -1}
    'Retient le nombre de série(s) terminée(s), et donc l'index du tableau précédent
    Dim nbSeriesTerminees As Integer = 0

    '-----------------------------------------------------------------------------------------------
    'Load
    '-----------------------------------------------------------------------------------------------

    Private Sub FormJeu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        retournerToutesLesCartes()

        Me.ControlBox = False

        afficheNomJoueur()

        Dim ListeCartes As List(Of PictureBox)

        melanger(liste)
        attribuer()

    End Sub

    '-----------------------------------------------------------------------------------------------
    'Sub pour le load
    '-----------------------------------------------------------------------------------------------

    'Permet de retourner les cartes des séries non-terminées
    Private Sub retournerToutesLesCartes()
        For Each carte As Label In PnlCarte.Controls
            'Si la carte fait partie d'une série terminée
            If seriesTerminees.Contains(carte.Tag) Then
                'On passe au suivant
                Continue For
            End If

            'On retourne la carte, en mettant la bonne image
            carte.Image = ImageList.Images(5)
        Next carte

        'On met l'index choix à 0, car aucune carte n'est sélectionnée dorénavant
        indexChoix = 0

        'On réinitialise les deux tableaux
        For i As Integer = 0 To nomsCartesChoisies.Length - 1
            nomsCartesChoisies(i) = ""
            tagCartesChoisies(i) = -1
        Next
    End Sub

    'Affiche le nom du joueur
    Private Sub afficheNomJoueur()
        LblJoueurModif.Text = FormMenu.ComboBoxNom.Text
    End Sub

    'Mélange la liste, pour avoir les cartes mélangées
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
            tabMelange(i) = liste(index)
        Next
    End Sub

    'Attribue chaque tag à un numéro du tableau tabMelange()
    Private Sub attribuer()
        For i As Integer = 0 To PnlCarte.Controls.Count - 1
            PnlCarte.Controls(i).Tag = tabMelange(i)
        Next
    End Sub

    '-----------------------------------------------------------------------------------------------
    'METHODE PRINCIPALE
    'A CHAQUE CARTE CLIQUEE
    '-----------------------------------------------------------------------------------------------

    Private Sub CarteCliquee(sender As Object, e As EventArgs) Handles LabelImg1.Click, LabelImg3.Click, LabelImg2.Click, LabelImg9.Click, LabelImg8.Click, LabelImg7.Click, LabelImg6.Click, LabelImg5.Click, LabelImg4.Click, LabelImg20.Click, LabelImg19.Click, LabelImg18.Click, LabelImg17.Click, LabelImg16.Click, LabelImg15.Click, LabelImg14.Click, LabelImg13.Click, LabelImg12.Click, LabelImg11.Click, LabelImg10.Click
        'Permet d'afficher la carte
        sender.image = ImageList.Images(sender.tag)

        'Vérifie si la carte a déjà été sélectionnée
        If carteUnique(sender.name) Then
            'Met le nom de la carte dans le tableau nomsCartesChoisies()
            nomsCartesChoisies(indexChoix) = sender.name
        Else
            'Ne rien faire
            Exit Sub
        End If

        'Met le tag de la carte dans le tableau tagCartesChoisies()
        tagCartesChoisies(indexChoix) = sender.tag

        If serieTerminee() Then
            seriesTerminees(nbSeriesTerminees) = sender.tag
            nbSeriesTerminees = nbSeriesTerminees + 1
            retournerToutesLesCartes()
            Exit Sub
        End If

        If premierChoix() Then
            indexChoix += 1
            Exit Sub
        End If

        If cartesEgales() Then
            indexChoix = indexChoix + 1
        Else
            retournerToutesLesCartes()
        End If

    End Sub

    '-----------------------------------------------------------------------------------------------
    'Sub et Function pour CarteCliquée 
    '-----------------------------------------------------------------------------------------------

    'Vérifie si la carte est la première sélectionnée
    'Retourne True si la carte est la première sélectionnée
    'Retourne False si la carte n'est pas la première sélectionnée
    Private Function premierChoix() As Boolean
        Return indexChoix = 0
    End Function

    'Vérifie si la carte est égale à la dernière sélectionnée
    'Retourne True si la carte est égale à la dernière sélectionnée
    'Retourne False si la carte n'est pas égale à la dernière sélectionnée
    Private Function cartesEgales() As Boolean
        Return tagCartesChoisies(indexChoix) = tagCartesChoisies(indexChoix - 1)
    End Function

    'Vérifie si la carte n'a pas déjà été selectionnée
    'Retourne True si la carte n'a pas déjà été selectionnée
    'Retourne False si la carte a déjà été selectionnée
    Private Function carteUnique(ByVal name As String) As Boolean
        For i As Integer = 0 To nomsCartesChoisies.Length - 1
            'Vérifie que le nom (qui est unique) fait partie du tableau nomsCartesChoisies()
            If name = nomsCartesChoisies(i) Then
                Return False
            End If
        Next

        Return True
    End Function

    'Vérifie si la série est terminée
    'Retourne True si si la série est terminée
    'Retourne False si la série n'est pas terminée
    Private Function serieTerminee() As Boolean
        For i As Integer = 0 To tagCartesChoisies.Length - 1
            'Compare la carte de tagCartesChoisies(0) à toutes les cartes
            'Si elles ne correspondent pas, on retourne False
            If Not tagCartesChoisies(0) = tagCartesChoisies(i) Then
                Return False
            End If
        Next

        Return True
    End Function

End Class