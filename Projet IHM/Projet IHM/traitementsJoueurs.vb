Imports System.IO

Module traitementsJoueurs
    Structure Joueur
        Dim nom As String
        Dim temps As Integer
        Dim cartes As Integer
        Dim cumultemps As Integer
        Dim nbparties As Integer
    End Structure

    Dim txt() As String
    Public tabJoueur(0) As Joueur
    Dim nbj As Integer = 0

    Public Sub Main()
        recupererJoueurs()
        Application.Run(FormMenu)
    End Sub

    Public Sub traitementSauvegarde(joueur As Joueur)

        recupererJoueurs()
        If joueurExistant(joueur) Then
            For k As Integer = 0 To tabJoueur.Length - 1 'ancien score
                If Not tabJoueur(k).nom = vbNullString Then
                    If tabJoueur(k).nom = joueur.nom Then
                        If joueur.cartes = 5 Then
                            tabJoueur(k).cumultemps = tabJoueur(k).cumultemps + joueur.temps
                        Else
                            tabJoueur(k).cumultemps = tabJoueur(k).cumultemps + FormJeu.getTemps()
                        End If
                        tabJoueur(k).nbparties = tabJoueur(k).nbparties + 1
                        MsgBox(tabJoueur(k).cumultemps & " " & joueur.cumultemps)
                        If tabJoueur(k).cartes < joueur.cartes Or (tabJoueur(k).cartes = joueur.cartes And tabJoueur(k).temps > joueur.temps) Then
                            MsgBox("T'as battu ton score")
                            tabJoueur(k).cartes = joueur.cartes
                            tabJoueur(k).temps = joueur.temps
                        End If
                        mettreAJour()
                        Exit For
                    End If
                End If
            Next
        Else
            appendJoueur(joueur)
        End If
    End Sub

    Private Function joueurExistant(joueur As Joueur) As Boolean
        For i As Integer = 0 To tabJoueur.Length - 1
            If joueur.nom = tabJoueur(i).nom Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub appendJoueur(joueur As Joueur)
        'Array.Clear(tabJoueur, 0, tabJoueur.Length - 1)
        If joueur.cartes = 5 Then
            joueur.cumultemps = joueur.cumultemps + joueur.temps
        Else
            joueur.cumultemps = joueur.cumultemps + FormJeu.getTemps()
        End If
        joueur.nbparties = 1
        My.Computer.FileSystem.WriteAllText("test.txt", joueur.nom & ";" & joueur.cartes & ";" & joueur.temps & ";" & joueur.cumultemps & ";" & joueur.nbparties & vbNewLine, True)
    End Sub

    Public Sub recupererJoueurs()
        Array.Clear(tabJoueur, 0, tabJoueur.Length - 1)
        Dim FILE_NAME As String = "test.txt"
        Dim TextLine As String
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objReader As New StreamReader(FILE_NAME)
            Do While objReader.Peek() <> -1
                TextLine = objReader.ReadLine()
                txt = TextLine.Split(";")
                Dim j As Joueur
                With j
                    .nom = txt(0)
                    .cartes = txt(1)
                    .temps = txt(2)
                    .cumultemps = txt(3)
                    .nbparties = txt(4)
                End With
                ajouterJoueurTab(j)
            Loop
            objReader.Close()
        Else
            MessageBox.Show("File Does Not Exist")
        End If
    End Sub

    Private Sub ajouterJoueurTab(joueur As Joueur)
        nbj += 1
        ReDim Preserve tabJoueur(nbj)
        tabJoueur(nbj - 1) = joueur
    End Sub

    Private Sub mettreAJour()
        Dim f As New StreamWriter("test.txt", False)
        For Each j As Joueur In tabJoueur
            If Not j.nom = vbNullString Then
                f.WriteLine(j.nom & ";" & j.cartes & ";" & j.temps & ";" & j.cumultemps & ";" & j.nbparties)
            End If
        Next j
        f.Close()
    End Sub
End Module
