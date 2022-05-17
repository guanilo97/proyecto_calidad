using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proyecto_diars.Models;

namespace Proyecto_diars.DB.Mapping
{
    public class Detalle_ReservaMap : IEntityTypeConfiguration<Detalle_Reserva>
    {
        public void Configure(EntityTypeBuilder<Detalle_Reserva> builder)
        {
            builder.ToTable("Detalle_Reserva");
            builder.HasKey(o => o.Id);
            //builder.HasOne(o => o.reserva).WithMany().HasForeignKey(o => o.Id_Reserva);
            builder.HasOne(o => o.productos).WithMany(o=>o.detalle_Reservas).HasForeignKey(o => o.Id_producto);
            builder.HasOne(o => o.reserva).WithMany(o => o.detalle_Reservas).HasForeignKey(o => o.Id_Reserva);
            builder.HasOne(o => o.estado).WithMany(o => o.estado_pedidos).HasForeignKey(o => o.Id_Estado);

        }
    }
}
