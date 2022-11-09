Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports CapaEntidad

Public Class estado_cliente
    Private conn As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ConnectionString)

    Public Function CD_Lista_EstadoCliente() As DataTable
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("[dbo].[get_lista_estado_cliente]", conn)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.Fill(dt)
        Return dt
    End Function
End Class




