using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Context
{
    public partial class Ventum
    {
        public Ventum()
        {
            LineaDeVenta = new HashSet<LineaDeVentum>();
        }

        public int IdVenta { get; set; }
        public int? IdUsuario { get; set; }
        public int? IdCliente { get; set; }
        public decimal? Total { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<LineaDeVentum> LineaDeVenta { get; set; }
    }
}
