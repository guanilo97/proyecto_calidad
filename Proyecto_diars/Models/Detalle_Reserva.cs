using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_diars.Models
{
    public class Detalle_Reserva
    {
        public int Id { get; set; }
        public int Id_Reserva { get; set; }
        public int Id_producto { get; set; }
        public int Cantidad { get; set; }
        public decimal Subtotal { get; set; }
        public int Id_Estado { get; set; }
        public Producto productos { get; set; }
        public Reserva reserva { get; set; }
        public Estado_Pedido estado { get; set; }
    }
}
