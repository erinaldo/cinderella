﻿Imports System.Data.SqlClient

Public Class NegDevolucion
    Dim ClsDatos As New Datos.Conexion
    Dim ClsFunciones As New Funciones

    Public Function NuevaDevolucion(ByVal Devolucion As Entidades.Devolucion) As String
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim msg As String = ""
        Dim dt As DataTable = New DataTable()
        Dim HayInternet As Boolean = Funciones.HayInternet

        'Cargo el detalle de la devolucion en un Tabla para pasarla por un campo al SP
        dt.Columns.Add("id_Producto", Type.GetType("System.Int32"))
        dt.Columns.Add("Cantidad", Type.GetType("System.Int32"))
        dt.Columns.Add("Precio", Type.GetType("System.Double"))

        For Each item As Entidades.Devolucion_Detalle In Devolucion.Detalle
            dt.Rows.Add(item.id_Producto, item.Cantidad, item.Precio)
        Next


        Try
            cmd.Connection = ClsDatos.ConectarLocal()
            msg = NuevaDevolucion(Devolucion, cmd, dt)
            ClsDatos.DesconectarLocal()

            'Conecto a la bdd.
            If HayInternet Then
                cmd = New SqlCommand()
                cmd.Connection = ClsDatos.ConectarRemoto()
                msg = NuevaDevolucion(Devolucion, cmd, dt)
                ClsDatos.DesconectarRemoto()
            End If

            'retorno valor
            Return msg
        Catch ex As Exception
            Return "0"
        End Try
    End Function

    Private Shared Function NuevaDevolucion(Devolucion As Entidades.Devolucion, ByRef cmd As SqlCommand, dt As DataTable) As String
        'Cargo y ejecuto el stored.
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_Devoluion_Alta"

        With cmd.Parameters
            .AddWithValue("@id_Cliente", Devolucion.id_Cliente)
            .AddWithValue("@id_Empleado", Devolucion.id_Empleado)
            .AddWithValue("@id_Encargado", Devolucion.id_Encargado)
            .AddWithValue("@id_Sucursal", Devolucion.id_Sucursal)
            .AddWithValue("@id_TipoPago", Devolucion.id_TipoPago)
            .AddWithValue("@id_TipoDevolucion", Devolucion.id_TipoDevolucion)
            .AddWithValue("@PrecioTotal", Devolucion.PrecioTotal)
            .AddWithValue("@Subtotal", Devolucion.SubTotal)
            .AddWithValue("@CantidadTotal", Devolucion.CantidadTotal)
            .AddWithValue("@Descuento", Devolucion.Descuento)
            .AddWithValue("@Habilitado", Devolucion.Habilitado)
            .AddWithValue("@NotaCredito", Devolucion.NotaCredito)
        End With

        'Declaro el tipo de dato para el detalle de la devolucion
        Dim param = cmd.Parameters.AddWithValue("@Detalle", dt)
        param.SqlDbType = SqlDbType.Structured
        param.TypeName = "dbo.DEVOLUCIONES_DETALLE_TYPE"

        'Respuesta del stored.
        Dim respuesta As New SqlParameter("@msg", SqlDbType.Int, 255)
        respuesta.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta)
        cmd.ExecuteNonQuery()
        Return respuesta.Value
    End Function

    'Funcion que obtiene el listado de devoluciones de una sucursal.
    Public Function ObtenerDevolucionesSucursalListado(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String)
        Dim ds As New DataSet

        If Funciones.HayInternet Then
            ds = ClsDatos.ConsultarBaseRemoto("execute sp_Devoluciones_SucursalObtenerListado @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        Else
            ds = ClsDatos.ConsultarBaseLocal("execute sp_Devoluciones_SucursalObtenerListado @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        End If

        Return ds
    End Function

    'Funcion para consultar un detalle de laa venta.
    Public Function TraerDevolucionDetalle(ByVal id_Venta As Integer)
        Dim dsVentas As New DataSet

        If (Funciones.HayInternet) Then
            dsVentas = ClsDatos.ConsultarBaseRemoto("execute sp_DevolucionDetalle_Listado @id_Venta=" & id_Venta)
        Else
            dsVentas = ClsDatos.ConsultarBaseLocal("execute sp_DevolucionDetalle_Listado @id_Venta=" & id_Venta)
        End If

        Return dsVentas
    End Function

    'Funcion para listar todas las devoluciones por FECHA.
    Function ListadoDevolucionesCompletoFecha(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String) As DataSet
        If Funciones.HayInternet Then
            Return ClsDatos.ConsultarBaseRemoto("execute sp_Devolucion_ListadoCompletoFecha @id_Sucursal=" & id_Sucursal & ",@FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        Else
            Return ClsDatos.ConsultarBaseLocal("execute sp_Devolucion_ListadoCompletoFecha @id_Sucursal=" & id_Sucursal & ",@FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        End If
    End Function

    'Funcion para consultar una devolucion.
    Public Function TraerDevolucion(ByVal id_Devolucion As Integer)
        Dim dsDevolucion As New DataSet

        If (Funciones.HayInternet) Then
            dsDevolucion = ClsDatos.ConsultarBaseRemoto("execute sp_Devolucion_Detalle @id_Devolucion=" & id_Devolucion)
        Else
            dsDevolucion = ClsDatos.ConsultarBaseLocal("execute sp_Devolucion_Detalle @id_Devolucion=" & id_Devolucion)
        End If

        Return dsDevolucion
    End Function

    Function AnularDevolucion(id_Devolucion As Integer, Texto As String) As Integer
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim msg As Integer
        Dim HayInternet As Boolean = Funciones.HayInternet


        If (Texto = "") Then
            Texto = "No se ingreso el motivo."
        End If

        Try
            cmd.Connection = ClsDatos.ConectarLocal()
            msg = AnularDevolucion(id_Devolucion, Texto, cmd)
            ClsDatos.DesconectarLocal()

            'Conecto a la bdd.
            If HayInternet Then
                cmd = New SqlCommand()
                cmd.Connection = ClsDatos.ConectarRemoto()
                msg = AnularDevolucion(id_Devolucion, Texto, cmd)
                ClsDatos.DesconectarRemoto()
            End If

            'retorno valor
            Return msg
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Private Shared Function AnularDevolucion(id_Devolucion As Integer, Texto As String, ByRef cmd As SqlCommand) As Integer
        'Cargo y ejecuto el stored.
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_Devolucion_Anular"
        With cmd.Parameters
            .AddWithValue("@id_Devolucion", id_Devolucion)
            .AddWithValue("@Texto", Texto)
            .AddWithValue("@Fecha", Now.Date.ToString("yyyy/MM/dd"))
        End With

        'Respuesta del stored.
        Dim respuesta As New SqlParameter("@msg", SqlDbType.Int, 255)
        respuesta.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta)
        cmd.ExecuteNonQuery()

        Return respuesta.Value
    End Function

    'Funcion que actualiza una venta como facturada o no facturada.
    Public Function GeneracionNotaCredito(ByVal credito As Boolean, ByVal id_Devolucion As Integer)
        Dim notaCredito As Integer = 0
        Dim HayInternet As Boolean = Funciones.HayInternet
        Dim cmd As New SqlCommand
        Dim msg As Boolean

        If credito Then
            notaCredito = 1
        Else
            notaCredito = 0
        End If

        Try
            cmd.Connection = ClsDatos.ConectarLocal()
            msg = GenerarNotaCredito(id_Devolucion, notaCredito, cmd)
            ClsDatos.DesconectarLocal()

            'Conecto a la bdd.
            If HayInternet Then
                cmd = New SqlCommand
                cmd.Connection = ClsDatos.ConectarRemoto()
                msg = GenerarNotaCredito(id_Devolucion, notaCredito, cmd)
                ClsDatos.DesconectarRemoto()
            End If

            'retorno valor
            Return msg
        Catch ex As Exception
            Return 0
        End Try

    End Function

    Private Shared Function GenerarNotaCredito(id_Devolucion As Integer, notaCredito As Integer, ByRef cmd As SqlCommand) As Boolean
        'Cargo y ejecuto el stored.
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_Devolucion_GeneracionNotaCredito"
        With cmd.Parameters
            .AddWithValue("@id_Devolucion", id_Devolucion)
            .AddWithValue("@NotaCredito", notaCredito)
        End With

        'Respuesta del stored.
        Dim respuesta As New SqlParameter("@msg", SqlDbType.Int, 255)
        respuesta.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta)
        cmd.ExecuteNonQuery()
        Return CBool(respuesta.Value)
    End Function

    Public Function TotalDevolucionesEfectivo(ByVal id_Sucursal As Integer, ByVal Fecha As String)
        Dim ds As New DataSet
        If Funciones.HayInternet Then
            ds = ClsDatos.ConsultarBaseRemoto("execute sp_Devoluciones_TotalDevolucionesEfectivo @id_Sucursal=" & id_Sucursal & ", @Fecha='" & Fecha & "'")
        Else
            ds = ClsDatos.ConsultarBaseLocal("execute sp_Devoluciones_TotalDevolucionesEfectivo @id_Sucursal=" & id_Sucursal & ", @Fecha='" & Fecha & "'")
        End If

        If ds.Tables(0).Rows.Count = 1 And ds.Tables(0).Rows(0).Item("DevolucionesTotales").ToString <> "" Then
            Return ds.Tables(0).Rows(0).Item("DevolucionesTotales").ToString
        Else
            Return 0
        End If
    End Function

End Class
