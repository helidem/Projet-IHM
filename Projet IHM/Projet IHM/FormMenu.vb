Public Class FormMenu

    '-----------------------------------------------------------------------------------------------
    'Load
    '-----------------------------------------------------------------------------------------------

    Private Sub FormMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnJouer.Enabled = False
        Me.ControlBox = False
    End Sub

    '-----------------------------------------------------------------------------------------------
    'ComboBoxNom
    '-----------------------------------------------------------------------------------------------

    Private Sub ComboBoxName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBoxNom.KeyPress

        If e.KeyChar = vbBack Or e.KeyChar = "-" Then
            Exit Sub
        End If

        If Not Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub ComboBoxName_TextChanged(sender As Object, e As EventArgs) Handles ComboBoxNom.TextChanged
        BtnJouer.Enabled = False

        If ComboBoxNom.Text.Length > 2 Then
            BtnJouer.Enabled = True
        End If
    End Sub
    Private Sub ComboBoxNom_LostFocus(sender As Object, e As EventArgs) Handles ComboBoxNom.LostFocus
        sender.Text = StrConv(sender.Text, vbProperCase)
    End Sub
    '-----------------------------------------------------------------------------------------------
    'ButtonJouer
    '-----------------------------------------------------------------------------------------------

    Private Sub BtnJouer_Click(sender As Object, e As EventArgs) Handles BtnJouer.Click
        FormJeu.Show()
        Me.Hide()
    End Sub

    '-----------------------------------------------------------------------------------------------
    'ButtonQuitter
    '-----------------------------------------------------------------------------------------------

    Private Sub BtnQuitter_Click(sender As Object, e As EventArgs) Handles BtnQuitter.Click
        If MsgBox("Voulez-vous quitter l'application ?",
                  vbCritical + vbYesNo + vbDefaultButton2, "Vous allez quitter l'application") = vbYes Then
            Me.Close()
        End If
    End Sub
End Class
