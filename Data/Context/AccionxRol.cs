using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Context
{
    public partial class AccionxRol
    {
        public int IdAccion { get; set; }
        public int IdRol { get; set; }

        public virtual Accione IdAccionNavigation { get; set; }
        public virtual Rol IdRolNavigation { get; set; }
    }
}
