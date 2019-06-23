﻿using Common.Core.Enum;
using System.Collections.Generic;
using System.Linq;
using Common.Device.Printer;
using Common.Core.ValueObjects;
using System;

namespace Common.Service.Facturar
{
    public class FacturarControladorFiscalStrategy : IFacturarStrategy
    {
        public void ObtenerCierreZ()
        {
            using (EpsonPrinter epsonFP = new EpsonPrinter())
            { 
                epsonFP.CierreZ();
            }
        }

        public void ObtenerCierreZPorFecha(DateTime fechaDesde, DateTime fechaHasta)
        {
            using (EpsonPrinter epsonFP = new EpsonPrinter())
            {
                epsonFP.CierreZPorRangoDeFecha(fechaDesde, fechaHasta);
            }
        }

        public List<int> ObtenerNumeroFactura(TipoCliente tipoCliente, CondicionIVA condicionesIVA, List<TicketPago> pagos, IList<TicketProducto> productos, decimal porcentajeFacturacion, string nombreYApellido, string direccion, string localidad, string cuit)
        {
            List<int> numeroFacturaRespuesta = new List<int>();
            using (EpsonPrinter epsonFP = new EpsonPrinter(tipoCliente, condicionesIVA, porcentajeFacturacion, nombreYApellido, direccion, localidad, cuit))
            {

                epsonFP.AbrirTicket();

                foreach (TicketProducto ticketProducto in productos)
                {
                    epsonFP.AgregarItemTicket(ticketProducto.Codigo, ticketProducto.Nombre, ticketProducto.Cantidad, ticketProducto.Monto);
                }

                if (pagos.Any(x => x.Descuento > 0))
                    epsonFP.DescuentosTicket("Bonificación", pagos.Sum(x => x.Descuento));

                if (pagos.Any(x => x.Cft > 0))
                    epsonFP.RecargosTicket("Costo Financiero", pagos.Sum(x => x.Cft));

                if (!pagos.Any(x => x.Descuento > 0) && !pagos.Any(x => x.Cft > 0))
                    epsonFP.SubtotalTicket();

                foreach (TicketPago pago in pagos)
                {
                    epsonFP.PagarTicket(pago.TipoPago, pago.NumeroCuotas, pago.Total);
                }

                int numeroTicket = epsonFP.CerrarTicket();

                numeroFacturaRespuesta.Add(numeroTicket);
                return numeroFacturaRespuesta;
            }
        }
    }
}
