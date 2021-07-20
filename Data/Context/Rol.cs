using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Context
{
    public partial class Rol
    {
        public Rol()
        {
            AccionxRols = new HashSet<AccionxRol>();
            RolxUsuarios = new HashSet<RolxUsuario>();
        }

        public int IdRol { get; set; }
        public int EstadoRol { get; set; }
        public string Descripcion { get; set; }

        public virtual Estado EstadoRolNavigation { get; set; }
        public virtual ICollection<AccionxRol> AccionxRols { get; set; }
        public virtual ICollection<RolxUsuario> RolxUsuarios { get; set; }
    }
}
