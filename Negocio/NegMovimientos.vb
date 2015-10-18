﻿Imports System.Data.SqlClient

Public Class NegMovimientos
    Dim clsDatos As New Datos.Conexion
    Dim ClsFunciones As New Funciones
    Dim HayInternet As Boolean = ClsFunciones.GotInternet

    'Obtener Ingresos
    Function ObtenerIngresos(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String)
        Dim ds As New DataSet
        If HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_Sucursales_Ingresos @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_Sucursales_Ingresos @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        End If
        Return ds.Tables(0).Rows(0).Item("Ingreso").ToString
    End Function

    'Obtener Egresos
    Function ObtenerEgresos(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String)
        Dim ds As New DataSet
        If HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_Sucursales_Egresos @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_Sucursales_Egresos @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        End If
        Return ds.Tables(0).Rows(0).Item("Egreso").ToString
    End Function

    'Obtener Ingresos Listado
    Function ObtenerIngresosListado(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String)
        Dim ds As New DataSet
        If HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_Sucursales_IngresosListado @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_Sucursales_IngresosListado @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        End If
        Return ds
    End Function

    'Obtener Egresos Listado
    Function ObtenerEgresosListado(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String)
        Dim ds As New DataSet
        If HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_Sucursales_EgresosListado @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_Sucursales_EgresosListado @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        End If
        Return ds
    End Function

    'NUEVOS'

    'Consulto si existen montos de un tipo de movimiento de un determinado rango de fechas.
    Function ConsultarMovimiento(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String, ByVal id_Seccion As Integer, ByVal id_Tipo As Integer) As Double
        Dim ds As New DataSet
        If HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_Movimientos_Consultar @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "', @id_Seccion='" & id_Seccion & "', @id_Tipo='" & id_Tipo & "'")
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_Movimientos_Consultar @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "', @id_Seccion='" & id_Seccion & "', @id_Tipo='" & id_Tipo & "'")
        End If

        If ds.Tables(0).Rows.Count = 1 And ds.Tables(0).Rows(0).Item("Suma").ToString <> "" Then
            Return 1
        Else
            Return 0
        End If
    End Function

    'Consulto si existen montos de un tipo de movimiento de un determinado rango de fechas.
    Function ConsultarTotalMovimiento(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String, ByVal id_Seccion As Integer) As Double
        Dim ds As New DataSet
        If HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_Movimientos_ConsultarTotal @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "', @id_Seccion='" & id_Seccion & "'")
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_Movimientos_ConsultarTotal @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "', @id_Seccion='" & id_Seccion & "'")
        End If

        If ds.Tables(0).Rows.Count = 1 And ds.Tables(0).Rows(0).Item("Suma").ToString <> "" Then
            Return ds.Tables(0).Rows(0).Item("Suma").ToString
        Else
            Return 0
        End If
    End Function

    'Consulto si existen montos de un tipo de movimiento de un determinado rango de fechas.
    Function ConsultarTotalGastoMercaderia(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String) As Double
        Dim ds As New DataSet
        If HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_Movimientos_MercaderiaTotal @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_Movimientos_MercaderiaTotal @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        End If

        If ds.Tables(0).Rows.Count = 1 And ds.Tables(0).Rows(0).Item("Suma").ToString <> "" Then
            Return ds.Tables(0).Rows(0).Item("Suma").ToString
        Else
            Return 0
        End If
    End Function

    'Consulto si existen montos de un tipo de movimiento de un determinado rango de fechas.
    Function ConsultarTotalCajaFuerte(ByVal id_Sucursal As Integer) As Double
        Dim ds As New DataSet
        If HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_MovCajaFuerte_ObtenerSumaTotal @id_Sucursal=" & id_Sucursal)
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_MovCajaFuerte_ObtenerSumaTotal @id_Sucursal=" & id_Sucursal)
        End If

        If ds.Tables(0).Rows.Count = 1 And ds.Tables(0).Rows(0).Item("Total").ToString <> "" Then
            Return ds.Tables(0).Rows(0).Item("Total").ToString
        Else
            Return 0
        End If
    End Function

    'Obtiene el monto de un tipo de movimiento de un determinado dia.
    Function ObtenerMovimiento(ByVal id_Sucursal As Integer, ByVal Fecha As String, ByVal id_Seccion As Integer, ByVal id_Tipo As Integer) As Double
        Dim ds As New DataSet
        If HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_Movimientos_Obtener @id_Sucursal=" & id_Sucursal & ", @Fecha='" & Fecha & "', @id_Tipo='" & id_Tipo & "', @id_Seccion='" & id_Seccion & "'")
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_Movimientos_Obtener @id_Sucursal=" & id_Sucursal & ", @Fecha='" & Fecha & "', @id_Tipo='" & id_Tipo & "', @id_Seccion='" & id_Seccion & "'")
        End If

        If ds.Tables(0).Rows.Count = 1 And ds.Tables(0).Rows(0).Item("Suma").ToString <> "" Then
            Return ds.Tables(0).Rows(0).Item("Suma")
        Else
            Return 0
        End If
    End Function

    'Obtiene los tipos de movimientos dependiendo de la seccion enviada.
    Function ListadoTiposMov(ByVal id_Seccion As Integer) As DataSet
        If (HayInternet) Then
            Return clsDatos.ConsultarBaseRemoto("execute sp_Movimientos_ListadoTiposMov @id_Seccion = " & id_Seccion)
        Else
            Return clsDatos.ConsultarBaseLocal("execute sp_Movimientos_ListadoTiposMov @id_Seccion = " & id_Seccion)
        End If
    End Function

    'Obtiene los subtipos de movimientos dependiendo de la seccion y el tipo enviado.
    Function ListadoSubtiposMov(ByVal id_Tipo As Integer) As DataSet
        If (HayInternet) Then
            Return clsDatos.ConsultarBaseRemoto("execute sp_Movimientos_ListadoSubtiposMov @id_Tipo=" & id_Tipo)
        Else
            Return clsDatos.ConsultarBaseLocal("execute sp_Movimientos_ListadoSubtiposMov @id_Tipo=" & id_Tipo)
        End If
    End Function

    'Funcion para insertar un Impuesto.
    Function AltaMovImpuesto(ByVal eImpuesto As Entidades.MovImpuesto) As String
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim msg As String = ""

        Try
            'Conecto
            If (HayInternet) Then
                cmd.Connection = clsDatos.ConectarRemoto()
            Else
                cmd.Connection = clsDatos.ConectarLocal()
            End If

            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_MovImpuestos_Alta"
            With cmd.Parameters
                .AddWithValue("@id_Movimiento", eImpuesto.id_Movimiento)
                .AddWithValue("@id_Tipo", eImpuesto.id_Tipo)
                .AddWithValue("@id_Sucursal", eImpuesto.id_Sucursal)
                .AddWithValue("@Monto", eImpuesto.Monto)
                .AddWithValue("@Fecha", eImpuesto.Fecha)
            End With

            Dim respuesta As New SqlParameter("@msg", SqlDbType.VarChar, 255)
            respuesta.Direction = ParameterDirection.Output
            cmd.Parameters.Add(respuesta)
            cmd.ExecuteNonQuery()

            'Desconecto
            If (HayInternet) Then
                clsDatos.DesconectarRemoto()
            Else
                clsDatos.DesconectarLocal()
            End If

            'muestro el mensaje
            Return respuesta.Value
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    'Funcion para insertar una Dif. de Caja.
    Function AltaMovCaja(ByVal eCaja As Entidades.MovCaja) As String
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim msg As String = ""

        Try
            'Conecto
            If (HayInternet) Then
                cmd.Connection = clsDatos.ConectarRemoto()
            Else
                cmd.Connection = clsDatos.ConectarLocal()
            End If

            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_MovCaja_Alta"
            With cmd.Parameters
                .AddWithValue("@id_Movimiento", eCaja.id_Movimiento)
                .AddWithValue("@id_Usuario", eCaja.id_Usuario)
                .AddWithValue("@id_Tipo", eCaja.id_Tipo)
                .AddWithValue("@id_Sucursal", eCaja.id_Sucursal)
                .AddWithValue("@Monto", eCaja.Monto)
                .AddWithValue("@Descripcion", eCaja.Descripcion)
                .AddWithValue("@Fecha", eCaja.Fecha)
            End With

            Dim respuesta As New SqlParameter("@msg", SqlDbType.VarChar, 255)
            respuesta.Direction = ParameterDirection.Output
            cmd.Parameters.Add(respuesta)
            cmd.ExecuteNonQuery()

            'Desconecto
            If (HayInternet) Then
                clsDatos.DesconectarRemoto()
            Else
                clsDatos.DesconectarLocal()
            End If

            'muestro el mensaje
            Return respuesta.Value
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    'Funcion para insertar un mov de caja chica.
    Function AltaMovCajaFuerte(ByVal eCaja As Entidades.MovCajaFuerte) As String
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim msg As String = ""

        Try
            'Conecto
            If (HayInternet) Then
                cmd.Connection = clsDatos.ConectarRemoto()
            Else
                cmd.Connection = clsDatos.ConectarLocal()
            End If

            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_MovCajaFuerte_Alta"
            With cmd.Parameters
                .AddWithValue("@id_Movimiento", eCaja.id_Movimiento)
                .AddWithValue("@id_Tipo", eCaja.id_Tipo)
                .AddWithValue("@id_Sucursal", eCaja.id_Sucursal)
                .AddWithValue("@Monto", eCaja.Monto)
                .AddWithValue("@Descripcion", eCaja.Descripcion)
                .AddWithValue("@Fecha", eCaja.Fecha)
            End With

            Dim respuesta As New SqlParameter("@msg", SqlDbType.VarChar, 255)
            respuesta.Direction = ParameterDirection.Output
            cmd.Parameters.Add(respuesta)
            cmd.ExecuteNonQuery()

            'Desconecto
            If (HayInternet) Then
                clsDatos.DesconectarRemoto()
            Else
                clsDatos.DesconectarLocal()
            End If

            'muestro el mensaje
            Return respuesta.Value
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    'Funcion para insertar un retiro de socios.
    Function AltaMovRetiro(ByVal eRetiro As Entidades.MovSocios) As String
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim msg As String = ""

        Try
            'Conecto
            If (HayInternet) Then
                cmd.Connection = clsDatos.ConectarRemoto()
            Else
                cmd.Connection = clsDatos.ConectarLocal()
            End If

            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_MovRetiro_Alta"
            With cmd.Parameters
                .AddWithValue("@id_Movimiento", eRetiro.id_Movimiento)
                .AddWithValue("@id_Sucursal", eRetiro.id_Sucursal)
                .AddWithValue("@Monto", eRetiro.Monto)
                .AddWithValue("@Descripcion", eRetiro.Descripcion)
                .AddWithValue("@Encargado", eRetiro.Encargado)
                .AddWithValue("@Persona", eRetiro.Persona)
                .AddWithValue("@Fecha", eRetiro.Fecha)
            End With

            Dim respuesta As New SqlParameter("@msg", SqlDbType.VarChar, 255)
            respuesta.Direction = ParameterDirection.Output
            cmd.Parameters.Add(respuesta)
            cmd.ExecuteNonQuery()

            'Desconecto
            If (HayInternet) Then
                clsDatos.DesconectarRemoto()
            Else
                clsDatos.DesconectarLocal()
            End If

            'muestro el mensaje
            Return respuesta.Value
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    'Funcion para insertar un aporte de socios.
    Function AltaMovAporte(ByVal eRetiro As Entidades.MovSocios) As String
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim msg As String = ""

        Try
            'Conecto
            If (HayInternet) Then
                cmd.Connection = clsDatos.ConectarRemoto()
            Else
                cmd.Connection = clsDatos.ConectarLocal()
            End If

            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_MovAporte_Alta"
            With cmd.Parameters
                .AddWithValue("@id_Movimiento", eRetiro.id_Movimiento)
                .AddWithValue("@id_Sucursal", eRetiro.id_Sucursal)
                .AddWithValue("@Monto", eRetiro.Monto)
                .AddWithValue("@Descripcion", eRetiro.Descripcion)
                .AddWithValue("@Encargado", eRetiro.Encargado)
                .AddWithValue("@Persona", eRetiro.Persona)
                .AddWithValue("@Fecha", eRetiro.Fecha)
            End With

            Dim respuesta As New SqlParameter("@msg", SqlDbType.VarChar, 255)
            respuesta.Direction = ParameterDirection.Output
            cmd.Parameters.Add(respuesta)
            cmd.ExecuteNonQuery()

            'Desconecto
            If (HayInternet) Then
                clsDatos.DesconectarRemoto()
            Else
                clsDatos.DesconectarLocal()
            End If

            'muestro el mensaje
            Return respuesta.Value
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    'Funcion para insertar un Gasto.
    Function AltaMovGasto(ByVal eGasto As Entidades.MovGasto) As String
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim msg As String = ""

        Try
            'Conecto
            If (HayInternet) Then
                cmd.Connection = clsDatos.ConectarRemoto()
            Else
                cmd.Connection = clsDatos.ConectarLocal()
            End If

            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_MovGasto_Alta"
            With cmd.Parameters
                .AddWithValue("@id_Movimiento", eGasto.id_Movimiento)
                .AddWithValue("@id_Tipo", eGasto.id_Tipo)
                .AddWithValue("@id_Sucursal", eGasto.id_Sucursal)
                .AddWithValue("@id_Registro", eGasto.id_Registro)
                .AddWithValue("@Monto", eGasto.Monto)
                .AddWithValue("@Fecha", eGasto.Fecha)
            End With

            Dim respuesta As New SqlParameter("@msg", SqlDbType.VarChar, 255)
            respuesta.Direction = ParameterDirection.Output
            cmd.Parameters.Add(respuesta)
            cmd.ExecuteNonQuery()

            'Desconecto
            If (HayInternet) Then
                clsDatos.DesconectarRemoto()
            Else
                clsDatos.DesconectarLocal()
            End If

            'muestro el mensaje
            Return respuesta.Value
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    'Funcion para insertar un Egreso.
    Function AltaMovEgreso(ByVal eEgreso As Entidades.MovEgreso) As String
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim msg As String = ""

        Try
            'Conecto
            If (HayInternet) Then
                cmd.Connection = clsDatos.ConectarRemoto()
            Else
                cmd.Connection = clsDatos.ConectarLocal()
            End If

            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_MovEgreso_Alta"
            With cmd.Parameters
                .AddWithValue("@id_Movimiento", eEgreso.id_Movimiento)
                .AddWithValue("@id_MovimientoPadre", eEgreso.id_MovimientoPadre)
                .AddWithValue("@id_Tipo", eEgreso.id_Tipo)
                .AddWithValue("@id_Subtipo", eEgreso.id_Subtipo)
                .AddWithValue("@id_Sucursal", eEgreso.id_Sucursal)
                .AddWithValue("@id_SucursalDestino", eEgreso.id_SucursalDestino)
                .AddWithValue("@Monto", eEgreso.Monto)
                .AddWithValue("@Descripcion", eEgreso.Descripcion)
                .AddWithValue("@Aceptado", eEgreso.Aceptado)
                .AddWithValue("@Fecha", eEgreso.Fecha)
            End With

            Dim respuesta As New SqlParameter("@msg", SqlDbType.VarChar, 255)
            respuesta.Direction = ParameterDirection.Output
            cmd.Parameters.Add(respuesta)
            cmd.ExecuteNonQuery()

            'Desconecto
            If (HayInternet) Then
                clsDatos.DesconectarRemoto()
            Else
                clsDatos.DesconectarLocal()
            End If

            'muestro el mensaje
            Return respuesta.Value
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    'Obtener ID
    Function ObtenerID(ByVal Tabla As String)
        Dim ds As New DataSet
        If HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_Movimientos_ObtenerID @Tabla=" & Tabla)
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_Movimientos_ObtenerID @Tabla=" & Tabla)
        End If

        If ds.Tables(0).Rows.Count > 0 Then
            If ds.Tables(0).Rows(0).Item("ID").ToString <> "" Then
                Return ds.Tables(0).Rows(0).Item("ID").ToString
            Else
                Return 0
            End If
        Else
            Return 0
        End If
    End Function

    'Function para insertar una nueva mercaderia para el egreso "mercaderias"
    Function AltaMovEgresoMercaderia(ByVal eMerca As Entidades.MovEgresoMercaderia) As String
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim msg As String = ""

        Try
            'Conecto
            If (HayInternet) Then
                cmd.Connection = clsDatos.ConectarRemoto()
            Else
                cmd.Connection = clsDatos.ConectarLocal()
            End If

            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_MovEgreso_AltaMercaderia"
            With cmd.Parameters
                .AddWithValue("@id_Movimiento", eMerca.id_Movimiento)
                .AddWithValue("@id_Sucursal", eMerca.id_Sucursal)
                .AddWithValue("@id_Producto", eMerca.id_Producto)
                .AddWithValue("@Nombre", eMerca.Nombre)
                .AddWithValue("@Codigo", eMerca.Codigo)
                .AddWithValue("@Costo", eMerca.Costo)
                .AddWithValue("@Cantidad", eMerca.Cantidad)
                .AddWithValue("@Subtotal", eMerca.Subtotal)
            End With

            Dim respuesta As New SqlParameter("@msg", SqlDbType.VarChar, 255)
            respuesta.Direction = ParameterDirection.Output
            cmd.Parameters.Add(respuesta)
            cmd.ExecuteNonQuery()

            'Desconecto
            If (HayInternet) Then
                clsDatos.DesconectarRemoto()
            Else
                clsDatos.DesconectarLocal()
            End If

            'muestro el mensaje
            Return respuesta.Value
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    'Function para insertar una nueva mercaderia para el egreso "mercaderias"
    Function EliminarMovEgresoMercaderia(ByVal id_Movimiento As Integer, ByVal id_Sucursal As Integer)
        Dim cmd As New SqlCommand
        Try
            cmd.Connection = clsDatos.ConectarRemoto()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_MovEgreso_EliminarMercaderia"
            With cmd.Parameters
                .AddWithValue("@id_Movimiento", id_Movimiento)
                .AddWithValue("@id_Sucursal", id_Sucursal)
            End With
            Dim respuesta As New SqlParameter("@msg", SqlDbType.VarChar, 255)
            respuesta.Direction = ParameterDirection.Output
            cmd.Parameters.Add(respuesta)

            cmd.ExecuteNonQuery()
            clsDatos.DesconectarRemoto()

            Return respuesta.Value
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    'Function para eliminar un movimiento del sistema.
    Function EliminarMovimiento(ByVal id_Movimiento As Integer, ByVal id_Sucursal As Integer, ByVal Tipo As Integer, Optional ByVal id_Registro As Integer = 0)
        Try
            Dim EsMercaderia As Integer = 0

            'Si es un egreso.
            If Tipo = 2 Then

                'Averiguo que movimiento es.
                Dim DsMovimiento As New DataSet
                DsMovimiento = ObtenerMov(id_Movimiento, id_Sucursal, "Egreso")

                'Si es mercaderia, hago un rollback del stock
                If DsMovimiento.Tables(0).Rows(0).Item("id_Tipo").ToString = "19" Then

                    EsMercaderia = 1
                    Dim dsMercaderias As New DataSet
                    Dim NStock As New NegStock
                    Dim SucuOrigen As Integer = CInt(DsMovimiento.Tables(0).Rows(0).Item("id_Sucursal"))
                    Dim SucuDestino As Integer = CInt(DsMovimiento.Tables(0).Rows(0).Item("id_SucursalDestino"))

                    'Aumento el stock de la sucursal Origen.
                    dsMercaderias = ObtenerMovEgresoMercaderias(id_Movimiento, SucuOrigen)
                    If dsMercaderias IsNot Nothing Then
                        If dsMercaderias.Tables(0).Rows.Count > 0 Then
                            For Each prod In dsMercaderias.Tables(0).Rows
                                NStock.AgregarStock(prod.item("id_Producto"), SucuOrigen, prod.item("Cantidad"))
                            Next
                        End If
                    End If

                    'Disminuyo el stock de la sucursal destino.
                    If dsMercaderias IsNot Nothing Then
                        If dsMercaderias.Tables(0).Rows.Count > 0 Then
                            For Each prod In dsMercaderias.Tables(0).Rows
                                NStock.DisminuirStock(prod.item("id_Producto"), prod.item("Cantidad"), SucuDestino)
                            Next
                        End If
                    End If

                End If
            End If

            'Elimino el movimiento.
            Dim cmd As New SqlCommand
            cmd.Connection = clsDatos.ConectarRemoto()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_Movimientos_Eliminar"
            With cmd.Parameters
                .AddWithValue("@id_Movimiento", id_Movimiento)
                .AddWithValue("@id_Registro", id_Registro)
                .AddWithValue("@id_Sucursal", id_Sucursal)
                .AddWithValue("@EsMercaderia", EsMercaderia)
                .AddWithValue("@Tipo", Tipo)
            End With
            Dim respuesta As New SqlParameter("@msg", SqlDbType.VarChar, 255)
            respuesta.Direction = ParameterDirection.Output
            cmd.Parameters.Add(respuesta)

            cmd.ExecuteNonQuery()
            clsDatos.DesconectarRemoto()

            Return respuesta.Value
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    'Obtener un listado de Dif. de Caja.
    Function ObtenerMovCaja(ByVal id_Sucursal As Integer, ByVal Anio As Integer, ByVal Mes As Integer)
        Dim ds As New DataSet
        If HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_MovCaja_Obtener @id_Sucursal=" & id_Sucursal & ", @Anio=" & Anio & ", @Mes=" & Mes)
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_MovCaja_Obtener @id_Sucursal=" & id_Sucursal & ", @Anio=" & Anio & ", @Mes=" & Mes)
        End If
        Return ds
    End Function

    Function ObtenerDifCaja(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String)
        Dim ds As New DataSet
        If HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_MovDiferencia_Obtener @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_MovDiferencia_Obtener @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        End If
        Return ds
    End Function

    'Obtener un listado de Caja Fuerte.
    Function ObtenerMovCajaFuerte(ByVal id_Sucursal As Integer, ByVal Anio As Integer, ByVal Mes As Integer)
        Dim ds As New DataSet
        If HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_MovCajaFuerte_Obtener @id_Sucursal=" & id_Sucursal & ", @Anio=" & Anio & ", @Mes=" & Mes)
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_MovCajaFuerte_Obtener @id_Sucursal=" & id_Sucursal & ", @Anio=" & Anio & ", @Mes=" & Mes)
        End If
        Return ds
    End Function

    'Obtengo el monto total de un determinado rango de fechas.
    Function ObtenerTotalMovCaja(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String, ByVal Tipo As String) As Double
        Dim ds As New DataSet
        If HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_MovCaja_ObtenerTotal @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "', @Tipo='" & Tipo & "'")
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_MovCaja_ObtenerTotal @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "', @Tipo='" & Tipo & "'")
        End If

        If ds.Tables(0).Rows.Count = 1 And ds.Tables(0).Rows(0).Item("Suma").ToString <> "" Then
            Return ds.Tables(0).Rows(0).Item("Suma").ToString
        Else
            Return 0
        End If
    End Function

    'Obtengo el monto total de un determinado rango de fechas.
    Function ObtenerTotalMovCajaFuerte(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String, ByVal Tipo As Integer) As Double
        Dim ds As New DataSet
        If HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_MovCajaFuerte_ObtenerTotal @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "', @Tipo='" & Tipo & "'")
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_MovCajaFuerte_ObtenerTotal @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "', @Tipo='" & Tipo & "'")
        End If

        If ds.Tables(0).Rows.Count = 1 And ds.Tables(0).Rows(0).Item("Suma").ToString <> "" Then
            Return ds.Tables(0).Rows(0).Item("Suma").ToString
        Else
            Return 0
        End If
    End Function

    'Obtengo el monto total de un determinado rango de fechas.
    Function ObtenerTotalMovEgreso(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String, ByVal Tipo As String) As Double
        Dim ds As New DataSet
        If HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_MovEgreso_ObtenerTotal @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "', @Tipo='" & Tipo & "'")
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_MovEgreso_ObtenerTotal @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "', @Tipo='" & Tipo & "'")
        End If

        If ds.Tables(0).Rows.Count = 1 And ds.Tables(0).Rows(0).Item("Suma").ToString <> "" Then
            Return ds.Tables(0).Rows(0).Item("Suma").ToString
        Else
            Return 0
        End If
    End Function

    'Obtener un listado de Gastos.
    Function ObtenerMovGasto(ByVal id_Sucursal As Integer, ByVal Anio As Integer, ByVal Mes As Integer)
        Dim ds As New DataSet
        If HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_MovGasto_Obtener @id_Sucursal=" & id_Sucursal & ", @Anio=" & Anio & ", @Mes=" & Mes)
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_MovGasto_Obtener @id_Sucursal=" & id_Sucursal & ", @Anio=" & Anio & ", @Mes=" & Mes)
        End If
        Return ds
    End Function

    'Obtener un listado de Impuestos.
    Function ObtenerMovImpuesto(ByVal id_Sucursal As Integer, ByVal Anio As Integer, ByVal Mes As Integer)
        Dim ds As New DataSet
        If HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_MovImpuesto_Obtener @id_Sucursal=" & id_Sucursal & ", @Anio=" & Anio & ", @Mes=" & Mes)
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_MovImpuesto_Obtener @id_Sucursal=" & id_Sucursal & ", @Anio=" & Anio & ", @Mes=" & Mes)
        End If
        Return ds
    End Function

    'Obtener un listado de Impuestos.
    Function ObtenerMovImpuestoFecha(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String)
        Dim ds As New DataSet
        If HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_MovImpuesto_ObtenerPorFecha @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_MovImpuesto_ObtenerPorFecha @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        End If
        Return ds
    End Function

    'Obtener un listado de Gastos por rango de fechas.
    Function ObtenerMovGastoFecha(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String)
        Dim ds As New DataSet
        If HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_MovGasto_ObtenerPorFecha @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_MovGasto_ObtenerPorFecha @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        End If
        Return ds
    End Function

    'Obtener un listado de Retiros de socios por rango de fechas.
    Function ObtenerMovRetiroFecha(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String)
        Dim ds As New DataSet
        If HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_MovRetiro_ObtenerPorFecha @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_MovRetiro_ObtenerPorFecha @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        End If
        Return ds
    End Function

    'Obtener un listado de Retiros de socios por rango de fechas.
    Function ObtenerMovAporteFecha(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String)
        Dim ds As New DataSet
        If HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_MovAporte_ObtenerPorFecha @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_MovAporte_ObtenerPorFecha @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        End If
        Return ds
    End Function

    'Obtener un listado de diferencias de caja por rango de fechas.
    Function ObtenerMovCajaFecha(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String, ByVal Tipo As Integer)
        Dim ds As New DataSet
        If HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_MovCaja_ObtenerPorFecha @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'" & ", @Tipo=" & Tipo)
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_MovCaja_ObtenerPorFecha @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'" & ", @Tipo=" & Tipo)
        End If
        Return ds
    End Function

    'Obtener un listado de efectivos por rango de fechas.
    Function ObtenerMovEgresoFecha(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String, ByVal Tipo As String)
        Dim ds As New DataSet
        If HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_MovEgreso_ObtenerPorFecha @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'" & ", @Tipo=" & Tipo)
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_MovEgreso_ObtenerPorFecha @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'" & ", @Tipo=" & Tipo)
        End If
        Return ds
    End Function

    'Obtener un listado de Egresos.
    Function ObtenerMovEgreso(ByVal id_Sucursal As Integer, ByVal Anio As Integer, ByVal Mes As Integer)
        Dim ds As New DataSet
        If HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_MovEgreso_Obtener @id_Sucursal=" & id_Sucursal & ", @Anio=" & Anio & ", @Mes=" & Mes)
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_MovEgreso_Obtener @id_Sucursal=" & id_Sucursal & ", @Anio=" & Anio & ", @Mes=" & Mes)
        End If
        Return ds
    End Function

    'Obtener un listado de Egresos por sucursal.
    Function ObtenerMovEgresoPorSucursal(ByVal id_Sucursal As Integer)
        Dim ds As New DataSet
        If HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_MovEgreso_ObtenerPorSucursal @id_Sucursal=" & id_Sucursal)
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_MovEgreso_ObtenerPorSucursal @id_Sucursal=" & id_Sucursal)
        End If
        Return ds
    End Function

    'Obtener un listado de Egresos por sucursal destino.
    Function ObtenerMovEgresoPorSucursalDestino(ByVal id_Sucursal As Integer, ByVal id_SucursalDestino As Integer)
        Dim ds As New DataSet
        If HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_MovEgreso_ObtenerPorSucursalDestino @id_Sucursal=" & id_Sucursal & ", @id_SucursalDestino=" & id_SucursalDestino)
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_MovEgreso_ObtenerPorSucursalDestino @id_Sucursal=" & id_Sucursal & ",  @id_SucursalDestino=" & id_SucursalDestino)
        End If
        Return ds
    End Function

    'Obtener un listado de Retiro de Socio.
    Function ObtenerMovRetiro(ByVal id_Sucursal As Integer, ByVal Anio As Integer, ByVal Mes As Integer)
        Dim ds As New DataSet
        If HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_MovRetiro_Obtener @id_Sucursal=" & id_Sucursal & ", @Anio=" & Anio & ", @Mes=" & Mes)
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_MovRetiro_Obtener @id_Sucursal=" & id_Sucursal & ", @Anio=" & Anio & ", @Mes=" & Mes)
        End If
        Return ds
    End Function

    'Obtener un listado de Aporte de Socio.
    Function ObtenerMovAporte(ByVal id_Sucursal As Integer, ByVal Anio As Integer, ByVal Mes As Integer)
        Dim ds As New DataSet
        If HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_MovAporte_Obtener @id_Sucursal=" & id_Sucursal & ", @Anio=" & Anio & ", @Mes=" & Mes)
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_MovAporte_Obtener @id_Sucursal=" & id_Sucursal & ", @Anio=" & Anio & ", @Mes=" & Mes)
        End If
        Return ds
    End Function

    'Obtener un movimiento determinado.
    Function ObtenerMov(ByVal id_Movimiento As Integer, ByVal id_sucursal As Integer, ByVal Tipo As String)
        Dim ds As New DataSet
        If HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_Mov_ObtenerDetalle @id_Movimiento=" & id_Movimiento & ", @id_sucursal=" & id_sucursal & ", @Tipo=" & Tipo)
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_Mov_ObtenerDetalle @id_Movimiento=" & id_Movimiento & ", @id_sucursal=" & id_sucursal & ", @Tipo=" & Tipo)
        End If
        Return ds
    End Function

    Function ObtenerMovDestino(ByVal id_Movimiento As Integer, ByVal id_sucursal As Integer, ByVal Tipo As String)
        Dim ds As New DataSet
        If HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_Mov_ObtenerDestinoDetalle @id_Movimiento=" & id_Movimiento & ", @id_sucursal=" & id_sucursal & ", @Tipo=" & Tipo)
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_Mov_ObtenerDestinoDetalle @id_Movimiento=" & id_Movimiento & ", @id_sucursal=" & id_sucursal & ", @Tipo=" & Tipo)
        End If
        Return ds
    End Function


    'Obtener un movimiento determinado.
    Function ObtenerMovEgresoDetalle(ByVal id_Movimiento As Integer, ByVal id_sucursal As Integer, ByVal id_sucursalDestino As Integer)
        Dim ds As New DataSet
        If HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_MovEgreso_Detalle @id_Movimiento=" & id_Movimiento & ", @id_sucursal=" & id_sucursal & ", @id_sucursalDestino=" & id_sucursalDestino)
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_MovEgreso_Detalle @id_Movimiento=" & id_Movimiento & ", @id_sucursal=" & id_sucursal & ", @id_sucursalDestino=" & id_sucursalDestino)
        End If
        Return ds
    End Function

    'Obtiene los productos de un egreso tipo mercaderias.
    Function ObtenerMovEgresoMercaderias(ByVal id_Movimiento As Integer, ByVal id_sucursal As Integer)
        Dim ds As New DataSet
        If HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_MovEgreso_ObtenerMercaderia @id_Movimiento=" & id_Movimiento & ", @id_sucursal=" & id_sucursal)
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_MovEgreso_ObtenerMercaderia @id_Movimiento=" & id_Movimiento & ", @id_sucursal=" & id_sucursal)
        End If
        Return ds
    End Function

    'Obtener notificaciones.
    Function ObtenerNotificaciones(ByVal id_Sucursal As Integer)
        Dim ds As New DataSet
        If HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_Movimientos_ObtenerNuevos @id_Sucursal=" & id_Sucursal)
            If ds.Tables(0).Rows.Count > 0 Then
                If ds.Tables(0).Rows(0).Item("Total").ToString <> "" Then
                    Return CInt(ds.Tables(0).Rows(0).Item("Total"))
                Else
                    Return 0
                End If
            Else
                Return 0
            End If
        Else
            Return 0
        End If
    End Function

    'Obtener listado de notificaciones.
    Function ObtenerListadoNotificaciones(ByVal id_Sucursal As Integer)
        Dim ds As New DataSet
        If HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_Movimientos_ObtenerListadoNuevos @id_Sucursal=" & id_Sucursal)
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_Movimientos_ObtenerListadoNuevos @id_Sucursal=" & id_Sucursal)
        End If
        Return ds
    End Function

    'Acepta un movimiento determinado.
    Function AceptarMovimiento(ByVal id_Movimiento As Integer, ByVal id_Tipo As Integer, ByVal id_Sucursal As Integer, ByVal id_SucursalConect As Integer)
        Dim cmd As New SqlCommand
        Try
            'Conecto a la bdd.
            If HayInternet Then
                cmd.Connection = clsDatos.ConectarRemoto()
            Else
                cmd.Connection = clsDatos.ConectarLocal()
            End If

            'Cargo y ejecuto el stored.
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_Movimientos_AceptarNuevo"
            With cmd.Parameters
                .AddWithValue("@id_Movimiento", id_Movimiento)
                .AddWithValue("@id_Sucursal", id_SucursalConect)
            End With

            'Respuesta del stored.
            Dim respuesta As New SqlParameter("@msg", SqlDbType.Bit, 1)
            respuesta.Direction = ParameterDirection.Output
            cmd.Parameters.Add(respuesta)
            cmd.ExecuteNonQuery()

            'Desconecto la bdd.
            If HayInternet Then
                clsDatos.DesconectarRemoto()
            Else
                clsDatos.DesconectarLocal()
            End If

            'Si es mercadería la que envio manejo los stocks
            If id_Tipo = 19 Then
                'Instancias.
                Dim NStock As New NegStock
                Dim dsMercaderias As New DataSet

                'Disminuyo el stock de la sucursal.
                dsMercaderias = ObtenerMovEgresoMercaderias(id_Movimiento, id_Sucursal)
                'If dsMercaderias IsNot Nothing Then
                '    If dsMercaderias.Tables(0).Rows.Count > 0 Then
                '        For Each prod In dsMercaderias.Tables(0).Rows
                '            NStock.DisminuirStock(prod.item("id_Producto"), prod.item("Cantidad"), prod.item("id_Sucursal"))
                '        Next
                '    End If
                'End If

                'Aumento el stock de la sucursal Destino.
                If dsMercaderias IsNot Nothing Then
                    If dsMercaderias.Tables(0).Rows.Count > 0 Then
                        For Each prod In dsMercaderias.Tables(0).Rows
                            NStock.AgregarStock(prod.item("id_Producto"), id_SucursalConect, prod.item("Cantidad"))
                        Next
                    End If
                End If
            End If

            Return respuesta.Value
        Catch ex As Exception
            Return False
        End Try
    End Function

    'Rechaza un movimiento determinado.
    Function RechazarMovimiento(ByVal id_Movimiento As Integer, ByVal id_Tipo As Integer, ByVal id_Sucursal As Integer, ByVal id_SucursalConect As Integer)
        Dim cmd As New SqlCommand
        Try
            'Conecto a la bdd.
            If HayInternet Then
                cmd.Connection = clsDatos.ConectarRemoto()
            Else
                cmd.Connection = clsDatos.ConectarLocal()
            End If

            'Cargo y ejecuto el stored.
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_Movimientos_RechazarNuevo"
            With cmd.Parameters
                .AddWithValue("@id_Movimiento", id_Movimiento)
                .AddWithValue("@id_Sucursal", id_Sucursal)
                .AddWithValue("@id_SucursalDestino", id_SucursalConect)
            End With

            'Respuesta del stored.
            Dim respuesta As New SqlParameter("@msg", SqlDbType.Bit, 1)
            respuesta.Direction = ParameterDirection.Output
            cmd.Parameters.Add(respuesta)
            cmd.ExecuteNonQuery()

            'Desconecto la bdd.
            If HayInternet Then
                clsDatos.DesconectarRemoto()
            Else
                clsDatos.DesconectarLocal()
            End If

            'Si es mercadería la que envio manejo los stocks
            If id_Tipo = 19 Then
                'Instancias.
                Dim NStock As New NegStock
                Dim dsMercaderias As New DataSet

                'Aumento el stock de la sucursal Origen.
                dsMercaderias = ObtenerMovEgresoMercaderias(id_Movimiento, id_Sucursal)
                If dsMercaderias IsNot Nothing Then
                    If dsMercaderias.Tables(0).Rows.Count > 0 Then
                        For Each prod In dsMercaderias.Tables(0).Rows
                            NStock.AgregarStock(prod.item("id_Producto"), prod.item("id_Sucursal"), prod.item("Cantidad"))
                        Next
                    End If
                End If
            End If

            Return respuesta.Value
        Catch ex As Exception
            Return False
        End Try
    End Function

End Class