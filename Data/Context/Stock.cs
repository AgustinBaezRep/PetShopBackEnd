﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Context
{
    public partial class Stock
    {
        public Stock()
        {
            Producto = new HashSet<Producto>();
        }

        public int IdStock { get; set; }
        public int PuntoMinimo { get; set; }
        public int PuntoMaximo { get; set; }
        public int CantidadActual { get; set; }

        public virtual ICollection<Producto> Producto { get; set; }
    }
}