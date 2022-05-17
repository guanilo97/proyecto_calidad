using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_diars.Models
{
    public class Estado_Pedido
    {
        public int Id { get; set; }
        public string Nombre_Estado { get; set; }
        public List<Detalle_Reserva> estado_pedidos { get; set; }
    }
}
