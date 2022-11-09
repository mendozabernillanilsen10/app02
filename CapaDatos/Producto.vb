Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports CapaEntidad

Public Class Producto
    'get_listar_producto'

    Private conn As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ConnectionString)

    Public Function CD_lista_productos() As DataTable
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("[dbo].[get_listar_producto]", conn)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.Fill(dt)
        Return dt
    End Function

End Class
