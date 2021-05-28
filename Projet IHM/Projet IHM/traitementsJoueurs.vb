Imports System.IO

Module traitementsJoueurs
    'Structure de toutes les informations d'un joueur
    Structure Joueur
        Dim nom As String
        Dim temps As Integer
        Dim serie As Integer
        Dim cumulTemps As Integer
        Dim nbparties As Integer
    End Structure

    'Enregistre brièvement chaque attribut d'un joueur, séparé dans le fichier texte par ";"
    Private txt() As String
    'Enregistre tous les joueurs
    Public tabJoueurs(0) As Joueur
    'Enregistre le nombre de joueurs
    Private nbj As Integer = 0

    '-----------------------------------------------------------------------------------------------
    'recupererJoueurs et ses fonctions
    '-----------------------------------------------------------------------------------------------

    '@brief Permet de récupérer les joueurs depuis le fichier texte pour les mettre dans tabJoueurs
    '@see ajouterJoueurTab(joueur As Joueur)
    Public Sub recupererJoueurs()
        Dim FILE_NAME As String = "save.txt"
        Dim TextLine As String

        'Efface le tableau tabJoueurs, pour pouvoir repartir d'une bonne base
        Array.Clear(tabJoueurs, 0, tabJoueurs.Length - 1)

        If System.IO.File.Exists(FILE_NAME) Then
            Dim objReader As New StreamReader(FILE_NAME)
            Do While objReader.Peek() <> -1
                'Lecture et séparation d'une ligne
                TextLine = objReader.ReadLine()
                txt = TextLine.Split(";")
                Dim j As Joueur
                'Enregistrement du joueur dans la structure
                With j
                    .nom = txt(0)
                    .serie = txt(1)
                    .temps = txt(2)
                    .cumulTemps = txt(3)
                    .nbparties = txt(4)
                End With
                'Passage du joueur dans tabJoueurs
                ajouterJoueurTab(j)
            Loop
            objReader.Close()
        Else
            MessageBox.Show("Le fichier n'existe pas !")
            Application.Exit()
        End If
    End Sub

    '@brief Ajoute un joueur dans le tableau tabJoueurs
    '@param[in] joueur le Joueur à passer dans le tableau
    Private Sub ajouterJoueurTab(joueur As Joueur)
        nbj += 1
        ReDim Preserve tabJoueurs(nbj)
        tabJoueurs(nbj - 1) = joueur
    End Sub

    '-----------------------------------------------------------------------------------------------
    'Fonction principale : traiter chaque joueur
    '-----------------------------------------------------------------------------------------------

    '@brief Permet de traiter la sauvegarde ou la modification d'un joueur
    '@param[in] joueur le joueur à sauvegarder
    '@see partieFinie() de FormJeu
    '@see recupererJoueurs()
    '@see mettreAJour()
    '@see appendJoueur()
    Public Sub traitementSauvegarde(joueur As Joueur)
        recupererJoueurs()
        If joueurExistant(joueur) Then
            traiterJoueurExistant(joueur)
        Else
            traiterNouveauJoueur(joueur)
        End If
    End Sub

    '@brief Vérifie si un joueur est déjà répertorié dans la sauvegarde ou non
    '@param[in] joueur le Joueur à vérifier
    '@return True si le joueur est répertorié dans la sauvegarde
    '@return False si le joueur n'est pas répertorié dans la sauvegarde
    Private Function joueurExistant(joueur As Joueur) As Boolean
        For i As Integer = 0 To tabJoueurs.Length - 1
            If joueur.nom = tabJoueurs(i).nom Then
                Return True
            End If
        Next
        Return False
    End Function

    '@brief Permet de traiter un joueur existant, en le mettant à jour selon les nouveaux critères
    '@param[in] joueur le Joueur à traiter
    '@see FormJeu.getTemps()
    Private Sub traiterJoueurExistant(joueur As Joueur)
        For k As Integer = 0 To tabJoueurs.Length - 1
            'Si le nom du joueur est déjà enregistré
            If (tabJoueurs(k).nom = joueur.nom) Then
                If joueur.serie = 5 Then
                    'Si le joueur à un score maximal, alors son temps nous intéresse, car c'est le temps qu'il a joué.
                    'Nous additionnons donc son temps avec son cumulTemps.
                    tabJoueurs(k).cumulTemps += joueur.temps
                Else
                    'Si le joueur n'a pas le score maximal, alors le TEMPS_MAXIMAL nous intéresse.
                    'Nous additionnons donc le TEMPS_MAXIMAL (trouvé grâce au Getter) avec son cumulTemps.
                    tabJoueurs(k).cumulTemps += FormJeu.getTemps()
                End If

                'Incrémentation du nombre de parties
                tabJoueurs(k).nbparties += 1

                'Si le joueur a trouvé un plus grand nombre de série, ou si il a mis moins de temps pour trouver le même nombre
                If tabJoueurs(k).serie < joueur.serie Or (tabJoueurs(k).serie = joueur.serie And tabJoueurs(k).temps > joueur.temps) Then
                    MsgBox("FELICITATION !! TU AS BATTU TON MEILLEUR SCORE", , "Félicitation")
                    'Mise à jour du record
                    tabJoueurs(k).serie = joueur.serie
                    tabJoueurs(k).temps = joueur.temps
                End If

                mettreAJour()
                Exit For
            End If
        Next
    End Sub

    '@brief Permet de mettre à jour le fichier texte
    Private Sub mettreAJour()
        Dim f As New StreamWriter("save.txt", False)
        For Each j As Joueur In tabJoueurs
            'Permet de ne pas écrire si le nom est nul, à cause du vbNewLine
            If Not j.nom = vbNullString Then
                f.WriteLine(j.nom & ";" & j.serie & ";" & j.temps & ";" & j.cumulTemps & ";" & j.nbparties)
            End If
        Next j
        f.Close()
    End Sub

    '@brief Permet de traiter un nouveau joueur, en l'initialisant
    '@param[in] joueur le Joueur à traiter
    '@see FormJeu.getTemps()
    Private Sub traiterNouveauJoueur(joueur As Joueur)
        If joueur.serie = 5 Then
            joueur.cumulTemps = joueur.cumulTemps + joueur.temps
        Else
            joueur.cumulTemps = joueur.cumulTemps + FormJeu.getTemps()
        End If
        'Initialisation de son nombre de parties
        joueur.nbparties = 1
        'Ecriture du nouveau joueur dans le fichier de sauvegarde
        My.Computer.FileSystem.WriteAllText("save.txt", joueur.nom & ";" & joueur.serie & ";" & joueur.temps & ";" & joueur.cumulTemps & ";" & joueur.nbparties & vbNewLine, True)
    End Sub
End Module
