<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class midificar_cantidad
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.codigo_libro_textbox = New System.Windows.Forms.TextBox
        Me.nombre_libro_textbox = New System.Windows.Forms.TextBox
        Me.Buttonaceptar = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.NumericUpDown_cantidad = New System.Windows.Forms.NumericUpDown
        Me.TextBox_ejemplares = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        CType(Me.NumericUpDown_cantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo de libro"
        '
        'codigo_libro_textbox
        '
        Me.codigo_libro_textbox.Enabled = False
        Me.codigo_libro_textbox.Location = New System.Drawing.Point(154, 82)
        Me.codigo_libro_textbox.Name = "codigo_libro_textbox"
        Me.codigo_libro_textbox.Size = New System.Drawing.Size(211, 20)
        Me.codigo_libro_textbox.TabIndex = 2
        '
        'nombre_libro_textbox
        '
        Me.nombre_libro_textbox.Enabled = False
        Me.nombre_libro_textbox.Location = New System.Drawing.Point(154, 125)
        Me.nombre_libro_textbox.Name = "nombre_libro_textbox"
        Me.nombre_libro_textbox.Size = New System.Drawing.Size(147, 20)
        Me.nombre_libro_textbox.TabIndex = 3
        '
        'Buttonaceptar
        '
        Me.Buttonaceptar.Location = New System.Drawing.Point(97, 277)
        Me.Buttonaceptar.Name = "Buttonaceptar"
        Me.Buttonaceptar.Size = New System.Drawing.Size(75, 23)
        Me.Buttonaceptar.TabIndex = 6
        Me.Buttonaceptar.Text = "Aceptar "
        Me.Buttonaceptar.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(191, 277)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label4.Font = New System.Drawing.Font("Microsoft Uighur", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(91, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(228, 31)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Modificar Cantidad"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(61, 125)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 13)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Nombre del Libro"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 219)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Cantidad"
        '
        'NumericUpDown_cantidad
        '
        Me.NumericUpDown_cantidad.Location = New System.Drawing.Point(154, 217)
        Me.NumericUpDown_cantidad.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_cantidad.Name = "NumericUpDown_cantidad"
        Me.NumericUpDown_cantidad.Size = New System.Drawing.Size(53, 20)
        Me.NumericUpDown_cantidad.TabIndex = 23
        Me.NumericUpDown_cantidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'TextBox_ejemplares
        '
        Me.TextBox_ejemplares.Enabled = False
        Me.TextBox_ejemplares.Location = New System.Drawing.Point(154, 171)
        Me.TextBox_ejemplares.Name = "TextBox_ejemplares"
        Me.TextBox_ejemplares.Size = New System.Drawing.Size(112, 20)
        Me.TextBox_ejemplares.TabIndex = 24
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(61, 171)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 13)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "Ejemplares"
        '
        'midificar_cantidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(400, 323)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TextBox_ejemplares)
        Me.Controls.Add(Me.NumericUpDown_cantidad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Buttonaceptar)
        Me.Controls.Add(Me.nombre_libro_textbox)
        Me.Controls.Add(Me.codigo_libro_textbox)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "midificar_cantidad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "midificar_cantidad"
        CType(Me.NumericUpDown_cantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents codigo_libro_textbox As System.Windows.Forms.TextBox
    Friend WithEvents nombre_libro_textbox As System.Windows.Forms.TextBox
    Friend WithEvents Buttonaceptar As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown_cantidad As System.Windows.Forms.NumericUpDown
    Friend WithEvents TextBox_ejemplares As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
End Class
