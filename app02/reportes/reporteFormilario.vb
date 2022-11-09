Public Class reporteFormilario
    Private Sub reporteFormilario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Get_listaPersona' Puede moverla o quitarla según sea necesario.
        Me.Get_listaPersonaTableAdapter.Fill(Me.DataSet1.Get_listaPersona)

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport
        Me.ReportViewer1.RefreshReport
    End Sub
End Class