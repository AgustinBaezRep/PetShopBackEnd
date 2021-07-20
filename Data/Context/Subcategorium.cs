using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Context
{
    public partial class Subcategorium
    {
        public Subcategorium()
        {
            BeneficioxSubcategoria = new HashSet<BeneficioxSubcategorium>();
            Productos = new HashSet<Producto>();
        }

        public int IdSubcategoria { get; set; }
        public string Descripcion { get; set; }
        public int IdCategoria { get; set; }

        public virtual Categorium IdCategoriaNavigation { get; set; }
        public virtual ICollection<BeneficioxSubcategorium> BeneficioxSubcategoria { get; set; }
        public virtual ICollection<Producto> Productos { get; set; }
    }
}
