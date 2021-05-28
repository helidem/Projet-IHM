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
        Me.PanelTimer = New System.Windows.Forms.Panel()
        Me.LblTimer = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.LblTheme = New System.Windows.Forms.Label()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelTimer.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelTimer
        '
        Me.PanelTimer.Controls.Add(Me.RadioButton3)
        Me.PanelTimer.Controls.Add(Me.RadioButton2)
        Me.PanelTimer.Controls.Add(Me.RadioButton1)
        Me.PanelTimer.Location = New System.Drawing.Point(183, 72)
        Me.PanelTimer.Name = "PanelTimer"
        Me.PanelTimer.Size = New System.Drawing.Size(412, 75)
        Me.PanelTimer.TabIndex = 0
        '
        'LblTimer
        '
        Me.LblTimer.AutoSize = True
        Me.LblTimer.Location = New System.Drawing.Point(93, 100)
        Me.LblTimer.Name = "LblTimer"
        Me.LblTimer.Size = New System.Drawing.Size(83, 13)
        Me.LblTimer.TabIndex = 1
        Me.LblTimer.Text = "Temps de partie"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(40, 28)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(166, 28)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "RadioButton2"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(290, 28)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "RadioButton3"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'LblTheme
        '
        Me.LblTheme.AutoSize = True
        Me.LblTheme.Location = New System.Drawing.Point(103, 219)
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
        Me.Panel1.Location = New System.Drawing.Point(183, 193)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(412, 75)
        Me.Panel1.TabIndex = 3
        '
        'FormOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 343)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LblTheme)
        Me.Controls.Add(Me.LblTimer)
        Me.Controls.Add(Me.PanelTimer)
        Me.Name = "FormOptions"
        Me.Text = "FormOptions"
        Me.PanelTimer.ResumeLayout(False)
        Me.PanelTimer.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelTimer As Panel
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents LblTimer As Label
    Friend WithEvents LblTheme As Label
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents Panel1 As Panel
End Class
