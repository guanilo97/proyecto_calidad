using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proyecto_diars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_diars.DB.Mapping
{
    public class Estado_MesaMap : IEntityTypeConfiguration<Estado_Mesa>
    {
        public void Configure(EntityTypeBuilder<Estado_Mesa> builder)
        {
            builder.ToTable("Estado_Mesa");
            builder.HasKey(o => o.Id);
        }
    }
}
