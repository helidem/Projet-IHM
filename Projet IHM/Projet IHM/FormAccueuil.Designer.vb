<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAccueuil
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
        Me.ComboBoxName = New System.Windows.Forms.ComboBox()
        Me.BtnJouer = New System.Windows.Forms.Button()
        Me.BtnOptions = New System.Windows.Forms.Button()
        Me.BtnScores = New System.Windows.Forms.Button()
        Me.BtnQuitter = New System.Windows.Forms.Button()
        Me.LblName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ComboBoxName
        '
        Me.ComboBoxName.FormattingEnabled = True
        Me.ComboBoxName.Location = New System.Drawing.Point(208, 238)
        Me.ComboBoxName.Name = "ComboBoxName"
        Me.ComboBoxName.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxName.TabIndex = 0
        '
        'BtnJouer
        '
        Me.BtnJouer.Location = New System.Drawing.Point(157, 301)
        Me.BtnJouer.Name = "BtnJouer"
        Me.BtnJouer.Size = New System.Drawing.Size(125, 23)
        Me.BtnJouer.TabIndex = 1
        Me.BtnJouer.Text = "Jouer"
        Me.BtnJouer.UseVisualStyleBackColor = True
        '
        'BtnOptions
        '
        Me.BtnOptions.Location = New System.Drawing.Point(157, 354)
        Me.BtnOptions.Name = "BtnOptions"
        Me.BtnOptions.Size = New System.Drawing.Size(125, 23)
        Me.BtnOptions.TabIndex = 2
        Me.BtnOptions.Text = "Options"
        Me.BtnOptions.UseVisualStyleBackColor = True
        '
        'BtnScores
        '
        Me.BtnScores.Location = New System.Drawing.Point(157, 411)
        Me.BtnScores.Name = "BtnScores"
        Me.BtnScores.Size = New System.Drawing.Size(125, 23)
        Me.BtnScores.TabIndex = 3
        Me.BtnScores.Text = "Score"
        Me.BtnScores.UseVisualStyleBackColor = True
        '
        'BtnQuitter
        '
        Me.BtnQuitter.Location = New System.Drawing.Point(157, 470)
        Me.BtnQuitter.Name = "BtnQuitter"
        Me.BtnQuitter.Size = New System.Drawing.Size(125, 23)
        Me.BtnQuitter.TabIndex = 4
        Me.BtnQuitter.Text = "Quitter"
        Me.BtnQuitter.UseVisualStyleBackColor = True
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.Location = New System.Drawing.Point(105, 241)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(82, 13)
        Me.LblName.TabIndex = 5
        Me.LblName.Text = "Entre ton nom : "
        '
        'FormAccueuil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 617)
        Me.Controls.Add(Me.LblName)
        Me.Controls.Add(Me.BtnQuitter)
        Me.Controls.Add(Me.BtnScores)
        Me.Controls.Add(Me.BtnOptions)
        Me.Controls.Add(Me.BtnJouer)
        Me.Controls.Add(Me.ComboBoxName)
        Me.Name = "FormAccueuil"
        Me.Text = "Accueil"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBoxName As ComboBox
    Friend WithEvents BtnJouer As Button
    Friend WithEvents BtnOptions As Button
    Friend WithEvents BtnScores As Button
    Friend WithEvents BtnQuitter As Button
    Friend WithEvents LblName As Label
End Class
