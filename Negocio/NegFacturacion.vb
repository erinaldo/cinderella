﻿Imports System.Data.SqlClient
Imports Datos

Public Class NegFacturacion
    Dim ClsDatos As New Datos.Conexion
    Dim ClsFunciones As New Funciones
    Dim HayInternet As Boolean = ClsFunciones.GotInternet
    Dim con As New Conexion

    'Funcion que inserta un nuevo registro en la tabla VENTAS_DETALLE.
    Public Function NuevaFacturacion(ByVal EntFacturacion As Entidades.Facturacion) As Boolean
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim msg As String = ""
        Try
            'Conecto a la bdd.
            If (HayInternet) Then
                cmd.Connection = ClsDatos.ConectarRemoto()
            Else
                cmd.Connection = ClsDatos.ConectarLocal()
            End If

            'Ejecuto el stored.
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_Facturacion_Alta"
            With cmd.Parameters
                .AddWithValue("@id_Venta", EntFacturacion.id_Venta)
                .AddWithValue("@NumeroFactura", EntFacturacion.NumeroFactura)
                .AddWithValue("@Monto", EntFacturacion.Monto)
                .AddWithValue("@Nombre", EntFacturacion.Nombre)
                .AddWithValue("@Cuit", EntFacturacion.Cuit)
                .AddWithValue("@Direccion", EntFacturacion.Direccion)
                .AddWithValue("@Localidad", EntFacturacion.Localidad)
                .AddWithValue("@TipoFactura", EntFacturacion.TipoFactura)
                .AddWithValue("@PuntoVenta", EntFacturacion.PuntoVenta)
                .AddWithValue("@Id_Sucursal", EntFacturacion.IdSucursal)
                .AddWithValue("@TipoRecibo", EntFacturacion.TipoRecibo)
            End With

            'Respuesta del stored.
            Dim respuesta As New SqlParameter("@msg", SqlDbType.Int, 255)
            respuesta.Direction = ParameterDirection.Output
            cmd.Parameters.Add(respuesta)
            cmd.ExecuteNonQuery()

            'Desconecto la bdd.
            If (HayInternet) Then
                ClsDatos.DesconectarRemoto()
            Else
                ClsDatos.DesconectarLocal()
            End If

            'retorno valor
            Return CBool(respuesta.Value)
        Catch ex As Exception
            Return False
        End Try
    End Function

    'Funcion que retorna el ultimo numero utilizado en una factura 
    Public Function ObtenerUltimoNumeroFactura(ByVal TipoRecibo As Entidades.TipoFactura, ByVal PuntoVenta As Integer, ByVal Id_Sucursal As Integer, ByVal tipoFactura As String) As String
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim msg As String = ""
        'Conecto a la bdd.

        Try
            If (HayInternet) Then
                cmd.Connection = ClsDatos.ConectarRemoto()
            Else
                cmd.Connection = ClsDatos.ConectarLocal()
            End If

            'Ejecuto el stored.
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_Facturacion_Ultimo_Numero"
            With cmd.Parameters
                .AddWithValue("@TipoRecibo", TipoRecibo)
                .AddWithValue("@PuntoVenta", PuntoVenta)
                .AddWithValue("@Id_Sucursal", Id_Sucursal)
                .AddWithValue("@tipoFactura", tipoFactura)
            End With

            'Respuesta del stored.
            Dim respuesta As New SqlParameter("@NumeroFactura", SqlDbType.VarChar, 255)
            respuesta.Direction = ParameterDirection.Output
            cmd.Parameters.Add(respuesta)
            cmd.ExecuteNonQuery()

            'Desconecto la bdd.
            If (HayInternet) Then
                ClsDatos.DesconectarRemoto()
            Else
                ClsDatos.DesconectarLocal()
            End If

            'retorno valor
            Return respuesta.Value
        Catch ex As Exception
            Return 0
        End Try
    End Function

    'Funcion que verifica si un numero de factura esta utilizado
    Public Function NumeroFacturaUtilizado(ByVal TipoRecibo As Entidades.TipoFactura, ByVal PuntoVenta As Integer, ByVal Id_Sucursal As Integer, ByVal NumeroFactura As String, ByVal tipoFactura As String) As Boolean
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim msg As String = ""

        Try

            'Conecto a la bdd.
            If (HayInternet) Then
                cmd.Connection = ClsDatos.ConectarRemoto()
            Else
                cmd.Connection = ClsDatos.ConectarLocal()
            End If

            'Ejecuto el stored.
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_Facturacion_Existe_Numero"
            With cmd.Parameters
                .AddWithValue("@TipoRecibo", TipoRecibo)
                .AddWithValue("@PuntoVenta", PuntoVenta)
                .AddWithValue("@Id_Sucursal", Id_Sucursal)
                .AddWithValue("@NumeroFactura", NumeroFactura)
                .AddWithValue("@tipoFactura", tipoFactura)
            End With

            'Respuesta del stored.
            Dim respuesta As New SqlParameter("@Existe", SqlDbType.Bit, 1)
            respuesta.Direction = ParameterDirection.Output
            cmd.Parameters.Add(respuesta)
            cmd.ExecuteNonQuery()

            'Desconecto la bdd.
            If (HayInternet) Then
                ClsDatos.DesconectarRemoto()
            Else
                ClsDatos.DesconectarLocal()
            End If

            'retorno valor
            Return Boolean.Parse(respuesta.Value.ToString())
        Catch ex As Exception
            Return False
        End Try
    End Function

    'Funcion que retorna el ultimo numero utilizado en una factura 
    Public Function ListadoTicketControladorFiscal(ByVal tipoFactura As String, ByVal idSucursal As Integer, ByVal FDesde As String, ByVal FHasta As String) As List(Of Entidades.Facturacion)
        'Declaro variables
        Dim dsFacturas As New DataSet
        Dim facturas As List(Of Entidades.Facturacion) = New List(Of Entidades.Facturacion)()
        'Conecto a la bdd.

        Try
            If (HayInternet) Then
                dsFacturas = ClsDatos.ConsultarBaseRemoto("execute sp_Facturacion_Listado @TipoFactura='" & tipoFactura & "', @idSucursal=" & idSucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
            Else
                dsFacturas = ClsDatos.ConsultarBaseRemoto("execute sp_Facturacion_Listado @TipoFactura='" & tipoFactura & "', @idSucursal=" & idSucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
            End If

            For Each factura As DataRow In dsFacturas.Tables(0).Rows
                facturas.Add(ObtenerEntidadFactura(factura))
            Next
            'retorno valor
            Return facturas
        Catch ex As Exception
            Return facturas
        End Try
    End Function

    'Funcion para consultar una factura.
    Public Function TraerFacturacion(ByVal id_Venta As Integer)
        Dim dsFactura As New DataSet
        Dim entFactura As New Entidades.Facturacion

        If (HayInternet) Then
            dsFactura = ClsDatos.ConsultarBaseRemoto("execute sp_Facturacion_Detalle @id_Venta=" & id_Venta)
        Else
            dsFactura = ClsDatos.ConsultarBaseLocal("execute sp_Facturacion_Detalle @id_Venta=" & id_Venta)
        End If

        If dsFactura.Tables(0).Rows.Count <> 0 Then
            entFactura = ObtenerEntidadFactura(dsFactura.Tables(0).Rows(0))
        End If

        Return entFactura
    End Function

    Private Function ObtenerEntidadFactura(ByVal dr As DataRow) As Entidades.Facturacion

        Dim entFactura As New Entidades.Facturacion

        entFactura.id_Facturacion = dr.Item("id_Facturacion").ToString
        entFactura.id_Venta = dr.Item("id_Venta").ToString
        entFactura.NumeroFactura = dr.Item("NumeroFactura").ToString
        entFactura.Monto = dr.Item("Monto").ToString
        entFactura.TipoFactura = dr.Item("TipoFactura").ToString
        entFactura.Nombre = dr.Item("Nombre").ToString
        entFactura.Direccion = dr.Item("Direccion").ToString
        entFactura.Localidad = dr.Item("Localidad").ToString
        entFactura.Cuit = dr.Item("Cuit").ToString
        entFactura.Fecha = dr.Item("Fecha").ToString
        entFactura.PuntoVenta = dr.Item("PuntoVenta").ToString
        entFactura.TipoRecibo = Integer.Parse(dr.Item("TipoRecibo").ToString)
        entFactura.IdSucursal = dr.Item("Id_Sucursal").ToString
        entFactura.IVA = Double.Parse(dr.Item("Monto").ToString) * 0.21
        entFactura.SubTotal = Double.Parse(dr.Item("Monto").ToString) * 0.79

        Return entFactura
    End Function


End Class
