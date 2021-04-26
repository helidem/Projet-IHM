Public Class FormJeu

    Dim random As New Random

    '-----------------------------------------------------------------------------------------------
    'Load
    '-----------------------------------------------------------------------------------------------

    Private Sub FormJeu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ControlBox = False
        changeNomJoueur()
    End Sub

    Private Sub changeNomJoueur()
        LblJoueurModif.Text = FormMenu.ComboBoxNom.Text
    End Sub
End Class