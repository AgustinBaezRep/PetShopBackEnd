using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Context
{
    public partial class Cliente
    {
        public Cliente()
        {
            Venta = new HashSet<Ventum>();
        }

        public int IdCliente { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public int Cuit { get; set; }
        public int? Telefono { get; set; }

        public virtual ICollection<Ventum> Venta { get; set; }
    }
}
