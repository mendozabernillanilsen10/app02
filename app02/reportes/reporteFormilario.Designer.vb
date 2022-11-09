<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class reporteFormilario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DataSet1 = New appfarmaciaa.DataSet1()
        Me.DataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.get_lista_categoriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Get_listaPersonaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GetlistaPersonaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Get_listaPersonaTableAdapter = New appfarmaciaa.DataSet1TableAdapters.Get_listaPersonaTableAdapter()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.get_lista_categoriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Get_listaPersonaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GetlistaPersonaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.GetlistaPersonaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "appfarmaciaa.reporteclientes.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(967, 649)
        Me.ReportViewer1.TabIndex = 0
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataSet1BindingSource
        '
        Me.DataSet1BindingSource.DataSource = Me.DataSet1
        Me.DataSet1BindingSource.Position = 0
        '
        'get_lista_categoriaBindingSource
        '
        Me.get_lista_categoriaBindingSource.DataMember = "get_lista_categoria"
        Me.get_lista_categoriaBindingSource.DataSource = Me.DataSet1
        '
        'Get_listaPersonaBindingSource
        '
        Me.Get_listaPersonaBindingSource.DataMember = "Get_listaPersona"
        Me.Get_listaPersonaBindingSource.DataSource = Me.DataSet1
        '
        'GetlistaPersonaBindingSource
        '
        Me.GetlistaPersonaBindingSource.DataMember = "Get_listaPersona"
        Me.GetlistaPersonaBindingSource.DataSource = Me.DataSet1BindingSource
        '
        'Get_listaPersonaTableAdapter
        '
        Me.Get_listaPersonaTableAdapter.ClearBeforeFill = True
        '
        'reporteFormilario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 649)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "reporteFormilario"
        Me.Text = "reporteFormilario"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.get_lista_categoriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Get_listaPersonaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GetlistaPersonaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DataSet1BindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents get_lista_categoriaBindingSource As BindingSource
    Friend WithEvents Get_listaPersonaBindingSource As BindingSource
    Friend WithEvents GetlistaPersonaBindingSource As BindingSource
    Friend WithEvents Get_listaPersonaTableAdapter As DataSet1TableAdapters.Get_listaPersonaTableAdapter
End Class
