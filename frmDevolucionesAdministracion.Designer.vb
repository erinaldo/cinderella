﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDevolucionesAdministracion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDevolucionesAdministracion))
        Me.TabVentas = New System.Windows.Forms.TabControl()
        Me.TbListado = New System.Windows.Forms.TabPage()
        Me.lbl_Msg = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_Restablecer = New System.Windows.Forms.Button()
        Me.BtnFiltrar = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.FHasta = New System.Windows.Forms.DateTimePicker()
        Me.FDesde = New System.Windows.Forms.DateTimePicker()
        Me.DG_Devolucion = New System.Windows.Forms.DataGridView()
        Me.TbDetalle = New System.Windows.Forms.TabPage()
        Me.lblcontenedor = New System.Windows.Forms.GroupBox()
        Me.lblEncargado = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblDescuento = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.BtnNotaCredito = New System.Windows.Forms.Button()
        Me.lblAnulado = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblNotaCredito = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.lblMonto = New System.Windows.Forms.Label()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.lblPago = New System.Windows.Forms.Label()
        Me.lblVenta = New System.Windows.Forms.Label()
        Me.lblVendedor = New System.Windows.Forms.Label()
        Me.lblSucursal = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.Gb_Anulado = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDescripcionAnular = New System.Windows.Forms.TextBox()
        Me.BtnAnular = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DG_Productos = New System.Windows.Forms.DataGridView()
        Me.NUMERO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODIGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANTIDAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRECIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SUBTOTAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.id_Devolucion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Empleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Anulado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoNotaCredito = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.NumeroNotaCredito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnEmitirFactura = New System.Windows.Forms.Button()
        Me.TabVentas.SuspendLayout()
        Me.TbListado.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DG_Devolucion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TbDetalle.SuspendLayout()
        Me.lblcontenedor.SuspendLayout()
        Me.Gb_Anulado.SuspendLayout()
        CType(Me.DG_Productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabVentas
        '
        Me.TabVentas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabVentas.Controls.Add(Me.TbListado)
        Me.TabVentas.Controls.Add(Me.TbDetalle)
        Me.TabVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabVentas.Location = New System.Drawing.Point(8, 8)
        Me.TabVentas.Name = "TabVentas"
        Me.TabVentas.SelectedIndex = 0
        Me.TabVentas.Size = New System.Drawing.Size(806, 557)
        Me.TabVentas.TabIndex = 3
        '
        'TbListado
        '
        Me.TbListado.Controls.Add(Me.lbl_Msg)
        Me.TbListado.Controls.Add(Me.GroupBox1)
        Me.TbListado.Controls.Add(Me.DG_Devolucion)
        Me.TbListado.Location = New System.Drawing.Point(4, 29)
        Me.TbListado.Name = "TbListado"
        Me.TbListado.Padding = New System.Windows.Forms.Padding(3)
        Me.TbListado.Size = New System.Drawing.Size(798, 524)
        Me.TbListado.TabIndex = 0
        Me.TbListado.Text = "Devoluciones"
        Me.TbListado.UseVisualStyleBackColor = True
        '
        'lbl_Msg
        '
        Me.lbl_Msg.AutoSize = True
        Me.lbl_Msg.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lbl_Msg.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Msg.Location = New System.Drawing.Point(44, 290)
        Me.lbl_Msg.Name = "lbl_Msg"
        Me.lbl_Msg.Size = New System.Drawing.Size(710, 25)
        Me.lbl_Msg.TabIndex = 2
        Me.lbl_Msg.Text = "No se han encontrado ventas en el rango de fechas seleccionado."
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btn_Restablecer)
        Me.GroupBox1.Controls.Add(Me.BtnFiltrar)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.FHasta)
        Me.GroupBox1.Controls.Add(Me.FDesde)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(10, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(782, 93)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtrar ventas por fecha."
        '
        'btn_Restablecer
        '
        Me.btn_Restablecer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Restablecer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Restablecer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Restablecer.Location = New System.Drawing.Point(570, 29)
        Me.btn_Restablecer.Name = "btn_Restablecer"
        Me.btn_Restablecer.Size = New System.Drawing.Size(100, 40)
        Me.btn_Restablecer.TabIndex = 9
        Me.btn_Restablecer.Text = "Restablecer Busqueda"
        Me.btn_Restablecer.UseVisualStyleBackColor = True
        '
        'BtnFiltrar
        '
        Me.BtnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFiltrar.FlatAppearance.BorderSize = 0
        Me.BtnFiltrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFiltrar.Image = Global.SistemaCinderella.My.Resources.Recursos.IconoBuscar32
        Me.BtnFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnFiltrar.Location = New System.Drawing.Point(676, 29)
        Me.BtnFiltrar.Name = "BtnFiltrar"
        Me.BtnFiltrar.Size = New System.Drawing.Size(100, 40)
        Me.BtnFiltrar.TabIndex = 4
        Me.BtnFiltrar.Text = "Buscar"
        Me.BtnFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnFiltrar.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 29)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(99, 16)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Fecha desde"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 61)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 16)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Fecha hasta"
        '
        'FHasta
        '
        Me.FHasta.Location = New System.Drawing.Point(126, 56)
        Me.FHasta.Name = "FHasta"
        Me.FHasta.Size = New System.Drawing.Size(250, 21)
        Me.FHasta.TabIndex = 1
        '
        'FDesde
        '
        Me.FDesde.Location = New System.Drawing.Point(126, 24)
        Me.FDesde.Name = "FDesde"
        Me.FDesde.Size = New System.Drawing.Size(250, 21)
        Me.FDesde.TabIndex = 0
        '
        'DG_Devolucion
        '
        Me.DG_Devolucion.AllowUserToAddRows = False
        Me.DG_Devolucion.AllowUserToDeleteRows = False
        Me.DG_Devolucion.AllowUserToResizeColumns = False
        Me.DG_Devolucion.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DG_Devolucion.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_Devolucion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_Devolucion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_Devolucion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_Devolucion, Me.Empleado, Me.Cliente, Me.MontoTotal, Me.Anulado, Me.Fecha, Me.TipoNotaCredito, Me.NumeroNotaCredito})
        Me.DG_Devolucion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DG_Devolucion.Location = New System.Drawing.Point(10, 105)
        Me.DG_Devolucion.MultiSelect = False
        Me.DG_Devolucion.Name = "DG_Devolucion"
        Me.DG_Devolucion.ReadOnly = True
        Me.DG_Devolucion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DG_Devolucion.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DG_Devolucion.RowTemplate.Height = 30
        Me.DG_Devolucion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Devolucion.Size = New System.Drawing.Size(782, 402)
        Me.DG_Devolucion.TabIndex = 0
        '
        'TbDetalle
        '
        Me.TbDetalle.Controls.Add(Me.lblcontenedor)
        Me.TbDetalle.Location = New System.Drawing.Point(4, 29)
        Me.TbDetalle.Name = "TbDetalle"
        Me.TbDetalle.Size = New System.Drawing.Size(798, 524)
        Me.TbDetalle.TabIndex = 2
        Me.TbDetalle.Text = "Detalle de la Devolución"
        Me.TbDetalle.UseVisualStyleBackColor = True
        '
        'lblcontenedor
        '
        Me.lblcontenedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblcontenedor.Controls.Add(Me.BtnEmitirFactura)
        Me.lblcontenedor.Controls.Add(Me.lblEncargado)
        Me.lblcontenedor.Controls.Add(Me.Label16)
        Me.lblcontenedor.Controls.Add(Me.lblSubtotal)
        Me.lblcontenedor.Controls.Add(Me.Label15)
        Me.lblcontenedor.Controls.Add(Me.lblDescuento)
        Me.lblcontenedor.Controls.Add(Me.Label14)
        Me.lblcontenedor.Controls.Add(Me.BtnNotaCredito)
        Me.lblcontenedor.Controls.Add(Me.lblAnulado)
        Me.lblcontenedor.Controls.Add(Me.lblCliente)
        Me.lblcontenedor.Controls.Add(Me.Label10)
        Me.lblcontenedor.Controls.Add(Me.lblNotaCredito)
        Me.lblcontenedor.Controls.Add(Me.label8)
        Me.lblcontenedor.Controls.Add(Me.lblMonto)
        Me.lblcontenedor.Controls.Add(Me.lblCantidad)
        Me.lblcontenedor.Controls.Add(Me.lblPago)
        Me.lblcontenedor.Controls.Add(Me.lblVenta)
        Me.lblcontenedor.Controls.Add(Me.lblVendedor)
        Me.lblcontenedor.Controls.Add(Me.lblSucursal)
        Me.lblcontenedor.Controls.Add(Me.lblFecha)
        Me.lblcontenedor.Controls.Add(Me.Gb_Anulado)
        Me.lblcontenedor.Controls.Add(Me.Label7)
        Me.lblcontenedor.Controls.Add(Me.Label1)
        Me.lblcontenedor.Controls.Add(Me.DG_Productos)
        Me.lblcontenedor.Controls.Add(Me.Label6)
        Me.lblcontenedor.Controls.Add(Me.Label5)
        Me.lblcontenedor.Controls.Add(Me.Label4)
        Me.lblcontenedor.Controls.Add(Me.Label3)
        Me.lblcontenedor.Controls.Add(Me.Label2)
        Me.lblcontenedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcontenedor.Location = New System.Drawing.Point(10, 6)
        Me.lblcontenedor.Name = "lblcontenedor"
        Me.lblcontenedor.Size = New System.Drawing.Size(782, 512)
        Me.lblcontenedor.TabIndex = 0
        Me.lblcontenedor.TabStop = False
        Me.lblcontenedor.Text = "Información de la devolución realizada."
        '
        'lblEncargado
        '
        Me.lblEncargado.AutoSize = True
        Me.lblEncargado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEncargado.Location = New System.Drawing.Point(628, 63)
        Me.lblEncargado.Name = "lblEncargado"
        Me.lblEncargado.Size = New System.Drawing.Size(42, 15)
        Me.lblEncargado.TabIndex = 36
        Me.lblEncargado.Text = "- - - - - "
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(542, 63)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(84, 15)
        Me.Label16.TabIndex = 35
        Me.Label16.Text = "Encargado :"
        '
        'lblSubtotal
        '
        Me.lblSubtotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtotal.Location = New System.Drawing.Point(196, 441)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(42, 15)
        Me.lblSubtotal.TabIndex = 34
        Me.lblSubtotal.Text = "- - - - - "
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(6, 441)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(68, 15)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "Subtotal :"
        '
        'lblDescuento
        '
        Me.lblDescuento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDescuento.AutoSize = True
        Me.lblDescuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescuento.Location = New System.Drawing.Point(196, 417)
        Me.lblDescuento.Name = "lblDescuento"
        Me.lblDescuento.Size = New System.Drawing.Size(42, 15)
        Me.lblDescuento.TabIndex = 32
        Me.lblDescuento.Text = "- - - - - "
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(6, 417)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(83, 15)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "Descuento :"
        '
        'BtnNotaCredito
        '
        Me.BtnNotaCredito.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNotaCredito.FlatAppearance.BorderSize = 0
        Me.BtnNotaCredito.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNotaCredito.Image = Global.SistemaCinderella.My.Resources.Recursos.Detalle_Pequeno
        Me.BtnNotaCredito.Location = New System.Drawing.Point(244, 363)
        Me.BtnNotaCredito.Name = "BtnNotaCredito"
        Me.BtnNotaCredito.Size = New System.Drawing.Size(18, 18)
        Me.BtnNotaCredito.TabIndex = 30
        Me.BtnNotaCredito.Tag = "Ver Detalle"
        Me.BtnNotaCredito.UseVisualStyleBackColor = True
        '
        'lblAnulado
        '
        Me.lblAnulado.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblAnulado.AutoSize = True
        Me.lblAnulado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnulado.ForeColor = System.Drawing.Color.Red
        Me.lblAnulado.Location = New System.Drawing.Point(362, 405)
        Me.lblAnulado.Name = "lblAnulado"
        Me.lblAnulado.Size = New System.Drawing.Size(251, 24)
        Me.lblAnulado.TabIndex = 28
        Me.lblAnulado.Text = "DEVOLUCIÓN ANULADA."
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.Location = New System.Drawing.Point(628, 33)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(42, 15)
        Me.lblCliente.TabIndex = 27
        Me.lblCliente.Text = "- - - - - "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(542, 33)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 15)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Cliente :"
        '
        'lblNotaCredito
        '
        Me.lblNotaCredito.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblNotaCredito.AutoSize = True
        Me.lblNotaCredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotaCredito.Location = New System.Drawing.Point(196, 369)
        Me.lblNotaCredito.Name = "lblNotaCredito"
        Me.lblNotaCredito.Size = New System.Drawing.Size(42, 15)
        Me.lblNotaCredito.TabIndex = 25
        Me.lblNotaCredito.Text = "- - - - - "
        '
        'label8
        '
        Me.label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.Location = New System.Drawing.Point(6, 369)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(95, 15)
        Me.label8.TabIndex = 24
        Me.label8.Text = "Nota Crédito :"
        '
        'lblMonto
        '
        Me.lblMonto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblMonto.AutoSize = True
        Me.lblMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonto.Location = New System.Drawing.Point(196, 465)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(42, 15)
        Me.lblMonto.TabIndex = 23
        Me.lblMonto.Text = "- - - - - "
        '
        'lblCantidad
        '
        Me.lblCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.Location = New System.Drawing.Point(196, 393)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(42, 15)
        Me.lblCantidad.TabIndex = 22
        Me.lblCantidad.Text = "- - - - - "
        '
        'lblPago
        '
        Me.lblPago.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblPago.AutoSize = True
        Me.lblPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPago.Location = New System.Drawing.Point(196, 345)
        Me.lblPago.Name = "lblPago"
        Me.lblPago.Size = New System.Drawing.Size(42, 15)
        Me.lblPago.TabIndex = 21
        Me.lblPago.Text = "- - - - - "
        '
        'lblVenta
        '
        Me.lblVenta.AutoSize = True
        Me.lblVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVenta.Location = New System.Drawing.Point(365, 33)
        Me.lblVenta.Name = "lblVenta"
        Me.lblVenta.Size = New System.Drawing.Size(42, 15)
        Me.lblVenta.TabIndex = 20
        Me.lblVenta.Text = "- - - - - "
        '
        'lblVendedor
        '
        Me.lblVendedor.AutoSize = True
        Me.lblVendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVendedor.Location = New System.Drawing.Point(365, 63)
        Me.lblVendedor.Name = "lblVendedor"
        Me.lblVendedor.Size = New System.Drawing.Size(42, 15)
        Me.lblVendedor.TabIndex = 19
        Me.lblVendedor.Text = "- - - - - "
        '
        'lblSucursal
        '
        Me.lblSucursal.AutoSize = True
        Me.lblSucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSucursal.Location = New System.Drawing.Point(78, 33)
        Me.lblSucursal.Name = "lblSucursal"
        Me.lblSucursal.Size = New System.Drawing.Size(42, 15)
        Me.lblSucursal.TabIndex = 18
        Me.lblSucursal.Text = "- - - - - "
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(78, 63)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(42, 15)
        Me.lblFecha.TabIndex = 17
        Me.lblFecha.Text = "- - - - - "
        '
        'Gb_Anulado
        '
        Me.Gb_Anulado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gb_Anulado.Controls.Add(Me.Label9)
        Me.Gb_Anulado.Controls.Add(Me.txtDescripcionAnular)
        Me.Gb_Anulado.Controls.Add(Me.BtnAnular)
        Me.Gb_Anulado.Location = New System.Drawing.Point(514, 343)
        Me.Gb_Anulado.Name = "Gb_Anulado"
        Me.Gb_Anulado.Size = New System.Drawing.Size(262, 149)
        Me.Gb_Anulado.TabIndex = 16
        Me.Gb_Anulado.TabStop = False
        Me.Gb_Anulado.Text = "Anular Venta"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 15)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Motivo"
        '
        'txtDescripcionAnular
        '
        Me.txtDescripcionAnular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionAnular.Location = New System.Drawing.Point(55, 27)
        Me.txtDescripcionAnular.Multiline = True
        Me.txtDescripcionAnular.Name = "txtDescripcionAnular"
        Me.txtDescripcionAnular.Size = New System.Drawing.Size(194, 83)
        Me.txtDescripcionAnular.TabIndex = 15
        '
        'BtnAnular
        '
        Me.BtnAnular.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAnular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAnular.Image = Global.SistemaCinderella.My.Resources.Recursos.Desconectado
        Me.BtnAnular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAnular.Location = New System.Drawing.Point(171, 116)
        Me.BtnAnular.Name = "BtnAnular"
        Me.BtnAnular.Size = New System.Drawing.Size(78, 27)
        Me.BtnAnular.TabIndex = 14
        Me.BtnAnular.Text = "Anular"
        Me.BtnAnular.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAnular.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 465)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 15)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Monto total :"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 393)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 15)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Cant. de productos :"
        '
        'DG_Productos
        '
        Me.DG_Productos.AllowUserToAddRows = False
        Me.DG_Productos.AllowUserToDeleteRows = False
        Me.DG_Productos.AllowUserToResizeRows = False
        Me.DG_Productos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_Productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_Productos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DG_Productos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DG_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Productos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NUMERO, Me.CODIGO, Me.NOMBRE, Me.CANTIDAD, Me.PRECIO, Me.SUBTOTAL})
        Me.DG_Productos.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.DG_Productos.Location = New System.Drawing.Point(6, 93)
        Me.DG_Productos.MultiSelect = False
        Me.DG_Productos.Name = "DG_Productos"
        Me.DG_Productos.ReadOnly = True
        Me.DG_Productos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DG_Productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Productos.Size = New System.Drawing.Size(770, 232)
        Me.DG_Productos.TabIndex = 11
        '
        'NUMERO
        '
        Me.NUMERO.FillWeight = 68.49864!
        Me.NUMERO.HeaderText = "Número"
        Me.NUMERO.Name = "NUMERO"
        Me.NUMERO.ReadOnly = True
        '
        'CODIGO
        '
        Me.CODIGO.FillWeight = 107.5103!
        Me.CODIGO.HeaderText = "Código"
        Me.CODIGO.Name = "CODIGO"
        Me.CODIGO.ReadOnly = True
        '
        'NOMBRE
        '
        Me.NOMBRE.FillWeight = 177.4346!
        Me.NOMBRE.HeaderText = "Nombre"
        Me.NOMBRE.Name = "NOMBRE"
        Me.NOMBRE.ReadOnly = True
        '
        'CANTIDAD
        '
        Me.CANTIDAD.FillWeight = 73.49158!
        Me.CANTIDAD.HeaderText = "Cantidad"
        Me.CANTIDAD.Name = "CANTIDAD"
        Me.CANTIDAD.ReadOnly = True
        '
        'PRECIO
        '
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.PRECIO.DefaultCellStyle = DataGridViewCellStyle4
        Me.PRECIO.FillWeight = 81.69429!
        Me.PRECIO.HeaderText = "Precio"
        Me.PRECIO.Name = "PRECIO"
        Me.PRECIO.ReadOnly = True
        '
        'SUBTOTAL
        '
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.SUBTOTAL.DefaultCellStyle = DataGridViewCellStyle5
        Me.SUBTOTAL.FillWeight = 91.37056!
        Me.SUBTOTAL.HeaderText = "Subtotal"
        Me.SUBTOTAL.Name = "SUBTOTAL"
        Me.SUBTOTAL.ReadOnly = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Sucursal :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Fecha :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(262, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tipo de Venta :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(262, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Vendedor :"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 345)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tipo de Pago :"
        '
        'id_Devolucion
        '
        Me.id_Devolucion.DataPropertyName = "id_Devolucion"
        Me.id_Devolucion.FillWeight = 17.30346!
        Me.id_Devolucion.HeaderText = "ID"
        Me.id_Devolucion.MaxInputLength = 10
        Me.id_Devolucion.Name = "id_Devolucion"
        Me.id_Devolucion.ReadOnly = True
        '
        'Empleado
        '
        Me.Empleado.DataPropertyName = "Empleado"
        Me.Empleado.FillWeight = 162.2804!
        Me.Empleado.HeaderText = "Empleado"
        Me.Empleado.Name = "Empleado"
        Me.Empleado.ReadOnly = True
        '
        'Cliente
        '
        Me.Cliente.DataPropertyName = "Cliente"
        Me.Cliente.FillWeight = 128.2283!
        Me.Cliente.HeaderText = "Cliente"
        Me.Cliente.Name = "Cliente"
        Me.Cliente.ReadOnly = True
        '
        'MontoTotal
        '
        Me.MontoTotal.DataPropertyName = "MontoTotal"
        Me.MontoTotal.FillWeight = 141.8023!
        Me.MontoTotal.HeaderText = "Monto Total"
        Me.MontoTotal.Name = "MontoTotal"
        Me.MontoTotal.ReadOnly = True
        '
        'Anulado
        '
        Me.Anulado.DataPropertyName = "Anulado"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Anulado.DefaultCellStyle = DataGridViewCellStyle2
        Me.Anulado.FillWeight = 49.88074!
        Me.Anulado.HeaderText = "Anulado"
        Me.Anulado.MaxInputLength = 10
        Me.Anulado.Name = "Anulado"
        Me.Anulado.ReadOnly = True
        '
        'Fecha
        '
        Me.Fecha.DataPropertyName = "Fecha"
        Me.Fecha.FillWeight = 129.4388!
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        '
        'TipoNotaCredito
        '
        Me.TipoNotaCredito.DataPropertyName = "TipoRecibo"
        Me.TipoNotaCredito.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.TipoNotaCredito.HeaderText = "Nota Crédito"
        Me.TipoNotaCredito.Name = "TipoNotaCredito"
        Me.TipoNotaCredito.ReadOnly = True
        '
        'NumeroNotaCredito
        '
        Me.NumeroNotaCredito.DataPropertyName = "NumeroNotaCredito"
        Me.NumeroNotaCredito.HeaderText = "Numero"
        Me.NumeroNotaCredito.Name = "NumeroNotaCredito"
        Me.NumeroNotaCredito.ReadOnly = True
        '
        'BtnEmitirFactura
        '
        Me.BtnEmitirFactura.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEmitirFactura.FlatAppearance.BorderSize = 0
        Me.BtnEmitirFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEmitirFactura.Image = Global.SistemaCinderella.My.Resources.Recursos.TicketPequeño
        Me.BtnEmitirFactura.Location = New System.Drawing.Point(268, 363)
        Me.BtnEmitirFactura.Name = "BtnEmitirFactura"
        Me.BtnEmitirFactura.Size = New System.Drawing.Size(18, 18)
        Me.BtnEmitirFactura.TabIndex = 38
        Me.BtnEmitirFactura.Tag = "Ver Detalle"
        Me.BtnEmitirFactura.UseVisualStyleBackColor = True
        '
        'frmDevolucionesAdministracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(806, 557)
        Me.Controls.Add(Me.TabVentas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDevolucionesAdministracion"
        Me.Text = "Administración de Devoluciones"
        Me.TabVentas.ResumeLayout(False)
        Me.TbListado.ResumeLayout(False)
        Me.TbListado.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DG_Devolucion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TbDetalle.ResumeLayout(False)
        Me.lblcontenedor.ResumeLayout(False)
        Me.lblcontenedor.PerformLayout()
        Me.Gb_Anulado.ResumeLayout(False)
        Me.Gb_Anulado.PerformLayout()
        CType(Me.DG_Productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabVentas As System.Windows.Forms.TabControl
    Friend WithEvents TbListado As System.Windows.Forms.TabPage
    Friend WithEvents lbl_Msg As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Restablecer As System.Windows.Forms.Button
    Friend WithEvents BtnFiltrar As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents FHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents FDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents DG_Devolucion As System.Windows.Forms.DataGridView
    Friend WithEvents TbDetalle As System.Windows.Forms.TabPage
    Friend WithEvents lblcontenedor As System.Windows.Forms.GroupBox
    Friend WithEvents lblEncargado As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblSubtotal As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblDescuento As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents BtnNotaCredito As System.Windows.Forms.Button
    Friend WithEvents lblAnulado As System.Windows.Forms.Label
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblNotaCredito As System.Windows.Forms.Label
    Friend WithEvents label8 As System.Windows.Forms.Label
    Friend WithEvents lblMonto As System.Windows.Forms.Label
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents lblPago As System.Windows.Forms.Label
    Friend WithEvents lblVenta As System.Windows.Forms.Label
    Friend WithEvents lblVendedor As System.Windows.Forms.Label
    Friend WithEvents lblSucursal As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents Gb_Anulado As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcionAnular As System.Windows.Forms.TextBox
    Friend WithEvents BtnAnular As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DG_Productos As System.Windows.Forms.DataGridView
    Friend WithEvents NUMERO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CODIGO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CANTIDAD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRECIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SUBTOTAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents id_Devolucion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Empleado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontoTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Anulado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoNotaCredito As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents NumeroNotaCredito As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnEmitirFactura As System.Windows.Forms.Button
End Class
