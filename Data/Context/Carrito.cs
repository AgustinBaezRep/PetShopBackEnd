using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Context
{
    public partial class Carrito
    {
        public int IdCarrito { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioActual { get; set; }

        public virtual Producto IdProductoNavigation { get; set; }
    }
}
