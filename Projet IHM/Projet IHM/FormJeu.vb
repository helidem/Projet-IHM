Public Class FormJeu

    '-----------------------------------------------------------------------------------------------
    'Attributs
    '-----------------------------------------------------------------------------------------------

    'Retient le joueur
    Private joueur As Joueur

    'Retient le temps de la partie
    Private TEMPS_PARTIE As Integer
    Private tempsTexte As String
    Public themeList() As ImageList

    'Retient le score du joueur, c'est à dire son nombre de cartes
    Private cartes As Integer = 0
    'Retient le temps mis pour trouver x cartes
    'On l'initialise à TEMPS_PARTIE pour que si le joueur ne trouve aucune carte, le temps soit déjà à TEMPS_PARTIE
    '(le maximum)
    Private temps As Integer

    'Tableau servant à associer un numéro à une carte
    Private liste() As Integer = {0, 0, 0, 0, 1, 1, 1, 1, 2, 2, 2, 2, 3, 3, 3, 3, 4, 4, 4, 4}
    'Tableau précédent, mais mélangé dans la fonction mélanger
    Private tabMelange As Integer() = New Integer(liste.Length - 1) {}

    'Tableau mémorisant le tag des cartes sélectionnées simultanéments
    'Initialisé à -1, car aucune carte n'est sélectionnée
    Private tagCartesChoisies() As Integer = {-1, -1, -1, -1}
    'Retient l'index du tableau précédent
    Private indexChoix As Integer

    'Tableau mémorisant le nom des cartes sélectionnées simultanéments
    'Initialisé à "", car aucune carte n'est sélectionnée
    Private nomsCartesChoisies() As String = {"", "", "", ""}

    'Tableau mémorisant le tag des cartes trouvées
    'Initialisé à -1, car aucune série n'a été trouvée
    Private seriesTerminees() As Integer = {-1, -1, -1, -1, -1}
    'Retient le nombre de série(s) terminée(s), et donc l'index du tableau précédent
    Private nbSeriesTerminees As Integer = 0

    'Vérifie si c'est la première carte qui a été tirée de tout le jeu
    Private PremiereCarte As Boolean = True
    'Retient si le jeu est en pause ou non
    Private pause As Boolean = False

    '-----------------------------------------------------------------------------------------------
    'Getters and Setters
    '-----------------------------------------------------------------------------------------------

    '@brief Retourne le temps de la partie
    '@return TEMPS_PARTIE le temps de la partie
    Public Function getTemps() As Integer
        Return TEMPS_PARTIE
    End Function

    '@brief Met le temps de la partie
    '@param[in] temps le nouveau temps de la partie
    Public Sub setTemps(temps As Integer)
        TEMPS_PARTIE = temps
    End Sub

    '-----------------------------------------------------------------------------------------------
    'Load
    '-----------------------------------------------------------------------------------------------

    '@brief Permet d'enlever le ComboBox, de sélectionner le bon BorderStyle, de tailler la fenêtre,
    'de retourner les cartes, d'afficher le nom du joueur, de convertir le temps en texte, de rendre
    'invisible le BtnReprendre, de mélanger et d'attribuer les cartes
    '@param[in] sender et e
    Private Sub FormJeu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        themeList = {ImageListDefaut, ImageListPSG}

        'Enlève le ControlBox
        Me.ControlBox = False
        'Permet de pouvoir déplacer la fenêtre, mais de ne pas pouvoir la redimensionner
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        'Adapte la taille de la fenêtre automatiquement
        Me.AutoSize = True
        retournerToutesLesCartes()

        'Affiche le nom du joueur à la place du LblJoueurModif.Text
        afficheNomJoueur()
        TEMPS_PARTIE = getTime()
        temps = TEMPS_PARTIE
        convertTempsToTempsTexte()
        LblTpsRestantModif.Text = tempsTexte

        BtnReprendre.Visible = False

        melanger(liste)
        attribuer()
    End Sub

    '-----------------------------------------------------------------------------------------------
    'Sub pour le load
    '-----------------------------------------------------------------------------------------------

    '@brief Permet de retourner les cartes des séries non-terminées
    Private Sub retournerToutesLesCartes()
        For Each carte As Label In PnlCarte.Controls
            'Si la carte fait partie d'une série terminée
            If seriesTerminees.Contains(carte.Tag) Then
                'On met l'image en noir et blanc
                carte.Image = themeList(1).Images(carte.Tag + 6)

                'On passe au suivant
                Continue For
            End If

            'On retourne la carte, en mettant la bonne image
            carte.Image = ImageListDefaut.Images(5)
        Next carte

        'On met l'index choix à 0, car aucune carte n'est sélectionnée dorénavant
        indexChoix = 0

        'On réinitialise les deux tableaux
        For i As Integer = 0 To nomsCartesChoisies.Length - 1
            nomsCartesChoisies(i) = ""
            tagCartesChoisies(i) = -1
        Next
    End Sub

    '@brief Affiche le nom du joueur à la place du LblJoueurModif.Text
    Private Sub afficheNomJoueur()
        LblJoueurModif.Text = FormMenu.ComboBoxNom.Text
    End Sub

    '@brief Convertit TEMPS_PARTIE en String pouvant être exploitable par le TimerTempsRestant
    'Le TimerTempsRestant utilise se String comme "Point de départ" du timer
    '@see TimerTempsRestant_Tick()
    Private Sub convertTempsToTempsTexte()
        Dim tempsTexteFunct As String = "0"
        'On ajoute le nombre de minutes au String tempsTexteFunct
        tempsTexteFunct &= CStr(Math.Floor(TEMPS_PARTIE / 60))
        tempsTexteFunct &= ":"
        'On ajoute le nombre de secondes au String tempsTexteFunct
        If CStr(TEMPS_PARTIE Mod 60) < 10 Then
            tempsTexteFunct &= "0" & CStr(TEMPS_PARTIE Mod 60)
        Else
            tempsTexteFunct &= CStr(TEMPS_PARTIE Mod 60)
        End If
        tempsTexte = tempsTexteFunct
    End Sub

    '@brief Mélange la liste, pour avoir les cartes mélangées
    Private Sub melanger(liste)

        'Pour générer aléatoirement le placement des cartes
        Dim random As New Random

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

    '@brief Attribue chaque tag à un numéro du tableau tabMelange()
    Private Sub attribuer()
        For i As Integer = 0 To PnlCarte.Controls.Count - 1
            PnlCarte.Controls(i).Tag = tabMelange(i)
        Next
    End Sub

    '-----------------------------------------------------------------------------------------------
    'Timer Temps Restant
    '-----------------------------------------------------------------------------------------------

    '@brief Permet le fonctionnement du TimerTempsRestant
    'Quand le timer est fini, il lance le Sub partieFinie()
    '@param[in] sender et e
    '@see partieFinie()
    Private Sub TimerTempsRestant_Tick(sender As Object, e As EventArgs) Handles TimerTempsRestant.Tick
        LblTpsRestantModif.Text =
            FormatDateTime(DateAdd(DateInterval.Second, -1, DateTime.Parse(LblTpsRestantModif.Text)), DateFormat.ShortTime)

        If LblTpsRestantModif.Text = "00:00" Then
            partieFinie()
        End If
    End Sub

    '-----------------------------------------------------------------------------------------------
    'METHODE PRINCIPALE
    'A CHAQUE CARTE CLIQUEE
    '-----------------------------------------------------------------------------------------------

    '@brief Permet de retourner les cartes et faire toutes les vérifications sur celles-ci
    'Les 20 LabelImg sont Handles
    '@param[in] sender et e
    '@see carteUnique(ByVal name As String)
    '@see carteCliqueSerieTerminee()
    '@see serieTerminee()
    '@see conversionTemps()
    '@see retournerToutesLesCartes()
    '@see partieFinie()
    '@see premierChoix()
    '@see cartesEgales()
    Private Sub CarteCliquee(sender As Object, e As EventArgs) Handles LabelImg1.Click, LabelImg3.Click, LabelImg2.Click, LabelImg9.Click, LabelImg8.Click, LabelImg7.Click, LabelImg6.Click, LabelImg5.Click, LabelImg4.Click, LabelImg20.Click, LabelImg19.Click, LabelImg18.Click, LabelImg17.Click, LabelImg16.Click, LabelImg15.Click, LabelImg14.Click, LabelImg13.Click, LabelImg12.Click, LabelImg11.Click, LabelImg10.Click
        'Si le joueur visionne la carte, rien ne peut être cliqué
        If TimerVisionnerCarte.Enabled Then
            Exit Sub
        End If

        'Si le jeu est en pause, rien ne peut être cliqué
        If pause Then
            Exit Sub
        End If

        'Lance le timer dès que la première carte est cliquée
        If PremiereCarte Then
            'Intervalle mis à 1000 pour compter 1 seconde
            TimerTempsRestant.Interval = 1000
            TimerTempsRestant.Enabled = True
            PremiereCarte = False
        End If

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

        'Vérifie si la carte cliquée fait partie d'une série déjà terminée
        If carteCliqueSerieTerminee() Then
            Exit Sub
        End If

        'Permet d'afficher la carte
        sender.image = themeList(1).Images(sender.tag)

        If serieTerminee() Then
            'Le score du joueur est incrémenté
            cartes += 1
            'Le temps du joueur est mis à jour
            temps = conversionTemps()
            'On rentre cette série comme terminée dans le tableau
            seriesTerminees(nbSeriesTerminees) = sender.tag
            nbSeriesTerminees = nbSeriesTerminees + 1
            retournerToutesLesCartes()
            'Si toutes les séries sont trouvées (et donc le tableau ne contient plus -1)
            If Not seriesTerminees.Contains(-1) Then
                partieFinie()
            End If
            Exit Sub
        End If

        If premierChoix() Then
            indexChoix += 1
            Exit Sub
        End If

        If cartesEgales() Then
            indexChoix = indexChoix + 1
        Else
            'Timer pour "mettre en suspens" le programme
            TimerVisionnerCarte.Interval = 1000
            TimerVisionnerCarte.Start()
        End If
    End Sub


    '-----------------------------------------------------------------------------------------------
    'Sub et Function pour CarteCliquée 
    '-----------------------------------------------------------------------------------------------

    '@brief Vérifie si la carte est la première sélectionnée
    '@return True si la carte est la première sélectionnée
    '@return False si la carte n'est pas la première sélectionnée
    Private Function premierChoix() As Boolean
        Return indexChoix = 0
    End Function

    '@brief Vérifie si la carte est égale à la dernière sélectionnée
    '@return True si la carte est égale à la dernière sélectionnée
    '@return False si la carte n'est pas égale à la dernière sélectionnée
    Private Function cartesEgales() As Boolean
        Return tagCartesChoisies(indexChoix) = tagCartesChoisies(indexChoix - 1)
    End Function

    '@brief Vérifie si la carte n'a pas déjà été selectionnée
    '@param[in] name le nom de la carte
    '@return True si la carte n'a pas déjà été selectionnée
    '@return False si la carte a déjà été selectionnée
    Private Function carteUnique(ByVal name As String) As Boolean
        For i As Integer = 0 To nomsCartesChoisies.Length - 1
            'Vérifie que le nom (qui est unique) fait partie du tableau nomsCartesChoisies()
            If name = nomsCartesChoisies(i) Then
                Return False
            End If
        Next

        Return True
    End Function

    '@brief Convertit le temps restant en secondes écoulées
    '@return le nombre de secondes déjà écoulées
    Private Function conversionTemps() As Integer
        Dim secondesEcoulees As Integer = 0
        secondesEcoulees = Integer.Parse(LblTpsRestantModif.Text.Chars(4)) 'Secondes
        secondesEcoulees += Integer.Parse(LblTpsRestantModif.Text.Chars(3)) * 10 'Dizaines de secondes
        secondesEcoulees += Integer.Parse(LblTpsRestantModif.Text.Chars(1)) * 60 'Minutes
        secondesEcoulees += Integer.Parse(LblTpsRestantModif.Text.Chars(0)) * 600 'Dizaines de minutes
        Return TEMPS_PARTIE - secondesEcoulees
    End Function

    '@brief Vérifie si la série est terminée
    '@return True si la série est terminée
    '@return False si la série n'est pas terminée
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

    '@brief Vérifie si la carte cliquée fait partie d'une série terminée
    '@return True si la carte cliquée fait partie d'une série terminée
    '@return False si la carte cliquée ne fait pas partie d'une série terminée
    Private Function carteCliqueSerieTerminee() As Boolean
        Return seriesTerminees.Contains(tagCartesChoisies(indexChoix))
    End Function

    '@brief Permet de suspendre l'interaction utilisateur pendant que le programme montre la mauvaise carte
    Private Sub TimerVisionnerCarte_Tick(sender As Object, e As EventArgs) Handles TimerVisionnerCarte.Tick
        TimerVisionnerCarte.Stop()
        retournerToutesLesCartes()
    End Sub

    '-----------------------------------------------------------------------------------------------
    'Pause / Reprendre
    '-----------------------------------------------------------------------------------------------

    '@brief Permet de mettre la partie en pause
    '@param[in] sender et e
    Private Sub mettreEnPause(sender As Object, e As EventArgs) Handles BtnPause.Click
        'Si la partie n'est pas commencée, rien n'est fait
        If TimerTempsRestant.Enabled = False Then
            Exit Sub
        End If
        'Cache le bouton "Pause"
        BtnPause.Visible = False
        'Rend le bouton "Reprendre" visible
        BtnReprendre.Visible = True
        'Met le boolean "pause" a True
        Me.pause = True
        'Arrête le timer
        TimerTempsRestant.Stop()
    End Sub

    '@brief Permet de reprendre la partie
    '@param[in] sender et e
    Private Sub Reprendre(sender As Object, e As EventArgs) Handles BtnReprendre.Click
        'Cache le bouton "Reprendre"
        BtnReprendre.Visible = False
        'Rend le bouton "Pause" visible
        BtnPause.Visible = True
        'Met le boolean "pause" a False
        Me.pause = False
        'Continue le timer
        TimerTempsRestant.Start()
    End Sub

    '-----------------------------------------------------------------------------------------------
    'Partie Finie
    '-----------------------------------------------------------------------------------------------

    '@brief Permet de traiter la fin de partie
    Private Sub partieFinie()
        'Stoppe le timer
        TimerTempsRestant.Enabled = False

        'Enregistre les statistiques du joueur dans la structure
        joueur.cartes = cartes
        joueur.nom = LblJoueurModif.Text
        joueur.temps = temps

        'Sauvegarde les informations du joueur
        traitementSauvegarde(joueur)

        'Si le joueur n'a trouvé aucun carré
        If temps = TEMPS_PARTIE Then
            If MsgBox(LblJoueurModif.Text & ", vous n'avez trouvé aucun carré. Votre score est donc de " & cartes &
                      ", et votre temps est de " & temps & " secondes.", vbOKOnly, "Partie perdue") = vbOK Then
                Me.Close()
                FormMenu.Show()
            End If
        Else
            If MsgBox(LblJoueurModif.Text & ", la partie est finie. Votre score est de " & cartes &
                      ", et votre temps est de " & temps & " secondes.", vbOKOnly, "Partie terminée") = vbOK Then
                Me.Close()
                FormMenu.Show()
            End If
        End If

    End Sub

    '-----------------------------------------------------------------------------------------------
    'Bouton Abandonner
    '-----------------------------------------------------------------------------------------------

    '@brief Permet d'abandonner la partie sur le clique de BtnAbandonner
    '@param[in] sender et e
    Private Sub BtnAbandonner_Click(sender As Object, e As EventArgs) Handles BtnAbandonner.Click
        If MsgBox("Voulez-vous abandonner ?",
                  vbCritical + vbYesNo + vbDefaultButton2, "Abandonner") = vbYes Then
            Me.Close()
            FormMenu.Show()
        End If
    End Sub
End Class