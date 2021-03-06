﻿Public Class frmStockFaltante

    Dim NegStock As New Negocio.NegStock
    Dim NegErrores As New Negocio.NegManejadorErrores
    Dim eStock As Entidades.Stock
    Public idProducto As Integer
    Public codigoProducto As String
    Public idSucursal As Integer
    Public stockCargado As Integer

    Sub New(ByVal idProducto As Integer, ByVal codigoProducto As String, ByVal idSucursal As Integer, ByVal stockCargado As Integer)

        InitializeComponent()

        Me.idProducto = idProducto
        Me.codigoProducto = codigoProducto
        Me.idSucursal = idSucursal
        Me.stockCargado = stockCargado
    End Sub

    Private Sub frmStockFaltante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        eStock = NegStock.TraerStockProducto(idProducto, idSucursal)
        lblMensaje.Text = String.Format(lblMensaje.Text, codigoProducto, eStock.Stock_Actual)
        txtStock.Text = stockCargado
        Me.ActiveControl = txtStock
    End Sub


    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        If Integer.Parse(txtStock.Text) <> 0 Then
            DialogResult = Windows.Forms.DialogResult.OK
            stockCargado = Integer.Parse(txtStock.Text)
        Else
            DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    'Valido que sea solo numeros.
    Private Sub txtStock_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStock.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
End Class