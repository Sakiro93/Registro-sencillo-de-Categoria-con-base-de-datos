Imports System.Data.SqlClient
Imports Interfaz
Imports Entidad
Public Class AccCategoria
    Implements IntCategoria


    Public Function buscar(ByVal filtro As String) As System.Collections.Generic.List(Of Entidad.EntCategoria) Implements Interfaz.IntCategoria.buscar
        Dim sql As New SqlEjecucion()
        Dim cmd As New SqlCommand()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "Ca_Categorias"
        With cmd.Parameters
            .Add("@Opcion", SqlDbType.VarChar).Value = "DES"
            .Add("@CatCodigo", SqlDbType.TinyInt).Value = 0
            .Add("@CatDescripcion", SqlDbType.VarChar).Value = filtro
        End With
        Dim LstCategoria As New List(Of EntCategoria)
        Dim Categoria As EntCategoria
        Dim Tabla As New DataTable
        Tabla = sql.Consulta(cmd)
        For fila = 0 To Tabla.Rows.Count - 1
            Categoria = New EntCategoria(Tabla.Rows(fila).Item(0), Tabla.Rows(fila).Item(1))
            LstCategoria.Add(Categoria)
        Next
        Return LstCategoria
    End Function

    Public Sub eliminar(ByVal Categoria As Entidad.EntCategoria) Implements Interfaz.IntCategoria.eliminar
        grabar("ELI", Categoria)
    End Sub

    Public Sub ingresar(ByVal Categoria As Entidad.EntCategoria) Implements Interfaz.IntCategoria.ingresar
        grabar("INS", Categoria)
    End Sub
    Public Sub modificar(ByVal Categoria As Entidad.EntCategoria) Implements Interfaz.IntCategoria.modificar
        grabar("MOD", Categoria)
    End Sub
    Public Sub grabar(ByVal opc As String, ByVal Categoria As Entidad.EntCategoria)
        Dim sql As New SqlEjecucion()
        Dim cmd As New SqlCommand()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "Ca_Categorias"
        With cmd.Parameters
            .Add("@Opcion", SqlDbType.VarChar).Value = opc
            .Add("@CatCodigo", SqlDbType.TinyInt).Value = Categoria.Codigo
            .Add("@CatDescripcion", SqlDbType.VarChar).Value = Categoria.Descripcion
        End With
        sql.Ejecutar(cmd)

    End Sub

    Public Function MaxCodigo() As String Implements Interfaz.IntCategoria.MaxCodigo
        Dim sql As New SqlEjecucion()
        Dim cmd As New SqlCommand()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "Ca_Categorias"
        With cmd.Parameters
            .Add("@Opcion", SqlDbType.VarChar).Value = "SIG"
            .Add("@CatCodigo", SqlDbType.TinyInt).Value = 0
            .Add("@CatDescripcion", SqlDbType.VarChar).Value = ""
        End With
        Return sql.MaximoCodigo(cmd)
    End Function

    Public Function buscarCodigo(ByVal cod As Integer) As System.Data.DataTable Implements Interfaz.IntCategoria.buscarCodigo
        Dim sql As New SqlEjecucion()
        Dim cmd As New SqlCommand()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "Ca_Categorias"
        With cmd.Parameters
            .Add("@Opcion", SqlDbType.VarChar).Value = "COD"
            .Add("@CatCodigo", SqlDbType.TinyInt).Value = cod
            .Add("@CatDescripcion", SqlDbType.VarChar).Value = ""
        End With
        Dim Tabla As New DataTable
        Tabla = sql.Consulta(cmd)
        Return Tabla
    End Function
End Class
