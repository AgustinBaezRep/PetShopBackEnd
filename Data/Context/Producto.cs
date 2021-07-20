using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Context
{
    public partial class Producto
    {
        public Producto()
        {
            BeneficioxProductos = new HashSet<BeneficioxProducto>();
            Carritos = new HashSet<Carrito>();
            LineaDeVenta = new HashSet<LineaDeVentum>();
        }

        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; }
        public decimal Precio { get; set; }
        public string Especificacion { get; set; }
        public int IdStock { get; set; }
        public int IdSubcategoria { get; set; }

        public virtual Stock IdStockNavigation { get; set; }
        public virtual Subcategorium IdSubcategoriaNavigation { get; set; }
        public virtual ICollection<BeneficioxProducto> BeneficioxProductos { get; set; }
        public virtual ICollection<Carrito> Carritos { get; set; }
        public virtual ICollection<LineaDeVentum> LineaDeVenta { get; set; }
    }
}
