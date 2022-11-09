Public Class RporteUsuarios
    Private Sub RporteUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Get_lista_usuario' Puede moverla o quitarla según sea necesario.
        Me.Get_lista_usuarioTableAdapter.Fill(Me.DataSet1.Get_lista_usuario)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class