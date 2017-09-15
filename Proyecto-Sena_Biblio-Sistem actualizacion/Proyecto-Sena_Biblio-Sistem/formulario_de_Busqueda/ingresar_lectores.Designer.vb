<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ingresar_lectores
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Buttoncancelar = New System.Windows.Forms.Button
        Me.butonguardar = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.LectoresTableAdapter = New Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSetTableAdapters.lectoresTableAdapter
        Me.TableAdapterManager = New Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSetTableAdapters.TableAdapterManager
        Me.GroupBox1.SuspendLayout()
        CType(Me.LectoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Biblio_SystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
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
        Me.GroupBox1.Location = New System.Drawing.Point(29, 128)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(635, 239)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Lector"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LectoresBindingSource, "telefono", True))
        Me.TextBox1.Location = New System.Drawing.Point(448, 149)
        Me.TextBox1.MaxLength = 13
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(88, 20)
        Me.TextBox1.TabIndex = 18
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
        Me.ComboBoxtipo_lect.FormattingEnabled = True
        Me.ComboBoxtipo_lect.Items.AddRange(New Object() {"Estudiante", "Profesor", "Secretaria", "Coordinador", "Rector", "Particular"})
        Me.ComboBoxtipo_lect.Location = New System.Drawing.Point(153, 198)
        Me.ComboBoxtipo_lect.Name = "ComboBoxtipo_lect"
        Me.ComboBoxtipo_lect.Size = New System.Drawing.Size(154, 21)
        Me.ComboBoxtipo_lect.TabIndex = 17
        Me.ComboBoxtipo_lect.Text = "Estudiante"
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
        Me.ComboBoxcurso.Text = "02"
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
        Me.ComboBoxgrado.Text = "11º"
        '
        'TextBoxdireccion
        '
        Me.TextBoxdireccion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LectoresBindingSource, "direccion", True))
        Me.TextBoxdireccion.Location = New System.Drawing.Point(153, 147)
        Me.TextBoxdireccion.MaxLength = 25
        Me.TextBoxdireccion.Name = "TextBoxdireccion"
        Me.TextBoxdireccion.Size = New System.Drawing.Size(154, 20)
        Me.TextBoxdireccion.TabIndex = 13
        '
        'ComboBoxsexo
        '
        Me.ComboBoxsexo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LectoresBindingSource, "sexo", True))
        Me.ComboBoxsexo.FormattingEnabled = True
        Me.ComboBoxsexo.Items.AddRange(New Object() {"F", "M"})
        Me.ComboBoxsexo.Location = New System.Drawing.Point(579, 152)
        Me.ComboBoxsexo.Name = "ComboBoxsexo"
        Me.ComboBoxsexo.Size = New System.Drawing.Size(44, 21)
        Me.ComboBoxsexo.TabIndex = 12
        Me.ComboBoxsexo.Text = "M"
        '
        'TextBoxapellido
        '
        Me.TextBoxapellido.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LectoresBindingSource, "apellido", True))
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
        Me.texboxnombre.Location = New System.Drawing.Point(153, 96)
        Me.texboxnombre.MaxLength = 50
        Me.texboxnombre.Name = "texboxnombre"
        Me.texboxnombre.Size = New System.Drawing.Size(154, 20)
        Me.texboxnombre.TabIndex = 10
        '
        'textBoxid_lector
        '
        Me.textBoxid_lector.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LectoresBindingSource, "cod_lector", True))
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
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Blue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(213, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(295, 44)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "LECTORES"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Buttoncancelar
        '
        Me.Buttoncancelar.Image = Global.Proyecto_Sena_Biblio_Sistem.My.Resources.Resources.Sign_07_24x24_32
        Me.Buttoncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Buttoncancelar.Location = New System.Drawing.Point(352, 403)
        Me.Buttoncancelar.Name = "Buttoncancelar"
        Me.Buttoncancelar.Size = New System.Drawing.Size(101, 30)
        Me.Buttoncancelar.TabIndex = 11
        Me.Buttoncancelar.Text = "Cancelar"
        Me.Buttoncancelar.UseVisualStyleBackColor = True
        '
        'butonguardar
        '
        Me.butonguardar.Image = Global.Proyecto_Sena_Biblio_Sistem.My.Resources.Resources.Floppy_24x24_32
        Me.butonguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.butonguardar.Location = New System.Drawing.Point(219, 403)
        Me.butonguardar.Name = "butonguardar"
        Me.butonguardar.Size = New System.Drawing.Size(101, 30)
        Me.butonguardar.TabIndex = 12
        Me.butonguardar.Text = "Guardar"
        Me.butonguardar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.Proyecto_Sena_Biblio_Sistem.My.Resources.Resources.Silver
        Me.PictureBox1.Location = New System.Drawing.Point(106, 42)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(494, 45)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
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
        'ingresar_lectores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 456)
        Me.Controls.Add(Me.Buttoncancelar)
        Me.Controls.Add(Me.butonguardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ingresar_lectores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ingresar_lectores"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.LectoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Biblio_SystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Protected WithEvents Buttoncancelar As System.Windows.Forms.Button
    Protected WithEvents butonguardar As System.Windows.Forms.Button
    Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxtipo_lect As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxcurso As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxgrado As System.Windows.Forms.ComboBox
    Friend WithEvents TextBoxdireccion As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxsexo As System.Windows.Forms.ComboBox
    Friend WithEvents TextBoxapellido As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents texboxnombre As System.Windows.Forms.TextBox
    Friend WithEvents textBoxid_lector As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Protected WithEvents Label1 As System.Windows.Forms.Label
    Protected WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Biblio_SystemDataSet As Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSet
    Friend WithEvents LectoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LectoresTableAdapter As Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSetTableAdapters.lectoresTableAdapter
    Friend WithEvents TableAdapterManager As Proyecto_Sena_Biblio_Sistem.Biblio_SystemDataSetTableAdapters.TableAdapterManager
End Class
