using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_diars.Models
{
    public class Producto
    {
        public int Id_producto { get; set; }
        public int Id_Categoria { get; set; }
        public decimal Precio { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; }
        public List<Detalle_Reserva> detalle_Reservas{ get; set; }
        public List<Carrito> carrito { get; set; }
        //public Reserva reserva { get; set; }
     public Categorias categorias { get; set; }

    }
}
