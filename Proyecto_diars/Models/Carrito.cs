using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_diars.Models
{
    public class Carrito
    {
        public int Id { get; set; }
        public int Id_Reserva { get; set; }
        public int Id_Usuario { get; set; }
        public int Id_producto { get; set; }
        [Required(ErrorMessage = ("cantidad es obligatorio"))]
        public int Cantidad { get; set; }
        public decimal Subtotal { get; set; }
        public Producto producto { get; set; }
    }
}
