using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proyecto_diars.Models;

namespace Proyecto_diars.DB.Mapping
{
    public class CarritoMap : IEntityTypeConfiguration<Carrito>
    {
public void Configure(EntityTypeBuilder<Carrito> builder)
        {
            builder.ToTable("Carrito");
            builder.HasKey(o => o.Id);

            // builder.(o => o.producto).WithOne().HasForeignKey(o => o.Id_producto);
            builder.HasOne(o => o.producto).WithMany(o=>o.carrito).HasForeignKey(o => o.Id_producto);
        }
    }
}
