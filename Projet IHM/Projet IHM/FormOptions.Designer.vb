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
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblTimer = New System.Windows.Forms.Label()
        Me.TextBoxTime = New System.Windows.Forms.TextBox()
        Me.BtnValiderTemps = New System.Windows.Forms.Button()
        Me.BtnRetour = New System.Windows.Forms.Button()
        Me.ButtonDefault = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblTheme
        '
        Me.LblTheme.AutoSize = True
        Me.LblTheme.Location = New System.Drawing.Point(95, 177)
        Me.LblTheme.Name = "LblTheme"
        Me.LblTheme.Size = New System.Drawing.Size(40, 13)
        Me.LblTheme.TabIndex = 2
        Me.LblTheme.Text = "Thème"
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(290, 28)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton4.TabIndex = 2
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "RadioButton4"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(166, 28)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton5.TabIndex = 1
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "RadioButton5"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(40, 28)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton6.TabIndex = 0
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.Text = "RadioButton6"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RadioButton4)
        Me.Panel1.Controls.Add(Me.RadioButton5)
        Me.Panel1.Controls.Add(Me.RadioButton6)
        Me.Panel1.Location = New System.Drawing.Point(175, 151)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(412, 75)
        Me.Panel1.TabIndex = 3
        '
        'LblTimer
        '
        Me.LblTimer.AutoSize = True
        Me.LblTimer.Location = New System.Drawing.Point(93, 100)
        Me.LblTimer.Name = "LblTimer"
        Me.LblTimer.Size = New System.Drawing.Size(147, 13)
        Me.LblTimer.TabIndex = 1
        Me.LblTimer.Text = "Temps de partie en secondes"
        '
        'TextBoxTime
        '
        Me.TextBoxTime.Location = New System.Drawing.Point(260, 97)
        Me.TextBoxTime.Name = "TextBoxTime"
        Me.TextBoxTime.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxTime.TabIndex = 4
        '
        'BtnValiderTemps
        '
        Me.BtnValiderTemps.Location = New System.Drawing.Point(428, 97)
        Me.BtnValiderTemps.Name = "BtnValiderTemps"
        Me.BtnValiderTemps.Size = New System.Drawing.Size(75, 23)
        Me.BtnValiderTemps.TabIndex = 5
        Me.BtnValiderTemps.Text = "Valider"
        Me.BtnValiderTemps.UseVisualStyleBackColor = True
        '
        'BtnRetour
        '
        Me.BtnRetour.Location = New System.Drawing.Point(15, 12)
        Me.BtnRetour.Name = "BtnRetour"
        Me.BtnRetour.Size = New System.Drawing.Size(90, 32)
        Me.BtnRetour.TabIndex = 6
        Me.BtnRetour.Text = "Menu Principal"
        Me.BtnRetour.UseVisualStyleBackColor = True
        '
        'ButtonDefault
        '
        Me.ButtonDefault.Location = New System.Drawing.Point(71, 292)
        Me.ButtonDefault.Name = "ButtonDefault"
        Me.ButtonDefault.Size = New System.Drawing.Size(151, 25)
        Me.ButtonDefault.TabIndex = 7
        Me.ButtonDefault.Text = "Rétablir les options par defaut"
        Me.ButtonDefault.UseVisualStyleBackColor = True
        '
        'FormOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 343)
        Me.Controls.Add(Me.ButtonDefault)
        Me.Controls.Add(Me.BtnRetour)
        Me.Controls.Add(Me.BtnValiderTemps)
        Me.Controls.Add(Me.TextBoxTime)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LblTheme)
        Me.Controls.Add(Me.LblTimer)
        Me.Name = "FormOptions"
        Me.Text = "FormOptions"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblTheme As Label
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LblTimer As Label
    Friend WithEvents TextBoxTime As TextBox
    Friend WithEvents BtnValiderTemps As Button
    Friend WithEvents BtnRetour As Button
    Friend WithEvents ButtonDefault As Button
End Class
