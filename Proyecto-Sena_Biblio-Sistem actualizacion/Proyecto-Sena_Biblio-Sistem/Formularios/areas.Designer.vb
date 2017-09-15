<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class areas
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
        Dim Codigo_Label As System.Windows.Forms.Label
        Dim Nombre_Label As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(areas))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Codigo_TextBox = New System.Windows.Forms.TextBox
        Me.AreasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Biblio_SystemDataSet = New Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSet
        Me.Nombre_TextBox = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.AreasTableAdapter = New Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSetTableAdapters.areasTableAdapter
        Me.TableAdapterManager = New Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSetTableAdapters.TableAdapterManager
        Me.AreasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Cancelar = New System.Windows.Forms.Button
        Me.Eliminar = New System.Windows.Forms.Button
        Me.Editar = New System.Windows.Forms.Button
        Me.Guardar = New System.Windows.Forms.Button
        Me.nuevo = New System.Windows.Forms.Button
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Codigo_Label = New System.Windows.Forms.Label
        Nombre_Label = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.AreasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Biblio_SystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AreasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AreasBindingNavigator.SuspendLayout()
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Codigo_Label
        '
        Codigo_Label.AutoSize = True
        Codigo_Label.Location = New System.Drawing.Point(62, 37)
        Codigo_Label.Name = "Codigo_Label"
        Codigo_Label.Size = New System.Drawing.Size(43, 13)
        Codigo_Label.TabIndex = 0
        Codigo_Label.Text = "Codigo "
        '
        'Nombre_Label
        '
        Nombre_Label.AutoSize = True
        Nombre_Label.Location = New System.Drawing.Point(62, 63)
        Nombre_Label.Name = "Nombre_Label"
        Nombre_Label.Size = New System.Drawing.Size(47, 13)
        Nombre_Label.TabIndex = 2
        Nombre_Label.Text = "Nombre "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Codigo_Label)
        Me.GroupBox1.Controls.Add(Me.Codigo_TextBox)
        Me.GroupBox1.Controls.Add(Nombre_Label)
        Me.GroupBox1.Controls.Add(Me.Nombre_TextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(33, 110)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(343, 105)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Codigo_TextBox
        '
        Me.Codigo_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AreasBindingSource, "Codigo ", True))
        Me.Codigo_TextBox.Enabled = False
        Me.Codigo_TextBox.Location = New System.Drawing.Point(118, 34)
        Me.Codigo_TextBox.Name = "Codigo_TextBox"
        Me.Codigo_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Codigo_TextBox.TabIndex = 1
        '
        'AreasBindingSource
        '
        Me.AreasBindingSource.DataMember = "areas"
        Me.AreasBindingSource.DataSource = Me.Biblio_SystemDataSet
        '
        'Biblio_SystemDataSet
        '
        Me.Biblio_SystemDataSet.DataSetName = "Biblio_SystemDataSet"
        Me.Biblio_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Nombre_TextBox
        '
        Me.Nombre_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AreasBindingSource, "Nombre ", True))
        Me.Nombre_TextBox.Enabled = False
        Me.Nombre_TextBox.Location = New System.Drawing.Point(118, 60)
        Me.Nombre_TextBox.Name = "Nombre_TextBox"
        Me.Nombre_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Nombre_TextBox.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Blue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(130, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 40)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "AREAS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.Proyecto_Sena_Biblio_Sistem.My.Resources.Resources.Silver
        Me.PictureBox1.Location = New System.Drawing.Point(33, 50)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(332, 43)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'AreasTableAdapter
        '
        Me.AreasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.areasTableAdapter = Me.AreasTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.detalle_prestamoTableAdapter = Nothing
        Me.TableAdapterManager.devolucionesTableAdapter = Nothing
        Me.TableAdapterManager.lectoresTableAdapter = Nothing
        Me.TableAdapterManager.LibrosTableAdapter = Nothing
        Me.TableAdapterManager.PrestamosTableAdapter = Nothing
        Me.TableAdapterManager.sancionesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        '
        'AreasBindingNavigator
        '
        Me.AreasBindingNavigator.AddNewItem = Nothing
        Me.AreasBindingNavigator.BindingSource = Me.AreasBindingSource
        Me.AreasBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AreasBindingNavigator.DeleteItem = Nothing
        Me.AreasBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.AreasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.AreasBindingNavigator.Location = New System.Drawing.Point(3, 0)
        Me.AreasBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AreasBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AreasBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AreasBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AreasBindingNavigator.Name = "AreasBindingNavigator"
        Me.AreasBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AreasBindingNavigator.Size = New System.Drawing.Size(211, 25)
        Me.AreasBindingNavigator.TabIndex = 5
        Me.AreasBindingNavigator.Text = "BindingNavigator1"
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
        'ToolStripContainer1.BottomToolStripPanel
        '
        Me.ToolStripContainer1.BottomToolStripPanel.Controls.Add(Me.AreasBindingNavigator)
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(219, 0)
        Me.ToolStripContainer1.Location = New System.Drawing.Point(85, 286)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(219, 46)
        Me.ToolStripContainer1.TabIndex = 6
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'Cancelar
        '
        Me.Cancelar.Image = Global.Proyecto_Sena_Biblio_Sistem.My.Resources.Resources.Nueva_imagen__4_
        Me.Cancelar.Location = New System.Drawing.Point(273, 235)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(40, 36)
        Me.Cancelar.TabIndex = 28
        Me.Cancelar.UseVisualStyleBackColor = True
        '
        'Eliminar
        '
        Me.Eliminar.Image = Global.Proyecto_Sena_Biblio_Sistem.My.Resources.Resources.ELIMINAR1
        Me.Eliminar.Location = New System.Drawing.Point(226, 235)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(40, 36)
        Me.Eliminar.TabIndex = 27
        Me.Eliminar.UseVisualStyleBackColor = True
        '
        'Editar
        '
        Me.Editar.Image = Global.Proyecto_Sena_Biblio_Sistem.My.Resources.Resources.EDITAR
        Me.Editar.Location = New System.Drawing.Point(177, 235)
        Me.Editar.Name = "Editar"
        Me.Editar.Size = New System.Drawing.Size(40, 36)
        Me.Editar.TabIndex = 26
        Me.Editar.UseVisualStyleBackColor = True
        '
        'Guardar
        '
        Me.Guardar.Enabled = False
        Me.Guardar.Image = Global.Proyecto_Sena_Biblio_Sistem.My.Resources.Resources.Nueva_imagen__1_
        Me.Guardar.Location = New System.Drawing.Point(134, 235)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(40, 36)
        Me.Guardar.TabIndex = 25
        Me.Guardar.UseVisualStyleBackColor = True
        '
        'nuevo
        '
        Me.nuevo.Image = Global.Proyecto_Sena_Biblio_Sistem.My.Resources.Resources.Nueva_imagen__3_
        Me.nuevo.Location = New System.Drawing.Point(88, 235)
        Me.nuevo.Name = "nuevo"
        Me.nuevo.Size = New System.Drawing.Size(40, 36)
        Me.nuevo.TabIndex = 24
        Me.nuevo.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.MenuBar
        Me.RichTextBox1.Enabled = False
        Me.RichTextBox1.Location = New System.Drawing.Point(48, 227)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(306, 53)
        Me.RichTextBox1.TabIndex = 23
        Me.RichTextBox1.Text = ""
        '
        'areas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(413, 344)
        Me.Controls.Add(Me.Cancelar)
        Me.Controls.Add(Me.Eliminar)
        Me.Controls.Add(Me.Editar)
        Me.Controls.Add(Me.Guardar)
        Me.Controls.Add(Me.nuevo)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "areas"
        Me.Text = "Areas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.AreasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Biblio_SystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AreasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AreasBindingNavigator.ResumeLayout(False)
        Me.AreasBindingNavigator.PerformLayout()
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Biblio_SystemDataSet As Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSet
    Friend WithEvents AreasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AreasTableAdapter As Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSetTableAdapters.areasTableAdapter
    Friend WithEvents TableAdapterManager As Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AreasBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Codigo_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nombre_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cancelar As System.Windows.Forms.Button
    Friend WithEvents Eliminar As System.Windows.Forms.Button
    Friend WithEvents Editar As System.Windows.Forms.Button
    Friend WithEvents Guardar As System.Windows.Forms.Button
    Friend WithEvents nuevo As System.Windows.Forms.Button
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox

End Class
