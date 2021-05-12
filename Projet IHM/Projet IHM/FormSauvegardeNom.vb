Public Class FormSauvegardeNom
    Dim tab() As String
    Private Sub AjouterUnJoueur(sender As Object, e As EventArgs) Handles ButtonAjouter.Click
        update()
        For index As Integer = 0 To tab.Length - 1
            Debug.WriteLine(tab(index))
            If TextBox1.Text = tab(index) Or TextBox1.Text = vbNullString Then
                MessageBox.Show("existe deja")
                Exit Sub
            End If
        Next index
        My.Computer.FileSystem.WriteAllText("C:\Users\You\Documents\test.txt", TextBox1.Text + ";", True)
    End Sub

    Private Sub AfficherLesJoueurs(sender As Object, e As EventArgs) Handles ButtonAfficher.Click
        update()
        For index As Integer = 0 To tab.Length - 1
            Debug.WriteLine(tab(index))
        Next index
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        update()
    End Sub

    Private Sub update()
        Dim FILE_NAME As String = "C:\Users\You\Documents\test.txt"
        Dim TextLine As String
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objReader As New System.IO.StreamReader(FILE_NAME)
            Do While objReader.Peek() <> -1
                TextLine = TextLine & objReader.ReadLine() & vbNewLine
                tab = TextLine.Split(";")
            Loop
            objReader.Close()
        Else
            MessageBox.Show("File Does Not Exist")
        End If
    End Sub
End Class
