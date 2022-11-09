<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class empleado
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(empleado))
        Me.Lista_productos = New Guna.UI.WinForms.GunaDataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BuscarCliente = New Bunifu.Framework.UI.BunifuImageButton()
        Me.txtBuscar = New Bunifu.Framework.UI.BunifuTextbox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.agregarMedicamentos = New Guna.UI.WinForms.GunaGradientTileButton()
        CType(Me.Lista_productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuscarCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lista_productos
        '
        Me.Lista_productos.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.Lista_productos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Lista_productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Lista_productos.BackgroundColor = System.Drawing.Color.White
        Me.Lista_productos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Lista_productos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Lista_productos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Lista_productos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Lista_productos.ColumnHeadersHeight = 27
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Lista_productos.DefaultCellStyle = DataGridViewCellStyle3
        Me.Lista_productos.EnableHeadersVisualStyles = False
        Me.Lista_productos.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Lista_productos.Location = New System.Drawing.Point(36, 159)
        Me.Lista_productos.Name = "Lista_productos"
        Me.Lista_productos.RowHeadersVisible = False
        Me.Lista_productos.RowHeadersWidth = 51
        Me.Lista_productos.RowTemplate.Height = 24
        Me.Lista_productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Lista_productos.Size = New System.Drawing.Size(739, 217)
        Me.Lista_productos.TabIndex = 3
        Me.Lista_productos.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.Lista_productos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.Lista_productos.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.Lista_productos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.Lista_productos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.Lista_productos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.Lista_productos.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.Lista_productos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Lista_productos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Lista_productos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Lista_productos.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.Lista_productos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.Lista_productos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.Lista_productos.ThemeStyle.HeaderStyle.Height = 27
        Me.Lista_productos.ThemeStyle.ReadOnly = False
        Me.Lista_productos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.Lista_productos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Lista_productos.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.Lista_productos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Lista_productos.ThemeStyle.RowsStyle.Height = 24
        Me.Lista_productos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Lista_productos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BunifuImageButton2)
        Me.Panel1.Controls.Add(Me.BunifuImageButton1)
        Me.Panel1.Controls.Add(Me.BuscarCliente)
        Me.Panel1.Controls.Add(Me.txtBuscar)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 97)
        Me.Panel1.TabIndex = 2
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuImageButton2.Image = CType(resources.GetObject("BunifuImageButton2.Image"), System.Drawing.Image)
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.Location = New System.Drawing.Point(483, 30)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(68, 52)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton2.TabIndex = 21
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 10
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Red
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(409, 30)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(68, 52)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 20
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'BuscarCliente
        '
        Me.BuscarCliente.BackColor = System.Drawing.Color.SeaGreen
        Me.BuscarCliente.Image = CType(resources.GetObject("BuscarCliente.Image"), System.Drawing.Image)
        Me.BuscarCliente.ImageActive = Nothing
        Me.BuscarCliente.Location = New System.Drawing.Point(335, 30)
        Me.BuscarCliente.Name = "BuscarCliente"
        Me.BuscarCliente.Size = New System.Drawing.Size(68, 52)
        Me.BuscarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BuscarCliente.TabIndex = 19
        Me.BuscarCliente.TabStop = False
        Me.BuscarCliente.Zoom = 10
        '
        'txtBuscar
        '
        Me.txtBuscar.BackColor = System.Drawing.Color.Silver
        Me.txtBuscar.BackgroundImage = CType(resources.GetObject("txtBuscar.BackgroundImage"), System.Drawing.Image)
        Me.txtBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBuscar.Icon = CType(resources.GetObject("txtBuscar.Icon"), System.Drawing.Image)
        Me.txtBuscar.Location = New System.Drawing.Point(88, 30)
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(240, 52)
        Me.txtBuscar.TabIndex = 18
        Me.txtBuscar.text = ""
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.agregarMedicamentos)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(497, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(303, 97)
        Me.Panel2.TabIndex = 0
        '
        'agregarMedicamentos
        '
        Me.agregarMedicamentos.AnimationHoverSpeed = 0.07!
        Me.agregarMedicamentos.AnimationSpeed = 0.03!
        Me.agregarMedicamentos.BackColor = System.Drawing.Color.Transparent
        Me.agregarMedicamentos.BaseColor1 = System.Drawing.Color.SlateBlue
        Me.agregarMedicamentos.BaseColor2 = System.Drawing.Color.Fuchsia
        Me.agregarMedicamentos.BorderColor = System.Drawing.Color.Black
        Me.agregarMedicamentos.BorderSize = 1
        Me.agregarMedicamentos.DialogResult = System.Windows.Forms.DialogResult.None
        Me.agregarMedicamentos.FocusedColor = System.Drawing.Color.Empty
        Me.agregarMedicamentos.Font = New System.Drawing.Font("Segoe UI Light", 15.75!)
        Me.agregarMedicamentos.ForeColor = System.Drawing.Color.White
        Me.agregarMedicamentos.Image = CType(resources.GetObject("agregarMedicamentos.Image"), System.Drawing.Image)
        Me.agregarMedicamentos.ImageSize = New System.Drawing.Size(40, 40)
        Me.agregarMedicamentos.Location = New System.Drawing.Point(58, 21)
        Me.agregarMedicamentos.Name = "agregarMedicamentos"
        Me.agregarMedicamentos.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.agregarMedicamentos.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.agregarMedicamentos.OnHoverBorderColor = System.Drawing.Color.Black
        Me.agregarMedicamentos.OnHoverForeColor = System.Drawing.Color.White
        Me.agregarMedicamentos.OnHoverImage = Nothing
        Me.agregarMedicamentos.OnPressedColor = System.Drawing.Color.Black
        Me.agregarMedicamentos.Radius = 20
        Me.agregarMedicamentos.Size = New System.Drawing.Size(196, 76)
        Me.agregarMedicamentos.TabIndex = 13
        Me.agregarMedicamentos.Text = "Nuevo "
        '
        'empleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Lista_productos)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "empleado"
        Me.Text = "empleado"
        CType(Me.Lista_productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuscarCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Lista_productos As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BuscarCliente As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents txtBuscar As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents agregarMedicamentos As Guna.UI.WinForms.GunaGradientTileButton
End Class
