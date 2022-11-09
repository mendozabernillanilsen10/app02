Imports CapaDatos
Imports CapaEntidad
Public Class cls_CapaNegocioClientes


    Private objetGenero As New Genero
    Private objetoDatosCLiente As New Clientes
    Private objetUsuarios As New Usuarios
    Private objetoCategoria As New Categoria
    Public Function CN_ListarClientes() As DataTable
        Return objetoDatosCLiente.CD_ListarClientes
    End Function


    Public Function CN_BuscarCliente(texto As String) As DataTable
        Return objetoDatosCLiente.CD_BuscarCliente(texto)
    End Function

    Public Function CN_listargenro() As DataTable
        Return objetGenero.CD_LisGenero
    End Function
    Public Sub CN_InsertarClientes(CEDatos As PersonaRegistro)
        objetoDatosCLiente.CD_InsertarCliente(CEDatos)
    End Sub


    Public Function CN_InsertarCategoria(CEDatos As cat)

        objetoCategoria.CD_InsertarCategoria(CEDatos)

    End Function




    'oooooooooooooooooooooooooooo'
    Public Function CN_ListarUsuarios() As DataTable
        Return objetUsuarios.CD_ListarUsuarios
    End Function

    Public Function CN_listaCategoria() As DataTable
        Return objetoCategoria.CD_Lista_categoria
    End Function





End Class
