﻿Imports System.Configuration
Imports Negocio

Public Class frmConfiguracion
    Dim NSucursales As New Negocio.NegSucursales
    Dim NListas As New Negocio.NegListasPrecio
    Dim NegErrores As New Negocio.NegManejadorErrores

    'Load del formulario.
    Private Sub frmConfiguracion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Cambio el cursor a "WAIT"
        Me.Cursor = Cursors.WaitCursor

        'Sucursal Cargada en el app.config.
        lbl_NombreSucursalActual.Text = My.Settings("NombreSucursal")

        'Lista de Precios cargada en el app.config.
        lbl_NombreListaActual.Text = My.Settings("NombreListaPrecio")

        'Periodo de tiempo para la actualizacion de la memoria Cache
        Cb_TiempoActualizacionMemoriaChace.SelectedItem = My.Settings.TemporizadorActualizacionMemoriaCache.ToString()

        If My.Settings.UsarMemoriaCache Then
            RUsoMemoriaChaceSi.Checked = True
        Else
            RUsoMemoriaChaceNo.Checked = True
        End If

        'Cargo el listado de sucursales.
        If (NSucursales.ListadoSucursales().Tables.Count <> 0) Then
            Cb_Sucursales.DataSource = NSucursales.ListadoSucursales().Tables(0)
            Cb_Sucursales.DisplayMember = "Nombre"
            Cb_Sucursales.ValueMember = "id_Sucursal"
            Cb_Sucursales.SelectedValue = My.Settings("Sucursal")
            Cb_Sucursales.Refresh()
        End If

        If (Not Negocio.Funciones.HayInternet) Then
            Cb_Sucursales.Enabled = False
        End If

        'Cargo el listado de Precios.
        If (NListas.ListadoGrupoPrecios().Tables.Count <> 0) Then
            cb_Precios.DataSource = NListas.ListadoGrupoPrecios().Tables(0)
            cb_Precios.DisplayMember = "ListaPrecio"
            cb_Precios.ValueMember = "id_Lista"
            cb_Precios.SelectedValue = My.Settings("ListaPrecio")
            cb_Precios.Refresh()
        End If

        txt_descuentoMinorista.Text = My.Settings("DescuentoMinorista")

        'Cargo los valores de Mailing.
        txtPort.Text = My.Settings("MailPort")
        txtSmtp.Text = My.Settings("MailHost")
        txtUsuario.Text = My.Settings("MailUsuario")
        txtPassword.Text = My.Settings("MailPassword")

        'Cargo los valores del Controlador.
        If My.Settings("ControladorStatus") = "SI" Then
            RContrSI.Checked = True
        Else
            RContrNO.Checked = True
        End If

        If My.Settings("HabilitarExentoSinIVA") = "SI" Then
            RExentoSinIvaSI.Checked = True
        Else
            RExentoSinIvaNo.Checked = True
        End If

        Cb_ConexionControladora.SelectedItem = My.Settings("ConexionControladora").ToString()
        txt_MontoTopeTicket.Text = My.Settings.MontoTopeFaturacionTicket
        txt_MontoTopeManual.Text = My.Settings.MontoTopeFacturacionManual
        txt_MontoTopeElectronico.Text = My.Settings.MontoTopeFacturacionElectronica

        txt_MontoMaximoNotaCredito.Text = My.Settings("MontoMaximoNotaCredito")

        txt_PuntoVentaElectronica.Text = My.Settings.PuntoVentaFacturacionElectronica
        txt_PuntoVentaControladora.Text = My.Settings.PuntoVentaFacturacionTicket
        txt_PuntoVentaManual.Text = My.Settings.PuntoVentaFacturacionManual

        'Comprobacion de notificaciones.
        Cb_TiempoComprobacionMensajes.SelectedItem = CStr(CInt((My.Settings("TemporizadorMensajes") / 60000)))
        Cb_TiempoComprobacionMovimientos.SelectedItem = CStr(CInt((My.Settings("TemporizadorMovimientos") / 60000)))
        Cb_TiempoComprobacionCheques.SelectedItem = CStr(CInt((My.Settings("TemporizadorCheques") / 60000)))
        Cb_TiempoComprobacionNotasPedidos.SelectedItem = CStr(CInt((My.Settings("TemporizadorNotasPedido") / 60000)))


        'Comprobacion de internet.
        Cb_SegundosInternet.SelectedItem = CStr(CInt((My.Settings("TemporizadorInternet") / 1000)))
        If My.Settings("Internet") Then
            Rb1.Checked = True
        Else
            Rb2.Checked = False
        End If

        'cargo los valoes del tab Host
        txtIPHost.Text = My.Settings.IpHost
        txtPuertoHost.Text = My.Settings.PuertoHost

        EvaluarPermisos()

        'Cambio el cursor a NORMAL.
        Me.Cursor = Cursors.Arrow
    End Sub

    'Actualizo la sucursal.
    Private Sub Btn_Actualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Actualizar.Click
        'Cambio el cursor a "WAIT"
        Me.Cursor = Cursors.WaitCursor

        Try
            If Cb_Sucursales.SelectedValue <> 0 Then

                My.Settings.Sucursal = Cb_Sucursales.SelectedValue
                My.Settings.NombreSucursal = Cb_Sucursales.SelectedItem("Nombre").ToString
                My.Settings.TemporizadorActualizacionMemoriaCache = Cb_TiempoActualizacionMemoriaChace.SelectedItem
                My.Settings.UsarMemoriaCache = If(RUsoMemoriaChaceSi.Checked, True, False)
                My.Settings.Save()
                MessageBox.Show("Los cambios se han realizado correctamente." & vbCrLf & "Reinicie la aplicación para que surjan efecto.", "Configuración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Debe seleccionar una sucursal.", "Configuración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "Configuración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'Cambio el cursor a NORMAL.
        Me.Cursor = Cursors.Arrow
    End Sub

    'Actualizo el listado de precios
    Private Sub Btn_Precios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Precios.Click
        'Cambio el cursor a "WAIT"
        Me.Cursor = Cursors.WaitCursor

        Try
            If cb_Precios.SelectedValue <> 0 And Not String.IsNullOrEmpty(txt_descuentoMinorista.Text) Then
                My.Settings.ListaPrecio = cb_Precios.SelectedValue
                My.Settings.NombreListaPrecio = cb_Precios.SelectedItem("ListaPrecio").ToString
                My.Settings.DescuentoMinorista = txt_descuentoMinorista.Text
                My.Settings.Save()
                MessageBox.Show("Los cambios se han realizado correctamente." & vbCrLf & "Reinicie la aplicación para que surjan efecto.", "Configuración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Debe completar todos los campos.", "Configuración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "Configuración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'Cambio el cursor a NORMAL.
        Me.Cursor = Cursors.Arrow
    End Sub

    'Actualizo los datos de mailing.
    Private Sub BtnMailing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMailing.Click
        'Cambio el cursor a "WAIT"
        Me.Cursor = Cursors.WaitCursor

        Try
            If txtPort.Text <> "" And txtSmtp.Text <> "" And txtUsuario.Text <> "" And txtPassword.Text <> "" Then
                My.Settings.MailPort = Trim(txtPort.Text)
                My.Settings.MailHost = Trim(txtSmtp.Text)
                My.Settings.MailUsuario = Trim(txtUsuario.Text)
                My.Settings.MailPassword = Trim(txtPassword.Text)
                My.Settings.Save()
                MessageBox.Show("Los cambios se han realizado correctamente." & vbCrLf & "Reinicie la aplicación para que surjan efecto.", "Configuración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Debe completar todos los campos.", "Configuración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "Configuración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'Cambio el cursor a NORMAL.
        Me.Cursor = Cursors.Arrow
    End Sub

    'Actualizo los datos del controlador.
    Private Sub Btn_Controlador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Controlador.Click
        'Cambio el cursor a "WAIT"
        Me.Cursor = Cursors.WaitCursor

        Try
            If (RContrSI.Checked Or RContrNO.Checked) And (txt_MontoTopeTicket.Text <> "" And txt_MontoTopeManual.Text <> "" And txt_PuntoVentaElectronica.Text <> "" And txt_PuntoVentaControladora.Text <> "" And txt_PuntoVentaElectronica.Text <> "" And txt_PuntoVentaManual.Text <> "") Then
                If RContrSI.Checked Then
                    My.Settings.ControladorStatus = "SI"
                Else
                    My.Settings.ControladorStatus = "NO"
                End If
                If RExentoSinIvaSI.Checked Then
                    My.Settings.HabilitarExentoSinIVA = "SI"
                Else
                    My.Settings.HabilitarExentoSinIVA = "NO"
                End If
                My.Settings.ConexionControladora = Cb_ConexionControladora.SelectedItem
                My.Settings.MontoTopeFaturacionTicket = Trim(txt_MontoTopeTicket.Text)
                My.Settings.MontoTopeFacturacionManual = Trim(txt_MontoTopeManual.Text)
                My.Settings.MontoTopeFacturacionElectronica = Trim(txt_MontoTopeElectronico.Text)
                My.Settings.MontoMaximoNotaCredito = Trim(txt_MontoMaximoNotaCredito.Text)
                My.Settings.PuntoVentaFacturacionElectronica = Integer.Parse(Trim(txt_PuntoVentaElectronica.Text))
                My.Settings.PuntoVentaFacturacionTicket = Integer.Parse(Trim(txt_PuntoVentaControladora.Text))
                My.Settings.PuntoVentaFacturacionManual = Integer.Parse(Trim(txt_PuntoVentaManual.Text))
                My.Settings.Save()
                MessageBox.Show("Los cambios se han realizado correctamente." & vbCrLf & "Reinicie la aplicación para que surjan efecto.", "Configuración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Debe completar todos los campos.", "Configuración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "Configuración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'Cambio el cursor a NORMAL.
        Me.Cursor = Cursors.Arrow
    End Sub



    'Actualizo el periodo de comprobacion de notificaciones
    Private Sub BtnNotificaciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNotificaciones.Click
        'Cambio el cursor a "WAIT"
        Me.Cursor = Cursors.WaitCursor

        Try
            If Cb_TiempoComprobacionMensajes.SelectedItem IsNot Nothing AndAlso Cb_TiempoComprobacionMovimientos.SelectedItem IsNot Nothing AndAlso Cb_TiempoComprobacionCheques.SelectedItem IsNot Nothing Then
                My.Settings.TemporizadorMensajes = (Cb_TiempoComprobacionMensajes.SelectedItem * 60000)
                My.Settings.TemporizadorMovimientos = (Cb_TiempoComprobacionMovimientos.SelectedItem * 60000)
                My.Settings.TemporizadorCheques = (Cb_TiempoComprobacionCheques.SelectedItem * 60000)
                My.Settings.TemporizadorNotasPedido = (Cb_TiempoComprobacionNotasPedidos.SelectedItem * 60000)

                My.Settings.Save()
                MessageBox.Show("Los cambios se han realizado correctamente." & vbCrLf & "Reinicie la aplicación para que surjan efecto.", "Configuración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Debe seleccionar una opción.", "Configuración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "Configuración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'Cambio el cursor a NORMAL.
        Me.Cursor = Cursors.Arrow
    End Sub

    'Actualizo el periodo de comprobacion de internet
    Private Sub BtnInternet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInternet.Click
        'Cambio el cursor a "WAIT"
        Me.Cursor = Cursors.WaitCursor

        Try
            If (Rb1.Checked Or Rb2.Checked) And Cb_SegundosInternet.SelectedItem IsNot Nothing Then
                If Rb1.Checked Then
                    My.Settings.Internet = True
                Else
                    My.Settings.Internet = False
                End If
                My.Settings.TemporizadorInternet = (Cb_SegundosInternet.SelectedItem * 1000)
                My.Settings.Save()
                MessageBox.Show("Los cambios se han realizado correctamente." & vbCrLf & "Reinicie la aplicación para que surjan efecto.", "Configuración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Debe seleccionar una opción.", "Configuración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "Configuración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'Cambio el cursor a NORMAL.
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub Rb1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Rb1.CheckedChanged
        If Rb1.Checked = True Then
            Rb2.Checked = False
        Else
            Rb2.Checked = True
        End If
    End Sub

    Private Sub Rb2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Rb2.CheckedChanged
        If Rb2.Checked = True Then
            Rb1.Checked = False
        Else
            Rb1.Checked = True
        End If
    End Sub

    Private Sub txt_PuntoVentaControladora_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_PuntoVentaControladora.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_PuntoVentaManual_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_PuntoVentaManual.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_PuntoVentaElectronica_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_PuntoVentaElectronica.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnModificarHost_Click(sender As Object, e As EventArgs) Handles btnModificarHost.Click
        'Cambio el cursor a "WAIT"
        Me.Cursor = Cursors.WaitCursor

        Try
            If txtPuertoHost.Text <> "" And txtIPHost.Text <> "" Then
                My.Settings.IpHost = Trim(txtIPHost.Text)
                My.Settings.PuertoHost = Trim(txtPuertoHost.Text)
                My.Settings.Save()
                MessageBox.Show("Los cambios se han realizado correctamente." & vbCrLf & "Reinicie la aplicación para que surjan efecto.", "Configuración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Debe completar todos los campos.", "Configuración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "Configuración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'Cambio el cursor a NORMAL.
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub txtPuertoHost_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPuertoHost.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Sub EvaluarPermisos()
        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Sistema_Configuración_Sucursal_Visualizar)) Then

        Else
            TabControl1.TabPages.Remove(TabControl1.TabPages("TabSucursal"))
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Sistema_Configuración_Sucursal_Modificar)) Then
            Btn_Actualizar.Enabled = True
        Else
            Btn_Actualizar.Enabled = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Sistema_Configuración_Precio_Visualizar)) Then

        Else
            TabControl1.TabPages.Remove(TabControl1.TabPages("TabPrecios"))
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Sistema_Configuración_Precio_Modificar)) Then
            Btn_Precios.Enabled = True
        Else
            Btn_Precios.Enabled = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Sistema_Configuración_Mail_Visualizar)) Then

        Else
            TabControl1.TabPages.Remove(TabControl1.TabPages("TabMail"))
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Sistema_Configuración_Mail_Modificar)) Then
            BtnMailing.Enabled = True
        Else
            BtnMailing.Enabled = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Sistema_Configuración_Facturación_Visualizar)) Then

        Else
            TabControl1.TabPages.Remove(TabControl1.TabPages("TabFacturacion"))
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Sistema_Configuración_Facturación_Modificar)) Then
            Btn_Controlador.Enabled = True
        Else
            Btn_Controlador.Enabled = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Sistema_Configuración_Alertas_Visualizar)) Then

        Else
            TabControl1.TabPages.Remove(TabControl1.TabPages("TabNotificaciones"))
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Sistema_Configuración_Alertas_Modificar)) Then
            BtnNotificaciones.Enabled = True
        Else
            BtnNotificaciones.Enabled = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Sistema_Configuración_Internet_Visualizar)) Then

        Else
            TabControl1.TabPages.Remove(TabControl1.TabPages("TabInternet"))
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Sistema_Configuración_Internet_Modificar)) Then
            BtnInternet.Enabled = True
        Else
            BtnInternet.Enabled = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Sistema_Configuración_Host_Visualizar)) Then

        Else
            TabControl1.TabPages.Remove(TabControl1.TabPages("Host"))
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Sistema_Configuración_Host_Modificar)) Then
            btnModificarHost.Enabled = True
        Else
            btnModificarHost.Enabled = False
        End If
    End Sub

    Private Sub btn_ActualizarListaProductos_Click(sender As Object, e As EventArgs) Handles btn_ActualizarListaProductos.Click
        Me.Cursor = Cursors.WaitCursor
        Dim negTipoPago As NegTipoPago = New NegTipoPago()
        negTipoPago.ListadoTiposPagosCache(False)

        NegTarjeta.TraerTarjetasCache(False)

        Dim negProductos As NegProductos = New NegProductos()
        negProductos.ListadoProductosCache(False)

        Dim negListasPrecio As NegListasPrecio = New NegListasPrecio()
        negListasPrecio.ListadoPreciosPorGrupoCache(My.Settings("ListaPrecio"), False)
        MessageBox.Show("La memoria cache se ha actualizado correctamente.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub RUsoMemoriaChaceNo_CheckedChanged(sender As Object, e As EventArgs) Handles RUsoMemoriaChaceNo.CheckedChanged
        Cb_TiempoActualizacionMemoriaChace.Enabled = False
        btn_ActualizarListaProductos.Enabled = False
    End Sub

    Private Sub RUsoMemoriaChaceSi_CheckedChanged(sender As Object, e As EventArgs) Handles RUsoMemoriaChaceSi.CheckedChanged
        Cb_TiempoActualizacionMemoriaChace.Enabled = True
        btn_ActualizarListaProductos.Enabled = True
    End Sub
End Class