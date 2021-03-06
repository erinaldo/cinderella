﻿Imports System.ServiceModel

<ServiceBehavior(IncludeExceptionDetailInFaults:=True, UseSynchronizationContext:=False)>
Public Class NotaPedido
    Implements INotaPedido

    Public Delegate Sub NevaNotaPedidoDelegate(EntNotaPedido As Entidades.NotaPedido, EntConsumidorFinal As Entidades.ConsumidorFinal)
    Public Shared Event onNevaNotaPedidoCompleted As NevaNotaPedidoDelegate

    Function SetNevaNotaPedido(ByVal EntNotaPedido As EntidadNotaPedido, EntDetalleNotaPedido As List(Of EntidadNotaPedido_Detalle), ByVal EntConsumidorFinal As EntidadConsumidorFinal) As Boolean Implements INotaPedido.SetNevaNotaPedido
        Negocio.Funciones.HayConexionInternet()

        Dim NotaPedidoNegocio As Negocio.NegNotaPedido = New Negocio.NegNotaPedido()
        Dim NegClienteMinorista As Negocio.NegClienteMinorista = New Negocio.NegClienteMinorista()

        'Doy de alta el consumidor final y lo relaciono a la nota de pedido
        Dim consumidorFinal As Entidades.ConsumidorFinal = New Entidades.ConsumidorFinal()

        If (EntConsumidorFinal IsNot Nothing) Then
            consumidorFinal.Apellido = EntConsumidorFinal.Apellido
            consumidorFinal.Email = EntConsumidorFinal.Email
            consumidorFinal.Nombre = EntConsumidorFinal.Nombre

            Dim id_ConsumidorFinal As Integer = NegClienteMinorista.AltaClienteConsumidorFinal(consumidorFinal)
            EntNotaPedido.Id_ConsumidorFinal = id_ConsumidorFinal
        End If

        Dim detalleNotaPedido As List(Of Entidades.NotaPedido_Detalle) = New List(Of Entidades.NotaPedido_Detalle)()

        For Each det As EntidadNotaPedido_Detalle In EntDetalleNotaPedido
            Dim detalle As Entidades.NotaPedido_Detalle = New Entidades.NotaPedido_Detalle()
            detalle.Cantidad = det.Cantidad
            detalle.id_Detalle = det.id_Detalle
            detalle.id_NotaPedido = det.id_NotaPedido
            detalle.id_Producto = det.id_Producto
            detalle.Precio = 0
            detalle.Iva = 0
            detalle.Monto = det.Precio

            detalleNotaPedido.Add(detalle)
        Next

        Dim notaPedido As Entidades.NotaPedido = New Entidades.NotaPedido()
        notaPedido.Fecha = EntNotaPedido.Fecha
        notaPedido.id_Cliente = EntNotaPedido.id_Cliente
        notaPedido.Id_ConsumidorFinal = EntNotaPedido.Id_ConsumidorFinal
        notaPedido.id_Empleado = EntNotaPedido.id_Empleado
        notaPedido.id_ListaPrecio = EntNotaPedido.id_ListaPrecio
        notaPedido.id_Sucursal = EntNotaPedido.id_Sucursal
        notaPedido.id_TipoPago = EntNotaPedido.id_TipoPago
        notaPedido.id_TipoVenta = EntNotaPedido.id_TipoVenta
        notaPedido.PrecioTotal = EntNotaPedido.PrecioTotal
        notaPedido.Vendida = EntNotaPedido.Vendida

        notaPedido.id_NotaPedido = NotaPedidoNegocio.NuevaNotaPedido(notaPedido, detalleNotaPedido)

        If (notaPedido.id_NotaPedido > 0) Then
            RaiseEvent onNevaNotaPedidoCompleted(notaPedido, consumidorFinal)
            Return True
        Else
            Return False
        End If
    End Function

End Class
