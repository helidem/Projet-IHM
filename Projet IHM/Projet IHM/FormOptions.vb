Public Class FormOptions


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnValiderTemps.Click
        If Not TextBoxTime.Text > 0 And TextBoxTime.Text < 599 Then
            Exit Sub
        End If

        traitementOptions.time = TextBoxTime.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnRetour.Click
        Me.Hide()
        FormMenu.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ButtonDefault.Click
        initOption()
    End Sub

    Private Sub changementTheme(sender As Object, e As EventArgs) Handles RadioButtonClassique.CheckedChanged, RadioButtonPSG.CheckedChanged, RadioButtonRMA.CheckedChanged
        If RadioButtonClassique.Checked Then
            theme = 0
        ElseIf RadioButtonPSG.Checked Then
            theme = 1
        ElseIf RadioButtonRMA.Checked Then
            theme = 2
        End If
    End Sub
End Class