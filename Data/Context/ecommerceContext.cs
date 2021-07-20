using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Data.Context
{
    public partial class ecommerceContext : DbContext
    {
        public ecommerceContext()
        {
        }

        public ecommerceContext(DbContextOptions<ecommerceContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Accione> Acciones { get; set; }
        public virtual DbSet<AccionxRol> AccionxRols { get; set; }
        public virtual DbSet<Beneficio> Beneficios { get; set; }
        public virtual DbSet<BeneficioxProducto> BeneficioxProductos { get; set; }
        public virtual DbSet<BeneficioxSubcategorium> BeneficioxSubcategoria { get; set; }
        public virtual DbSet<Carrito> Carritos { get; set; }
        public virtual DbSet<Categorium> Categoria { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Estado> Estados { get; set; }
        public virtual DbSet<LineaDeVentum> LineaDeVenta { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }
        public virtual DbSet<Rol> Rols { get; set; }
        public virtual DbSet<RolxUsuario> RolxUsuarios { get; set; }
        public virtual DbSet<Stock> Stocks { get; set; }
        public virtual DbSet<Subcategorium> Subcategoria { get; set; }
        public virtual DbSet<Test> Tests { get; set; }
        public virtual DbSet<TipoBeneficio> TipoBeneficios { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Ventum> Venta { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=e-commerce.mssql.somee.com;Database=e-commerce;User=mastes_SQLLogin_1;Password=gppg6gv18u;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Accione>(entity =>
            {
                entity.HasKey(e => e.IdAccion)
                    .HasName("PK__Acciones__387C45617686F3AF");

                entity.Property(e => e.IdAccion).HasColumnName("id_accion");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");
            });

            modelBuilder.Entity<AccionxRol>(entity =>
            {
                entity.HasKey(e => new { e.IdAccion, e.IdRol })
                    .HasName("PK__AccionxR__2ED78E3F9F453107");

                entity.ToTable("AccionxRol");

                entity.Property(e => e.IdAccion).HasColumnName("id_accion");

                entity.Property(e => e.IdRol).HasColumnName("id_rol");

                entity.HasOne(d => d.IdAccionNavigation)
                    .WithMany(p => p.AccionxRols)
                    .HasForeignKey(d => d.IdAccion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AccionxRo__id_ac__403A8C7D");

                entity.HasOne(d => d.IdRolNavigation)
                    .WithMany(p => p.AccionxRols)
                    .HasForeignKey(d => d.IdRol)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AccionxRo__id_ro__412EB0B6");
            });

            modelBuilder.Entity<Beneficio>(entity =>
            {
                entity.HasKey(e => e.IdBeneficio)
                    .HasName("PK__Benefici__E83C0831145963CA");

                entity.ToTable("Beneficio");

                entity.Property(e => e.IdBeneficio).HasColumnName("id_beneficio");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.FechaVencimiento)
                    .HasColumnType("date")
                    .HasColumnName("fecha_vencimiento");

                entity.Property(e => e.IdTipoBeneficio).HasColumnName("id_tipo_beneficio");

                entity.HasOne(d => d.IdTipoBeneficioNavigation)
                    .WithMany(p => p.Beneficios)
                    .HasForeignKey(d => d.IdTipoBeneficio)
                    .HasConstraintName("FK__Beneficio__id_ti__5CD6CB2B");
            });

            modelBuilder.Entity<BeneficioxProducto>(entity =>
            {
                entity.HasKey(e => new { e.IdBeneficio, e.IdProducto })
                    .HasName("PK__Benefici__27CF49F185EEFE85");

                entity.ToTable("BeneficioxProducto");

                entity.Property(e => e.IdBeneficio).HasColumnName("id_beneficio");

                entity.Property(e => e.IdProducto).HasColumnName("id_producto");

                entity.HasOne(d => d.IdBeneficioNavigation)
                    .WithMany(p => p.BeneficioxProductos)
                    .HasForeignKey(d => d.IdBeneficio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Beneficio__id_be__6383C8BA");

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.BeneficioxProductos)
                    .HasForeignKey(d => d.IdProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Beneficio__id_pr__6477ECF3");
            });

            modelBuilder.Entity<BeneficioxSubcategorium>(entity =>
            {
                entity.HasKey(e => new { e.IdBeneficio, e.IdSubcategoria })
                    .HasName("PK__Benefici__17E730880367A1CC");

                entity.Property(e => e.IdBeneficio).HasColumnName("id_beneficio");

                entity.Property(e => e.IdSubcategoria).HasColumnName("id_subcategoria");

                entity.HasOne(d => d.IdBeneficioNavigation)
                    .WithMany(p => p.BeneficioxSubcategoria)
                    .HasForeignKey(d => d.IdBeneficio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Beneficio__id_be__5FB337D6");

                entity.HasOne(d => d.IdSubcategoriaNavigation)
                    .WithMany(p => p.BeneficioxSubcategoria)
                    .HasForeignKey(d => d.IdSubcategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Beneficio__id_su__60A75C0F");
            });

            modelBuilder.Entity<Carrito>(entity =>
            {
                entity.HasKey(e => new { e.IdCarrito, e.IdProducto })
                    .HasName("PK__Carrito__4C51EC5CD051EA25");

                entity.ToTable("Carrito");

                entity.Property(e => e.IdCarrito).HasColumnName("id_carrito");

                entity.Property(e => e.IdProducto).HasColumnName("id_producto");

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.Property(e => e.PrecioActual)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("precio_actual");

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.Carritos)
                    .HasForeignKey(d => d.IdProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Carrito__id_prod__5812160E");
            });

            modelBuilder.Entity<Categorium>(entity =>
            {
                entity.HasKey(e => e.IdCategoria)
                    .HasName("PK__Categori__CD54BC5AF8CBED51");

                entity.Property(e => e.IdCategoria).HasColumnName("id_categoria");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PK__Cliente__677F38F5C40D3500");

                entity.ToTable("Cliente");

                entity.Property(e => e.IdCliente).HasColumnName("id_cliente");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("apellido");

                entity.Property(e => e.Cuit).HasColumnName("cuit");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Telefono).HasColumnName("telefono");
            });

            modelBuilder.Entity<Estado>(entity =>
            {
                entity.HasKey(e => e.IdEstado)
                    .HasName("PK__Estados__86989FB22256B1D2");

                entity.Property(e => e.IdEstado).HasColumnName("id_estado");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");
            });

            modelBuilder.Entity<LineaDeVentum>(entity =>
            {
                entity.HasKey(e => new { e.IdVenta, e.IdProducto })
                    .HasName("PK__LineaDeV__8A66727F7E90ACB7");

                entity.Property(e => e.IdVenta).HasColumnName("id_venta");

                entity.Property(e => e.IdProducto).HasColumnName("id_producto");

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.Property(e => e.PrecioActual)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("precio_actual");

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.LineaDeVenta)
                    .HasForeignKey(d => d.IdProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LineaDeVe__id_pr__5441852A");

                entity.HasOne(d => d.IdVentaNavigation)
                    .WithMany(p => p.LineaDeVenta)
                    .HasForeignKey(d => d.IdVenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LineaDeVe__id_ve__534D60F1");
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.IdProducto)
                    .HasName("PK__Producto__FF341C0DA3E8226F");

                entity.ToTable("Producto");

                entity.Property(e => e.IdProducto).HasColumnName("id_producto");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Especificacion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("especificacion");

                entity.Property(e => e.IdStock).HasColumnName("id_stock");

                entity.Property(e => e.IdSubcategoria).HasColumnName("id_subcategoria");

                entity.Property(e => e.Imagen)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("imagen");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Precio)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("precio");

                entity.HasOne(d => d.IdStockNavigation)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.IdStock)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Producto__id_sto__5070F446");

                entity.HasOne(d => d.IdSubcategoriaNavigation)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.IdSubcategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Producto__id_sub__5165187F");
            });

            modelBuilder.Entity<Rol>(entity =>
            {
                entity.HasKey(e => e.IdRol)
                    .HasName("PK__Rol__6ABCB5E002101E26");

                entity.ToTable("Rol");

                entity.Property(e => e.IdRol).HasColumnName("id_rol");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.EstadoRol).HasColumnName("estado_rol");

                entity.HasOne(d => d.EstadoRolNavigation)
                    .WithMany(p => p.Rols)
                    .HasForeignKey(d => d.EstadoRol)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Rol__estado_rol__37A5467C");
            });

            modelBuilder.Entity<RolxUsuario>(entity =>
            {
                entity.HasKey(e => new { e.IdUsuario, e.IdRol })
                    .HasName("PK__RolxUsua__5895CFF3F7C960ED");

                entity.ToTable("RolxUsuario");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.Property(e => e.IdRol).HasColumnName("id_rol");

                entity.HasOne(d => d.IdRolNavigation)
                    .WithMany(p => p.RolxUsuarios)
                    .HasForeignKey(d => d.IdRol)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RolxUsuar__id_ro__3B75D760");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.RolxUsuarios)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RolxUsuar__id_us__3A81B327");
            });

            modelBuilder.Entity<Stock>(entity =>
            {
                entity.HasKey(e => e.IdStock)
                    .HasName("PK__Stock__3A39590AA8FC8AD1");

                entity.ToTable("Stock");

                entity.Property(e => e.IdStock).HasColumnName("id_stock");

                entity.Property(e => e.CantidadActual).HasColumnName("cantidad_actual");

                entity.Property(e => e.PuntoMaximo).HasColumnName("punto_maximo");

                entity.Property(e => e.PuntoMinimo).HasColumnName("punto_minimo");
            });

            modelBuilder.Entity<Subcategorium>(entity =>
            {
                entity.HasKey(e => e.IdSubcategoria)
                    .HasName("PK__Subcateg__FDB38B9E0A10B281");

                entity.Property(e => e.IdSubcategoria).HasColumnName("id_subcategoria");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.IdCategoria).HasColumnName("id_categoria");

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.Subcategoria)
                    .HasForeignKey(d => d.IdCategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Subcatego__id_ca__4BAC3F29");
            });

            modelBuilder.Entity<Test>(entity =>
            {
                entity.ToTable("Test");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Prueba)
                    .HasMaxLength(50)
                    .HasColumnName("prueba");
            });

            modelBuilder.Entity<TipoBeneficio>(entity =>
            {
                entity.HasKey(e => e.IdTipoBeneficio)
                    .HasName("PK__TipoBene__CFE5FB24E0BD038B");

                entity.ToTable("TipoBeneficio");

                entity.Property(e => e.IdTipoBeneficio).HasColumnName("id_tipo_beneficio");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__Usuario__4E3E04AD7C668295");

                entity.ToTable("Usuario");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("apellido");

                entity.Property(e => e.Contraseña)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("contraseña");

                entity.Property(e => e.Cuit).HasColumnName("cuit");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.EstadoUsuario).HasColumnName("estado_usuario");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Telefono).HasColumnName("telefono");

                entity.HasOne(d => d.EstadoUsuarioNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.EstadoUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Usuario__estado___34C8D9D1");
            });

            modelBuilder.Entity<Ventum>(entity =>
            {
                entity.HasKey(e => e.IdVenta)
                    .HasName("PK__Venta__459533BF204BC06A");

                entity.Property(e => e.IdVenta).HasColumnName("id_venta");

                entity.Property(e => e.IdCliente).HasColumnName("id_cliente");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("total");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.Venta)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("FK__Venta__id_client__46E78A0C");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Venta)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK__Venta__id_usuari__45F365D3");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
