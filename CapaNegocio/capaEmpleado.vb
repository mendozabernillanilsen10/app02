Imports CapaDatos
Imports CapaEntidad
Public Class capaEmpleado
    Private objetoDatos As New datosEmpleado

    Public Function CN_listaempleado() As DataTable
        Return objetoDatos.CD_Lista_Empleado
    End Function
End Class
