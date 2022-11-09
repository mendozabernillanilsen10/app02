Public Class FormEmpleado
    Private Sub FormEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.get_lista_empleado' Puede moverla o quitarla según sea necesario.
        Me.Get_lista_empleadoTableAdapter.Fill(Me.DataSet1.get_lista_empleado)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class