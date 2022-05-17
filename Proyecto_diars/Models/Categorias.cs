using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_diars.Models
{
    public class Categorias
    {
        public int Id { get; set; }
        public string Nombre_Categoria { get; set; }

        public List<Producto> productos { get; set; }
    }
}
