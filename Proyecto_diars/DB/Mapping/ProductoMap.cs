using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proyecto_diars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_diars.DB.Mapping
{
    public class ProductoMap : IEntityTypeConfiguration<Producto>
    {
        public void Configure(EntityTypeBuilder<Producto> builder)
        {
            builder.ToTable("Producto");
            builder.HasKey(o=> o.Id_producto);

            builder.HasOne(o => o.categorias)
               .WithMany(o=>o.productos)
              .HasForeignKey(o => o.Id_Categoria);


        }
    }
}
