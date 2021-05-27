Imports System.IO

Module traitementsJoueurs
    Structure Joueur
        Dim nom As String
        Dim temps As Integer
        Dim cartes As Integer
    End Structure

    Dim txt() As String
    Dim tabJoueur(0) As Joueur
    Dim nbj As Integer = 0

    Public Sub Main()
        recupererJoueurs()
        Application.Run(FormMenu)
    End Sub

    Public Sub traitementSauvegarde(joueur As Joueur)
        If joueurExistant(joueur) Then
            For Each j As Joueur In tabJoueur 'ancien score
                If Not j.nom = vbNullString Then
                    If j.cartes < joueur.cartes Or (j.cartes = joueur.cartes And j.temps > joueur.temps) Then
                        MsgBox("T'as battu ton score" & j.cartes & " : " & joueur.cartes)
                        For i As Integer = 0 To tabJoueur.Length - 1
                            If tabJoueur(i).nom = joueur.nom Then
                                tabJoueur(i).cartes = joueur.cartes
                                tabJoueur(i).temps = joueur.temps
                            End If
                        Next
                        mettreAJour()
                    End If
                End If
            Next j
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
        My.Computer.FileSystem.WriteAllText("test.txt", joueur.nom & ";" & joueur.cartes & ";" & joueur.temps & vbNewLine, True)
    End Sub

    Private Sub recupererJoueurs()
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
                f.WriteLine(j.nom & ";" & j.cartes & ";" & j.temps)
            End If
        Next j

        f.Close()
    End Sub
End Module
