Imports System.IO

Module traitementsJoueurs
    'Structure de toutes les informations d'un joueur
    Structure Joueur
        Dim nom As String
        Dim temps As Integer
        Dim cartes As Integer
        Dim cumultemps As Integer
        Dim nbparties As Integer
    End Structure

    'Enregistre brièvement chaque attribut d'un joueur, séparé dans le fichier texte par ";"
    Dim txt() As String
    'Enregistre tous les joueurs
    Public tabJoueurs(0) As Joueur
    'Enregistre le nombre de joueurs
    Dim nbj As Integer = 0

    '-----------------------------------------------------------------------------------------------
    'MAIN
    '-----------------------------------------------------------------------------------------------

    '@brief Sub principal du programme. Permet de récupérer tous les joueurs depuis le fichier texte, d'initialiser les
    'options et de lancer le formulaire Menu
    '@see recupererJoueurs
    '@see initOption() de traitementOptions.vb
    Public Sub Main()
        'Récupère les joueurs depuis le fichier texte pour les mettre dans tabJoueurs
        recupererJoueurs()
        initOption()
        Application.Run(FormMenu)
    End Sub

    '-----------------------------------------------------------------------------------------------
    'recupererJoueurs et ses fonctions
    '-----------------------------------------------------------------------------------------------

    '@brief Permet de récupérer les joueurs depuis le fichier texte pour les mettre dans tabJoueurs
    '@see ajouterJoueurTab(joueur As Joueur)
    Public Sub recupererJoueurs()
        Dim FILE_NAME As String = "test.txt"
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
                    .cartes = txt(1)
                    .temps = txt(2)
                    .cumultemps = txt(3)
                    .nbparties = txt(4)
                End With
                'Passage du joueur dans tabJoueurs
                ajouterJoueurTab(j)
            Loop
            objReader.Close()
        Else
            MessageBox.Show("Le fichier n'existe pas !")
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

    '@brief Permet de traiter un joueur existant, en le mettant à jour selon les nouveaux critères
    '@param[in] joueur le Joueur à traiter
    Private Sub traiterJoueurExistant(joueur As Joueur)
        For k As Integer = 0 To tabJoueurs.Length - 1 'ancien score
            If (tabJoueurs(k).nom = joueur.nom) Then
                If joueur.cartes = 5 Then
                    tabJoueurs(k).cumultemps = tabJoueurs(k).cumultemps + joueur.temps
                Else
                    tabJoueurs(k).cumultemps = tabJoueurs(k).cumultemps + FormJeu.getTemps()
                End If

                tabJoueurs(k).nbparties = tabJoueurs(k).nbparties + 1
                If tabJoueurs(k).cartes < joueur.cartes Or (tabJoueurs(k).cartes = joueur.cartes And tabJoueurs(k).temps > joueur.temps) Then
                    MsgBox("T'as battu ton score")
                    tabJoueurs(k).cartes = joueur.cartes
                    tabJoueurs(k).temps = joueur.temps
                End If

                mettreAJour()
                Exit For
            End If
        Next
    End Sub

    Private Function joueurExistant(joueur As Joueur) As Boolean
        For i As Integer = 0 To tabJoueurs.Length - 1
            If joueur.nom = tabJoueurs(i).nom Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub mettreAJour()
        Dim f As New StreamWriter("test.txt", False)
        For Each j As Joueur In tabJoueurs
            If Not j.nom = vbNullString Then
                f.WriteLine(j.nom & ";" & j.cartes & ";" & j.temps & ";" & j.cumultemps & ";" & j.nbparties)
            End If
        Next j
        f.Close()
    End Sub

    Private Sub traiterNouveauJoueur(joueur As Joueur)
        If joueur.cartes = 5 Then
            joueur.cumultemps = joueur.cumultemps + joueur.temps
        Else
            joueur.cumultemps = joueur.cumultemps + FormJeu.getTemps()
        End If
        joueur.nbparties = 1
        My.Computer.FileSystem.WriteAllText("test.txt", joueur.nom & ";" & joueur.cartes & ";" & joueur.temps & ";" & joueur.cumultemps & ";" & joueur.nbparties & vbNewLine, True)
    End Sub
End Module
