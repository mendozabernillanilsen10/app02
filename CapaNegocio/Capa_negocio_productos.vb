Imports CapaDatos
Imports CapaEntidad

Public Class Capa_negocio_productos
    Private objetoDatos As New Producto

    Public Function CN_listaProductos() As DataTable
        Return objetoDatos.CD_lista_productos
    End Function
End Class
