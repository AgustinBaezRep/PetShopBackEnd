using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Context
{
    public partial class BeneficioxProducto
    {
        public int IdBeneficio { get; set; }
        public int IdProducto { get; set; }

        public virtual Beneficio IdBeneficioNavigation { get; set; }
        public virtual Producto IdProductoNavigation { get; set; }
    }
}
