Imports CapaNegocio

Public Class categoria
    Private objNegocio As New cls_CapaNegocioClientes
    Private Sub categoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarCategoria()
    End Sub



    Sub MostrarCategoria()
        Dim dt As DataTable = objNegocio.CN_listaCategoria
        Me.tabla_categoria.DataSource = dt
    End Sub


    Private Sub agregarcategoria_Click(sender As Object, e As EventArgs) Handles agregarcategoria.Click
        Dim FormAgrCliente As New AgregarCategoria
        FormAgrCliente.ShowDialog()
        MostrarCategoria()
    End Sub


    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        'reporteCategoria'
        Dim FormAgrCliente As New reporteCategoria
        FormAgrCliente.ShowDialog()
        MostrarCategoria()
    End Sub
End Class