<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Libros
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
        Dim Nom_libroLabel As System.Windows.Forms.Label
        Dim EditorialLabel As System.Windows.Forms.Label
        Dim Cod_areaLabel As System.Windows.Forms.Label
        Dim Fecha_IngresoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Libros))
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.LibrosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Biblio_SystemDataSet = New Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSet
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.EditorialComboBox = New System.Windows.Forms.ComboBox
        Me.Num_copiasNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.Cod_libroTextBox = New System.Windows.Forms.TextBox
        Me.Nom_libroTextBox = New System.Windows.Forms.TextBox
        Me.ubicacionTextBox = New System.Windows.Forms.TextBox
        Me.cod_area_TextBox = New System.Windows.Forms.TextBox
        Me.Fecha_IngresoDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Button2 = New System.Windows.Forms.Button
        Me.nom_area_TextBox2 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.LibrosTableAdapter = New Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSetTableAdapters.LibrosTableAdapter
        Me.TableAdapterManager = New Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSetTableAdapters.TableAdapterManager
        Me.AreasTableAdapter = New Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSetTableAdapters.areasTableAdapter
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Cancelar = New System.Windows.Forms.Button
        Me.Eliminar = New System.Windows.Forms.Button
        Me.Editar = New System.Windows.Forms.Button
        Me.Guardar = New System.Windows.Forms.Button
        Me.nuevo = New System.Windows.Forms.Button
        Me.AreasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BiblioSystemDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Biblio_SystemDataSet1 = New Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSet
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer
        Me.TableAdapterManager1 = New Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSetTableAdapters.TableAdapterManager
        Nom_libroLabel = New System.Windows.Forms.Label
        EditorialLabel = New System.Windows.Forms.Label
        Cod_areaLabel = New System.Windows.Forms.Label
        Fecha_IngresoLabel = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibrosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Biblio_SystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Num_copiasNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AreasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BiblioSystemDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Biblio_SystemDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Nom_libroLabel
        '
        Nom_libroLabel.AutoSize = True
        Nom_libroLabel.Location = New System.Drawing.Point(382, 39)
        Nom_libroLabel.Name = "Nom_libroLabel"
        Nom_libroLabel.Size = New System.Drawing.Size(86, 13)
        Nom_libroLabel.TabIndex = 22
        Nom_libroLabel.Text = "Nombre del libro:"
        '
        'EditorialLabel
        '
        EditorialLabel.AutoSize = True
        EditorialLabel.Location = New System.Drawing.Point(39, 92)
        EditorialLabel.Name = "EditorialLabel"
        EditorialLabel.Size = New System.Drawing.Size(47, 13)
        EditorialLabel.TabIndex = 24
        EditorialLabel.Text = "Editorial:"
        '
        'Cod_areaLabel
        '
        Cod_areaLabel.AutoSize = True
        Cod_areaLabel.Location = New System.Drawing.Point(39, 193)
        Cod_areaLabel.Name = "Cod_areaLabel"
        Cod_areaLabel.Size = New System.Drawing.Size(81, 13)
        Cod_areaLabel.TabIndex = 28
        Cod_areaLabel.Text = "Codigo del area"
        '
        'Fecha_IngresoLabel
        '
        Fecha_IngresoLabel.AutoSize = True
        Fecha_IngresoLabel.Location = New System.Drawing.Point(382, 141)
        Fecha_IngresoLabel.Name = "Fecha_IngresoLabel"
        Fecha_IngresoLabel.Size = New System.Drawing.Size(78, 13)
        Fecha_IngresoLabel.TabIndex = 32
        Fecha_IngresoLabel.Text = "Fecha Ingreso:"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Blue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(323, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 47)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "LIBROS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.PictureBox3)
        Me.GroupBox1.Controls.Add(Me.EditorialComboBox)
        Me.GroupBox1.Controls.Add(Me.Num_copiasNumericUpDown)
        Me.GroupBox1.Controls.Add(Me.Cod_libroTextBox)
        Me.GroupBox1.Controls.Add(Nom_libroLabel)
        Me.GroupBox1.Controls.Add(Me.Nom_libroTextBox)
        Me.GroupBox1.Controls.Add(EditorialLabel)
        Me.GroupBox1.Controls.Add(Cod_areaLabel)
        Me.GroupBox1.Controls.Add(Me.ubicacionTextBox)
        Me.GroupBox1.Controls.Add(Me.cod_area_TextBox)
        Me.GroupBox1.Controls.Add(Fecha_IngresoLabel)
        Me.GroupBox1.Controls.Add(Me.Fecha_IngresoDateTimePicker)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.nom_area_TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(39, 118)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(709, 278)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informacion del Libro"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Proyecto_Sena_Biblio_Sistem.My.Resources.Resources.s0307_life
        Me.PictureBox2.Location = New System.Drawing.Point(556, 205)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(102, 47)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibrosBindingSource, "nom_libro", True))
        Me.TextBox1.Location = New System.Drawing.Point(556, 223)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 4
        '
        'LibrosBindingSource
        '
        Me.LibrosBindingSource.DataMember = "Libros"
        Me.LibrosBindingSource.DataSource = Me.Biblio_SystemDataSet
        '
        'Biblio_SystemDataSet
        '
        Me.Biblio_SystemDataSet.DataSetName = "Biblio_SystemDataSet"
        Me.Biblio_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Proyecto_Sena_Biblio_Sistem.My.Resources.Resources.s0307_life
        Me.PictureBox3.Location = New System.Drawing.Point(430, 205)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(102, 47)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'EditorialComboBox
        '
        Me.EditorialComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibrosBindingSource, "editorial", True))
        Me.EditorialComboBox.Enabled = False
        Me.EditorialComboBox.FormattingEnabled = True
        Me.EditorialComboBox.Items.AddRange(New Object() {"Norma ", "El Cid", "Santillana", "Planeta", "Susaeta", "otro"})
        Me.EditorialComboBox.Location = New System.Drawing.Point(146, 87)
        Me.EditorialComboBox.Name = "EditorialComboBox"
        Me.EditorialComboBox.Size = New System.Drawing.Size(182, 21)
        Me.EditorialComboBox.TabIndex = 35
        '
        'Num_copiasNumericUpDown
        '
        Me.Num_copiasNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.LibrosBindingSource, "num_copias", True))
        Me.Num_copiasNumericUpDown.Enabled = False
        Me.Num_copiasNumericUpDown.Location = New System.Drawing.Point(478, 87)
        Me.Num_copiasNumericUpDown.Maximum = New Decimal(New Integer() {150, 0, 0, 0})
        Me.Num_copiasNumericUpDown.Name = "Num_copiasNumericUpDown"
        Me.Num_copiasNumericUpDown.Size = New System.Drawing.Size(54, 20)
        Me.Num_copiasNumericUpDown.TabIndex = 34
        '
        'Cod_libroTextBox
        '
        Me.Cod_libroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibrosBindingSource, "cod_libro", True))
        Me.Cod_libroTextBox.Enabled = False
        Me.Cod_libroTextBox.Location = New System.Drawing.Point(146, 39)
        Me.Cod_libroTextBox.MaxLength = 18
        Me.Cod_libroTextBox.Name = "Cod_libroTextBox"
        Me.Cod_libroTextBox.Size = New System.Drawing.Size(182, 20)
        Me.Cod_libroTextBox.TabIndex = 21
        '
        'Nom_libroTextBox
        '
        Me.Nom_libroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibrosBindingSource, "nom_libro", True))
        Me.Nom_libroTextBox.Enabled = False
        Me.Nom_libroTextBox.Location = New System.Drawing.Point(478, 36)
        Me.Nom_libroTextBox.Name = "Nom_libroTextBox"
        Me.Nom_libroTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Nom_libroTextBox.TabIndex = 23
        '
        'ubicacionTextBox
        '
        Me.ubicacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibrosBindingSource, "ubicacion", True))
        Me.ubicacionTextBox.Enabled = False
        Me.ubicacionTextBox.Location = New System.Drawing.Point(146, 141)
        Me.ubicacionTextBox.Name = "ubicacionTextBox"
        Me.ubicacionTextBox.Size = New System.Drawing.Size(177, 20)
        Me.ubicacionTextBox.TabIndex = 29
        '
        'cod_area_TextBox
        '
        Me.cod_area_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibrosBindingSource, "cod_area", True))
        Me.cod_area_TextBox.Enabled = False
        Me.cod_area_TextBox.Location = New System.Drawing.Point(146, 186)
        Me.cod_area_TextBox.Name = "cod_area_TextBox"
        Me.cod_area_TextBox.Size = New System.Drawing.Size(112, 20)
        Me.cod_area_TextBox.TabIndex = 31
        '
        'Fecha_IngresoDateTimePicker
        '
        Me.Fecha_IngresoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.LibrosBindingSource, "Fecha_Ingreso", True))
        Me.Fecha_IngresoDateTimePicker.Enabled = False
        Me.Fecha_IngresoDateTimePicker.Location = New System.Drawing.Point(478, 138)
        Me.Fecha_IngresoDateTimePicker.Name = "Fecha_IngresoDateTimePicker"
        Me.Fecha_IngresoDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Fecha_IngresoDateTimePicker.TabIndex = 33
        Me.Fecha_IngresoDateTimePicker.Value = New Date(2010, 3, 20, 0, 0, 0, 0)
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Image = Global.Proyecto_Sena_Biblio_Sistem.My.Resources.Resources.Search_32
        Me.Button2.Location = New System.Drawing.Point(270, 177)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(39, 37)
        Me.Button2.TabIndex = 19
        Me.ToolTip1.SetToolTip(Me.Button2, "Buscar")
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'nom_area_TextBox2
        '
        Me.nom_area_TextBox2.Enabled = False
        Me.nom_area_TextBox2.Location = New System.Drawing.Point(146, 232)
        Me.nom_area_TextBox2.Name = "nom_area_TextBox2"
        Me.nom_area_TextBox2.Size = New System.Drawing.Size(182, 20)
        Me.nom_area_TextBox2.TabIndex = 13
        Me.nom_area_TextBox2.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(39, 235)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Nombre del Area"
        Me.Label6.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(39, 141)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Ubicacion de Libro"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(382, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Ejemplares"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Codigo del Libro"
        '
        'LibrosTableAdapter
        '
        Me.LibrosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.areasTableAdapter = Me.AreasTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.detalle_prestamoTableAdapter = Nothing
        Me.TableAdapterManager.devolucionesTableAdapter = Nothing
        Me.TableAdapterManager.lectoresTableAdapter = Nothing
        Me.TableAdapterManager.LibrosTableAdapter = Me.LibrosTableAdapter
        Me.TableAdapterManager.PrestamosTableAdapter = Nothing
        Me.TableAdapterManager.sancionesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        '
        'AreasTableAdapter
        '
        Me.AreasTableAdapter.ClearBeforeFill = True
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        '
        'Cancelar
        '
        Me.Cancelar.Image = Global.Proyecto_Sena_Biblio_Sistem.My.Resources.Resources.Nueva_imagen__4_
        Me.Cancelar.Location = New System.Drawing.Point(447, 419)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(40, 36)
        Me.Cancelar.TabIndex = 16
        Me.ToolTip1.SetToolTip(Me.Cancelar, "Cancelar")
        Me.Cancelar.UseVisualStyleBackColor = True
        '
        'Eliminar
        '
        Me.Eliminar.Image = Global.Proyecto_Sena_Biblio_Sistem.My.Resources.Resources.ELIMINAR1
        Me.Eliminar.Location = New System.Drawing.Point(400, 419)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(40, 36)
        Me.Eliminar.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.Eliminar, "Eliminar")
        Me.Eliminar.UseVisualStyleBackColor = True
        '
        'Editar
        '
        Me.Editar.Image = Global.Proyecto_Sena_Biblio_Sistem.My.Resources.Resources.EDITAR
        Me.Editar.Location = New System.Drawing.Point(351, 419)
        Me.Editar.Name = "Editar"
        Me.Editar.Size = New System.Drawing.Size(40, 36)
        Me.Editar.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.Editar, "Editar")
        Me.Editar.UseVisualStyleBackColor = True
        '
        'Guardar
        '
        Me.Guardar.Enabled = False
        Me.Guardar.Image = Global.Proyecto_Sena_Biblio_Sistem.My.Resources.Resources.Nueva_imagen__1_
        Me.Guardar.Location = New System.Drawing.Point(308, 419)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(40, 36)
        Me.Guardar.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.Guardar, "Guardar")
        Me.Guardar.UseVisualStyleBackColor = True
        '
        'nuevo
        '
        Me.nuevo.Image = Global.Proyecto_Sena_Biblio_Sistem.My.Resources.Resources.Nueva_imagen__3_
        Me.nuevo.Location = New System.Drawing.Point(262, 419)
        Me.nuevo.Name = "nuevo"
        Me.nuevo.Size = New System.Drawing.Size(40, 36)
        Me.nuevo.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.nuevo, "Nuevo")
        Me.nuevo.UseVisualStyleBackColor = True
        '
        'AreasBindingSource
        '
        Me.AreasBindingSource.DataMember = "areas"
        Me.AreasBindingSource.DataSource = Me.BiblioSystemDataSetBindingSource
        '
        'BiblioSystemDataSetBindingSource
        '
        Me.BiblioSystemDataSetBindingSource.DataSource = Me.Biblio_SystemDataSet1
        Me.BiblioSystemDataSetBindingSource.Position = 0
        '
        'Biblio_SystemDataSet1
        '
        Me.Biblio_SystemDataSet1.DataSetName = "Biblio_SystemDataSet"
        Me.Biblio_SystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BindingSource = Me.LibrosBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Dock = System.Windows.Forms.DockStyle.None
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.BindingNavigator1.Location = New System.Drawing.Point(3, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(211, 25)
        Me.BindingNavigator1.TabIndex = 5
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.Proyecto_Sena_Biblio_Sistem.My.Resources.Resources.Silver
        Me.PictureBox1.Location = New System.Drawing.Point(211, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(359, 47)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.MenuBar
        Me.RichTextBox1.Location = New System.Drawing.Point(222, 411)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(306, 53)
        Me.RichTextBox1.TabIndex = 6
        Me.RichTextBox1.Text = ""
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.BottomToolStripPanel
        '
        Me.ToolStripContainer1.BottomToolStripPanel.Controls.Add(Me.BindingNavigator1)
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(231, 0)
        Me.ToolStripContainer1.Location = New System.Drawing.Point(256, 474)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(231, 28)
        Me.ToolStripContainer1.TabIndex = 17
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.areasTableAdapter = Nothing
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.detalle_prestamoTableAdapter = Nothing
        Me.TableAdapterManager1.devolucionesTableAdapter = Nothing
        Me.TableAdapterManager1.lectoresTableAdapter = Nothing
        Me.TableAdapterManager1.LibrosTableAdapter = Me.LibrosTableAdapter
        Me.TableAdapterManager1.PrestamosTableAdapter = Nothing
        Me.TableAdapterManager1.sancionesTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.UsuariosTableAdapter = Nothing
        '
        'Libros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuBar
        Me.ClientSize = New System.Drawing.Size(784, 514)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Controls.Add(Me.Cancelar)
        Me.Controls.Add(Me.Eliminar)
        Me.Controls.Add(Me.Editar)
        Me.Controls.Add(Me.Guardar)
        Me.Controls.Add(Me.nuevo)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Libros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Libros"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibrosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Biblio_SystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Num_copiasNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AreasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BiblioSystemDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Biblio_SystemDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Biblio_SystemDataSet As Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSet
    Friend WithEvents LibrosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LibrosTableAdapter As Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSetTableAdapters.LibrosTableAdapter
    Friend WithEvents TableAdapterManager As Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Cod_libroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nom_libroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EditorialComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Num_copiasNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents ubicacionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents cod_area_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Fecha_IngresoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents nom_area_TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents AreasTableAdapter As Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSetTableAdapters.areasTableAdapter
    Friend WithEvents AreasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BiblioSystemDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Biblio_SystemDataSet1 As Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSet
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Cancelar As System.Windows.Forms.Button
    Friend WithEvents Eliminar As System.Windows.Forms.Button
    Friend WithEvents Editar As System.Windows.Forms.Button
    Friend WithEvents Guardar As System.Windows.Forms.Button
    Friend WithEvents nuevo As System.Windows.Forms.Button
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents TableAdapterManager1 As Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSetTableAdapters.TableAdapterManager
End Class
