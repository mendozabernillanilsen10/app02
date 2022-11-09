
Imports CapaNegocio
Imports CapaEntidad
Public Class AgregarCliente
    Private objNegocio As New cls_CapaNegocioClientes
    Dim Persona As New PersonaRegistro
    Private objetoEstadoCliente As New CapaNegocioEstadoCliente
    Private objetoNegocioPais As New capaNegocioPais


    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        listarPais()
        listadoEstado()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        conoboGenero()

    End Sub


    Public Sub listarPais()
        Dim table As DataTable = objetoNegocioPais.CN_ListarPais
        comboPais.DataSource = table
        comboPais.DisplayMember = "nacionalidad"
        comboPais.ValueMember = "idPais"
    End Sub

    Public Sub listadoEstado()
        Dim table As DataTable = objetoEstadoCliente.CN_listaEstadoCliente
        combo_estado.DataSource = table
        combo_estado.DisplayMember = "nombre_estado"
        combo_estado.ValueMember = "id_estado"
    End Sub




    Public Sub conoboGenero()
        Dim table As DataTable = objNegocio.CN_listargenro
        Genero.DataSource = table
        Genero.DisplayMember = "nombre_genero"
        Genero.ValueMember = "id_genero"
    End Sub





    Private Sub comboPais_SelectedValueChanged(sender As Object, e As EventArgs) Handles comboPais.SelectedValueChanged
        Dim cod As Integer = Val(comboPais.SelectedValue.ToString)
        Dim table As DataTable = objetoNegocioPais.CD_BuscarPais(cod)
        ConboDepartamento.DataSource = table
        ConboDepartamento.DisplayMember = "departamento"
        ConboDepartamento.ValueMember = "idDepartamento"
    End Sub


    Private Sub ConboDepartamento_SelectedValueChanged(sender As Object, e As EventArgs) Handles ConboDepartamento.SelectedValueChanged
        Dim cod2 As Integer = Val(ConboDepartamento.SelectedValue.ToString)
        Dim table As DataTable = objetoNegocioPais.CN_BuscarProvincia(cod2)
        ComboBoxProvincia.DataSource = table
        ComboBoxProvincia.DisplayMember = "provincia"
        ComboBoxProvincia.ValueMember = "idProvincia"
    End Sub

    Private Sub ComboBoxProvincia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxProvincia.SelectedValueChanged

        Dim cod2 As Integer = Val(ComboBoxProvincia.SelectedValue.ToString)
        Dim table As DataTable = objetoNegocioPais.CN_ListarDistrito(cod2)
        conboDistrito.DataSource = table
        conboDistrito.DisplayMember = "distrito"
        conboDistrito.ValueMember = "idDistrito"

    End Sub

    Private Sub AgregarPersonas_Click(sender As Object, e As EventArgs) Handles AgregarPersonas.Click
        Persona.apellidos = txtApellido.Text
        Persona.nombres = txtNombre.Text
        Persona.fecha_nacimiento = Format(fechaNacimiento.Value, "yyyy-MM-dd")
        Persona.nombreDireccion = DIreccion.Text
        Persona.id_distrito = Val(conboDistrito.SelectedValue.ToString)
        Persona.id_genero = Val(Genero.SelectedValue.ToString)
        Persona.id_estado = Val(combo_estado.SelectedValue.ToString)
        Persona.dni = Dni.Text
        objNegocio.CN_InsertarClientes(Persona)
        MessageBox.Show("Se registró correctamente el cliente")
        Close()

    End Sub

    Private Sub combo_estado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_estado.SelectedValueChanged

    End Sub

    Private Sub Genero_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Genero.SelectedValueChanged

    End Sub
End Class