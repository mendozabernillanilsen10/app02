
Imports CapaNegocio

Public Class usuario
    Private objNegocio As New cls_CapaNegocioClientes
    Private Sub usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarUsuario()
    End Sub


    Sub MostrarUsuario()
        Dim dt As DataTable = objNegocio.CN_ListarUsuarios
        Me.tabla_usuarios.DataSource = dt
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Dim FormAgrCliente As New RporteUsuarios
        FormAgrCliente.ShowDialog()
        MostrarUsuario()
    End Sub
End Class