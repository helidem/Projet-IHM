<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenu
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ComboBoxNom = New System.Windows.Forms.ComboBox()
        Me.BtnJouer = New System.Windows.Forms.Button()
        Me.BtnOptions = New System.Windows.Forms.Button()
        Me.BtnScores = New System.Windows.Forms.Button()
        Me.BtnQuitter = New System.Windows.Forms.Button()
        Me.LblNom = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ComboBoxNom
        '
        Me.ComboBoxNom.FormattingEnabled = True
        Me.ComboBoxNom.Location = New System.Drawing.Point(237, 182)
        Me.ComboBoxNom.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComboBoxNom.Name = "ComboBoxNom"
        Me.ComboBoxNom.Size = New System.Drawing.Size(180, 28)
        Me.ComboBoxNom.TabIndex = 0
        '
        'BtnJouer
        '
        Me.BtnJouer.Location = New System.Drawing.Point(161, 253)
        Me.BtnJouer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnJouer.Name = "BtnJouer"
        Me.BtnJouer.Size = New System.Drawing.Size(188, 35)
        Me.BtnJouer.TabIndex = 1
        Me.BtnJouer.Text = "Jouer"
        Me.BtnJouer.UseVisualStyleBackColor = True
        '
        'BtnOptions
        '
        Me.BtnOptions.Location = New System.Drawing.Point(161, 298)
        Me.BtnOptions.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnOptions.Name = "BtnOptions"
        Me.BtnOptions.Size = New System.Drawing.Size(188, 35)
        Me.BtnOptions.TabIndex = 2
        Me.BtnOptions.Text = "Options"
        Me.BtnOptions.UseVisualStyleBackColor = True
        '
        'BtnScores
        '
        Me.BtnScores.Location = New System.Drawing.Point(161, 343)
        Me.BtnScores.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnScores.Name = "BtnScores"
        Me.BtnScores.Size = New System.Drawing.Size(188, 35)
        Me.BtnScores.TabIndex = 3
        Me.BtnScores.Text = "Score"
        Me.BtnScores.UseVisualStyleBackColor = True
        '
        'BtnQuitter
        '
        Me.BtnQuitter.Location = New System.Drawing.Point(161, 388)
        Me.BtnQuitter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnQuitter.Name = "BtnQuitter"
        Me.BtnQuitter.Size = New System.Drawing.Size(188, 35)
        Me.BtnQuitter.TabIndex = 4
        Me.BtnQuitter.Text = "Quitter"
        Me.BtnQuitter.UseVisualStyleBackColor = True
        '
        'LblNom
        '
        Me.LblNom.AutoSize = True
        Me.LblNom.Location = New System.Drawing.Point(83, 187)
        Me.LblNom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblNom.Name = "LblNom"
        Me.LblNom.Size = New System.Drawing.Size(142, 20)
        Me.LblNom.TabIndex = 5
        Me.LblNom.Text = "Entrez votre nom : "
        '
        'FormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 430)
        Me.Controls.Add(Me.LblNom)
        Me.Controls.Add(Me.BtnQuitter)
        Me.Controls.Add(Me.BtnScores)
        Me.Controls.Add(Me.BtnOptions)
        Me.Controls.Add(Me.BtnJouer)
        Me.Controls.Add(Me.ComboBoxNom)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu principal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBoxNom As ComboBox
    Friend WithEvents BtnJouer As Button
    Friend WithEvents BtnOptions As Button
    Friend WithEvents BtnScores As Button
    Friend WithEvents BtnQuitter As Button
    Friend WithEvents LblNom As Label
End Class
