﻿using Common.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Core.Model.VentaAggregate;
using System.Data.Entity;
using Ventas.Core.Interfaces;
using Common.Core.Exceptions;
using Common.Core.Model;

namespace Ventas.Data.Repository
{
    public class ProductoRepository: BaseRepository, IProductoRepository
    {
        public ProductoRepository(VentaContext ventaContext) : base(ventaContext)
        {
        }

        public Producto Obtener(int idSucursal,int idProducto)
        {
            Producto producto = _context.Producto.Include(x => x.Precios).FirstOrDefault(x => x.Id == idProducto);
            if (producto == null)
                throw new NegocioException($"El producto con id {idProducto} no existe.");

            Stock stock = _context.Stock.FirstOrDefault(x => x.IdSucursal == idSucursal && x.IdProducto == producto.Id);

            if (stock == null)
                stock = new Stock(idSucursal, idProducto, 0, 0, 0 , 0);

            producto.Stock = stock;

            return producto;
        }

        public IList<Producto> Obtener()
        {
            return _context.Producto.ToList();
        }
    }
}
