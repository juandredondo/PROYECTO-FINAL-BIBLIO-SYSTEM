<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIParent1
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
        Me.StatusStrip = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.MenuStrip = New System.Windows.Forms.MenuStrip
        Me.IngresarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NuevoLibroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NuevoLectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AreaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AccionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NuevoPrestamoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RegistrarDevolucionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BusquedaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LibrosDisponiblesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BuscarLectoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ListadoDePrestamosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ListaDeDevolucionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.InvertarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 710)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1005, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.ToolStripStatusLabel.ForeColor = System.Drawing.Color.Black
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(42, 17)
        Me.ToolStripStatusLabel.Text = "Estado"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 641)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1005, 69)
        Me.Panel1.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PictureBox1.Image = Global.Proyecto_Sena_Biblio_Sistem.My.Resources.Resources.Logo_Template___Logo_24
        Me.PictureBox1.Location = New System.Drawing.Point(849, -10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(153, 89)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.HighlightText
        Me.PictureBox2.Image = Global.Proyecto_Sena_Biblio_Sistem.My.Resources.Resources.LOGO_FINAL
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(973, 694)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.White
        Me.MenuStrip.BackgroundImage = Global.Proyecto_Sena_Biblio_Sistem.My.Resources.Resources.Camara
        Me.MenuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresarToolStripMenuItem, Me.AccionesToolStripMenuItem, Me.BusquedaToolStripMenuItem, Me.ReportesToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip.Size = New System.Drawing.Size(1005, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'IngresarToolStripMenuItem
        '
        Me.IngresarToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.IngresarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoLibroToolStripMenuItem, Me.NuevoLectorToolStripMenuItem, Me.AreaToolStripMenuItem})
        Me.IngresarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.IngresarToolStripMenuItem.Name = "IngresarToolStripMenuItem"
        Me.IngresarToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.IngresarToolStripMenuItem.Text = "&Ingresar "
        '
        'NuevoLibroToolStripMenuItem
        '
        Me.NuevoLibroToolStripMenuItem.Name = "NuevoLibroToolStripMenuItem"
        Me.NuevoLibroToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NuevoLibroToolStripMenuItem.Text = "Libros"
        '
        'NuevoLectorToolStripMenuItem
        '
        Me.NuevoLectorToolStripMenuItem.Name = "NuevoLectorToolStripMenuItem"
        Me.NuevoLectorToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NuevoLectorToolStripMenuItem.Text = "Lectores"
        '
        'AreaToolStripMenuItem
        '
        Me.AreaToolStripMenuItem.Name = "AreaToolStripMenuItem"
        Me.AreaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AreaToolStripMenuItem.Text = "Areas"
        '
        'AccionesToolStripMenuItem
        '
        Me.AccionesToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.AccionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoPrestamoToolStripMenuItem, Me.RegistrarDevolucionToolStripMenuItem})
        Me.AccionesToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.AccionesToolStripMenuItem.Name = "AccionesToolStripMenuItem"
        Me.AccionesToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.AccionesToolStripMenuItem.Text = "&Acciones"
        '
        'NuevoPrestamoToolStripMenuItem
        '
        Me.NuevoPrestamoToolStripMenuItem.Name = "NuevoPrestamoToolStripMenuItem"
        Me.NuevoPrestamoToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.NuevoPrestamoToolStripMenuItem.Text = "Nuevo Prestamo"
        '
        'RegistrarDevolucionToolStripMenuItem
        '
        Me.RegistrarDevolucionToolStripMenuItem.Name = "RegistrarDevolucionToolStripMenuItem"
        Me.RegistrarDevolucionToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.RegistrarDevolucionToolStripMenuItem.Text = "Registrar Devolucion"
        '
        'BusquedaToolStripMenuItem
        '
        Me.BusquedaToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.BusquedaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LibrosDisponiblesToolStripMenuItem, Me.BuscarLectoresToolStripMenuItem, Me.ListadoDePrestamosToolStripMenuItem, Me.ListaDeDevolucionesToolStripMenuItem})
        Me.BusquedaToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.BusquedaToolStripMenuItem.Name = "BusquedaToolStripMenuItem"
        Me.BusquedaToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.BusquedaToolStripMenuItem.Text = "&Consultas"
        '
        'LibrosDisponiblesToolStripMenuItem
        '
        Me.LibrosDisponiblesToolStripMenuItem.Name = "LibrosDisponiblesToolStripMenuItem"
        Me.LibrosDisponiblesToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.LibrosDisponiblesToolStripMenuItem.Text = "Listado de Libros"
        '
        'BuscarLectoresToolStripMenuItem
        '
        Me.BuscarLectoresToolStripMenuItem.Name = "BuscarLectoresToolStripMenuItem"
        Me.BuscarLectoresToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.BuscarLectoresToolStripMenuItem.Text = "Listado de Lectores"
        '
        'ListadoDePrestamosToolStripMenuItem
        '
        Me.ListadoDePrestamosToolStripMenuItem.Name = "ListadoDePrestamosToolStripMenuItem"
        Me.ListadoDePrestamosToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.ListadoDePrestamosToolStripMenuItem.Text = "Lista de Prestamos"
        '
        'ListaDeDevolucionesToolStripMenuItem
        '
        Me.ListaDeDevolucionesToolStripMenuItem.Name = "ListaDeDevolucionesToolStripMenuItem"
        Me.ListaDeDevolucionesToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.ListaDeDevolucionesToolStripMenuItem.Text = "Lista de devoluciones"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InvertarioToolStripMenuItem})
        Me.ReportesToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "&Reportes"
        '
        'InvertarioToolStripMenuItem
        '
        Me.InvertarioToolStripMenuItem.Name = "InvertarioToolStripMenuItem"
        Me.InvertarioToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.InvertarioToolStripMenuItem.Text = "Invertario"
        '
        'MDIParent1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 732)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.ForeColor = System.Drawing.Color.Black
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MDIParent1"
        Me.Text = "Biblio-System"
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents IngresarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoLibroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoLectorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AreaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AccionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoPrestamoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistrarDevolucionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BusquedaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LibrosDisponiblesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarLectoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InvertarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents ListadoDePrestamosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListaDeDevolucionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
