﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormJeu
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormJeu))
        Me.LblJoueur = New System.Windows.Forms.Label()
        Me.LblJoueurModif = New System.Windows.Forms.Label()
        Me.LabelImg1 = New System.Windows.Forms.Label()
        Me.PnlCarte = New System.Windows.Forms.Panel()
        Me.LabelImg20 = New System.Windows.Forms.Label()
        Me.LabelImg19 = New System.Windows.Forms.Label()
        Me.LabelImg18 = New System.Windows.Forms.Label()
        Me.LabelImg17 = New System.Windows.Forms.Label()
        Me.LabelImg16 = New System.Windows.Forms.Label()
        Me.LabelImg15 = New System.Windows.Forms.Label()
        Me.LabelImg14 = New System.Windows.Forms.Label()
        Me.LabelImg13 = New System.Windows.Forms.Label()
        Me.LabelImg12 = New System.Windows.Forms.Label()
        Me.LabelImg11 = New System.Windows.Forms.Label()
        Me.LabelImg10 = New System.Windows.Forms.Label()
        Me.LabelImg9 = New System.Windows.Forms.Label()
        Me.LabelImg8 = New System.Windows.Forms.Label()
        Me.LabelImg7 = New System.Windows.Forms.Label()
        Me.LabelImg6 = New System.Windows.Forms.Label()
        Me.LabelImg5 = New System.Windows.Forms.Label()
        Me.LabelImg4 = New System.Windows.Forms.Label()
        Me.LabelImg3 = New System.Windows.Forms.Label()
        Me.LabelImg2 = New System.Windows.Forms.Label()
        Me.ImageListDefaut = New System.Windows.Forms.ImageList(Me.components)
        Me.LblTpsRestant = New System.Windows.Forms.Label()
        Me.LblTpsRestantModif = New System.Windows.Forms.Label()
        Me.BtnAbandonner = New System.Windows.Forms.Button()
        Me.TimerTempsRestant = New System.Windows.Forms.Timer(Me.components)
        Me.TimerVisionnerCarte = New System.Windows.Forms.Timer(Me.components)
        Me.BtnReprendre = New System.Windows.Forms.Button()
        Me.BtnPause = New System.Windows.Forms.Button()
        Me.ImageListPSG = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageListRMA = New System.Windows.Forms.ImageList(Me.components)
        Me.PnlCarte.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblJoueur
        '
        Me.LblJoueur.AutoSize = True
        Me.LblJoueur.Location = New System.Drawing.Point(50, 29)
        Me.LblJoueur.Name = "LblJoueur"
        Me.LblJoueur.Size = New System.Drawing.Size(66, 20)
        Me.LblJoueur.TabIndex = 41
        Me.LblJoueur.Text = "Joueur :"
        '
        'LblJoueurModif
        '
        Me.LblJoueurModif.AutoSize = True
        Me.LblJoueurModif.Location = New System.Drawing.Point(118, 29)
        Me.LblJoueurModif.Name = "LblJoueurModif"
        Me.LblJoueurModif.Size = New System.Drawing.Size(135, 20)
        Me.LblJoueurModif.TabIndex = 42
        Me.LblJoueurModif.Text = "<Nom du Joueur>"
        '
        'LabelImg1
        '
        Me.LabelImg1.Location = New System.Drawing.Point(28, 15)
        Me.LabelImg1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelImg1.Name = "LabelImg1"
        Me.LabelImg1.Size = New System.Drawing.Size(146, 211)
        Me.LabelImg1.TabIndex = 43
        '
        'PnlCarte
        '
        Me.PnlCarte.Controls.Add(Me.LabelImg20)
        Me.PnlCarte.Controls.Add(Me.LabelImg19)
        Me.PnlCarte.Controls.Add(Me.LabelImg18)
        Me.PnlCarte.Controls.Add(Me.LabelImg17)
        Me.PnlCarte.Controls.Add(Me.LabelImg16)
        Me.PnlCarte.Controls.Add(Me.LabelImg15)
        Me.PnlCarte.Controls.Add(Me.LabelImg14)
        Me.PnlCarte.Controls.Add(Me.LabelImg13)
        Me.PnlCarte.Controls.Add(Me.LabelImg12)
        Me.PnlCarte.Controls.Add(Me.LabelImg11)
        Me.PnlCarte.Controls.Add(Me.LabelImg10)
        Me.PnlCarte.Controls.Add(Me.LabelImg9)
        Me.PnlCarte.Controls.Add(Me.LabelImg8)
        Me.PnlCarte.Controls.Add(Me.LabelImg7)
        Me.PnlCarte.Controls.Add(Me.LabelImg6)
        Me.PnlCarte.Controls.Add(Me.LabelImg5)
        Me.PnlCarte.Controls.Add(Me.LabelImg4)
        Me.PnlCarte.Controls.Add(Me.LabelImg3)
        Me.PnlCarte.Controls.Add(Me.LabelImg2)
        Me.PnlCarte.Controls.Add(Me.LabelImg1)
        Me.PnlCarte.Location = New System.Drawing.Point(12, 148)
        Me.PnlCarte.Name = "PnlCarte"
        Me.PnlCarte.Size = New System.Drawing.Size(818, 877)
        Me.PnlCarte.TabIndex = 20
        '
        'LabelImg20
        '
        Me.LabelImg20.Location = New System.Drawing.Point(646, 648)
        Me.LabelImg20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelImg20.Name = "LabelImg20"
        Me.LabelImg20.Size = New System.Drawing.Size(146, 211)
        Me.LabelImg20.TabIndex = 62
        '
        'LabelImg19
        '
        Me.LabelImg19.Location = New System.Drawing.Point(492, 648)
        Me.LabelImg19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelImg19.Name = "LabelImg19"
        Me.LabelImg19.Size = New System.Drawing.Size(146, 211)
        Me.LabelImg19.TabIndex = 61
        '
        'LabelImg18
        '
        Me.LabelImg18.Location = New System.Drawing.Point(338, 648)
        Me.LabelImg18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelImg18.Name = "LabelImg18"
        Me.LabelImg18.Size = New System.Drawing.Size(146, 211)
        Me.LabelImg18.TabIndex = 60
        '
        'LabelImg17
        '
        Me.LabelImg17.Location = New System.Drawing.Point(183, 648)
        Me.LabelImg17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelImg17.Name = "LabelImg17"
        Me.LabelImg17.Size = New System.Drawing.Size(146, 211)
        Me.LabelImg17.TabIndex = 59
        '
        'LabelImg16
        '
        Me.LabelImg16.Location = New System.Drawing.Point(28, 648)
        Me.LabelImg16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelImg16.Name = "LabelImg16"
        Me.LabelImg16.Size = New System.Drawing.Size(146, 211)
        Me.LabelImg16.TabIndex = 58
        '
        'LabelImg15
        '
        Me.LabelImg15.Location = New System.Drawing.Point(646, 437)
        Me.LabelImg15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelImg15.Name = "LabelImg15"
        Me.LabelImg15.Size = New System.Drawing.Size(146, 211)
        Me.LabelImg15.TabIndex = 57
        '
        'LabelImg14
        '
        Me.LabelImg14.Location = New System.Drawing.Point(492, 437)
        Me.LabelImg14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelImg14.Name = "LabelImg14"
        Me.LabelImg14.Size = New System.Drawing.Size(146, 211)
        Me.LabelImg14.TabIndex = 56
        '
        'LabelImg13
        '
        Me.LabelImg13.Location = New System.Drawing.Point(338, 437)
        Me.LabelImg13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelImg13.Name = "LabelImg13"
        Me.LabelImg13.Size = New System.Drawing.Size(146, 211)
        Me.LabelImg13.TabIndex = 55
        '
        'LabelImg12
        '
        Me.LabelImg12.Location = New System.Drawing.Point(183, 437)
        Me.LabelImg12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelImg12.Name = "LabelImg12"
        Me.LabelImg12.Size = New System.Drawing.Size(146, 211)
        Me.LabelImg12.TabIndex = 54
        '
        'LabelImg11
        '
        Me.LabelImg11.Location = New System.Drawing.Point(28, 437)
        Me.LabelImg11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelImg11.Name = "LabelImg11"
        Me.LabelImg11.Size = New System.Drawing.Size(146, 211)
        Me.LabelImg11.TabIndex = 53
        '
        'LabelImg10
        '
        Me.LabelImg10.Location = New System.Drawing.Point(646, 226)
        Me.LabelImg10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelImg10.Name = "LabelImg10"
        Me.LabelImg10.Size = New System.Drawing.Size(146, 211)
        Me.LabelImg10.TabIndex = 52
        '
        'LabelImg9
        '
        Me.LabelImg9.Location = New System.Drawing.Point(492, 226)
        Me.LabelImg9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelImg9.Name = "LabelImg9"
        Me.LabelImg9.Size = New System.Drawing.Size(146, 211)
        Me.LabelImg9.TabIndex = 51
        '
        'LabelImg8
        '
        Me.LabelImg8.Location = New System.Drawing.Point(338, 226)
        Me.LabelImg8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelImg8.Name = "LabelImg8"
        Me.LabelImg8.Size = New System.Drawing.Size(146, 211)
        Me.LabelImg8.TabIndex = 50
        '
        'LabelImg7
        '
        Me.LabelImg7.Location = New System.Drawing.Point(183, 226)
        Me.LabelImg7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelImg7.Name = "LabelImg7"
        Me.LabelImg7.Size = New System.Drawing.Size(146, 211)
        Me.LabelImg7.TabIndex = 49
        '
        'LabelImg6
        '
        Me.LabelImg6.Location = New System.Drawing.Point(28, 226)
        Me.LabelImg6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelImg6.Name = "LabelImg6"
        Me.LabelImg6.Size = New System.Drawing.Size(146, 211)
        Me.LabelImg6.TabIndex = 48
        '
        'LabelImg5
        '
        Me.LabelImg5.Location = New System.Drawing.Point(646, 15)
        Me.LabelImg5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelImg5.Name = "LabelImg5"
        Me.LabelImg5.Size = New System.Drawing.Size(146, 211)
        Me.LabelImg5.TabIndex = 47
        '
        'LabelImg4
        '
        Me.LabelImg4.Location = New System.Drawing.Point(492, 15)
        Me.LabelImg4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelImg4.Name = "LabelImg4"
        Me.LabelImg4.Size = New System.Drawing.Size(146, 211)
        Me.LabelImg4.TabIndex = 46
        '
        'LabelImg3
        '
        Me.LabelImg3.Location = New System.Drawing.Point(338, 15)
        Me.LabelImg3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelImg3.Name = "LabelImg3"
        Me.LabelImg3.Size = New System.Drawing.Size(146, 211)
        Me.LabelImg3.TabIndex = 45
        '
        'LabelImg2
        '
        Me.LabelImg2.Location = New System.Drawing.Point(183, 15)
        Me.LabelImg2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelImg2.Name = "LabelImg2"
        Me.LabelImg2.Size = New System.Drawing.Size(146, 211)
        Me.LabelImg2.TabIndex = 44
        '
        'ImageListDefaut
        '
        Me.ImageListDefaut.ImageStream = CType(resources.GetObject("ImageListDefaut.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListDefaut.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListDefaut.Images.SetKeyName(0, "Card0.png")
        Me.ImageListDefaut.Images.SetKeyName(1, "Card1.png")
        Me.ImageListDefaut.Images.SetKeyName(2, "Card2.png")
        Me.ImageListDefaut.Images.SetKeyName(3, "Card3.png")
        Me.ImageListDefaut.Images.SetKeyName(4, "Card4.png")
        Me.ImageListDefaut.Images.SetKeyName(5, "BackCard.png")
        Me.ImageListDefaut.Images.SetKeyName(6, "Card0BW.png")
        Me.ImageListDefaut.Images.SetKeyName(7, "Card1BW.png")
        Me.ImageListDefaut.Images.SetKeyName(8, "Card2BW.png")
        Me.ImageListDefaut.Images.SetKeyName(9, "Card3BW.png")
        Me.ImageListDefaut.Images.SetKeyName(10, "Card4BW.png")
        '
        'LblTpsRestant
        '
        Me.LblTpsRestant.AutoSize = True
        Me.LblTpsRestant.Location = New System.Drawing.Point(334, 29)
        Me.LblTpsRestant.Name = "LblTpsRestant"
        Me.LblTpsRestant.Size = New System.Drawing.Size(119, 20)
        Me.LblTpsRestant.TabIndex = 43
        Me.LblTpsRestant.Text = "Temps restant :"
        '
        'LblTpsRestantModif
        '
        Me.LblTpsRestantModif.AutoSize = True
        Me.LblTpsRestantModif.Location = New System.Drawing.Point(452, 29)
        Me.LblTpsRestantModif.Name = "LblTpsRestantModif"
        Me.LblTpsRestantModif.Size = New System.Drawing.Size(129, 20)
        Me.LblTpsRestantModif.TabIndex = 44
        Me.LblTpsRestantModif.Text = "<Temps restant>"
        '
        'BtnAbandonner
        '
        Me.BtnAbandonner.Location = New System.Drawing.Point(694, 18)
        Me.BtnAbandonner.Name = "BtnAbandonner"
        Me.BtnAbandonner.Size = New System.Drawing.Size(112, 43)
        Me.BtnAbandonner.TabIndex = 45
        Me.BtnAbandonner.Text = "Abandonner"
        Me.BtnAbandonner.UseVisualStyleBackColor = True
        '
        'TimerTempsRestant
        '
        '
        'TimerVisionnerCarte
        '
        '
        'BtnReprendre
        '
        Me.BtnReprendre.Location = New System.Drawing.Point(694, 86)
        Me.BtnReprendre.Name = "BtnReprendre"
        Me.BtnReprendre.Size = New System.Drawing.Size(112, 43)
        Me.BtnReprendre.TabIndex = 46
        Me.BtnReprendre.Text = "Reprendre"
        Me.BtnReprendre.UseVisualStyleBackColor = True
        '
        'BtnPause
        '
        Me.BtnPause.Location = New System.Drawing.Point(694, 86)
        Me.BtnPause.Name = "BtnPause"
        Me.BtnPause.Size = New System.Drawing.Size(112, 42)
        Me.BtnPause.TabIndex = 47
        Me.BtnPause.Text = "Pause"
        Me.BtnPause.UseVisualStyleBackColor = True
        '
        'ImageListPSG
        '
        Me.ImageListPSG.ImageStream = CType(resources.GetObject("ImageListPSG.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListPSG.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListPSG.Images.SetKeyName(0, "kimpembe.png")
        Me.ImageListPSG.Images.SetKeyName(1, "marqui.png")
        Me.ImageListPSG.Images.SetKeyName(2, "mbappé.png")
        Me.ImageListPSG.Images.SetKeyName(3, "navas.png")
        Me.ImageListPSG.Images.SetKeyName(4, "verrati.png")
        Me.ImageListPSG.Images.SetKeyName(5, "BackCard.png")
        Me.ImageListPSG.Images.SetKeyName(6, "kimpembeNB.png")
        Me.ImageListPSG.Images.SetKeyName(7, "marquiNB.jpg")
        Me.ImageListPSG.Images.SetKeyName(8, "mbappéNB.jpg")
        Me.ImageListPSG.Images.SetKeyName(9, "navasNB.jpg")
        Me.ImageListPSG.Images.SetKeyName(10, "verratiNB.png")
        '
        'ImageListRMA
        '
        Me.ImageListRMA.ImageStream = CType(resources.GetObject("ImageListRMA.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListRMA.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListRMA.Images.SetKeyName(0, "benzema.png")
        Me.ImageListRMA.Images.SetKeyName(1, "kroos.png")
        Me.ImageListRMA.Images.SetKeyName(2, "courtois.png")
        Me.ImageListRMA.Images.SetKeyName(3, "modric.png")
        Me.ImageListRMA.Images.SetKeyName(4, "varane.png")
        Me.ImageListRMA.Images.SetKeyName(5, "BackCard.png")
        Me.ImageListRMA.Images.SetKeyName(6, "benzemaNB.jpg")
        Me.ImageListRMA.Images.SetKeyName(7, "courtoisNB.jpg")
        Me.ImageListRMA.Images.SetKeyName(8, "kroosNB.jpg")
        Me.ImageListRMA.Images.SetKeyName(9, "modricNB.jpg")
        Me.ImageListRMA.Images.SetKeyName(10, "varaneNB.jpg")
        '
        'FormJeu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 1049)
        Me.Controls.Add(Me.BtnPause)
        Me.Controls.Add(Me.BtnReprendre)
        Me.Controls.Add(Me.BtnAbandonner)
        Me.Controls.Add(Me.LblTpsRestantModif)
        Me.Controls.Add(Me.LblTpsRestant)
        Me.Controls.Add(Me.LblJoueurModif)
        Me.Controls.Add(Me.LblJoueur)
        Me.Controls.Add(Me.PnlCarte)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormJeu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jeu du Mémory"
        Me.PnlCarte.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblJoueur As Label
    Friend WithEvents LblJoueurModif As Label
    Friend WithEvents LabelImg1 As Label
    Friend WithEvents PnlCarte As Panel
    Friend WithEvents LabelImg16 As Label
    Friend WithEvents LabelImg15 As Label
    Friend WithEvents LabelImg14 As Label
    Friend WithEvents LabelImg13 As Label
    Friend WithEvents LabelImg12 As Label
    Friend WithEvents LabelImg11 As Label
    Friend WithEvents LabelImg10 As Label
    Friend WithEvents LabelImg9 As Label
    Friend WithEvents LabelImg8 As Label
    Friend WithEvents LabelImg7 As Label
    Friend WithEvents LabelImg6 As Label
    Friend WithEvents LabelImg5 As Label
    Friend WithEvents LabelImg4 As Label
    Friend WithEvents LabelImg3 As Label
    Friend WithEvents LabelImg2 As Label
    Friend WithEvents LabelImg20 As Label
    Friend WithEvents LabelImg19 As Label
    Friend WithEvents LabelImg18 As Label
    Friend WithEvents LabelImg17 As Label
    Friend WithEvents ImageListDefaut As ImageList
    Friend WithEvents LblTpsRestant As Label
    Friend WithEvents LblTpsRestantModif As Label
    Friend WithEvents BtnAbandonner As Button
    Private WithEvents TimerVisionnerCarte As Timer
    Private WithEvents TimerTempsRestant As Timer
    Friend WithEvents BtnReprendre As Button
    Friend WithEvents BtnPause As Button
    Friend WithEvents ImageListPSG As ImageList
    Friend WithEvents ImageListRMA As ImageList
End Class
