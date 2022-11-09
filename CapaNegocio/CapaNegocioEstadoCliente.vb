Imports CapaDatos
Imports CapaEntidad

Public Class CapaNegocioEstadoCliente
    Private objetoEstadoCliente As New estado_cliente

    Public Function CN_listaEstadoCliente() As DataTable
        Return objetoEstadoCliente.CD_Lista_EstadoCliente
    End Function
End Class
