Public Class FormOptions
    '@brief Permet d'enlever le ComboBox, de sélectionner le bon BorderStyle, et de tailler la fenêtre
    '@param[in] sender et e
    Private Sub FormOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Enlève le ControlBox
        Me.ControlBox = False
        'Permet de pouvoir déplacer la fenêtre, mais de ne pas pouvoir la redimensionner
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        'Adapte la taille de la fenêtre automatiquement
        Me.AutoSize = True
        'Change l'icone
        Me.Icon = My.Resources.game
    End Sub

    '-----------------------------------------------------------------------------------------------
    'Mode détente
    '-----------------------------------------------------------------------------------------------

    Private Sub dedente_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxDetente.CheckedChanged
        If CheckBoxDetente.Checked Then
            TextBoxTimer.Enabled = False
            TextBoxTimer.Text = vbNullString
        Else
            TextBoxTimer.Enabled = True
        End If
    End Sub

    '-----------------------------------------------------------------------------------------------
    'Valider et mettre les options
    '-----------------------------------------------------------------------------------------------

    '@brief Permet de valider les options en appuyant sur BtnValider
    '@see verifTemps()
    '@see putOptions()
    Private Sub validerOption() Handles BtnValider.Click
        LblTimer.ForeColor = Color.Black

        If ckTemps() Then
            putOptions()
        End If
    End Sub

    '@brief Permet de mettre les options
    '@see traitementsOptions.setTime(timeV As Integer)
    '@see traitementsOptions.setTheme(themeV As Integer)
    Private Sub putOptions()
        traitementsOptions.setDetente(CheckBoxDetente.Checked)

        If RadioButtonClassique.Checked Then
            traitementsOptions.setTheme(0)
        ElseIf RadioButtonPSG.Checked Then
            traitementsOptions.setTheme(1)
        ElseIf RadioButtonRMA.Checked Then
            traitementsOptions.setTheme(2)
        End If

        If CheckBoxDetente.Checked Then
            MsgBox("Les paramètres ont été changés. Le mode détente est activé, et le thème est le n°" & traitementsOptions.getTheme + 1 & ".")
        Else
            traitementsOptions.setTime(TextBoxTimer.Text)
            MsgBox("Les paramètres ont été changés. Le temps est de " & traitementsOptions.getTime _
                   & " secondes, et le thème est le n°" & traitementsOptions.getTheme + 1 & ".")
        End If

        Me.Close()
        FormMenu.Show()
    End Sub

    '-----------------------------------------------------------------------------------------------
    'Vérifications Temps
    '-----------------------------------------------------------------------------------------------

    '@brief Permet de vérifier si le temps est correctement entré
    '@return True si le temps est correctement entré
    '@return False si le temps n'est pas correctement entré
    Private Function ckTemps() As Boolean
        If Not CheckBoxDetente.Checked Then
            If (TextBoxTimer.Text = "") OrElse TextBoxTimer.Text = 0 _
                OrElse TextBoxTimer.Text > 599 Then
                LblTimer.ForeColor = Color.Red
                MsgBox("Vous devez entrer comme temps une valeur comprise entre 1 et 599.", vbOKOnly)
                Return False
            End If
        End If
        Return True
    End Function

    '@brief Vérifie que le temps entré sois un nombre à chaque KeyPress
    '@param[in] sender et e
    Private Sub verifTempsDigit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxTimer.KeyPress
        If e.KeyChar = vbBack Then
            Exit Sub
        End If

        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    '-----------------------------------------------------------------------------------------------
    'Rétablir par défault et retour au menu principal
    '-----------------------------------------------------------------------------------------------

    '@brief Rétablit les paramètres par défault, en appuyant sur BtnDefault
    '@param[in] sender et e
    '@see le module traitementOptions.vb
    Private Sub retablirDefault(sender As Object, e As EventArgs) Handles BtnDefault.Click
        traitementsOptions.initOption()
        MsgBox("Les paramètres ont été rétablis par défault. Le mode détente est désactivé, le temps est de " _
               & traitementsOptions.getTime & " secondes, et le thème est le n°" & traitementsOptions.getTheme + 1 & ".")
        Me.Close()
        FormMenu.Show()
    End Sub

    '@brief Permet le retour au menu, en appuyant sur BtnMenu
    '@param[in] sender et e
    Private Sub retourMenu(sender As Object, e As EventArgs) Handles BtnMenu.Click
        Me.Close()
        FormMenu.Show()
    End Sub
End Class