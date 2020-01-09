Imports Entidad
Imports Logica
Public Class PreConCategoria
    Dim ObjLogCat As New LogCategoria
    Public grabar As String = ""
    Private Sub tooltip() 'Mensaje 
        TooMensaje.SetToolTip(BtnSalir, "Salir De la Consulta")
        TooMensaje.SetToolTip(BtnIngresar, "Ingresar Nueva Categoria")
        TooMensaje.ToolTipTitle = "Sistema de Categoria"
        TooMensaje.ToolTipIcon = ToolTipIcon.Info
        TooMensaje.BackColor = Color.Tomato
    End Sub
    Private Sub PreConCategoria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dg.DataSource = ObjLogCat.buscar("")
        tooltip()
        cargar()
    End Sub

    Private Sub cargar()
        Dg.Rows.Clear()
        For Each cat In ObjLogCat.buscar(TxtBuscar.Text.Trim)
            Dg.Rows.Add(cat.Codigo, cat.Descripcion)
        Next
    End Sub

   

    Private Sub TxtBuscar_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBuscar.TextChanged
        If (TxtBuscar.Text <> "") Then
            If (RbCod.Checked = True) Then
                Dg.Rows.Clear()
                Dim tabla As DataTable = ObjLogCat.buscarCodigo(Val(TxtBuscar.Text.Trim))
                For Each fil In tabla.Rows
                    Dg.Rows.Add(fil.Item(0), fil.Item(1))
                Next
            Else
                If (RbDesc.Checked = True) Then
                    cargar()
                End If
            End If
        Else
            cargar()
        End If
    End Sub

    Private Sub Dg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dg.Click
        If Dg.CurrentCell.ColumnIndex = 2 Then
            grabar = "M"
            ManCategoria.TxtCodigo.Text = Val(Dg.Rows(Dg.CurrentRow.Index).Cells(0).Value.ToString)
            ManCategoria.TxtDescripcion.Text = Dg.Rows(Dg.CurrentRow.Index).Cells(1).Value.ToString
            ManCategoria.ShowDialog()
            cargar()
        Else
            If Dg.CurrentCell.ColumnIndex = 3 Then
                If MessageBox.Show("Esta Seguro De Eliminar El Registro" + Chr(13) + Chr(13) + Dg.Rows(Dg.CurrentRow.Index).Cells(1).Value.ToString, "Sistema Categoria", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                    ObjLogCat.eliminar(New EntCategoria(Val(Val(Dg.Rows(Dg.CurrentRow.Index).Cells(0).Value.ToString)), ""))
                    TxtBuscar.Text = ""
                    MessageBox.Show("Registro Eliminado Correctamente")
                Else
                    MessageBox.Show("Operacion Cancelada")
                End If
                cargar()
            End If
        End If
    End Sub

    
    Private Sub BtnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIngresar.Click
        grabar = "N"
        ManCategoria.TxtCodigo.Text = ObjLogCat.MaxCodigo()
        ManCategoria.ShowDialog()
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        If MessageBox.Show("Desea Salir de la Consulta", "Sistema Categoria", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub BtnIngresar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnIngresar.GotFocus
        If grabar = "ok" Then
            grabar = ""
            cargar()
        End If
    End Sub
End Class