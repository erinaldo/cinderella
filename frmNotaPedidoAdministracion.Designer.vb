﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNotaPedidoAdministracion
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNotaPedidoAdministracion))
        Me.dgvNotaPedidos = New System.Windows.Forms.DataGridView()
        Me.Numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdTipoVentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdTipoPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpleadoNombreyApellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Eliminar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.IMPRIMIR = New System.Windows.Forms.DataGridViewImageColumn()
        Me.PorcentajeFacturacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NotaPedidoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BtnFiltrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.chkSinSalida = New System.Windows.Forms.CheckBox()
        Me.chkDepositado = New System.Windows.Forms.CheckBox()
        Me.chkPasado = New System.Windows.Forms.CheckBox()
        Me.chkDevuelto = New System.Windows.Forms.CheckBox()
        Me.chkOtros = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ChkFiltroFecha = New System.Windows.Forms.CheckBox()
        Me.ChkCerradas = New System.Windows.Forms.CheckBox()
        Me.ChkAbiertas = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.dtFechaAltaHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtFechaAltaDesde = New System.Windows.Forms.DateTimePicker()
        Me.btn_Restablecer = New System.Windows.Forms.Button()
        Me.cmbVendedor = New System.Windows.Forms.ComboBox()
        Me.txtNombreCliente = New System.Windows.Forms.TextBox()
        Me.cmbTiposPago = New System.Windows.Forms.ComboBox()
        Me.cmbTipoVenta = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTotalSinIVA = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtValorPromedio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_Msg = New System.Windows.Forms.Label()
        CType(Me.dgvNotaPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NotaPedidoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvNotaPedidos
        '
        Me.dgvNotaPedidos.AllowUserToAddRows = False
        Me.dgvNotaPedidos.AllowUserToDeleteRows = False
        Me.dgvNotaPedidos.AllowUserToResizeColumns = False
        Me.dgvNotaPedidos.AllowUserToResizeRows = False
        Me.dgvNotaPedidos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvNotaPedidos.AutoGenerateColumns = False
        Me.dgvNotaPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvNotaPedidos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvNotaPedidos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvNotaPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNotaPedidos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Numero, Me.Estado, Me.IdTipoVentaDataGridViewTextBoxColumn, Me.IdTipoPagoDataGridViewTextBoxColumn, Me.EmpleadoNombreyApellidoDataGridViewTextBoxColumn, Me.PrecioTotalDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.NombreCliente, Me.Eliminar, Me.IMPRIMIR, Me.PorcentajeFacturacion})
        Me.dgvNotaPedidos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvNotaPedidos.DataSource = Me.NotaPedidoBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvNotaPedidos.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvNotaPedidos.Location = New System.Drawing.Point(12, 149)
        Me.dgvNotaPedidos.MultiSelect = False
        Me.dgvNotaPedidos.Name = "dgvNotaPedidos"
        Me.dgvNotaPedidos.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvNotaPedidos.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvNotaPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvNotaPedidos.Size = New System.Drawing.Size(910, 522)
        Me.dgvNotaPedidos.TabIndex = 0
        '
        'Numero
        '
        Me.Numero.DataPropertyName = "id_NotaPedido"
        Me.Numero.HeaderText = "NRO"
        Me.Numero.Name = "Numero"
        Me.Numero.ReadOnly = True
        '
        'Estado
        '
        Me.Estado.HeaderText = "ESTADO"
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        '
        'IdTipoVentaDataGridViewTextBoxColumn
        '
        Me.IdTipoVentaDataGridViewTextBoxColumn.DataPropertyName = "TipoVentaDescripcion"
        Me.IdTipoVentaDataGridViewTextBoxColumn.HeaderText = "TIPO VENTA"
        Me.IdTipoVentaDataGridViewTextBoxColumn.Name = "IdTipoVentaDataGridViewTextBoxColumn"
        Me.IdTipoVentaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdTipoPagoDataGridViewTextBoxColumn
        '
        Me.IdTipoPagoDataGridViewTextBoxColumn.DataPropertyName = "TipoPagoDescripcion"
        Me.IdTipoPagoDataGridViewTextBoxColumn.HeaderText = "TIPO PAGO"
        Me.IdTipoPagoDataGridViewTextBoxColumn.Name = "IdTipoPagoDataGridViewTextBoxColumn"
        Me.IdTipoPagoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmpleadoNombreyApellidoDataGridViewTextBoxColumn
        '
        Me.EmpleadoNombreyApellidoDataGridViewTextBoxColumn.DataPropertyName = "EmpleadoNombreyApellido"
        Me.EmpleadoNombreyApellidoDataGridViewTextBoxColumn.HeaderText = "VENDEDOR"
        Me.EmpleadoNombreyApellidoDataGridViewTextBoxColumn.Name = "EmpleadoNombreyApellidoDataGridViewTextBoxColumn"
        Me.EmpleadoNombreyApellidoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrecioTotalDataGridViewTextBoxColumn
        '
        Me.PrecioTotalDataGridViewTextBoxColumn.DataPropertyName = "PrecioTotal"
        DataGridViewCellStyle2.Format = "C2"
        Me.PrecioTotalDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.PrecioTotalDataGridViewTextBoxColumn.HeaderText = "PRECIO TOTAL"
        Me.PrecioTotalDataGridViewTextBoxColumn.Name = "PrecioTotalDataGridViewTextBoxColumn"
        Me.PrecioTotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "FECHA"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreCliente
        '
        Me.NombreCliente.HeaderText = "NOMBRE CLIENTE"
        Me.NombreCliente.Name = "NombreCliente"
        Me.NombreCliente.ReadOnly = True
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "ELIMINAR"
        Me.Eliminar.Image = Global.SistemaCinderella.My.Resources.Recursos.Boton_Eliminar
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'IMPRIMIR
        '
        Me.IMPRIMIR.HeaderText = "IMPRIMIR"
        Me.IMPRIMIR.Image = Global.SistemaCinderella.My.Resources.Recursos.icono_imprimir
        Me.IMPRIMIR.Name = "IMPRIMIR"
        Me.IMPRIMIR.ReadOnly = True
        '
        'PorcentajeFacturacion
        '
        Me.PorcentajeFacturacion.DataPropertyName = "PorcentajeFacturacion"
        Me.PorcentajeFacturacion.HeaderText = "PorcentajeFacturacion"
        Me.PorcentajeFacturacion.Name = "PorcentajeFacturacion"
        Me.PorcentajeFacturacion.ReadOnly = True
        Me.PorcentajeFacturacion.Visible = False
        '
        'NotaPedidoBindingSource
        '
        Me.NotaPedidoBindingSource.DataSource = GetType(Entidades.NotaPedido)
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(560, 55)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 16)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "Nombre"
        '
        'BtnFiltrar
        '
        Me.BtnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFiltrar.FlatAppearance.BorderSize = 0
        Me.BtnFiltrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFiltrar.Image = Global.SistemaCinderella.My.Resources.Recursos.IconoBuscar32
        Me.BtnFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnFiltrar.Location = New System.Drawing.Point(804, 85)
        Me.BtnFiltrar.Name = "BtnFiltrar"
        Me.BtnFiltrar.Size = New System.Drawing.Size(100, 40)
        Me.BtnFiltrar.TabIndex = 23
        Me.BtnFiltrar.Text = "Buscar"
        Me.BtnFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnFiltrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 16)
        Me.Label1.TabIndex = 112
        Me.Label1.Text = "Tipo de Venta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 16)
        Me.Label2.TabIndex = 122
        Me.Label2.Text = "Tipo de Pago"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(560, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 16)
        Me.Label3.TabIndex = 142
        Me.Label3.Text = "Vendedor"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(8, 192)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(110, 16)
        Me.Label31.TabIndex = 423
        Me.Label31.Text = "Destino Salida"
        '
        'chkSinSalida
        '
        Me.chkSinSalida.AutoSize = True
        Me.chkSinSalida.Checked = True
        Me.chkSinSalida.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSinSalida.Location = New System.Drawing.Point(154, 192)
        Me.chkSinSalida.Name = "chkSinSalida"
        Me.chkSinSalida.Size = New System.Drawing.Size(82, 19)
        Me.chkSinSalida.TabIndex = 420
        Me.chkSinSalida.Text = "Sin Salida"
        Me.chkSinSalida.UseVisualStyleBackColor = True
        '
        'chkDepositado
        '
        Me.chkDepositado.AutoSize = True
        Me.chkDepositado.Checked = True
        Me.chkDepositado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDepositado.Location = New System.Drawing.Point(241, 192)
        Me.chkDepositado.Name = "chkDepositado"
        Me.chkDepositado.Size = New System.Drawing.Size(89, 19)
        Me.chkDepositado.TabIndex = 421
        Me.chkDepositado.Text = "Depositado"
        Me.chkDepositado.UseVisualStyleBackColor = True
        '
        'chkPasado
        '
        Me.chkPasado.AutoSize = True
        Me.chkPasado.Checked = True
        Me.chkPasado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPasado.Location = New System.Drawing.Point(336, 192)
        Me.chkPasado.Name = "chkPasado"
        Me.chkPasado.Size = New System.Drawing.Size(68, 19)
        Me.chkPasado.TabIndex = 422
        Me.chkPasado.Text = "Pasado"
        Me.chkPasado.UseVisualStyleBackColor = True
        '
        'chkDevuelto
        '
        Me.chkDevuelto.AutoSize = True
        Me.chkDevuelto.Checked = True
        Me.chkDevuelto.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDevuelto.Location = New System.Drawing.Point(410, 192)
        Me.chkDevuelto.Name = "chkDevuelto"
        Me.chkDevuelto.Size = New System.Drawing.Size(74, 19)
        Me.chkDevuelto.TabIndex = 424
        Me.chkDevuelto.Text = "Devuelto"
        Me.chkDevuelto.UseVisualStyleBackColor = True
        '
        'chkOtros
        '
        Me.chkOtros.AutoSize = True
        Me.chkOtros.Checked = True
        Me.chkOtros.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkOtros.Location = New System.Drawing.Point(490, 192)
        Me.chkOtros.Name = "chkOtros"
        Me.chkOtros.Size = New System.Drawing.Size(55, 19)
        Me.chkOtros.TabIndex = 425
        Me.chkOtros.Text = "Otros"
        Me.chkOtros.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.ChkFiltroFecha)
        Me.GroupBox1.Controls.Add(Me.ChkCerradas)
        Me.GroupBox1.Controls.Add(Me.ChkAbiertas)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.dtFechaAltaHasta)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.dtFechaAltaDesde)
        Me.GroupBox1.Controls.Add(Me.btn_Restablecer)
        Me.GroupBox1.Controls.Add(Me.cmbVendedor)
        Me.GroupBox1.Controls.Add(Me.txtNombreCliente)
        Me.GroupBox1.Controls.Add(Me.cmbTiposPago)
        Me.GroupBox1.Controls.Add(Me.cmbTipoVenta)
        Me.GroupBox1.Controls.Add(Me.chkOtros)
        Me.GroupBox1.Controls.Add(Me.chkDevuelto)
        Me.GroupBox1.Controls.Add(Me.chkPasado)
        Me.GroupBox1.Controls.Add(Me.chkDepositado)
        Me.GroupBox1.Controls.Add(Me.chkSinSalida)
        Me.GroupBox1.Controls.Add(Me.Label31)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.BtnFiltrar)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(910, 131)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtrar Nota Pedido"
        '
        'ChkFiltroFecha
        '
        Me.ChkFiltroFecha.AutoSize = True
        Me.ChkFiltroFecha.Location = New System.Drawing.Point(365, 108)
        Me.ChkFiltroFecha.Name = "ChkFiltroFecha"
        Me.ChkFiltroFecha.Size = New System.Drawing.Size(15, 14)
        Me.ChkFiltroFecha.TabIndex = 440
        Me.ChkFiltroFecha.UseVisualStyleBackColor = True
        '
        'ChkCerradas
        '
        Me.ChkCerradas.AutoSize = True
        Me.ChkCerradas.Location = New System.Drawing.Point(208, 26)
        Me.ChkCerradas.Name = "ChkCerradas"
        Me.ChkCerradas.Size = New System.Drawing.Size(76, 19)
        Me.ChkCerradas.TabIndex = 439
        Me.ChkCerradas.Text = "Cerradas"
        Me.ChkCerradas.UseVisualStyleBackColor = True
        '
        'ChkAbiertas
        '
        Me.ChkAbiertas.AutoSize = True
        Me.ChkAbiertas.Checked = True
        Me.ChkAbiertas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkAbiertas.Location = New System.Drawing.Point(132, 26)
        Me.ChkAbiertas.Name = "ChkAbiertas"
        Me.ChkAbiertas.Size = New System.Drawing.Size(70, 19)
        Me.ChkAbiertas.TabIndex = 438
        Me.ChkAbiertas.Text = "Abiertas"
        Me.ChkAbiertas.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 16)
        Me.Label9.TabIndex = 437
        Me.Label9.Text = "Estado"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(239, 109)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(13, 16)
        Me.Label24.TabIndex = 436
        Me.Label24.Text = "-"
        '
        'dtFechaAltaHasta
        '
        Me.dtFechaAltaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaAltaHasta.Location = New System.Drawing.Point(258, 104)
        Me.dtFechaAltaHasta.Name = "dtFechaAltaHasta"
        Me.dtFechaAltaHasta.Size = New System.Drawing.Size(101, 21)
        Me.dtFechaAltaHasta.TabIndex = 433
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 109)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 16)
        Me.Label8.TabIndex = 435
        Me.Label8.Text = "Fecha Alta"
        '
        'dtFechaAltaDesde
        '
        Me.dtFechaAltaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaAltaDesde.Location = New System.Drawing.Point(132, 104)
        Me.dtFechaAltaDesde.Name = "dtFechaAltaDesde"
        Me.dtFechaAltaDesde.Size = New System.Drawing.Size(101, 21)
        Me.dtFechaAltaDesde.TabIndex = 432
        '
        'btn_Restablecer
        '
        Me.btn_Restablecer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Restablecer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Restablecer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Restablecer.Location = New System.Drawing.Point(698, 85)
        Me.btn_Restablecer.Name = "btn_Restablecer"
        Me.btn_Restablecer.Size = New System.Drawing.Size(100, 40)
        Me.btn_Restablecer.TabIndex = 431
        Me.btn_Restablecer.Text = "Restablecer Busqueda"
        Me.btn_Restablecer.UseVisualStyleBackColor = True
        '
        'cmbVendedor
        '
        Me.cmbVendedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbVendedor.FormattingEnabled = True
        Me.cmbVendedor.Items.AddRange(New Object() {"Seleccione un tipo de venta...", "Minorista", "Mayorista"})
        Me.cmbVendedor.Location = New System.Drawing.Point(656, 20)
        Me.cmbVendedor.Name = "cmbVendedor"
        Me.cmbVendedor.Size = New System.Drawing.Size(248, 23)
        Me.cmbVendedor.TabIndex = 430
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreCliente.Location = New System.Drawing.Point(656, 51)
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.Size = New System.Drawing.Size(248, 21)
        Me.txtNombreCliente.TabIndex = 429
        '
        'cmbTiposPago
        '
        Me.cmbTiposPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTiposPago.FormattingEnabled = True
        Me.cmbTiposPago.Location = New System.Drawing.Point(132, 77)
        Me.cmbTiposPago.Name = "cmbTiposPago"
        Me.cmbTiposPago.Size = New System.Drawing.Size(248, 23)
        Me.cmbTiposPago.TabIndex = 427
        '
        'cmbTipoVenta
        '
        Me.cmbTipoVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoVenta.FormattingEnabled = True
        Me.cmbTipoVenta.Items.AddRange(New Object() {"Seleccione un tipo de venta...", "Minorista", "Mayorista"})
        Me.cmbTipoVenta.Location = New System.Drawing.Point(132, 48)
        Me.cmbTipoVenta.Name = "cmbTipoVenta"
        Me.cmbTipoVenta.Size = New System.Drawing.Size(248, 23)
        Me.cmbTipoVenta.TabIndex = 426
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.txtTotal)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtTotalSinIVA)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtValorPromedio)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtCantidad)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 677)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(910, 65)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Totales"
        '
        'txtTotal
        '
        Me.txtTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotal.Location = New System.Drawing.Point(704, 38)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(200, 21)
        Me.txtTotal.TabIndex = 437
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(575, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 16)
        Me.Label6.TabIndex = 436
        Me.Label6.Text = "Importe total"
        '
        'txtTotalSinIVA
        '
        Me.txtTotalSinIVA.Location = New System.Drawing.Point(162, 38)
        Me.txtTotalSinIVA.Name = "txtTotalSinIVA"
        Me.txtTotalSinIVA.ReadOnly = True
        Me.txtTotalSinIVA.Size = New System.Drawing.Size(200, 21)
        Me.txtTotalSinIVA.TabIndex = 435
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(146, 16)
        Me.Label7.TabIndex = 434
        Me.Label7.Text = "Importe total sin IVA"
        '
        'txtValorPromedio
        '
        Me.txtValorPromedio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValorPromedio.Location = New System.Drawing.Point(704, 12)
        Me.txtValorPromedio.Name = "txtValorPromedio"
        Me.txtValorPromedio.ReadOnly = True
        Me.txtValorPromedio.Size = New System.Drawing.Size(200, 21)
        Me.txtValorPromedio.TabIndex = 433
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(573, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 16)
        Me.Label5.TabIndex = 432
        Me.Label5.Text = "Valor Promedio"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(162, 12)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.ReadOnly = True
        Me.txtCantidad.Size = New System.Drawing.Size(200, 21)
        Me.txtCantidad.TabIndex = 431
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 16)
        Me.Label4.TabIndex = 430
        Me.Label4.Text = "Cantidad NP"
        '
        'lbl_Msg
        '
        Me.lbl_Msg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Msg.AutoSize = True
        Me.lbl_Msg.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lbl_Msg.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Msg.Location = New System.Drawing.Point(231, 396)
        Me.lbl_Msg.Name = "lbl_Msg"
        Me.lbl_Msg.Size = New System.Drawing.Size(472, 29)
        Me.lbl_Msg.TabIndex = 20
        Me.lbl_Msg.Text = "No se han encontrado notas de pedido."
        '
        'frmNotaPedidoAdministracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 750)
        Me.Controls.Add(Me.lbl_Msg)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvNotaPedidos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmNotaPedidoAdministracion"
        Me.Text = "Administracion Nota Pedido"
        CType(Me.dgvNotaPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NotaPedidoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvNotaPedidos As System.Windows.Forms.DataGridView
    Friend WithEvents NotaPedidoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents BtnFiltrar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents chkSinSalida As System.Windows.Forms.CheckBox
    Friend WithEvents chkDepositado As System.Windows.Forms.CheckBox
    Friend WithEvents chkPasado As System.Windows.Forms.CheckBox
    Friend WithEvents chkDevuelto As System.Windows.Forms.CheckBox
    Friend WithEvents chkOtros As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNombreCliente As System.Windows.Forms.TextBox
    Friend WithEvents cmbTiposPago As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTipoVenta As System.Windows.Forms.ComboBox
    Friend WithEvents cmbVendedor As System.Windows.Forms.ComboBox
    Friend WithEvents btn_Restablecer As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTotalSinIVA As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtValorPromedio As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents dtFechaAltaHasta As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents dtFechaAltaDesde As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents lbl_Msg As Label
    Friend WithEvents ChkCerradas As CheckBox
    Friend WithEvents ChkAbiertas As CheckBox
    Friend WithEvents Numero As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents IdTipoVentaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdTipoPagoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmpleadoNombreyApellidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioTotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreCliente As DataGridViewTextBoxColumn
    Friend WithEvents Eliminar As DataGridViewImageColumn
    Friend WithEvents IMPRIMIR As DataGridViewImageColumn
    Friend WithEvents ChkFiltroFecha As CheckBox
    Friend WithEvents PorcentajeFacturacion As DataGridViewTextBoxColumn
End Class
