<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class prueva
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
        Me.components = New System.ComponentModel.Container
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Biblio_SystemDataSet = New Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSet
        Me.DevolucionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DevolucionesTableAdapter = New Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSetTableAdapters.devolucionesTableAdapter
        Me.PrestamoXIDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrestamoXIDTableAdapter = New Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSetTableAdapters.PrestamoXIDTableAdapter
        Me.CoddevolucionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodprestamoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechadevolprestDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Biblio_SystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DevolucionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrestamoXIDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Blue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(90, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(338, 38)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Lista de Devoluciones"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CoddevolucionDataGridViewTextBoxColumn, Me.CodprestamoDataGridViewTextBoxColumn, Me.FechadevolprestDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DevolucionesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(68, 138)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(378, 150)
        Me.DataGridView1.TabIndex = 9
        '
        'Biblio_SystemDataSet
        '
        Me.Biblio_SystemDataSet.DataSetName = "Biblio_SystemDataSet"
        Me.Biblio_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DevolucionesBindingSource
        '
        Me.DevolucionesBindingSource.DataMember = "devoluciones"
        Me.DevolucionesBindingSource.DataSource = Me.Biblio_SystemDataSet
        '
        'DevolucionesTableAdapter
        '
        Me.DevolucionesTableAdapter.ClearBeforeFill = True
        '
        'PrestamoXIDBindingSource
        '
        Me.PrestamoXIDBindingSource.DataMember = "PrestamoXID"
        Me.PrestamoXIDBindingSource.DataSource = Me.Biblio_SystemDataSet
        '
        'PrestamoXIDTableAdapter
        '
        Me.PrestamoXIDTableAdapter.ClearBeforeFill = True
        '
        'CoddevolucionDataGridViewTextBoxColumn
        '
        Me.CoddevolucionDataGridViewTextBoxColumn.DataPropertyName = "cod_devolucion"
        Me.CoddevolucionDataGridViewTextBoxColumn.HeaderText = "cod_devolucion"
        Me.CoddevolucionDataGridViewTextBoxColumn.Name = "CoddevolucionDataGridViewTextBoxColumn"
        Me.CoddevolucionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CodprestamoDataGridViewTextBoxColumn
        '
        Me.CodprestamoDataGridViewTextBoxColumn.DataPropertyName = "cod_prestamo"
        Me.CodprestamoDataGridViewTextBoxColumn.HeaderText = "cod_prestamo"
        Me.CodprestamoDataGridViewTextBoxColumn.Name = "CodprestamoDataGridViewTextBoxColumn"
        Me.CodprestamoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechadevolprestDataGridViewTextBoxColumn
        '
        Me.FechadevolprestDataGridViewTextBoxColumn.DataPropertyName = "fecha_devol_prest"
        Me.FechadevolprestDataGridViewTextBoxColumn.HeaderText = "fecha_devol_prest"
        Me.FechadevolprestDataGridViewTextBoxColumn.Name = "FechadevolprestDataGridViewTextBoxColumn"
        Me.FechadevolprestDataGridViewTextBoxColumn.ReadOnly = True
        '
        'prueva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 327)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "prueva"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Biblio_SystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DevolucionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrestamoXIDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Biblio_SystemDataSet As Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSet
    Friend WithEvents DevolucionesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DevolucionesTableAdapter As Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSetTableAdapters.devolucionesTableAdapter
    Friend WithEvents CoddevolucionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodprestamoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechadevolprestDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrestamoXIDBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PrestamoXIDTableAdapter As Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSetTableAdapters.PrestamoXIDTableAdapter
End Class
