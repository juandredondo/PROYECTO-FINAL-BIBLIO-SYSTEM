Imports System.Windows.Forms

Public Class MDIParent1


    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub NuevoLibroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoLibroToolStripMenuItem.Click

        My.Forms.Libros.Show()
        My.Forms.Libros.MdiParent = Me

    End Sub

    Private Sub NuevoLectorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoLectorToolStripMenuItem.Click

        My.Forms.Lectores.Show()
        My.Forms.Lectores.MdiParent = Me
    End Sub

    Private Sub NuevoPrestamoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoPrestamoToolStripMenuItem.Click

        My.Forms.Prestamos.Show()
        My.Forms.Prestamos.MdiParent = Me
    End Sub

    Private Sub AreaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AreaToolStripMenuItem.Click
        My.Forms.areas.Show()
        My.Forms.areas.MdiParent = Me
    End Sub

    Private Sub MDIParent1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox(" Esta seguro que desea Salir del sistema", MsgBoxStyle.YesNo, "Salir") = MsgBoxResult.Yes Then

        Else
            e.Cancel = True
        End If

    End Sub

    
    Private Sub ListadoDeLibrosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Forms.lista_de_libros.MdiParent = Me
        My.Forms.lista_de_libros.Show()

    End Sub

    Private Sub LibrosDisponiblesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LibrosDisponiblesToolStripMenuItem.Click
        My.Forms.Libros_Disponibles.Show()
        My.Forms.Libros_Disponibles.MdiParent = Me

    End Sub

    Private Sub BuscarLectoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarLectoresToolStripMenuItem.Click
        My.Forms.lista_de_lectores.Show()
        My.Forms.lista_de_lectores.MdiParent = Me

    End Sub

    Private Sub InvertarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InvertarioToolStripMenuItem.Click
        My.Forms.reporte.Show()
        My.Forms.reporte.MdiParent = Me

    End Sub

    Private Sub RegistrarDevolucionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistrarDevolucionToolStripMenuItem.Click
        My.Forms.devoluciones.Show()
        My.Forms.devoluciones.MdiParent = Me
    End Sub
    Private Sub ListadoDePrestamosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoDePrestamosToolStripMenuItem.Click
        My.Forms.lista_de_libros.Show()
        My.Forms.lista_de_libros.MdiParent = Me
    End Sub

    Private Sub ListaDeDevolucionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListaDeDevolucionesToolStripMenuItem.Click
        My.Forms.prueva.Show()
        My.Forms.prueva.MdiParent = Me
    End Sub
End Class
