using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Context
{
    public partial class Estado
    {
        public Estado()
        {
            Rols = new HashSet<Rol>();
            Usuarios = new HashSet<Usuario>();
        }

        public int IdEstado { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Rol> Rols { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
