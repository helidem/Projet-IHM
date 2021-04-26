Public Class Form1
    Dim Random As New Random
    Dim firstClicked As Label = Nothing
    Dim secondClicked As Label = Nothing


    Dim temporaryArray() As String = {"!", "!", "N", "N", ",", ",", "k", "k",
                                      "b", "b", "v", "v", "w", "w", "z", "z"}
    Dim icons As List(Of String) = temporaryArray.ToList()
    Private Sub AssignIconsToSquares()


        For Each control In TableLayoutPanel1.Controls
            Dim iconLabel As Label = TryCast(control, Label)
            If iconLabel IsNot Nothing Then
                Dim randomNumber As Integer = Random.Next(icons.Count)
                iconLabel.Text = icons.ElementAt(randomNumber)
                iconLabel.ForeColor = iconLabel.BackColor

            End If
        Next

    End Sub
    Public Sub New()

        InitializeComponent()

        AssignIconsToSquares()
    End Sub

    Private Sub label_Click(sender As System.Object, e As System.EventArgs) Handles Label9.Click, Label8.Click, Label7.Click, Label6.Click, Label5.Click, Label4.Click, Label3.Click, Label2.Click, Label16.Click, Label15.Click, Label14.Click, Label13.Click, Label12.Click, Label11.Click, Label10.Click, Label1.Click

        If (Timer1.Enabled = True) Then
            Return
        End If

        Dim clickedLabel As Label = TryCast(sender, Label)

        If clickedLabel IsNot Nothing Then

            If (clickedLabel.ForeColor = Color.Black) Then
                Return
            End If

            If (firstClicked Is Nothing) Then
                firstClicked = clickedLabel
                firstClicked.ForeColor = Color.Black
                Return
            End If

            secondClicked = clickedLabel
            secondClicked.ForeColor = Color.Black
            CheckForWinner()
            If (firstClicked.Text = secondClicked.Text) Then
                firstClicked = Nothing
                secondClicked = Nothing
                Return
            End If

            Timer1.Start()
        End If

    End Sub


    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick

        Timer1.Stop()


        firstClicked.ForeColor = firstClicked.BackColor
        secondClicked.ForeColor = secondClicked.BackColor

        firstClicked = Nothing
        secondClicked = Nothing
    End Sub
    Private Sub CheckForWinner()

        For Each control In TableLayoutPanel1.Controls
            Dim iconLabel As Label = TryCast(control, Label)
            If iconLabel IsNot Nothing Then
                If (iconLabel.ForeColor = iconLabel.BackColor) Then
                    Return
                End If
            End If
        Next

        MessageBox.Show("Vous avez gagn? !", "F?licitation")
        Close()

    End Sub
End Class
