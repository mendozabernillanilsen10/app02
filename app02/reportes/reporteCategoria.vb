Public Class reporteCategoria
    Private Sub reporteCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.get_lista_categoria' Puede moverla o quitarla según sea necesario.
        Me.Get_lista_categoriaTableAdapter.Fill(Me.DataSet1.get_lista_categoria)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class