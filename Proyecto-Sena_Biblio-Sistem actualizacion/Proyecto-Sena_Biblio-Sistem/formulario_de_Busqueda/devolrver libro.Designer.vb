<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class devolrver_libro
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Devolver_liDataGridView = New System.Windows.Forms.DataGridView
        Me.CodprestamoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaprestamoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodlectorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NomlectorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ApellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DEVOLUCIONESLIBROSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Biblio_SystemDataSet = New Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSet
        Me.DEVOLUCIONES_LIBROSTableAdapter = New Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSetTableAdapters.DEVOLUCIONES_LIBROSTableAdapter
        Me.DEVOLUCIONESLIBROSBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.fecha_devolucion = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.Devolver_liDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DEVOLUCIONESLIBROSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Biblio_SystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DEVOLUCIONESLIBROSBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(97, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(512, 33)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Buscar Préstamos"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(202, 129)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(248, 20)
        Me.TextBox1.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(90, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Nombre del Lector"
        '
        'Devolver_liDataGridView
        '
        Me.Devolver_liDataGridView.AllowUserToAddRows = False
        Me.Devolver_liDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.NavajoWhite
        Me.Devolver_liDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Devolver_liDataGridView.AutoGenerateColumns = False
        Me.Devolver_liDataGridView.BackgroundColor = System.Drawing.SystemColors.InactiveCaption
        Me.Devolver_liDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Devolver_liDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodprestamoDataGridViewTextBoxColumn, Me.FechaprestamoDataGridViewTextBoxColumn, Me.CodlectorDataGridViewTextBoxColumn, Me.NomlectorDataGridViewTextBoxColumn, Me.ApellidoDataGridViewTextBoxColumn, Me.fecha_devolucion})
        Me.Devolver_liDataGridView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Devolver_liDataGridView.DataSource = Me.DEVOLUCIONESLIBROSBindingSource1
        Me.Devolver_liDataGridView.Location = New System.Drawing.Point(12, 195)
        Me.Devolver_liDataGridView.MultiSelect = False
        Me.Devolver_liDataGridView.Name = "Devolver_liDataGridView"
        Me.Devolver_liDataGridView.ReadOnly = True
        Me.Devolver_liDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Devolver_liDataGridView.Size = New System.Drawing.Size(681, 220)
        Me.Devolver_liDataGridView.TabIndex = 19
        '
        'CodprestamoDataGridViewTextBoxColumn
        '
        Me.CodprestamoDataGridViewTextBoxColumn.DataPropertyName = "cod_prestamo"
        Me.CodprestamoDataGridViewTextBoxColumn.HeaderText = "cod_prestamo"
        Me.CodprestamoDataGridViewTextBoxColumn.Name = "CodprestamoDataGridViewTextBoxColumn"
        Me.CodprestamoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaprestamoDataGridViewTextBoxColumn
        '
        Me.FechaprestamoDataGridViewTextBoxColumn.DataPropertyName = "fecha_prestamo"
        Me.FechaprestamoDataGridViewTextBoxColumn.HeaderText = "fecha_prestamo"
        Me.FechaprestamoDataGridViewTextBoxColumn.Name = "FechaprestamoDataGridViewTextBoxColumn"
        Me.FechaprestamoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CodlectorDataGridViewTextBoxColumn
        '
        Me.CodlectorDataGridViewTextBoxColumn.DataPropertyName = "cod_lector"
        Me.CodlectorDataGridViewTextBoxColumn.HeaderText = "cod_lector"
        Me.CodlectorDataGridViewTextBoxColumn.Name = "CodlectorDataGridViewTextBoxColumn"
        Me.CodlectorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NomlectorDataGridViewTextBoxColumn
        '
        Me.NomlectorDataGridViewTextBoxColumn.DataPropertyName = "nom_lector"
        Me.NomlectorDataGridViewTextBoxColumn.HeaderText = "nom_lector"
        Me.NomlectorDataGridViewTextBoxColumn.Name = "NomlectorDataGridViewTextBoxColumn"
        Me.NomlectorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ApellidoDataGridViewTextBoxColumn
        '
        Me.ApellidoDataGridViewTextBoxColumn.DataPropertyName = "apellido"
        Me.ApellidoDataGridViewTextBoxColumn.HeaderText = "apellido"
        Me.ApellidoDataGridViewTextBoxColumn.Name = "ApellidoDataGridViewTextBoxColumn"
        Me.ApellidoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DEVOLUCIONESLIBROSBindingSource
        '
        Me.DEVOLUCIONESLIBROSBindingSource.DataMember = "DEVOLUCIONES_LIBROS"
        Me.DEVOLUCIONESLIBROSBindingSource.DataSource = Me.Biblio_SystemDataSet
        '
        'Biblio_SystemDataSet
        '
        Me.Biblio_SystemDataSet.DataSetName = "Biblio_SystemDataSet"
        Me.Biblio_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DEVOLUCIONES_LIBROSTableAdapter
        '
        Me.DEVOLUCIONES_LIBROSTableAdapter.ClearBeforeFill = True
        '
        'DEVOLUCIONESLIBROSBindingSource1
        '
        Me.DEVOLUCIONESLIBROSBindingSource1.DataMember = "DEVOLUCIONES_LIBROS"
        Me.DEVOLUCIONESLIBROSBindingSource1.DataSource = Me.Biblio_SystemDataSet
        '
        'fecha_devolucion
        '
        Me.fecha_devolucion.DataPropertyName = "fecha_devolucion"
        Me.fecha_devolucion.HeaderText = "fecha_devolucion"
        Me.fecha_devolucion.Name = "fecha_devolucion"
        Me.fecha_devolucion.ReadOnly = True
        '
        'devolrver_libro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(718, 447)
        Me.Controls.Add(Me.Devolver_liDataGridView)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "devolrver_libro"
        Me.Text = "Buscar prestamos"
        CType(Me.Devolver_liDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DEVOLUCIONESLIBROSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Biblio_SystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DEVOLUCIONESLIBROSBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Devolver_liDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Biblio_SystemDataSet As Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSet
    Friend WithEvents DEVOLUCIONESLIBROSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DEVOLUCIONES_LIBROSTableAdapter As Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSetTableAdapters.DEVOLUCIONES_LIBROSTableAdapter
    Friend WithEvents CodprestamoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaprestamoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodlectorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomlectorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApellidoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodlibroDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomlibroDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DEVOLUCIONESLIBROSBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents fecha_devolucion As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
