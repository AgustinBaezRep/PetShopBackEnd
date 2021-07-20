using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Context
{
    public partial class LineaDeVentum
    {
        public int IdVenta { get; set; }
        public int IdProducto { get; set; }
        public decimal PrecioActual { get; set; }
        public int Cantidad { get; set; }

        public virtual Producto IdProductoNavigation { get; set; }
        public virtual Ventum IdVentaNavigation { get; set; }
    }
}
