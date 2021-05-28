<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormScores
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
        Me.ListBoxScores = New System.Windows.Forms.ListBox()
        Me.BtnRetour = New System.Windows.Forms.Button()
        Me.LblTitreScores = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListBoxScores
        '
        Me.ListBoxScores.FormattingEnabled = True
        Me.ListBoxScores.ItemHeight = 20
        Me.ListBoxScores.Location = New System.Drawing.Point(57, 143)
        Me.ListBoxScores.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ListBoxScores.Name = "ListBoxScores"
        Me.ListBoxScores.Size = New System.Drawing.Size(788, 464)
        Me.ListBoxScores.TabIndex = 0
        '
        'BtnRetour
        '
        Me.BtnRetour.Location = New System.Drawing.Point(385, 626)
        Me.BtnRetour.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnRetour.Name = "BtnRetour"
        Me.BtnRetour.Size = New System.Drawing.Size(153, 52)
        Me.BtnRetour.TabIndex = 1
        Me.BtnRetour.Text = "Menu principal"
        Me.BtnRetour.UseVisualStyleBackColor = True
        '
        'LblTitreScores
        '
        Me.LblTitreScores.AutoSize = True
        Me.LblTitreScores.Font = New System.Drawing.Font("Showcard Gothic", 16.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitreScores.Location = New System.Drawing.Point(290, 50)
        Me.LblTitreScores.Name = "LblTitreScores"
        Me.LblTitreScores.Size = New System.Drawing.Size(341, 40)
        Me.LblTitreScores.TabIndex = 2
        Me.LblTitreScores.Text = "Tableau des scores"
        '
        'FormScores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 701)
        Me.Controls.Add(Me.LblTitreScores)
        Me.Controls.Add(Me.BtnRetour)
        Me.Controls.Add(Me.ListBoxScores)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormScores"
        Me.Text = "Scores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBoxScores As ListBox
    Friend WithEvents BtnRetour As Button
    Friend WithEvents LblTitreScores As Label
End Class
