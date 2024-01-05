Public Class GestorBaseDatos
    Public Sub New()
        comprobarbbdd()

    End Sub


    Public Sub comprobarbbdd()
        leerUSUARIOS()
        leerARTISTAS()
        leerALBUMES()
        leerCANCIONES()
        leerREPRODUCCIONES()
        leerARTISTAS_FAVORITOS()
    End Sub

    Public Sub leerUSUARIOS()
        AgenteBD.getAgente().leer("SELECT * FROM USUARIOS")
    End Sub

    Public Sub leerARTISTAS()
        AgenteBD.getAgente().leer("SELECT * FROM ARTISTAS")
    End Sub

    Public Sub leerALBUMES()
        AgenteBD.getAgente().leer("SELECT * FROM ALBUMES")
    End Sub

    Public Sub leerCANCIONES()
        AgenteBD.getAgente().leer("SELECT * FROM CANCIONES")
    End Sub

    Public Sub leerREPRODUCCIONES()
        AgenteBD.getAgente().leer("SELECT * FROM REPRODUCCIONES")
    End Sub

    Public Sub leerARTISTAS_FAVORITOS()
        AgenteBD.getAgente().leer("SELECT * FROM ARTISTAS_FAVORITOS")
    End Sub
End Class