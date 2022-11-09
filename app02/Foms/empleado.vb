Imports CapaNegocio

Public Class empleado
    Private objNegocio As New capaEmpleado
    Private Sub empleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarEmpleado()
    End Sub
    Sub MostrarEmpleado()
        Dim dt As DataTable = objNegocio.CN_listaempleado
        Me.Lista_productos.DataSource = dt
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Dim FormAgrCliente As New FormEmpleado
        FormAgrCliente.ShowDialog()
        MostrarEmpleado()
    End Sub
End Class