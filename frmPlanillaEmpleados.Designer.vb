﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPlanillaEmpleados
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPlanillaEmpleados))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Btn_Excel = New System.Windows.Forms.Button()
        Me.btn_Filtrar = New System.Windows.Forms.Button()
        Me.DG_Planilla = New System.Windows.Forms.DataGridView()
        Me.GB_Controles = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Cb_Sucursal = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cb_Periodo = New System.Windows.Forms.ComboBox()
        Me.Cb_Meses = New System.Windows.Forms.ComboBox()
        Me.Cb_Anios = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_TotSueldos = New System.Windows.Forms.Label()
        Me.lbl_TotComisiones = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_TotVacaciones = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl_TotAguinaldos = New System.Windows.Forms.Label()
        CType(Me.DG_Planilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_Controles.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Ayuda"
        '
        'Btn_Excel
        '
        Me.Btn_Excel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Excel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Excel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Excel.Image = Global.SistemaCinderella.My.Resources.Recursos.Btn_Excel
        Me.Btn_Excel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Excel.Location = New System.Drawing.Point(726, 18)
        Me.Btn_Excel.Name = "Btn_Excel"
        Me.Btn_Excel.Size = New System.Drawing.Size(40, 40)
        Me.Btn_Excel.TabIndex = 15
        Me.Btn_Excel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.Btn_Excel, "Exportar Planilla a Excel")
        Me.Btn_Excel.UseVisualStyleBackColor = True
        '
        'btn_Filtrar
        '
        Me.btn_Filtrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Filtrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Filtrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Filtrar.Image = Global.SistemaCinderella.My.Resources.Recursos.IconoBuscar32
        Me.btn_Filtrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Filtrar.Location = New System.Drawing.Point(772, 18)
        Me.btn_Filtrar.Name = "btn_Filtrar"
        Me.btn_Filtrar.Size = New System.Drawing.Size(40, 40)
        Me.btn_Filtrar.TabIndex = 12
        Me.btn_Filtrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btn_Filtrar, "Refinar la planilla. Se tomarán en cuenta, las diferentes opciones seleccionadas." & _
                "")
        Me.btn_Filtrar.UseVisualStyleBackColor = True
        '
        'DG_Planilla
        '
        Me.DG_Planilla.AllowUserToAddRows = False
        Me.DG_Planilla.AllowUserToDeleteRows = False
        Me.DG_Planilla.AllowUserToResizeRows = False
        Me.DG_Planilla.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_Planilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_Planilla.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_Planilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Planilla.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DG_Planilla.GridColor = System.Drawing.SystemColors.ControlText
        Me.DG_Planilla.Location = New System.Drawing.Point(15, 87)
        Me.DG_Planilla.Name = "DG_Planilla"
        Me.DG_Planilla.ReadOnly = True
        Me.DG_Planilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Planilla.Size = New System.Drawing.Size(816, 418)
        Me.DG_Planilla.TabIndex = 2
        '
        'GB_Controles
        '
        Me.GB_Controles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_Controles.Controls.Add(Me.Btn_Excel)
        Me.GB_Controles.Controls.Add(Me.Label4)
        Me.GB_Controles.Controls.Add(Me.Cb_Sucursal)
        Me.GB_Controles.Controls.Add(Me.btn_Filtrar)
        Me.GB_Controles.Controls.Add(Me.Label3)
        Me.GB_Controles.Controls.Add(Me.Label2)
        Me.GB_Controles.Controls.Add(Me.Label1)
        Me.GB_Controles.Controls.Add(Me.Cb_Periodo)
        Me.GB_Controles.Controls.Add(Me.Cb_Meses)
        Me.GB_Controles.Controls.Add(Me.Cb_Anios)
        Me.GB_Controles.Location = New System.Drawing.Point(14, 14)
        Me.GB_Controles.Name = "GB_Controles"
        Me.GB_Controles.Size = New System.Drawing.Size(818, 67)
        Me.GB_Controles.TabIndex = 10
        Me.GB_Controles.TabStop = False
        Me.GB_Controles.Text = "Seleccione los diferentes filtros si desea refinar su planilla de sueldos."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(495, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 15)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Sucursal"
        '
        'Cb_Sucursal
        '
        Me.Cb_Sucursal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_Sucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Sucursal.FormattingEnabled = True
        Me.Cb_Sucursal.Items.AddRange(New Object() {"Mes Completo", "Primera Quincena", "Segunda Quincena"})
        Me.Cb_Sucursal.Location = New System.Drawing.Point(564, 28)
        Me.Cb_Sucursal.Name = "Cb_Sucursal"
        Me.Cb_Sucursal.Size = New System.Drawing.Size(152, 23)
        Me.Cb_Sucursal.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(288, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 15)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Período"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 15)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Año"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(141, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 15)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Mes"
        '
        'Cb_Periodo
        '
        Me.Cb_Periodo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_Periodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Periodo.FormattingEnabled = True
        Me.Cb_Periodo.Items.AddRange(New Object() {"Mes Completo", "Primera Quincena", "Segunda Quincena"})
        Me.Cb_Periodo.Location = New System.Drawing.Point(351, 27)
        Me.Cb_Periodo.Name = "Cb_Periodo"
        Me.Cb_Periodo.Size = New System.Drawing.Size(138, 23)
        Me.Cb_Periodo.TabIndex = 8
        '
        'Cb_Meses
        '
        Me.Cb_Meses.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_Meses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Meses.FormattingEnabled = True
        Me.Cb_Meses.Location = New System.Drawing.Point(181, 28)
        Me.Cb_Meses.Name = "Cb_Meses"
        Me.Cb_Meses.Size = New System.Drawing.Size(101, 23)
        Me.Cb_Meses.TabIndex = 5
        '
        'Cb_Anios
        '
        Me.Cb_Anios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_Anios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Anios.FormattingEnabled = True
        Me.Cb_Anios.Location = New System.Drawing.Point(40, 28)
        Me.Cb_Anios.Name = "Cb_Anios"
        Me.Cb_Anios.Size = New System.Drawing.Size(95, 23)
        Me.Cb_Anios.TabIndex = 6
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.lbl_TotAguinaldos)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.lbl_TotVacaciones)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.lbl_TotSueldos)
        Me.GroupBox2.Controls.Add(Me.lbl_TotComisiones)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 511)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(817, 49)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Totales"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(199, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 15)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Total Comisiones:"
        '
        'lbl_TotSueldos
        '
        Me.lbl_TotSueldos.AutoSize = True
        Me.lbl_TotSueldos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TotSueldos.Location = New System.Drawing.Point(106, 23)
        Me.lbl_TotSueldos.Name = "lbl_TotSueldos"
        Me.lbl_TotSueldos.Size = New System.Drawing.Size(41, 18)
        Me.lbl_TotSueldos.TabIndex = 2
        Me.lbl_TotSueldos.Text = "$     -"
        '
        'lbl_TotComisiones
        '
        Me.lbl_TotComisiones.AutoSize = True
        Me.lbl_TotComisiones.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TotComisiones.Location = New System.Drawing.Point(327, 23)
        Me.lbl_TotComisiones.Name = "lbl_TotComisiones"
        Me.lbl_TotComisiones.Size = New System.Drawing.Size(41, 18)
        Me.lbl_TotComisiones.TabIndex = 1
        Me.lbl_TotComisiones.Text = "$     -"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Total Sueldos: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(413, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Total Vacaciones"
        '
        'lbl_TotVacaciones
        '
        Me.lbl_TotVacaciones.AutoSize = True
        Me.lbl_TotVacaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TotVacaciones.Location = New System.Drawing.Point(535, 23)
        Me.lbl_TotVacaciones.Name = "lbl_TotVacaciones"
        Me.lbl_TotVacaciones.Size = New System.Drawing.Size(41, 18)
        Me.lbl_TotVacaciones.TabIndex = 4
        Me.lbl_TotVacaciones.Text = "$     -"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(634, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(118, 15)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Total Aguinaldos:"
        '
        'lbl_TotAguinaldos
        '
        Me.lbl_TotAguinaldos.AutoSize = True
        Me.lbl_TotAguinaldos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TotAguinaldos.Location = New System.Drawing.Point(758, 23)
        Me.lbl_TotAguinaldos.Name = "lbl_TotAguinaldos"
        Me.lbl_TotAguinaldos.Size = New System.Drawing.Size(41, 18)
        Me.lbl_TotAguinaldos.TabIndex = 6
        Me.lbl_TotAguinaldos.Text = "$     -"
        '
        'frmPlanillaEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 572)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GB_Controles)
        Me.Controls.Add(Me.DG_Planilla)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPlanillaEmpleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Planilla de Sueldos de Empleados"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DG_Planilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_Controles.ResumeLayout(False)
        Me.GB_Controles.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents DG_Planilla As System.Windows.Forms.DataGridView
    Friend WithEvents GB_Controles As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_Excel As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Cb_Sucursal As System.Windows.Forms.ComboBox
    Friend WithEvents btn_Filtrar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Cb_Periodo As System.Windows.Forms.ComboBox
    Friend WithEvents Cb_Meses As System.Windows.Forms.ComboBox
    Friend WithEvents Cb_Anios As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lbl_TotSueldos As System.Windows.Forms.Label
    Friend WithEvents lbl_TotComisiones As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lbl_TotAguinaldos As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbl_TotVacaciones As System.Windows.Forms.Label
End Class
