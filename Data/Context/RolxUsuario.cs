using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Context
{
    public partial class RolxUsuario
    {
        public int IdUsuario { get; set; }
        public int IdRol { get; set; }

        public virtual Rol IdRolNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
