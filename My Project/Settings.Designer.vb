﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.1.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "My.Settings Auto-Save Functionality"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(sender As Global.System.Object, e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Cinderella")>  _
        Public ReadOnly Property Empresa() As String
            Get
                Return CType(Me("Empresa"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("as")>  _
        Public ReadOnly Property Setting() As String
            Get
                Return CType(Me("Setting"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("300000")>  _
        Public ReadOnly Property Temporizador() As String
            Get
                Return CType(Me("Temporizador"),String)
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Público Tigre")>  _
        Public Property NombreListaPrecio() As String
            Get
                Return CType(Me("NombreListaPrecio"),String)
            End Get
            Set
                Me("NombreListaPrecio") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("1")>  _
        Public Property ListaPrecio() As Integer
            Get
                Return CType(Me("ListaPrecio"),Integer)
            End Get
            Set
                Me("ListaPrecio") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("25")>  _
        Public Property MailPort() As String
            Get
                Return CType(Me("MailPort"),String)
            End Get
            Set
                Me("MailPort") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute(" 74.124.24.4")>  _
        Public Property MailHost() As String
            Get
                Return CType(Me("MailHost"),String)
            End Get
            Set
                Me("MailHost") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("sistema@nodomain.com")>  _
        Public Property MailUsuario() As String
            Get
                Return CType(Me("MailUsuario"),String)
            End Get
            Set
                Me("MailUsuario") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("cinderellasist11")>  _
        Public Property MailPassword() As String
            Get
                Return CType(Me("MailPassword"),String)
            End Get
            Set
                Me("MailPassword") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("SI")>  _
        Public Property ControladorStatus() As String
            Get
                Return CType(Me("ControladorStatus"),String)
            End Get
            Set
                Me("ControladorStatus") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("25000")>  _
        Public Property MontoTopeFaturacionTicket() As String
            Get
                Return CType(Me("MontoTopeFaturacionTicket"),String)
            End Get
            Set
                Me("MontoTopeFaturacionTicket") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("30000")>  _
        Public Property TemporizadorInternet() As String
            Get
                Return CType(Me("TemporizadorInternet"),String)
            End Get
            Set
                Me("TemporizadorInternet") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("300000")>  _
        Public Property TemporizadorMensajes() As String
            Get
                Return CType(Me("TemporizadorMensajes"),String)
            End Get
            Set
                Me("TemporizadorMensajes") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property Internet() As Boolean
            Get
                Return CType(Me("Internet"),Boolean)
            End Get
            Set
                Me("Internet") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("1")>  _
        Public Property PuntoVentaFacturacionManual() As Integer
            Get
                Return CType(Me("PuntoVentaFacturacionManual"),Integer)
            End Get
            Set
                Me("PuntoVentaFacturacionManual") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("2")>  _
        Public Property PuntoVentaFacturacionTicket() As Integer
            Get
                Return CType(Me("PuntoVentaFacturacionTicket"),Integer)
            End Get
            Set
                Me("PuntoVentaFacturacionTicket") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("3")>  _
        Public Property PuntoVentaFacturacionElectronica() As Integer
            Get
                Return CType(Me("PuntoVentaFacturacionElectronica"),Integer)
            End Get
            Set
                Me("PuntoVentaFacturacionElectronica") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("3000")>  _
        Public Property MontoMaximoNotaCredito() As String
            Get
                Return CType(Me("MontoMaximoNotaCredito"),String)
            End Get
            Set
                Me("MontoMaximoNotaCredito") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("USB")>  _
        Public Property ConexionControladora() As String
            Get
                Return CType(Me("ConexionControladora"),String)
            End Get
            Set
                Me("ConexionControladora") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("300000")>  _
        Public Property TemporizadorMovimientos() As String
            Get
                Return CType(Me("TemporizadorMovimientos"),String)
            End Get
            Set
                Me("TemporizadorMovimientos") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("300000")>  _
        Public Property TemporizadorCheques() As String
            Get
                Return CType(Me("TemporizadorCheques"),String)
            End Get
            Set
                Me("TemporizadorCheques") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("8088")>  _
        Public Property PuertoHost() As String
            Get
                Return CType(Me("PuertoHost"),String)
            End Get
            Set
                Me("PuertoHost") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("127.0.0.1")>  _
        Public Property IpHost() As String
            Get
                Return CType(Me("IpHost"),String)
            End Get
            Set
                Me("IpHost") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("300000")>  _
        Public Property TemporizadorNotasPedido() As String
            Get
                Return CType(Me("TemporizadorNotasPedido"),String)
            End Get
            Set
                Me("TemporizadorNotasPedido") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("25000")>  _
        Public Property MontoTopeFacturacionManual() As String
            Get
                Return CType(Me("MontoTopeFacturacionManual"),String)
            End Get
            Set
                Me("MontoTopeFacturacionManual") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("25000")>  _
        Public Property MontoTopeFacturacionElectronica() As String
            Get
                Return CType(Me("MontoTopeFacturacionElectronica"),String)
            End Get
            Set
                Me("MontoTopeFacturacionElectronica") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("3000")>  _
        Public Property ControladorMontoTope() As String
            Get
                Return CType(Me("ControladorMontoTope"),String)
            End Get
            Set
                Me("ControladorMontoTope") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("NO")>  _
        Public Property HabilitarExentoSinIVA() As String
            Get
                Return CType(Me("HabilitarExentoSinIVA"),String)
            End Get
            Set
                Me("HabilitarExentoSinIVA") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("10")>  _
        Public Property DescuentoMinorista() As Double
            Get
                Return CType(Me("DescuentoMinorista"),Double)
            End Get
            Set
                Me("DescuentoMinorista") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("2"),  _
         Global.System.Configuration.SettingsManageabilityAttribute(Global.System.Configuration.SettingsManageability.Roaming)>  _
        Public Property Sucursal() As Integer
            Get
                Return CType(Me("Sucursal"),Integer)
            End Get
            Set
                Me("Sucursal") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Av. Corrientes"),  _
         Global.System.Configuration.SettingsManageabilityAttribute(Global.System.Configuration.SettingsManageability.Roaming)>  _
        Public Property NombreSucursal() As String
            Get
                Return CType(Me("NombreSucursal"),String)
            End Get
            Set
                Me("NombreSucursal") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("300000")>  _
        Public Property TemporizadorOrdenesCompra() As String
            Get
                Return CType(Me("TemporizadorOrdenesCompra"),String)
            End Get
            Set
                Me("TemporizadorOrdenesCompra") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property GeneracionOrdenCompraAutomatica() As Boolean
            Get
                Return CType(Me("GeneracionOrdenCompraAutomatica"),Boolean)
            End Get
            Set
                Me("GeneracionOrdenCompraAutomatica") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("30")>  _
        Public Property PeriodoCaulculoVentaMensual() As String
            Get
                Return CType(Me("PeriodoCaulculoVentaMensual"),String)
            End Get
            Set
                Me("PeriodoCaulculoVentaMensual") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property MailSLL() As Boolean
            Get
                Return CType(Me("MailSLL"),Boolean)
            End Get
            Set
                Me("MailSLL") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("8.8.8.8")>  _
        Public Property IpPing() As String
            Get
                Return CType(Me("IpPing"),String)
            End Get
            Set
                Me("IpPing") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("2000")>  _
        Public Property IpTimeOut() As Integer
            Get
                Return CType(Me("IpTimeOut"),Integer)
            End Get
            Set
                Me("IpTimeOut") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Cinderella")>  _
        Public Property RazonSocial() As String
            Get
                Return CType(Me("RazonSocial"),String)
            End Get
            Set
                Me("RazonSocial") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("7200000")>  _
        Public Property TemporizadorSincronizacion() As String
            Get
                Return CType(Me("TemporizadorSincronizacion"),String)
            End Get
            Set
                Me("TemporizadorSincronizacion") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("15")>  _
        Public Property TemporizadorActualizacionMemoriaCache() As String
            Get
                Return CType(Me("TemporizadorActualizacionMemoriaCache"),String)
            End Get
            Set
                Me("TemporizadorActualizacionMemoriaCache") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property UsarMemoriaCache() As String
            Get
                Return CType(Me("UsarMemoriaCache"),String)
            End Get
            Set
                Me("UsarMemoriaCache") = value
            End Set
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Data Source=Localhost;Initial Catalog=CINDERELLA_LOCAL;Integrated Security=True")>  _
        Public ReadOnly Property Conexion() As String
            Get
                Return CType(Me("Conexion"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString),  _
         Global.System.Configuration.DefaultSettingValueAttribute("dqxgkq/GGutBEzBqe8fWB/46V9GSRFmxGDDgA6X0EQ5g3qwtKA4PIxG/uqJBma7OD/3+woYRf03OaAezl"& _ 
            "ltpA6/gQhWzNU089HLhPWu39Kk=")>  _
        Public ReadOnly Property ConexionRemoto() As String
            Get
                Return CType(Me("ConexionRemoto"),String)
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property ModeloControladora() As Integer
            Get
                Return CType(Me("ModeloControladora"),Integer)
            End Get
            Set
                Me("ModeloControladora") = value
            End Set
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.SistemaCinderella.My.MySettings
            Get
                Return Global.SistemaCinderella.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
