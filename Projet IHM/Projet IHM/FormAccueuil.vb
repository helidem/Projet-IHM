Public Class FormAccueuil


    Private Sub FormAccueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnJouer.Enabled = False
    End Sub

    Private Sub BtnQuitter_Click(sender As Object, e As EventArgs) Handles BtnQuitter.Click
        If MsgBox("Voulez-vous quitter l'application ?",
                  vbCritical + vbYesNo + vbDefaultButton2, "Vous allez quitter l'application") = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub ComboBoxName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBoxName.KeyPress
        BtnJouer.Enabled = False

        If e.KeyChar = vbBack Then 'ajouter les tirets et les chiffres

            If ComboBoxName.Text.Length - 1 > 1 Then
                check()
            End If
            Exit Sub
        End If

        If Not Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If

        If ComboBoxName.Text.Length > 1 Then
            BtnJouer.Enabled = True
        End If
    End Sub

    Private Sub check()
        If ComboBoxName.Text.Length < 3 Then
            BtnJouer.Enabled = False
        End If
    End Sub


    Private Sub ComboBoxName_TextChanged(sender As Object, e As EventArgs) Handles ComboBoxName.TextChanged
        Debug.WriteLine(ComboBoxName.Text.Length)
    End Sub

    Private Sub BtnJouer_Click(sender As Object, e As EventArgs) Handles BtnJouer.Click
        FormJeu.Show()
        Me.Hide()
    End Sub
End Class
