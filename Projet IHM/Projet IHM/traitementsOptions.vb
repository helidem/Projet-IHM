Module traitementsOptions
    Private time As Integer
    Private theme As Integer

    '@brief Permet d'initialiser les options aux valeurs de base
    Public Sub initOption()
        'Enregistre le temps de la partie
        time = 90
        'Enregistre le thème de la partie
        theme = 0
    End Sub

    '-----------------------------------------------------------------------------------------------
    'Getters et Setters
    '-----------------------------------------------------------------------------------------------

    '@brief Retourne l'attribut time
    '@return time l'attribut time
    Public Function getTime() As Integer
        Return time
    End Function

    '@brief Change l'attribut time
    '@param[in] timeV la variable contenant le nouvel attribut time
    Public Sub setTime(timeV As Integer)
        time = timeV
    End Sub

    '@brief Retourne l'attribut thème
    '@return thème l'attribut thème
    Public Function getTheme() As Integer
        Return theme
    End Function

    '@brief Change l'attribut thème
    '@param[in] thèmeV la variable contenant le nouvel attribut thème
    Public Sub setTheme(themeV As Integer)
        theme = themeV
    End Sub
End Module
