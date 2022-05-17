using Microsoft.EntityFrameworkCore;
using Proyecto_diars.DB.Mapping;
using Proyecto_diars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_diars.DB
{
    public class AppCartaContext:DbContext
    {
        public DbSet<Producto> cartas { get; set; }
        public DbSet<Categorias> categorias { get; set; }
        public DbSet<Mesa> mesas { get; set; }
        public DbSet<Estado_Mesa> estado_mesas { get; set; }
        public DbSet<Carrito> carritos { get; set; }
        public DbSet<Detalle_Reserva> detalle_Reservas { get; set; }
        public DbSet<Reserva> reservas { get;set ;}
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Estado_Pedido> Estado_Pedidos { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public AppCartaContext(DbContextOptions<AppCartaContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ProductoMap());
            modelBuilder.ApplyConfiguration(new ReservaMap());
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new MesaMap());
            modelBuilder.ApplyConfiguration(new CarritoMap());
            modelBuilder.ApplyConfiguration(new CategoriasMap());
            modelBuilder.ApplyConfiguration(new Detalle_ReservaMap());
            modelBuilder.ApplyConfiguration(new Estado_PedidoMap());
            modelBuilder.ApplyConfiguration(new Estado_MesaMap());
            modelBuilder.ApplyConfiguration(new RolMap());
        }
    }
}
