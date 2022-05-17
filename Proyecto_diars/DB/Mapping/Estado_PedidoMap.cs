using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proyecto_diars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_diars.DB.Mapping
{
     public class Estado_PedidoMap : IEntityTypeConfiguration<Estado_Pedido>
    {
        public void Configure(EntityTypeBuilder<Estado_Pedido> builder)
        {
            builder.ToTable("Estado_Pedido");
            builder.HasKey(o => o.Id);
        }
    }
}
