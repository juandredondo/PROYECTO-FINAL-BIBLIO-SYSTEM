<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lectores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lectores))
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TextBoxtelef = New System.Windows.Forms.TextBox
        Me.LectoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Biblio_SystemDataSet = New Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSet
        Me.ComboBoxtipo_lect = New System.Windows.Forms.ComboBox
        Me.ComboBoxcurso = New System.Windows.Forms.ComboBox
        Me.ComboBoxgrado = New System.Windows.Forms.ComboBox
        Me.TextBoxdireccion = New System.Windows.Forms.TextBox
        Me.ComboBoxsexo = New System.Windows.Forms.ComboBox
        Me.TextBoxapellido = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.texboxnombre = New System.Windows.Forms.TextBox
        Me.textBoxid_lector = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.LectoresTableAdapter = New Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSetTableAdapters.lectoresTableAdapter
        Me.TableAdapterManager = New Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSetTableAdapters.TableAdapterManager
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Cancelar = New System.Windows.Forms.Button
        Me.Eliminar = New System.Windows.Forms.Button
        Me.Editar = New System.Windows.Forms.Button
        Me.Guardar = New System.Windows.Forms.Button
        Me.nuevo = New System.Windows.Forms.Button
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
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
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.LectoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Biblio_SystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Blue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(214, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(258, 44)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "LECTORES"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBoxtelef)
        Me.GroupBox1.Controls.Add(Me.ComboBoxtipo_lect)
        Me.GroupBox1.Controls.Add(Me.ComboBoxcurso)
        Me.GroupBox1.Controls.Add(Me.ComboBoxgrado)
        Me.GroupBox1.Controls.Add(Me.TextBoxdireccion)
        Me.GroupBox1.Controls.Add(Me.ComboBoxsexo)
        Me.GroupBox1.Controls.Add(Me.TextBoxapellido)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.texboxnombre)
        Me.GroupBox1.Controls.Add(Me.textBoxid_lector)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 130)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(635, 239)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Lector"
        '
        'TextBoxtelef
        '
        Me.TextBoxtelef.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LectoresBindingSource, "telefono", True))
        Me.TextBoxtelef.Enabled = False
        Me.TextBoxtelef.Location = New System.Drawing.Point(448, 149)
        Me.TextBoxtelef.MaxLength = 13
        Me.TextBoxtelef.Name = "TextBoxtelef"
        Me.TextBoxtelef.Size = New System.Drawing.Size(88, 20)
        Me.TextBoxtelef.TabIndex = 18
        '
        'LectoresBindingSource
        '
        Me.LectoresBindingSource.DataMember = "lectores"
        Me.LectoresBindingSource.DataSource = Me.Biblio_SystemDataSet
        '
        'Biblio_SystemDataSet
        '
        Me.Biblio_SystemDataSet.DataSetName = "Biblio_SystemDataSet"
        Me.Biblio_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComboBoxtipo_lect
        '
        Me.ComboBoxtipo_lect.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LectoresBindingSource, "tipo_lector", True))
        Me.ComboBoxtipo_lect.Enabled = False
        Me.ComboBoxtipo_lect.FormattingEnabled = True
        Me.ComboBoxtipo_lect.Items.AddRange(New Object() {"Estudiante", "Profesor", "Secretaria", "Coordinador", "Rector", "Particular"})
        Me.ComboBoxtipo_lect.Location = New System.Drawing.Point(153, 198)
        Me.ComboBoxtipo_lect.Name = "ComboBoxtipo_lect"
        Me.ComboBoxtipo_lect.Size = New System.Drawing.Size(154, 21)
        Me.ComboBoxtipo_lect.TabIndex = 17
        '
        'ComboBoxcurso
        '
        Me.ComboBoxcurso.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LectoresBindingSource, "Curso", True))
        Me.ComboBoxcurso.Enabled = False
        Me.ComboBoxcurso.FormattingEnabled = True
        Me.ComboBoxcurso.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09"})
        Me.ComboBoxcurso.Location = New System.Drawing.Point(481, 198)
        Me.ComboBoxcurso.Name = "ComboBoxcurso"
        Me.ComboBoxcurso.Size = New System.Drawing.Size(56, 21)
        Me.ComboBoxcurso.TabIndex = 16
        '
        'ComboBoxgrado
        '
        Me.ComboBoxgrado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LectoresBindingSource, "Grado", True))
        Me.ComboBoxgrado.Enabled = False
        Me.ComboBoxgrado.FormattingEnabled = True
        Me.ComboBoxgrado.Items.AddRange(New Object() {"4º", "5º", "6º", "7º", "8º", "9º", "10º", "11º"})
        Me.ComboBoxgrado.Location = New System.Drawing.Point(378, 198)
        Me.ComboBoxgrado.Name = "ComboBoxgrado"
        Me.ComboBoxgrado.Size = New System.Drawing.Size(52, 21)
        Me.ComboBoxgrado.TabIndex = 15
        '
        'TextBoxdireccion
        '
        Me.TextBoxdireccion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LectoresBindingSource, "direccion", True))
        Me.TextBoxdireccion.Enabled = False
        Me.TextBoxdireccion.Location = New System.Drawing.Point(153, 147)
        Me.TextBoxdireccion.MaxLength = 25
        Me.TextBoxdireccion.Name = "TextBoxdireccion"
        Me.TextBoxdireccion.Size = New System.Drawing.Size(154, 20)
        Me.TextBoxdireccion.TabIndex = 13
        '
        'ComboBoxsexo
        '
        Me.ComboBoxsexo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LectoresBindingSource, "sexo", True))
        Me.ComboBoxsexo.Enabled = False
        Me.ComboBoxsexo.FormattingEnabled = True
        Me.ComboBoxsexo.Items.AddRange(New Object() {"F", "M"})
        Me.ComboBoxsexo.Location = New System.Drawing.Point(579, 152)
        Me.ComboBoxsexo.Name = "ComboBoxsexo"
        Me.ComboBoxsexo.Size = New System.Drawing.Size(44, 21)
        Me.ComboBoxsexo.TabIndex = 12
        '
        'TextBoxapellido
        '
        Me.TextBoxapellido.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LectoresBindingSource, "apellido", True))
        Me.TextBoxapellido.Enabled = False
        Me.TextBoxapellido.Location = New System.Drawing.Point(448, 99)
        Me.TextBoxapellido.MaxLength = 50
        Me.TextBoxapellido.Name = "TextBoxapellido"
        Me.TextBoxapellido.Size = New System.Drawing.Size(154, 20)
        Me.TextBoxapellido.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(542, 153)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Sexo"
        '
        'texboxnombre
        '
        Me.texboxnombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LectoresBindingSource, "nom_lector", True))
        Me.texboxnombre.Enabled = False
        Me.texboxnombre.Location = New System.Drawing.Point(153, 96)
        Me.texboxnombre.MaxLength = 50
        Me.texboxnombre.Name = "texboxnombre"
        Me.texboxnombre.Size = New System.Drawing.Size(154, 20)
        Me.texboxnombre.TabIndex = 10
        '
        'textBoxid_lector
        '
        Me.textBoxid_lector.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LectoresBindingSource, "cod_lector", True))
        Me.textBoxid_lector.Enabled = False
        Me.textBoxid_lector.Location = New System.Drawing.Point(153, 45)
        Me.textBoxid_lector.MaxLength = 13
        Me.textBoxid_lector.Name = "textBoxid_lector"
        Me.textBoxid_lector.Size = New System.Drawing.Size(107, 20)
        Me.textBoxid_lector.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(27, 150)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Direccion del Lector "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(340, 152)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Telefono del Lector"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(441, 201)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Curso"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(336, 198)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Grado"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Tipo de Lector"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(340, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Apellidos  del Lector"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nombre  del Lector"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Identificacion del Lector"
        '
        'LectoresTableAdapter
        '
        Me.LectoresTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.areasTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.detalle_prestamoTableAdapter = Nothing
        Me.TableAdapterManager.devolucionesTableAdapter = Nothing
        Me.TableAdapterManager.lectoresTableAdapter = Me.LectoresTableAdapter
        Me.TableAdapterManager.LibrosTableAdapter = Nothing
        Me.TableAdapterManager.PrestamosTableAdapter = Nothing
        Me.TableAdapterManager.sancionesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.Proyecto_Sena_Biblio_Sistem.My.Resources.Resources.Silver
        Me.PictureBox1.Location = New System.Drawing.Point(107, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(457, 45)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Cancelar
        '
        Me.Cancelar.Image = Global.Proyecto_Sena_Biblio_Sistem.My.Resources.Resources.Nueva_imagen__4_
        Me.Cancelar.Location = New System.Drawing.Point(430, 390)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(40, 36)
        Me.Cancelar.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.Cancelar, "Cancelar")
        Me.Cancelar.UseVisualStyleBackColor = True
        '
        'Eliminar
        '
        Me.Eliminar.Image = Global.Proyecto_Sena_Biblio_Sistem.My.Resources.Resources.ELIMINAR1
        Me.Eliminar.Location = New System.Drawing.Point(383, 390)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(40, 36)
        Me.Eliminar.TabIndex = 21
        Me.ToolTip1.SetToolTip(Me.Eliminar, "Eliminar")
        Me.Eliminar.UseVisualStyleBackColor = True
        '
        'Editar
        '
        Me.Editar.Image = Global.Proyecto_Sena_Biblio_Sistem.My.Resources.Resources.EDITAR
        Me.Editar.Location = New System.Drawing.Point(334, 390)
        Me.Editar.Name = "Editar"
        Me.Editar.Size = New System.Drawing.Size(40, 36)
        Me.Editar.TabIndex = 20
        Me.ToolTip1.SetToolTip(Me.Editar, "Editar")
        Me.Editar.UseVisualStyleBackColor = True
        '
        'Guardar
        '
        Me.Guardar.Enabled = False
        Me.Guardar.Image = Global.Proyecto_Sena_Biblio_Sistem.My.Resources.Resources.Nueva_imagen__1_
        Me.Guardar.Location = New System.Drawing.Point(291, 390)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(40, 36)
        Me.Guardar.TabIndex = 19
        Me.ToolTip1.SetToolTip(Me.Guardar, "Guardar")
        Me.Guardar.UseVisualStyleBackColor = True
        '
        'nuevo
        '
        Me.nuevo.Image = Global.Proyecto_Sena_Biblio_Sistem.My.Resources.Resources.Nueva_imagen__3_
        Me.nuevo.Location = New System.Drawing.Point(245, 390)
        Me.nuevo.Name = "nuevo"
        Me.nuevo.Size = New System.Drawing.Size(40, 36)
        Me.nuevo.TabIndex = 18
        Me.ToolTip1.SetToolTip(Me.nuevo, "Nuevo")
        Me.nuevo.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.MenuBar
        Me.RichTextBox1.Enabled = False
        Me.RichTextBox1.Location = New System.Drawing.Point(205, 382)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(306, 53)
        Me.RichTextBox1.TabIndex = 17
        Me.RichTextBox1.Text = ""
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BindingSource = Me.LectoresBindingSource
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
        Me.BindingNavigator1.TabIndex = 23
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
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(267, 150)
        Me.ToolStripContainer1.Location = New System.Drawing.Point(205, 441)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(267, 175)
        Me.ToolStripContainer1.TabIndex = 24
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.BindingNavigator1)
        '
        'Lectores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuBar
        Me.ClientSize = New System.Drawing.Size(676, 484)
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
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "Lectores"
        Me.Text = "Lectores"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.LectoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Biblio_SystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxtipo_lect As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxcurso As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxgrado As System.Windows.Forms.ComboBox
    Friend WithEvents TextBoxdireccion As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxsexo As System.Windows.Forms.ComboBox
    Friend WithEvents TextBoxapellido As System.Windows.Forms.TextBox
    Friend WithEvents texboxnombre As System.Windows.Forms.TextBox
    Friend WithEvents textBoxid_lector As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Biblio_SystemDataSet As Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSet
    Friend WithEvents LectoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LectoresTableAdapter As Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSetTableAdapters.lectoresTableAdapter
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBoxtelef As System.Windows.Forms.TextBox
    Friend WithEvents TableAdapterManager As Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSetTableAdapters.TableAdapterManager
    Protected WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Protected WithEvents Label1 As System.Windows.Forms.Label
    Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Cancelar As System.Windows.Forms.Button
    Friend WithEvents Eliminar As System.Windows.Forms.Button
    Friend WithEvents Editar As System.Windows.Forms.Button
    Friend WithEvents Guardar As System.Windows.Forms.Button
    Friend WithEvents nuevo As System.Windows.Forms.Button
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
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
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
