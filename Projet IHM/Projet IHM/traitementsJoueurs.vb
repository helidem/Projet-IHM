Module traitementsJoueurs
    Structure Joueur
        Dim nom As String
        Dim temps As Integer
        Dim cartes As Integer
    End Structure

    Dim tab() As String

    Public Sub sauvegardeJoueur(ByVal joueur As Joueur)
        If joueurExistant(joueur) Then
            If Convert.ToInt32(tab(1)) < joueur.cartes Then
                MsgBox("t'as battu ton score")

            End If
        Else
            AjouterJoueur(joueur)
        End If
    End Sub

    Private Function joueurExistant(ByVal joueur As Joueur) As Boolean
        Dim FILE_NAME As String = "test.txt"
        Dim TextLine As String

        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objReader As New System.IO.StreamReader(FILE_NAME)
            Do While objReader.Peek() <> -1
                TextLine = objReader.ReadLine()
                If TextLine.Contains(joueur.nom) Then
                    tab = TextLine.Split(";")
                    objReader.Close()
                    Return True
                End If
            Loop
            objReader.Close()
        Else
            MessageBox.Show("File Does Not Exist")
        End If
        Return False
    End Function

    Private Sub AjouterJoueur(ByVal joueur As Joueur)
        My.Computer.FileSystem.WriteAllText("test.txt", joueur.nom & ";" & joueur.cartes & ";" & joueur.temps & ";" & vbNewLine, True)
    End Sub

    Private Function supprimerJoueur(ByVal joueur As Joueur) As Boolean
        Dim num As Integer = FreeFile()
        'FileOpen(num, "test.txt", OpenMode.Output)
        Dim nextLine As String
        Do Until EOF(num)
            nextLine = LineInput(num)
            If nextLine.Contains(joueur.nom) Then
                LineInput(num) = ""
            End If
        Loop
    End Function

End Module
