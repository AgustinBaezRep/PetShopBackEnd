using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Context
{
    public partial class TipoBeneficio
    {
        public TipoBeneficio()
        {
            Beneficios = new HashSet<Beneficio>();
        }

        public int IdTipoBeneficio { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Beneficio> Beneficios { get; set; }
    }
}
