using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proyecto_diars.Models;

namespace Proyecto_diars.DB.Mapping
{
    public class CategoriasMap : IEntityTypeConfiguration<Categorias>
    {
        public void Configure(EntityTypeBuilder<Categorias> builder)
        {
            builder.ToTable("Categorias");
            builder.HasKey(o => o.Id);
        }
    }
}
