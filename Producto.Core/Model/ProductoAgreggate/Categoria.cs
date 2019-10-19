﻿using Common.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producto.Core.Model.ProductoAgreggate
{
    public class Categoria : Entity<int>
    {
        public string Descripcion { get; protected set; }
        public virtual IList<SubCategoria> SubCategorias { get; protected set; }
        public bool Habilitado { get; protected set; }

        internal Categoria()
        { }
    }
}
