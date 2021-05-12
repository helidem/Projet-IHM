<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSauvegardeNom
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ButtonAjouter = New System.Windows.Forms.Button()
        Me.ButtonAfficher = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(341, 172)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        '
        'ButtonAjouter
        '
        Me.ButtonAjouter.Location = New System.Drawing.Point(216, 286)
        Me.ButtonAjouter.Name = "ButtonAjouter"
        Me.ButtonAjouter.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAjouter.TabIndex = 1
        Me.ButtonAjouter.Text = "Ajouter"
        Me.ButtonAjouter.UseVisualStyleBackColor = True
        '
        'ButtonAfficher
        '
        Me.ButtonAfficher.Location = New System.Drawing.Point(451, 286)
        Me.ButtonAfficher.Name = "ButtonAfficher"
        Me.ButtonAfficher.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAfficher.TabIndex = 2
        Me.ButtonAfficher.Text = "Afficher"
        Me.ButtonAfficher.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonAfficher)
        Me.Controls.Add(Me.ButtonAjouter)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ButtonAjouter As Button
    Friend WithEvents ButtonAfficher As Button
End Class
