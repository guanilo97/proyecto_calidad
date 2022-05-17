using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proyecto_diars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_diars.DB.Mapping
{
    public class ReservaMap : IEntityTypeConfiguration<Reserva>
    {
        public void Configure(EntityTypeBuilder<Reserva> builder)
        {
            builder.ToTable("Reserva");
            builder.HasKey(o => o.Id);

            builder.HasOne(o => o.mesa).WithMany().HasForeignKey(o => o.Id_Mesa);
            builder.HasOne(o => o.usuario).WithMany().HasForeignKey(o => o.Id_Usuario);
            builder.HasOne(o => o.estado_Pedido).WithMany().HasForeignKey(o => o.Id_Estado_Pedido);
            //  builder.HasOne(o => o.cartass).WithMany().HasForeignKey(o => o.Cartaid);
        }
    }
}
