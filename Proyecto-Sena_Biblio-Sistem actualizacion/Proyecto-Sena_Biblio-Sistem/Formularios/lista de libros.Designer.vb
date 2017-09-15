<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lista_de_libros
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Biblio_SystemDataSet = New Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSet
        Me.PrestamosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrestamosTableAdapter = New Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSetTableAdapters.PrestamosTableAdapter
        Me.CodprestamoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodlectorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaprestamoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechadevolucionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Biblio_SystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrestamosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Blue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(157, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 38)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Lista de Prestamos"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Proyecto_Sena_Biblio_Sistem.My.Resources.Resources.Silver
        Me.PictureBox1.Location = New System.Drawing.Point(78, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(397, 38)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodprestamoDataGridViewTextBoxColumn, Me.CodlectorDataGridViewTextBoxColumn, Me.FechaprestamoDataGridViewTextBoxColumn, Me.FechadevolucionDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PrestamosBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(42, 113)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(478, 241)
        Me.DataGridView1.TabIndex = 7
        '
        'Biblio_SystemDataSet
        '
        Me.Biblio_SystemDataSet.DataSetName = "Biblio_SystemDataSet"
        Me.Biblio_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PrestamosBindingSource
        '
        Me.PrestamosBindingSource.DataMember = "Prestamos"
        Me.PrestamosBindingSource.DataSource = Me.Biblio_SystemDataSet
        '
        'PrestamosTableAdapter
        '
        Me.PrestamosTableAdapter.ClearBeforeFill = True
        '
        'CodprestamoDataGridViewTextBoxColumn
        '
        Me.CodprestamoDataGridViewTextBoxColumn.DataPropertyName = "cod_prestamo"
        Me.CodprestamoDataGridViewTextBoxColumn.HeaderText = "Codigo del Prestamo"
        Me.CodprestamoDataGridViewTextBoxColumn.Name = "CodprestamoDataGridViewTextBoxColumn"
        Me.CodprestamoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CodlectorDataGridViewTextBoxColumn
        '
        Me.CodlectorDataGridViewTextBoxColumn.DataPropertyName = "cod_lector"
        Me.CodlectorDataGridViewTextBoxColumn.HeaderText = "Codigo del lector"
        Me.CodlectorDataGridViewTextBoxColumn.Name = "CodlectorDataGridViewTextBoxColumn"
        Me.CodlectorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaprestamoDataGridViewTextBoxColumn
        '
        Me.FechaprestamoDataGridViewTextBoxColumn.DataPropertyName = "fecha_prestamo"
        Me.FechaprestamoDataGridViewTextBoxColumn.HeaderText = "Fecha de Prestamo"
        Me.FechaprestamoDataGridViewTextBoxColumn.Name = "FechaprestamoDataGridViewTextBoxColumn"
        Me.FechaprestamoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechadevolucionDataGridViewTextBoxColumn
        '
        Me.FechadevolucionDataGridViewTextBoxColumn.DataPropertyName = "fecha_devolucion"
        Me.FechadevolucionDataGridViewTextBoxColumn.HeaderText = "Fecha de Devolucion"
        Me.FechadevolucionDataGridViewTextBoxColumn.Name = "FechadevolucionDataGridViewTextBoxColumn"
        Me.FechadevolucionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'lista_de_libros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(554, 366)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.Name = "lista_de_libros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "lista_de_libros"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Biblio_SystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrestamosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Biblio_SystemDataSet As Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSet
    Friend WithEvents PrestamosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PrestamosTableAdapter As Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSetTableAdapters.PrestamosTableAdapter
    Friend WithEvents CodprestamoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodlectorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaprestamoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechadevolucionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
