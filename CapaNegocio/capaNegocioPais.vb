Imports CapaEntidad
Imports CapaDatos

Public Class capaNegocioPais
    Private objDatosPais As New Pais


    Public Function CN_ListarPais() As DataTable
        Return objDatosPais.CD_ListarPais
    End Function


    Public Function CD_BuscarPais(texto As String) As DataTable
        Return objDatosPais.CD_BuscarPais(texto)
    End Function

    Public Function CN_BuscarProvincia(texto As String) As DataTable

        Return objDatosPais.CD_BuscarProvincia(texto)
    End Function


    Public Function CN_ListarDistrito(texto As String) As DataTable
        Return objDatosPais.CD_ListarDistrito(texto)
    End Function
End Class
