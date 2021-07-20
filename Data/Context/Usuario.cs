using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Context
{
    public partial class Usuario
    {
        public Usuario()
        {
            RolxUsuarios = new HashSet<RolxUsuario>();
            Venta = new HashSet<Ventum>();
        }

        public int IdUsuario { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public int EstadoUsuario { get; set; }
        public string Contraseña { get; set; }
        public int Cuit { get; set; }
        public int Telefono { get; set; }

        public virtual Estado EstadoUsuarioNavigation { get; set; }
        public virtual ICollection<RolxUsuario> RolxUsuarios { get; set; }
        public virtual ICollection<Ventum> Venta { get; set; }
    }
}
