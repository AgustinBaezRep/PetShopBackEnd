using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Context
{
    public partial class BeneficioxSubcategorium
    {
        public int IdBeneficio { get; set; }
        public int IdSubcategoria { get; set; }

        public virtual Beneficio IdBeneficioNavigation { get; set; }
        public virtual Subcategorium IdSubcategoriaNavigation { get; set; }
    }
}
