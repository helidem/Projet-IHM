Module traitementsOptions
    'Enregistre le temps de la partie
    Private time As Integer
    'Enregistre le thème de la partie
    Private theme As Integer
    'Enregistre s'il y a ou non le mode détente
    Private detente As Boolean

    '@brief Permet d'initialiser les options aux valeurs de base
    Public Sub initOption()
        time = 90
        theme = 0
        detente = False
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

    '@brief Retourne le boolean detente
    '@return detente le boolean detente
    Public Function getDetente() As Integer
        Return detente
    End Function

    '@brief Change le boolean detente
    '@param[in] detente le boolean contenant le nouveau boolean detente
    Public Sub setDetente(detenteV As Boolean)
        detente = detenteV
    End Sub
End Module
