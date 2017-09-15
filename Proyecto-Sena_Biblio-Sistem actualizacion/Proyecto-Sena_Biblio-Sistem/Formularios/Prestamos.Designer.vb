<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Prestamos
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
        Dim Cod_prestamoLabel As System.Windows.Forms.Label
        Dim Cod_lectorLabel As System.Windows.Forms.Label
        Dim Fecha_prestamoLabel As System.Windows.Forms.Label
        Dim Fecha_devolucionLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBoxapellido_lector = New System.Windows.Forms.TextBox
        Me.TextBoxnom_lector = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ButtonIr_lector = New System.Windows.Forms.Button
        Me.Buttonbuscar_lector = New System.Windows.Forms.Button
        Me.Buttonprestar = New System.Windows.Forms.Button
        Me.Buttonbusc_libro = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.label_total = New System.Windows.Forms.Label
        Me.Buttonmodifi_cantidad = New System.Windows.Forms.Button
        Me.eliminarbutton = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.cod_del_Libro = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nombre_Libro = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ejemplares = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label8 = New System.Windows.Forms.Label
        Me.TextBoxCant_libro_pres = New System.Windows.Forms.TextBox
        Me.Fecha_devolucionDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.PrestamosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Biblio_SystemDataSet = New Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSet
        Me.TextBoxnomb_area = New System.Windows.Forms.TextBox
        Me.TextBoxnomb_libro = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.TextBoxeditorial = New System.Windows.Forms.TextBox
        Me.TextBoxcod_libro = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.TextBoxcan_todal_total = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.TextBoxgrado = New System.Windows.Forms.TextBox
        Me.TextBoxcurso = New System.Windows.Forms.TextBox
        Me.TextBoxtipo_lector = New System.Windows.Forms.TextBox
        Me.TextBoxCod_lector = New System.Windows.Forms.TextBox
        Me.Cod_prestamoLabel1 = New System.Windows.Forms.Label
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.QuitarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.fecha_pretamo = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.boton_guardar = New System.Windows.Forms.Button
        Me.boton_cancelar = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.DetalleprestamoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrestamosTableAdapter = New Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSetTableAdapters.PrestamosTableAdapter
        Me.TableAdapterManager = New Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSetTableAdapters.TableAdapterManager
        Me.Detalle_prestamoTableAdapter = New Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSetTableAdapters.detalle_prestamoTableAdapter
        Me.LectoresTableAdapter = New Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSetTableAdapters.lectoresTableAdapter
        Me.LectoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuscarlibroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Buscar_libroTableAdapter = New Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSetTableAdapters.buscar_libroTableAdapter
        Me.Contar_max1TableAdapter = New Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSetTableAdapters.contar_max1TableAdapter
        Me.Contar_max1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Cod_prestamoLabel = New System.Windows.Forms.Label
        Cod_lectorLabel = New System.Windows.Forms.Label
        Fecha_prestamoLabel = New System.Windows.Forms.Label
        Fecha_devolucionLabel = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrestamosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Biblio_SystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetalleprestamoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LectoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuscarlibroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Contar_max1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cod_prestamoLabel
        '
        Cod_prestamoLabel.AutoSize = True
        Cod_prestamoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cod_prestamoLabel.Location = New System.Drawing.Point(568, 20)
        Cod_prestamoLabel.Name = "Cod_prestamoLabel"
        Cod_prestamoLabel.Size = New System.Drawing.Size(93, 18)
        Cod_prestamoLabel.TabIndex = 0
        Cod_prestamoLabel.Text = "Prestamo Nº"
        '
        'Cod_lectorLabel
        '
        Cod_lectorLabel.AutoSize = True
        Cod_lectorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cod_lectorLabel.Location = New System.Drawing.Point(29, 34)
        Cod_lectorLabel.Name = "Cod_lectorLabel"
        Cod_lectorLabel.Size = New System.Drawing.Size(123, 13)
        Cod_lectorLabel.TabIndex = 2
        Cod_lectorLabel.Text = "Identificacion del Lector:"
        '
        'Fecha_prestamoLabel
        '
        Fecha_prestamoLabel.AutoSize = True
        Fecha_prestamoLabel.Location = New System.Drawing.Point(54, 81)
        Fecha_prestamoLabel.Name = "Fecha_prestamoLabel"
        Fecha_prestamoLabel.Size = New System.Drawing.Size(86, 13)
        Fecha_prestamoLabel.TabIndex = 4
        Fecha_prestamoLabel.Text = "Fecha prestamo:"
        '
        'Fecha_devolucionLabel
        '
        Fecha_devolucionLabel.AutoSize = True
        Fecha_devolucionLabel.Location = New System.Drawing.Point(32, 245)
        Fecha_devolucionLabel.Name = "Fecha_devolucionLabel"
        Fecha_devolucionLabel.Size = New System.Drawing.Size(95, 13)
        Fecha_devolucionLabel.TabIndex = 8
        Fecha_devolucionLabel.Text = "Fecha devolucion:"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Blue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(251, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 38)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "PRESTAMOS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBoxapellido_lector
        '
        Me.TextBoxapellido_lector.Enabled = False
        Me.TextBoxapellido_lector.Location = New System.Drawing.Point(433, 64)
        Me.TextBoxapellido_lector.MaxLength = 40
        Me.TextBoxapellido_lector.Name = "TextBoxapellido_lector"
        Me.TextBoxapellido_lector.Size = New System.Drawing.Size(183, 20)
        Me.TextBoxapellido_lector.TabIndex = 11
        '
        'TextBoxnom_lector
        '
        Me.TextBoxnom_lector.Enabled = False
        Me.TextBoxnom_lector.Location = New System.Drawing.Point(174, 64)
        Me.TextBoxnom_lector.MaxLength = 40
        Me.TextBoxnom_lector.Name = "TextBoxnom_lector"
        Me.TextBoxnom_lector.Size = New System.Drawing.Size(176, 20)
        Me.TextBoxnom_lector.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(496, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Curso"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(381, 92)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Grado"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(29, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Tipo de Lector"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(377, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Apellidos  "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nombre  del Lector"
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        '
        'ButtonIr_lector
        '
        Me.ButtonIr_lector.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonIr_lector.Image = Global.Proyecto_Sena_Biblio_Sistem.My.Resources.Resources._32px_Crystal_Clear_action_loopnone
        Me.ButtonIr_lector.Location = New System.Drawing.Point(304, 22)
        Me.ButtonIr_lector.Name = "ButtonIr_lector"
        Me.ButtonIr_lector.Size = New System.Drawing.Size(39, 37)
        Me.ButtonIr_lector.TabIndex = 37
        Me.ToolTip1.SetToolTip(Me.ButtonIr_lector, "Ir")
        Me.ButtonIr_lector.UseVisualStyleBackColor = True
        '
        'Buttonbuscar_lector
        '
        Me.Buttonbuscar_lector.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Buttonbuscar_lector.Image = Global.Proyecto_Sena_Biblio_Sistem.My.Resources.Resources.Search_32
        Me.Buttonbuscar_lector.Location = New System.Drawing.Point(349, 22)
        Me.Buttonbuscar_lector.Name = "Buttonbuscar_lector"
        Me.Buttonbuscar_lector.Size = New System.Drawing.Size(39, 37)
        Me.Buttonbuscar_lector.TabIndex = 18
        Me.ToolTip1.SetToolTip(Me.Buttonbuscar_lector, "Buscar Lector")
        Me.Buttonbuscar_lector.UseVisualStyleBackColor = True
        '
        'Buttonprestar
        '
        Me.Buttonprestar.Enabled = False
        Me.Buttonprestar.Image = Global.Proyecto_Sena_Biblio_Sistem.My.Resources.Resources.CP_57_24x24_32
        Me.Buttonprestar.Location = New System.Drawing.Point(547, 92)
        Me.Buttonprestar.Name = "Buttonprestar"
        Me.Buttonprestar.Size = New System.Drawing.Size(41, 35)
        Me.Buttonprestar.TabIndex = 40
        Me.ToolTip1.SetToolTip(Me.Buttonprestar, "Prestar")
        Me.Buttonprestar.UseVisualStyleBackColor = True
        '
        'Buttonbusc_libro
        '
        Me.Buttonbusc_libro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Buttonbusc_libro.Image = Global.Proyecto_Sena_Biblio_Sistem.My.Resources.Resources.Search_32
        Me.Buttonbusc_libro.Location = New System.Drawing.Point(313, 21)
        Me.Buttonbusc_libro.Name = "Buttonbusc_libro"
        Me.Buttonbusc_libro.Size = New System.Drawing.Size(39, 37)
        Me.Buttonbusc_libro.TabIndex = 18
        Me.ToolTip1.SetToolTip(Me.Buttonbusc_libro, "Buscar Libro")
        Me.Buttonbusc_libro.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox2.Controls.Add(Me.label_total)
        Me.GroupBox2.Controls.Add(Me.Buttonmodifi_cantidad)
        Me.GroupBox2.Controls.Add(Me.eliminarbutton)
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Controls.Add(Me.Buttonprestar)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TextBoxCant_libro_pres)
        Me.GroupBox2.Controls.Add(Me.Fecha_devolucionDateTimePicker)
        Me.GroupBox2.Controls.Add(Me.TextBoxnomb_area)
        Me.GroupBox2.Controls.Add(Me.TextBoxnomb_libro)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Fecha_devolucionLabel)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Buttonbusc_libro)
        Me.GroupBox2.Controls.Add(Me.TextBoxeditorial)
        Me.GroupBox2.Controls.Add(Me.TextBoxcod_libro)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox2.Location = New System.Drawing.Point(25, 227)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(644, 276)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Informacion del Libro"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Enabled = False
        Me.NumericUpDown1.Location = New System.Drawing.Point(500, 97)
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(41, 20)
        Me.NumericUpDown1.TabIndex = 43
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'label_total
        '
        Me.label_total.AutoSize = True
        Me.label_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_total.Location = New System.Drawing.Point(469, 245)
        Me.label_total.Name = "label_total"
        Me.label_total.Size = New System.Drawing.Size(14, 13)
        Me.label_total.TabIndex = 45
        Me.label_total.Text = "0"
        '
        'Buttonmodifi_cantidad
        '
        Me.Buttonmodifi_cantidad.Enabled = False
        Me.Buttonmodifi_cantidad.Image = Global.Proyecto_Sena_Biblio_Sistem.My.Resources.Resources.Desktop_32x32_32
        Me.Buttonmodifi_cantidad.Location = New System.Drawing.Point(518, 150)
        Me.Buttonmodifi_cantidad.Name = "Buttonmodifi_cantidad"
        Me.Buttonmodifi_cantidad.Size = New System.Drawing.Size(43, 37)
        Me.Buttonmodifi_cantidad.TabIndex = 42
        Me.Buttonmodifi_cantidad.UseVisualStyleBackColor = True
        '
        'eliminarbutton
        '
        Me.eliminarbutton.Enabled = False
        Me.eliminarbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.eliminarbutton.Image = Global.Proyecto_Sena_Biblio_Sistem.My.Resources.Resources.Sign_07_24x24_32
        Me.eliminarbutton.Location = New System.Drawing.Point(518, 188)
        Me.eliminarbutton.Name = "eliminarbutton"
        Me.eliminarbutton.Size = New System.Drawing.Size(43, 37)
        Me.eliminarbutton.TabIndex = 25
        Me.eliminarbutton.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.NavajoWhite
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveBorder
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cod_del_Libro, Me.Nombre_Libro, Me.ejemplares, Me.Cantidad})
        Me.DataGridView1.Location = New System.Drawing.Point(27, 129)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(456, 96)
        Me.DataGridView1.TabIndex = 41
        '
        'cod_del_Libro
        '
        Me.cod_del_Libro.HeaderText = "cod del Libro"
        Me.cod_del_Libro.Name = "cod_del_Libro"
        Me.cod_del_Libro.ReadOnly = True
        '
        'Nombre_Libro
        '
        Me.Nombre_Libro.HeaderText = "Nombre Libro"
        Me.Nombre_Libro.Name = "Nombre_Libro"
        Me.Nombre_Libro.ReadOnly = True
        '
        'ejemplares
        '
        Me.ejemplares.HeaderText = "ejemplares"
        Me.ejemplares.Name = "ejemplares"
        Me.ejemplares.ReadOnly = True
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(349, 245)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 13)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Total Libros prestados:"
        '
        'TextBoxCant_libro_pres
        '
        Me.TextBoxCant_libro_pres.Enabled = False
        Me.TextBoxCant_libro_pres.Location = New System.Drawing.Point(368, 97)
        Me.TextBoxCant_libro_pres.MaxLength = 10
        Me.TextBoxCant_libro_pres.Name = "TextBoxCant_libro_pres"
        Me.TextBoxCant_libro_pres.Size = New System.Drawing.Size(68, 20)
        Me.TextBoxCant_libro_pres.TabIndex = 38
        '
        'Fecha_devolucionDateTimePicker
        '
        Me.Fecha_devolucionDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrestamosBindingSource, "fecha_devolucion", True))
        Me.Fecha_devolucionDateTimePicker.Location = New System.Drawing.Point(131, 243)
        Me.Fecha_devolucionDateTimePicker.MinDate = New Date(2010, 3, 26, 0, 0, 0, 0)
        Me.Fecha_devolucionDateTimePicker.Name = "Fecha_devolucionDateTimePicker"
        Me.Fecha_devolucionDateTimePicker.Size = New System.Drawing.Size(213, 20)
        Me.Fecha_devolucionDateTimePicker.TabIndex = 9
        '
        'PrestamosBindingSource
        '
        Me.PrestamosBindingSource.DataMember = "Prestamos"
        Me.PrestamosBindingSource.DataSource = Me.Biblio_SystemDataSet
        '
        'Biblio_SystemDataSet
        '
        Me.Biblio_SystemDataSet.DataSetName = "Biblio_SystemDataSet"
        Me.Biblio_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBoxnomb_area
        '
        Me.TextBoxnomb_area.Enabled = False
        Me.TextBoxnomb_area.Location = New System.Drawing.Point(178, 98)
        Me.TextBoxnomb_area.MaxLength = 50
        Me.TextBoxnomb_area.Name = "TextBoxnomb_area"
        Me.TextBoxnomb_area.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxnomb_area.TabIndex = 25
        '
        'TextBoxnomb_libro
        '
        Me.TextBoxnomb_libro.Enabled = False
        Me.TextBoxnomb_libro.Location = New System.Drawing.Point(178, 68)
        Me.TextBoxnomb_libro.MaxLength = 50
        Me.TextBoxnomb_libro.Name = "TextBoxnomb_libro"
        Me.TextBoxnomb_libro.Size = New System.Drawing.Size(211, 20)
        Me.TextBoxnomb_libro.TabIndex = 24
        Me.TextBoxnomb_libro.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(442, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Cantidad"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(304, 101)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 13)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "Ejemplares"
        '
        'TextBoxeditorial
        '
        Me.TextBoxeditorial.Enabled = False
        Me.TextBoxeditorial.Location = New System.Drawing.Point(477, 66)
        Me.TextBoxeditorial.MaxLength = 30
        Me.TextBoxeditorial.Name = "TextBoxeditorial"
        Me.TextBoxeditorial.Size = New System.Drawing.Size(140, 20)
        Me.TextBoxeditorial.TabIndex = 12
        '
        'TextBoxcod_libro
        '
        Me.TextBoxcod_libro.Enabled = False
        Me.TextBoxcod_libro.Location = New System.Drawing.Point(175, 38)
        Me.TextBoxcod_libro.MaxLength = 18
        Me.TextBoxcod_libro.Name = "TextBoxcod_libro"
        Me.TextBoxcod_libro.Size = New System.Drawing.Size(133, 20)
        Me.TextBoxcod_libro.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(32, 97)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Nombre del Area"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(408, 71)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Editorial"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(32, 69)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 13)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Nombre del Libro"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(30, 41)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 13)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Codigo del Libro"
        '
        'TextBoxcan_todal_total
        '
        Me.TextBoxcan_todal_total.Enabled = False
        Me.TextBoxcan_todal_total.Location = New System.Drawing.Point(637, 521)
        Me.TextBoxcan_todal_total.MaxLength = 10
        Me.TextBoxcan_todal_total.Name = "TextBoxcan_todal_total"
        Me.TextBoxcan_todal_total.Size = New System.Drawing.Size(45, 20)
        Me.TextBoxcan_todal_total.TabIndex = 38
        Me.TextBoxcan_todal_total.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBoxgrado)
        Me.GroupBox3.Controls.Add(Me.TextBoxcurso)
        Me.GroupBox3.Controls.Add(Me.TextBoxtipo_lector)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.TextBoxapellido_lector)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Cod_lectorLabel)
        Me.GroupBox3.Controls.Add(Me.TextBoxCod_lector)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.TextBoxnom_lector)
        Me.GroupBox3.Controls.Add(Me.ButtonIr_lector)
        Me.GroupBox3.Controls.Add(Me.Buttonbuscar_lector)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(26, 97)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(644, 124)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Informacion de l Lector"
        '
        'TextBoxgrado
        '
        Me.TextBoxgrado.Enabled = False
        Me.TextBoxgrado.Location = New System.Drawing.Point(433, 89)
        Me.TextBoxgrado.Name = "TextBoxgrado"
        Me.TextBoxgrado.Size = New System.Drawing.Size(60, 20)
        Me.TextBoxgrado.TabIndex = 40
        '
        'TextBoxcurso
        '
        Me.TextBoxcurso.Enabled = False
        Me.TextBoxcurso.Location = New System.Drawing.Point(556, 92)
        Me.TextBoxcurso.Name = "TextBoxcurso"
        Me.TextBoxcurso.Size = New System.Drawing.Size(60, 20)
        Me.TextBoxcurso.TabIndex = 39
        '
        'TextBoxtipo_lector
        '
        Me.TextBoxtipo_lector.Enabled = False
        Me.TextBoxtipo_lector.Location = New System.Drawing.Point(175, 92)
        Me.TextBoxtipo_lector.MaxLength = 40
        Me.TextBoxtipo_lector.Name = "TextBoxtipo_lector"
        Me.TextBoxtipo_lector.Size = New System.Drawing.Size(176, 20)
        Me.TextBoxtipo_lector.TabIndex = 38
        '
        'TextBoxCod_lector
        '
        Me.TextBoxCod_lector.Location = New System.Drawing.Point(175, 31)
        Me.TextBoxCod_lector.MaxLength = 13
        Me.TextBoxCod_lector.Name = "TextBoxCod_lector"
        Me.TextBoxCod_lector.Size = New System.Drawing.Size(107, 20)
        Me.TextBoxCod_lector.TabIndex = 3
        '
        'Cod_prestamoLabel1
        '
        Me.Cod_prestamoLabel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Cod_prestamoLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Cod_prestamoLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cod_prestamoLabel1.ForeColor = System.Drawing.Color.Red
        Me.Cod_prestamoLabel1.Location = New System.Drawing.Point(564, 38)
        Me.Cod_prestamoLabel1.Name = "Cod_prestamoLabel1"
        Me.Cod_prestamoLabel1.Size = New System.Drawing.Size(105, 35)
        Me.Cod_prestamoLabel1.TabIndex = 1
        Me.Cod_prestamoLabel1.Text = "Label8"
        Me.Cod_prestamoLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuitarToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(108, 26)
        '
        'QuitarToolStripMenuItem
        '
        Me.QuitarToolStripMenuItem.Name = "QuitarToolStripMenuItem"
        Me.QuitarToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.QuitarToolStripMenuItem.Text = "Quitar"
        '
        'fecha_pretamo
        '
        Me.fecha_pretamo.AutoSize = True
        Me.fecha_pretamo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha_pretamo.Location = New System.Drawing.Point(152, 81)
        Me.fecha_pretamo.Name = "fecha_pretamo"
        Me.fecha_pretamo.Size = New System.Drawing.Size(45, 13)
        Me.fecha_pretamo.TabIndex = 25
        Me.fecha_pretamo.Text = "Label8"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Tag = ""
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(1, 568)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(78, 31)
        Me.Panel1.TabIndex = 26
        '
        'boton_guardar
        '
        Me.boton_guardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.boton_guardar.Image = Global.Proyecto_Sena_Biblio_Sistem.My.Resources.Resources.Floppy_24x24_32
        Me.boton_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.boton_guardar.Location = New System.Drawing.Point(232, 516)
        Me.boton_guardar.Name = "boton_guardar"
        Me.boton_guardar.Size = New System.Drawing.Size(101, 30)
        Me.boton_guardar.TabIndex = 9
        Me.boton_guardar.Text = "Prestar"
        Me.boton_guardar.UseVisualStyleBackColor = True
        '
        'boton_cancelar
        '
        Me.boton_cancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.boton_cancelar.Image = Global.Proyecto_Sena_Biblio_Sistem.My.Resources.Resources.Sign_07_24x24_32
        Me.boton_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.boton_cancelar.Location = New System.Drawing.Point(357, 516)
        Me.boton_cancelar.Name = "boton_cancelar"
        Me.boton_cancelar.Size = New System.Drawing.Size(101, 30)
        Me.boton_cancelar.TabIndex = 8
        Me.boton_cancelar.Text = "Cancelar"
        Me.boton_cancelar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.Proyecto_Sena_Biblio_Sistem.My.Resources.Resources.Silver
        Me.PictureBox1.Location = New System.Drawing.Point(172, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(347, 38)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'DetalleprestamoBindingSource
        '
        Me.DetalleprestamoBindingSource.DataMember = "detalle_prestamo"
        Me.DetalleprestamoBindingSource.DataSource = Me.Biblio_SystemDataSet
        '
        'PrestamosTableAdapter
        '
        Me.PrestamosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.areasTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.detalle_prestamoTableAdapter = Me.Detalle_prestamoTableAdapter
        Me.TableAdapterManager.devolucionesTableAdapter = Nothing
        Me.TableAdapterManager.lectoresTableAdapter = Me.LectoresTableAdapter
        Me.TableAdapterManager.LibrosTableAdapter = Nothing
        Me.TableAdapterManager.PrestamosTableAdapter = Me.PrestamosTableAdapter
        Me.TableAdapterManager.sancionesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        '
        'Detalle_prestamoTableAdapter
        '
        Me.Detalle_prestamoTableAdapter.ClearBeforeFill = True
        '
        'LectoresTableAdapter
        '
        Me.LectoresTableAdapter.ClearBeforeFill = True
        '
        'LectoresBindingSource
        '
        Me.LectoresBindingSource.DataMember = "lectores"
        Me.LectoresBindingSource.DataSource = Me.Biblio_SystemDataSet
        '
        'BuscarlibroBindingSource
        '
        Me.BuscarlibroBindingSource.DataMember = "buscar_libro"
        Me.BuscarlibroBindingSource.DataSource = Me.Biblio_SystemDataSet
        '
        'Buscar_libroTableAdapter
        '
        Me.Buscar_libroTableAdapter.ClearBeforeFill = True
        '
        'Contar_max1TableAdapter
        '
        Me.Contar_max1TableAdapter.ClearBeforeFill = True
        '
        'Contar_max1BindingSource
        '
        Me.Contar_max1BindingSource.DataMember = "contar_max1"
        Me.Contar_max1BindingSource.DataSource = Me.Biblio_SystemDataSet
        '
        'Prestamos
        '
        Me.AcceptButton = Me.ButtonIr_lector
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(694, 563)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.fecha_pretamo)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Cod_prestamoLabel)
        Me.Controls.Add(Me.Cod_prestamoLabel1)
        Me.Controls.Add(Me.TextBoxcan_todal_total)
        Me.Controls.Add(Fecha_prestamoLabel)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.boton_guardar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.boton_cancelar)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.Name = "Prestamos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PRESTAMOS "
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrestamosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Biblio_SystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetalleprestamoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LectoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuscarlibroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Contar_max1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBoxapellido_lector As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxnom_lector As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Buttonbuscar_lector As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Buttonbusc_libro As System.Windows.Forms.Button
    Friend WithEvents TextBoxcod_libro As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents boton_cancelar As System.Windows.Forms.Button
    Friend WithEvents boton_guardar As System.Windows.Forms.Button
    Friend WithEvents ButtonIr_lector As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Biblio_SystemDataSet As Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSet
    Friend WithEvents PrestamosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PrestamosTableAdapter As Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSetTableAdapters.PrestamosTableAdapter
    Friend WithEvents TableAdapterManager As Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Cod_prestamoLabel1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxCod_lector As System.Windows.Forms.TextBox
    Friend WithEvents Fecha_devolucionDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBoxtipo_lector As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxcurso As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxgrado As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCant_libro_pres As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxnomb_area As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxnomb_libro As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxeditorial As System.Windows.Forms.TextBox
    Friend WithEvents LectoresTableAdapter As Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSetTableAdapters.lectoresTableAdapter
    Friend WithEvents LectoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BuscarlibroBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Buscar_libroTableAdapter As Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSetTableAdapters.buscar_libroTableAdapter
    Friend WithEvents Detalle_prestamoTableAdapter As Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSetTableAdapters.detalle_prestamoTableAdapter
    Friend WithEvents DetalleprestamoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Contar_max1TableAdapter As Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSetTableAdapters.contar_max1TableAdapter
    Friend WithEvents Contar_max1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Buttonprestar As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TextBoxcan_todal_total As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents eliminarbutton As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents QuitarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Buttonmodifi_cantidad As System.Windows.Forms.Button
    Friend WithEvents fecha_pretamo As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents label_total As System.Windows.Forms.Label
    Friend WithEvents cod_del_Libro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre_Libro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ejemplares As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
