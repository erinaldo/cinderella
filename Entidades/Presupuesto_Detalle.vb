﻿Public Class Presupuesto_Detalle
    Private id_Presupuesto_, id_Detalle_, id_Producto_, Cantidad_ As Integer
    Dim Precio_, Iva_, Monto_ As Double
    Dim nombreProducto_, CodigoProducto_ As String

    Public Property id_Presupuesto() As Integer
        Get
            Return id_Presupuesto_
        End Get
        Set(ByVal value As Integer)
            id_Presupuesto_ = value
        End Set
    End Property

    Public Property id_Detalle() As Integer
        Get
            Return id_Detalle_
        End Get
        Set(ByVal value As Integer)
            id_Detalle_ = value
        End Set
    End Property

    Public Property id_Producto() As Integer
        Get
            Return id_Producto_
        End Get
        Set(ByVal value As Integer)
            id_Producto_ = value
        End Set
    End Property

    Public Property CodigoProducto() As String
        Get
            Return CodigoProducto_
        End Get
        Set(ByVal value As String)
            CodigoProducto_ = value
        End Set
    End Property

    Public Property NombreProducto() As String
        Get
            Return nombreProducto_
        End Get
        Set(ByVal value As String)
            nombreProducto_ = value
        End Set
    End Property

    Public Property Cantidad() As Integer
        Get
            Return Cantidad_
        End Get
        Set(ByVal value As Integer)
            Cantidad_ = value
        End Set
    End Property

    Public Property Precio() As Double
        Get
            Return Precio_
        End Get
        Set(ByVal value As Double)
            Precio_ = value
        End Set
    End Property

    Public Property Iva() As Double
        Get
            Return Iva_
        End Get
        Set(ByVal value As Double)
            Iva_ = value
        End Set
    End Property

    Public Property Monto() As Double
        Get
            Return Monto_
        End Get
        Set(ByVal value As Double)
            Monto_ = value
        End Set
    End Property
End Class
