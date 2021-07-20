using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Context
{
    public partial class Categorium
    {
        public Categorium()
        {
            Subcategoria = new HashSet<Subcategorium>();
        }

        public int IdCategoria { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Subcategorium> Subcategoria { get; set; }
    }
}
