using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Context
{
    public partial class Accione
    {
        public Accione()
        {
            AccionxRols = new HashSet<AccionxRol>();
        }

        public int IdAccion { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<AccionxRol> AccionxRols { get; set; }
    }
}
