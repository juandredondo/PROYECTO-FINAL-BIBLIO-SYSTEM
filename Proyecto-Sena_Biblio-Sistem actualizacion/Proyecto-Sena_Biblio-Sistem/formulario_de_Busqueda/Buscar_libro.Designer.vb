<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Buscar_libro
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.CodlibroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NomlibroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NombareaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EditorialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NumcopiasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BuscarlibroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Biblio_SystemDataSet = New Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSet
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Buscar_libroTableAdapter = New Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSetTableAdapters.buscar_libroTableAdapter
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuscarlibroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Biblio_SystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 167)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(584, 361)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.NavajoWhite
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveBorder
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodlibroDataGridViewTextBoxColumn, Me.NomlibroDataGridViewTextBoxColumn, Me.NombareaDataGridViewTextBoxColumn, Me.EditorialDataGridViewTextBoxColumn, Me.NumcopiasDataGridViewTextBoxColumn})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.DataSource = Me.BuscarlibroBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.Highlight
        Me.DataGridView1.Location = New System.Drawing.Point(3, 16)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaShell
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(578, 342)
        Me.DataGridView1.TabIndex = 0
        '
        'CodlibroDataGridViewTextBoxColumn
        '
        Me.CodlibroDataGridViewTextBoxColumn.DataPropertyName = "cod_libro"
        Me.CodlibroDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.CodlibroDataGridViewTextBoxColumn.Name = "CodlibroDataGridViewTextBoxColumn"
        Me.CodlibroDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NomlibroDataGridViewTextBoxColumn
        '
        Me.NomlibroDataGridViewTextBoxColumn.DataPropertyName = "nom_libro"
        Me.NomlibroDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NomlibroDataGridViewTextBoxColumn.Name = "NomlibroDataGridViewTextBoxColumn"
        Me.NomlibroDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombareaDataGridViewTextBoxColumn
        '
        Me.NombareaDataGridViewTextBoxColumn.DataPropertyName = "nomb_area"
        Me.NombareaDataGridViewTextBoxColumn.HeaderText = "Area"
        Me.NombareaDataGridViewTextBoxColumn.Name = "NombareaDataGridViewTextBoxColumn"
        Me.NombareaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EditorialDataGridViewTextBoxColumn
        '
        Me.EditorialDataGridViewTextBoxColumn.DataPropertyName = "editorial"
        Me.EditorialDataGridViewTextBoxColumn.HeaderText = "Editorial"
        Me.EditorialDataGridViewTextBoxColumn.Name = "EditorialDataGridViewTextBoxColumn"
        Me.EditorialDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NumcopiasDataGridViewTextBoxColumn
        '
        Me.NumcopiasDataGridViewTextBoxColumn.DataPropertyName = "num_copias"
        Me.NumcopiasDataGridViewTextBoxColumn.HeaderText = "Ejemplares"
        Me.NumcopiasDataGridViewTextBoxColumn.Name = "NumcopiasDataGridViewTextBoxColumn"
        Me.NumcopiasDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BuscarlibroBindingSource
        '
        Me.BuscarlibroBindingSource.DataMember = "buscar_libro"
        Me.BuscarlibroBindingSource.DataSource = Me.Biblio_SystemDataSet
        '
        'Biblio_SystemDataSet
        '
        Me.Biblio_SystemDataSet.DataSetName = "Biblio_SystemDataSet"
        Me.Biblio_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(158, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 33)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Buscar Libro"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(135, 118)
        Me.TextBox1.MaxLength = 35
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(274, 20)
        Me.TextBox1.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Nombre del Libro"
        '
        'Buscar_libroTableAdapter
        '
        Me.Buscar_libroTableAdapter.ClearBeforeFill = True
        '
        'Buscar_libro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(638, 551)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Buscar_libro"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuscarlibroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Biblio_SystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BuscarlibroBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Biblio_SystemDataSet As Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSet
    Friend WithEvents Buscar_libroTableAdapter As Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSetTableAdapters.buscar_libroTableAdapter
    Friend WithEvents CodlibroDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomlibroDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombareaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EditorialDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumcopiasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
