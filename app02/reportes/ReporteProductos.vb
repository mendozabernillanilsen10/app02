Public Class ReporteProductos
    Private Sub ReporteProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.get_listar_producto' Puede moverla o quitarla según sea necesario.
        Me.Get_listar_productoTableAdapter.Fill(Me.DataSet1.get_listar_producto)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class