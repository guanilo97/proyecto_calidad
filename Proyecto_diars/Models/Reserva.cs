using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_diars.Models
{
    public class Reserva
    {
        public int Id { get; set; }
        public int Id_Usuario { get; set; }
        [Required(ErrorMessage = ("cantidad es obligatorio"))]
        public DateTime Fecha { get; set; }
        [Required(ErrorMessage = ("cantidad es obligatorio"))]
        public TimeSpan Hora { get; set; }
        [Required(ErrorMessage = ("cantidad es obligatorio"))]
        public int N_personas { get; set; }
        [Required(ErrorMessage = ("cantidad es obligatorio"))]
        public int Id_Mesa { get; set; }
        [Required(ErrorMessage = ("cantidad es obligatorio"))]
        public int Id_Estado_Pedido {get;set;}
        public Estado_Pedido estado_Pedido { get; set; }
        public Mesa mesa { get; set; }
        public Usuario usuario { get; set; }
        public List<Detalle_Reserva> detalle_Reservas { get; set; }

        public decimal Total { get; set; }
    }
}
