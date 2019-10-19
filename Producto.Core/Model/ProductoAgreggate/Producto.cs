﻿using Common.Core.Exceptions;
using Common.Core.Model;
using System;
using System.Collections.Generic;

namespace Producto.Core.Model.ProductoAgreggate
{
    public class Producto : Entity<int>
    {
        public int? IdCategoria { get; protected set; }
        public virtual Categoria Categoria { get; protected set; }
        public int? IdSubcategoria { get; protected set; }
        public virtual SubCategoria Subcategoria { get; protected set; }
        public int? IdProveedor { get; protected set; }
        public virtual Proveedor Proveedor { get; protected set; }

        public void AgregarNombre(string value)
        {
            throw new NotImplementedException();
        }

        public virtual IList<Precio> Precios { get; protected set; }
        public string Nombre { get; protected set; }
        public string Descripcion { get; protected set; }
        public decimal Costo { get; protected set; }
        public string Origen { get; protected set; }
        public string Tamanio { get; protected set; }
        public string Codigo { get; protected set; }
        public string CodigoBarra { get; protected set; }
        public string Foto { get; protected set; }
        public DateTime Fecha { get; protected set; }
        public bool Habilitado { get; protected set; }
        public bool Novedad { get; protected set; }
        public bool SubirWeb { get; protected set; }

        public Producto()
        {
        }

        public Producto(Categoria categoria, SubCategoria subcategoria, Proveedor proveedor, string nombre, string descripcion, decimal costo, string origen, string tamanio, string codigo, string foto, bool habilitado, bool novedad, bool subirWeb, IList<Precio> precios)
        {
            if(string.IsNullOrWhiteSpace(nombre))
                throw new NegocioException("En nombre del producto no puede estar vacío.");
            if (string.IsNullOrWhiteSpace(codigo))
                throw new NegocioException("En código del producto no puede estar vacío.");
            if (precios.Count < 6)
                throw new NegocioException("Debe completar el listado de precios.");

            Categoria = categoria ?? throw new NegocioException("La categoría del producto no puede estar vacío.");
            IdCategoria = categoria.Id;
            Subcategoria = subcategoria ?? throw new NegocioException("En subcategoría del producto no puede estar vacío.");
            IdSubcategoria = subcategoria.Id;
            Proveedor = proveedor ?? throw new NegocioException("El proveedor del producto no puede estar vacío.");
            IdProveedor = proveedor.Id;
            Nombre = nombre;
            Descripcion = descripcion;
            Costo = costo;
            Origen = origen;
            Tamanio = tamanio;
            Codigo = codigo;
            Foto = foto;
            Fecha = DateTime.Now;
            Habilitado = habilitado;
            Novedad = Novedad;
            SubirWeb = SubirWeb;
            Precios = precios;
        }

        public void ActualizarDatos(Categoria categoria, SubCategoria subcategoria, Proveedor proveedor, string nombre, string descripcion, decimal costo, string origen, string tamanio, string codigo, string foto, bool habilitado, bool novedad, bool subirWeb)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new NegocioException("En nombre del producto no puede estar vacío.");
            if (string.IsNullOrWhiteSpace(codigo))
                throw new NegocioException("En código del producto no puede estar vacío.");

            Categoria = categoria ?? throw new NegocioException("La categoría del producto no puede estar vacío.");
            IdCategoria = categoria.Id;
            Subcategoria = subcategoria ?? throw new NegocioException("En subcategoría del producto no puede estar vacío.");
            IdSubcategoria = subcategoria.Id;
            Proveedor = proveedor ?? throw new NegocioException("El proveedor del producto no puede estar vacío.");
            IdProveedor = proveedor.Id;
            Nombre = nombre;
            Descripcion = descripcion;
            Costo = costo;
            Origen = origen;
            Tamanio = tamanio;
            Codigo = codigo;
            Foto = foto;
            Fecha = DateTime.Now;
            Habilitado = habilitado;
            Novedad = Novedad;
            SubirWeb = SubirWeb;
        }

        public void CargarCodigoBarras(int idProducto)
        {
            CodigoBarra = ObtenerCodigoBarras(idProducto);
        }


        private string ObtenerCodigoBarras(int idProducto)
        {
            string codigo = "7791234" + idProducto.ToString().PadLeft(5,'0');
            return codigo + ObtenerCodigoVerificador(codigo);
        }

        private string ObtenerCodigoVerificador(string codigoBarras)
        {
            int suma = 0;
            for (int i = 0; i <= 11; i++)
            {
                int digit = codigoBarras[i] - 0x30;
                if ((i & 0x01) == 1)
                    suma += digit;
                else
                    suma += digit * 3;
            }
            int mod = suma % 10;
            return (mod == 0 ? 0 : 10 - mod).ToString();
        }
    } 
}
