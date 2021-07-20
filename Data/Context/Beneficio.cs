using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Context
{
    public partial class Beneficio
    {
        public Beneficio()
        {
            BeneficioxProductos = new HashSet<BeneficioxProducto>();
            BeneficioxSubcategoria = new HashSet<BeneficioxSubcategorium>();
        }

        public int IdBeneficio { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public int? IdTipoBeneficio { get; set; }

        public virtual TipoBeneficio IdTipoBeneficioNavigation { get; set; }
        public virtual ICollection<BeneficioxProducto> BeneficioxProductos { get; set; }
        public virtual ICollection<BeneficioxSubcategorium> BeneficioxSubcategoria { get; set; }
    }
}
