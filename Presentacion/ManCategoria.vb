Imports Entidad
Imports Logica

Public Class ManCategoria
    Private Sub tooltip() 'Mensaje 
        TooMensaje.SetToolTip(BtnSalir, "Salir del Formulario")
        TooMensaje.SetToolTip(BtnGuardar, "Grabar Registro")
        TooMensaje.ToolTipTitle = "Sistema de Categoria"
        TooMensaje.ToolTipIcon = ToolTipIcon.Info
        TooMensaje.BackColor = Color.Tomato
    End Sub
    Private Sub ManCategoria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tooltip()
    End Sub

    Public Sub LimpiarGroupbox()
        For Each C In GBox.Controls
            If TypeOf C Is TextBox Then C.Text = ""
        Next
    End Sub
    Public Function ValidaEntrada(ByVal err As ErrorProvider, ByVal grp As GroupBox) As Boolean
        Dim er As Boolean = True
        For Each C In grp.Controls 'For que se lo utiliza para leer colecciones
            If TypeOf C Is TextBox And C.Text = "" Then 'TypeOf = tipo
                err.SetError(C, "No ha ingresado informacion en: " + C.Name)
                er = False
            End If
        Next
        Return er
    End Function

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        ErrDatos.Clear()
        Dim ObjLogCat As New LogCategoria
        If MessageBox.Show("Esta Seguro de Grabar el Registro", "Sistema Categoria", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            If ValidaEntrada(ErrDatos, GBox) Then
                If PreConCategoria.grabar = "N" Then
                    ObjLogCat.ingresar(New EntCategoria(Val(TxtCodigo.Text), TxtDescripcion.Text))
                    MessageBox.Show("Registro Grabado Correctamente")
                Else
                    ObjLogCat.modificar(New EntCategoria(Val(TxtCodigo.Text), TxtDescripcion.Text))
                    MessageBox.Show("Registro Modificado Correctamente")
                End If
                PreConCategoria.TxtBuscar.Clear()
                PreConCategoria.grabar = "ok"
                Me.Dispose()
            Else
                MessageBox.Show("Error. Llene los Campos")
            End If
        End If
        PreConCategoria.TxtBuscar.Clear()
    End Sub


    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        If MessageBox.Show("Desea Salir del Formulario", "Sistema Categoria", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            Me.Dispose()
        End If
    End Sub
End Class
