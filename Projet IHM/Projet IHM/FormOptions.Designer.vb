<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormOptions
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
        Me.LblTheme = New System.Windows.Forms.Label()
        Me.RadioButtonRMA = New System.Windows.Forms.RadioButton()
        Me.RadioButtonPSG = New System.Windows.Forms.RadioButton()
        Me.RadioButtonClassique = New System.Windows.Forms.RadioButton()
        Me.PnlTheme = New System.Windows.Forms.Panel()
        Me.LblTimer = New System.Windows.Forms.Label()
        Me.TextBoxTimer = New System.Windows.Forms.TextBox()
        Me.BtnValider = New System.Windows.Forms.Button()
        Me.BtnMenu = New System.Windows.Forms.Button()
        Me.BtnDefault = New System.Windows.Forms.Button()
        Me.LblTitreOptions = New System.Windows.Forms.Label()
        Me.LblDetente = New System.Windows.Forms.Label()
        Me.CheckBoxDetente = New System.Windows.Forms.CheckBox()
        Me.PnlTheme.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblTheme
        '
        Me.LblTheme.AutoSize = True
        Me.LblTheme.Location = New System.Drawing.Point(41, 294)
        Me.LblTheme.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblTheme.Name = "LblTheme"
        Me.LblTheme.Size = New System.Drawing.Size(66, 20)
        Me.LblTheme.TabIndex = 2
        Me.LblTheme.Text = "Thème :"
        '
        'RadioButtonRMA
        '
        Me.RadioButtonRMA.AutoSize = True
        Me.RadioButtonRMA.Location = New System.Drawing.Point(435, 43)
        Me.RadioButtonRMA.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RadioButtonRMA.Name = "RadioButtonRMA"
        Me.RadioButtonRMA.Size = New System.Drawing.Size(119, 24)
        Me.RadioButtonRMA.TabIndex = 2
        Me.RadioButtonRMA.TabStop = True
        Me.RadioButtonRMA.Text = "Real Madrid"
        Me.RadioButtonRMA.UseVisualStyleBackColor = True
        '
        'RadioButtonPSG
        '
        Me.RadioButtonPSG.AutoSize = True
        Me.RadioButtonPSG.Location = New System.Drawing.Point(249, 43)
        Me.RadioButtonPSG.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RadioButtonPSG.Name = "RadioButtonPSG"
        Me.RadioButtonPSG.Size = New System.Drawing.Size(68, 24)
        Me.RadioButtonPSG.TabIndex = 1
        Me.RadioButtonPSG.TabStop = True
        Me.RadioButtonPSG.Text = "PSG"
        Me.RadioButtonPSG.UseVisualStyleBackColor = True
        '
        'RadioButtonClassique
        '
        Me.RadioButtonClassique.AutoSize = True
        Me.RadioButtonClassique.Location = New System.Drawing.Point(60, 43)
        Me.RadioButtonClassique.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RadioButtonClassique.Name = "RadioButtonClassique"
        Me.RadioButtonClassique.Size = New System.Drawing.Size(103, 24)
        Me.RadioButtonClassique.TabIndex = 0
        Me.RadioButtonClassique.TabStop = True
        Me.RadioButtonClassique.Text = "Classique"
        Me.RadioButtonClassique.UseVisualStyleBackColor = True
        '
        'PnlTheme
        '
        Me.PnlTheme.Controls.Add(Me.RadioButtonRMA)
        Me.PnlTheme.Controls.Add(Me.RadioButtonPSG)
        Me.PnlTheme.Controls.Add(Me.RadioButtonClassique)
        Me.PnlTheme.Location = New System.Drawing.Point(161, 254)
        Me.PnlTheme.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PnlTheme.Name = "PnlTheme"
        Me.PnlTheme.Size = New System.Drawing.Size(618, 115)
        Me.PnlTheme.TabIndex = 3
        '
        'LblTimer
        '
        Me.LblTimer.AutoSize = True
        Me.LblTimer.Location = New System.Drawing.Point(161, 177)
        Me.LblTimer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblTimer.Name = "LblTimer"
        Me.LblTimer.Size = New System.Drawing.Size(195, 20)
        Me.LblTimer.TabIndex = 1
        Me.LblTimer.Text = "Temps de la partie (en s.) :"
        '
        'TextBoxTimer
        '
        Me.TextBoxTimer.Location = New System.Drawing.Point(494, 174)
        Me.TextBoxTimer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBoxTimer.Name = "TextBoxTimer"
        Me.TextBoxTimer.Size = New System.Drawing.Size(100, 26)
        Me.TextBoxTimer.TabIndex = 4
        '
        'BtnValider
        '
        Me.BtnValider.Location = New System.Drawing.Point(370, 399)
        Me.BtnValider.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnValider.Name = "BtnValider"
        Me.BtnValider.Size = New System.Drawing.Size(135, 49)
        Me.BtnValider.TabIndex = 5
        Me.BtnValider.Text = "Valider"
        Me.BtnValider.UseVisualStyleBackColor = True
        '
        'BtnMenu
        '
        Me.BtnMenu.Location = New System.Drawing.Point(221, 493)
        Me.BtnMenu.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnMenu.Name = "BtnMenu"
        Me.BtnMenu.Size = New System.Drawing.Size(135, 49)
        Me.BtnMenu.TabIndex = 6
        Me.BtnMenu.Text = "Menu principal"
        Me.BtnMenu.UseVisualStyleBackColor = True
        '
        'BtnDefault
        '
        Me.BtnDefault.Location = New System.Drawing.Point(518, 493)
        Me.BtnDefault.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnDefault.Name = "BtnDefault"
        Me.BtnDefault.Size = New System.Drawing.Size(135, 49)
        Me.BtnDefault.TabIndex = 7
        Me.BtnDefault.Text = "Rétablir les options par defaut"
        Me.BtnDefault.UseVisualStyleBackColor = True
        '
        'LblTitreOptions
        '
        Me.LblTitreOptions.AutoSize = True
        Me.LblTitreOptions.Font = New System.Drawing.Font("Showcard Gothic", 16.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitreOptions.Location = New System.Drawing.Point(344, 29)
        Me.LblTitreOptions.Name = "LblTitreOptions"
        Me.LblTitreOptions.Size = New System.Drawing.Size(154, 40)
        Me.LblTitreOptions.TabIndex = 8
        Me.LblTitreOptions.Text = "Options"
        '
        'LblDetente
        '
        Me.LblDetente.AutoSize = True
        Me.LblDetente.Location = New System.Drawing.Point(99, 118)
        Me.LblDetente.Name = "LblDetente"
        Me.LblDetente.Size = New System.Drawing.Size(324, 20)
        Me.LblDetente.TabIndex = 9
        Me.LblDetente.Text = "Mode détente : Pas de score, pas de temps :"
        '
        'CheckBoxDetente
        '
        Me.CheckBoxDetente.AutoSize = True
        Me.CheckBoxDetente.Location = New System.Drawing.Point(535, 119)
        Me.CheckBoxDetente.Name = "CheckBoxDetente"
        Me.CheckBoxDetente.Size = New System.Drawing.Size(22, 21)
        Me.CheckBoxDetente.TabIndex = 10
        Me.CheckBoxDetente.UseVisualStyleBackColor = True
        '
        'FormOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 566)
        Me.Controls.Add(Me.CheckBoxDetente)
        Me.Controls.Add(Me.LblDetente)
        Me.Controls.Add(Me.LblTitreOptions)
        Me.Controls.Add(Me.BtnDefault)
        Me.Controls.Add(Me.BtnMenu)
        Me.Controls.Add(Me.BtnValider)
        Me.Controls.Add(Me.TextBoxTimer)
        Me.Controls.Add(Me.PnlTheme)
        Me.Controls.Add(Me.LblTheme)
        Me.Controls.Add(Me.LblTimer)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormOptions"
        Me.Text = "FormOptions"
        Me.PnlTheme.ResumeLayout(False)
        Me.PnlTheme.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblTheme As Label
    Friend WithEvents RadioButtonRMA As RadioButton
    Friend WithEvents RadioButtonPSG As RadioButton
    Friend WithEvents RadioButtonClassique As RadioButton
    Friend WithEvents PnlTheme As Panel
    Friend WithEvents LblTimer As Label
    Friend WithEvents TextBoxTimer As TextBox
    Friend WithEvents BtnValider As Button
    Friend WithEvents BtnMenu As Button
    Friend WithEvents BtnDefault As Button
    Friend WithEvents LblTitreOptions As Label
    Friend WithEvents LblDetente As Label
    Friend WithEvents CheckBoxDetente As CheckBox
End Class
