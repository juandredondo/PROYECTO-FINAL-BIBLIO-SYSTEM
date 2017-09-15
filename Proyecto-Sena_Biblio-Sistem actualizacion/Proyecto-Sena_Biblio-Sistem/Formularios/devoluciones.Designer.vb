<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class devoluciones
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
        Me.DateTimePicker1Devol = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.boton_guardar = New System.Windows.Forms.Button
        Me.boton_cancelar = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.label_total = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.fechdev = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.CodlibroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CanttotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NomlibroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PrestamoXIDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Biblio_SystemDataSet = New Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSet
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Apellido_leTextBox6 = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.nomb_lecTextBox5 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cod_lectTextBox4 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.buscarn = New System.Windows.Forms.Button
        Me.fecha_pTextBox2 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Codig_pTextBox1 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.IdDevol = New System.Windows.Forms.Label
        Me.PrestamoXIDTableAdapter = New Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSetTableAdapters.PrestamoXIDTableAdapter
        Me.Contar_max_devolBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Contar_max_devolTableAdapter = New Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSetTableAdapters.contar_max_devolTableAdapter
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrestamoXIDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Biblio_SystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Contar_max_devolBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePicker1Devol
        '
        Me.DateTimePicker1Devol.Enabled = False
        Me.DateTimePicker1Devol.Location = New System.Drawing.Point(199, 94)
        Me.DateTimePicker1Devol.MinDate = New Date(2010, 3, 27, 0, 0, 0, 0)
        Me.DateTimePicker1Devol.Name = "DateTimePicker1Devol"
        Me.DateTimePicker1Devol.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1Devol.TabIndex = 38
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(75, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 13)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Fecha de Devolucion"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(641, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Devolucion N°"
        '
        'Label11
        '
        Me.Label11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoEllipsis = True
        Me.Label11.BackColor = System.Drawing.Color.Blue
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label11.Location = New System.Drawing.Point(226, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(298, 41)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "DEVOLUCIONES"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'boton_guardar
        '
        Me.boton_guardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.boton_guardar.Image = Global.Proyecto_Sena_Biblio_Sistem.My.Resources.Resources.Floppy_24x24_32
        Me.boton_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.boton_guardar.Location = New System.Drawing.Point(233, 448)
        Me.boton_guardar.Name = "boton_guardar"
        Me.boton_guardar.Size = New System.Drawing.Size(111, 30)
        Me.boton_guardar.TabIndex = 32
        Me.boton_guardar.Text = "Devolver"
        Me.boton_guardar.UseVisualStyleBackColor = True
        '
        'boton_cancelar
        '
        Me.boton_cancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.boton_cancelar.Image = Global.Proyecto_Sena_Biblio_Sistem.My.Resources.Resources.Sign_07_24x24_32
        Me.boton_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.boton_cancelar.Location = New System.Drawing.Point(404, 448)
        Me.boton_cancelar.Name = "boton_cancelar"
        Me.boton_cancelar.Size = New System.Drawing.Size(101, 30)
        Me.boton_cancelar.TabIndex = 31
        Me.boton_cancelar.Text = "Cancelar"
        Me.boton_cancelar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.Proyecto_Sena_Biblio_Sistem.My.Resources.Resources.Silver
        Me.PictureBox1.Location = New System.Drawing.Point(153, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(425, 41)
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.label_total)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.fechdev)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.buscarn)
        Me.GroupBox1.Controls.Add(Me.fecha_pTextBox2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Codig_pTextBox1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(58, 132)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(682, 299)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "informacion del Préstamo"
        '
        'label_total
        '
        Me.label_total.AutoSize = True
        Me.label_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_total.Location = New System.Drawing.Point(649, 272)
        Me.label_total.Name = "label_total"
        Me.label_total.Size = New System.Drawing.Size(14, 13)
        Me.label_total.TabIndex = 47
        Me.label_total.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(529, 272)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 13)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "Total Libros prestados:"
        '
        'fechdev
        '
        Me.fechdev.Enabled = False
        Me.fechdev.Location = New System.Drawing.Point(470, 58)
        Me.fechdev.Name = "fechdev"
        Me.fechdev.Size = New System.Drawing.Size(134, 20)
        Me.fechdev.TabIndex = 44
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(354, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 13)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Fecha de devolución:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodlibroDataGridViewTextBoxColumn, Me.CanttotalDataGridViewTextBoxColumn, Me.NomlibroDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PrestamoXIDBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(43, 158)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(477, 127)
        Me.DataGridView1.TabIndex = 30
        '
        'CodlibroDataGridViewTextBoxColumn
        '
        Me.CodlibroDataGridViewTextBoxColumn.DataPropertyName = "cod_libro"
        Me.CodlibroDataGridViewTextBoxColumn.HeaderText = "Código del libro"
        Me.CodlibroDataGridViewTextBoxColumn.Name = "CodlibroDataGridViewTextBoxColumn"
        Me.CodlibroDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CanttotalDataGridViewTextBoxColumn
        '
        Me.CanttotalDataGridViewTextBoxColumn.DataPropertyName = "cant_total"
        Me.CanttotalDataGridViewTextBoxColumn.HeaderText = "N° de Libros prestados"
        Me.CanttotalDataGridViewTextBoxColumn.Name = "CanttotalDataGridViewTextBoxColumn"
        Me.CanttotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NomlibroDataGridViewTextBoxColumn
        '
        Me.NomlibroDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NomlibroDataGridViewTextBoxColumn.DataPropertyName = "nom_libro"
        Me.NomlibroDataGridViewTextBoxColumn.HeaderText = "Nombre del libro"
        Me.NomlibroDataGridViewTextBoxColumn.Name = "NomlibroDataGridViewTextBoxColumn"
        Me.NomlibroDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrestamoXIDBindingSource
        '
        Me.PrestamoXIDBindingSource.DataMember = "PrestamoXID"
        Me.PrestamoXIDBindingSource.DataSource = Me.Biblio_SystemDataSet
        '
        'Biblio_SystemDataSet
        '
        Me.Biblio_SystemDataSet.DataSetName = "Biblio_SystemDataSet"
        Me.Biblio_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Apellido_leTextBox6)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.nomb_lecTextBox5)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.cod_lectTextBox4)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(20, 78)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(623, 74)
        Me.GroupBox2.TabIndex = 42
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Informacion del Lector"
        '
        'Apellido_leTextBox6
        '
        Me.Apellido_leTextBox6.Enabled = False
        Me.Apellido_leTextBox6.Location = New System.Drawing.Point(481, 29)
        Me.Apellido_leTextBox6.Name = "Apellido_leTextBox6"
        Me.Apellido_leTextBox6.Size = New System.Drawing.Size(134, 20)
        Me.Apellido_leTextBox6.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(423, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Apellidos:"
        '
        'nomb_lecTextBox5
        '
        Me.nomb_lecTextBox5.Enabled = False
        Me.nomb_lecTextBox5.Location = New System.Drawing.Point(282, 29)
        Me.nomb_lecTextBox5.Name = "nomb_lecTextBox5"
        Me.nomb_lecTextBox5.Size = New System.Drawing.Size(134, 20)
        Me.nomb_lecTextBox5.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(229, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Nombre:"
        '
        'cod_lectTextBox4
        '
        Me.cod_lectTextBox4.Enabled = False
        Me.cod_lectTextBox4.Location = New System.Drawing.Point(89, 29)
        Me.cod_lectTextBox4.Name = "cod_lectTextBox4"
        Me.cod_lectTextBox4.Size = New System.Drawing.Size(134, 20)
        Me.cod_lectTextBox4.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Identificación:"
        '
        'buscarn
        '
        Me.buscarn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.buscarn.Image = Global.Proyecto_Sena_Biblio_Sistem.My.Resources.Resources.Search_32
        Me.buscarn.Location = New System.Drawing.Point(286, 35)
        Me.buscarn.Name = "buscarn"
        Me.buscarn.Size = New System.Drawing.Size(39, 37)
        Me.buscarn.TabIndex = 29
        Me.buscarn.UseVisualStyleBackColor = True
        '
        'fecha_pTextBox2
        '
        Me.fecha_pTextBox2.Enabled = False
        Me.fecha_pTextBox2.Location = New System.Drawing.Point(470, 32)
        Me.fecha_pTextBox2.Name = "fecha_pTextBox2"
        Me.fecha_pTextBox2.Size = New System.Drawing.Size(134, 20)
        Me.fecha_pTextBox2.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(354, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Fecha del Prestamo"
        '
        'Codig_pTextBox1
        '
        Me.Codig_pTextBox1.Enabled = False
        Me.Codig_pTextBox1.Location = New System.Drawing.Point(136, 41)
        Me.Codig_pTextBox1.Name = "Codig_pTextBox1"
        Me.Codig_pTextBox1.Size = New System.Drawing.Size(134, 20)
        Me.Codig_pTextBox1.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Codigo del Prestamo"
        '
        'IdDevol
        '
        Me.IdDevol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IdDevol.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.IdDevol.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdDevol.ForeColor = System.Drawing.Color.Red
        Me.IdDevol.Location = New System.Drawing.Point(623, 41)
        Me.IdDevol.Name = "IdDevol"
        Me.IdDevol.Size = New System.Drawing.Size(105, 35)
        Me.IdDevol.TabIndex = 42
        Me.IdDevol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PrestamoXIDTableAdapter
        '
        Me.PrestamoXIDTableAdapter.ClearBeforeFill = True
        '
        'Contar_max_devolBindingSource
        '
        Me.Contar_max_devolBindingSource.DataMember = "contar_max_devol"
        Me.Contar_max_devolBindingSource.DataSource = Me.Biblio_SystemDataSet
        '
        'Contar_max_devolTableAdapter
        '
        Me.Contar_max_devolTableAdapter.ClearBeforeFill = True
        '
        'devoluciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(759, 486)
        Me.Controls.Add(Me.IdDevol)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.boton_guardar)
        Me.Controls.Add(Me.boton_cancelar)
        Me.Controls.Add(Me.DateTimePicker1Devol)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "devoluciones"
        Me.Text = "devoluciones"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrestamoXIDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Biblio_SystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Contar_max_devolBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents boton_guardar As System.Windows.Forms.Button
    Friend WithEvents boton_cancelar As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1Devol As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents buscarn As System.Windows.Forms.Button
    Friend WithEvents fecha_pTextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Codig_pTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Apellido_leTextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents nomb_lecTextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cod_lectTextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PrestamoXIDBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Biblio_SystemDataSet As Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSet
    Friend WithEvents PrestamoXIDTableAdapter As Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSetTableAdapters.PrestamoXIDTableAdapter
    Friend WithEvents CodlibroDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CanttotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomlibroDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fechdev As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents label_total As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Contar_max_devolBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Contar_max_devolTableAdapter As Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSetTableAdapters.contar_max_devolTableAdapter
    Friend WithEvents IdDevol As System.Windows.Forms.Label
End Class
