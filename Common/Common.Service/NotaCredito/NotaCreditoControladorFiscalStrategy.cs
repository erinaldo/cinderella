﻿using System.Collections.Generic;
using System.Linq;
using Common.Core.Enum;
using Common.Core.ValueObjects;
using Common.Device.Printer;
using Common.Service.NotaCredito.Contracts;

namespace Common.Service.NotaCredito
{
    public class NotaCreditoControladorFiscalStrategy : INotaCreditoStrategy
    {
        public ObtenerNumeroNotaCretidoResponse ObtenerNumeroNotaCretido(TipoCliente tipoCliente, CondicionIVA condicionesIVA, List<TicketPago> pagos, IList<TicketProducto> productos, decimal porcentajeFacturacion, string nombreYApellido, string direccion, string localidad, string cuit, int numeroFacturaOrigen, int puntoVentaOrigen, CondicionIVA condicionesIVAOriginal)
        {
            EpsonPrinter epsonFP = new EpsonPrinter(tipoCliente, condicionesIVA, porcentajeFacturacion, nombreYApellido, direccion, localidad, cuit, numeroFacturaOrigen.ToString(), puntoVentaOrigen.ToString(), condicionesIVAOriginal);

            epsonFP.AbrirNotaCredito();

            foreach (TicketProducto ticketProducto in productos)
            {
                epsonFP.AgregarItemNotaCredito(ticketProducto.Codigo, ticketProducto.Nombre, ticketProducto.Cantidad, ticketProducto.Monto);
            }

            if (pagos.Any(x => x.Descuento > 0))
                epsonFP.DescuentosNotaCredito("Bonificación", pagos.Sum(x => x.Descuento));

            if (pagos.Any(x => x.Cft > 0))
                epsonFP.RecargosNotaCredito("Costo Financiero", pagos.Sum(x => x.Cft));

            if (!pagos.Any(x => x.Descuento > 0) && !pagos.Any(x => x.Cft > 0))
                epsonFP.SubtotalNotaCredito();

            int numeroTicket = epsonFP.CerrarNotaCredito();

            return new ObtenerNumeroNotaCretidoResponse()
            {
                NumeroNotaCredito = new List<int>() { numeroTicket }
            };
        }
    }
}