Imports CapaNegocio


Public Class foms_productos
    Private objNegocio As New Capa_negocio_productos
    Private Sub productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarProductos()
    End Sub
    Sub MostrarProductos()
        Dim dt As DataTable = objNegocio.CN_listaProductos
        Me.Lista_productos.DataSource = dt
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Dim FormAgrCliente As New ReporteProductos
        FormAgrCliente.ShowDialog()
        MostrarProductos()
    End Sub
End Class