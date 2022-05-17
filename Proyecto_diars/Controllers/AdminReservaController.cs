using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Proyecto_diars.DB;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Proyecto_diars.Models;
using Microsoft.AspNetCore.Authorization;

namespace Proyecto_diars.Controllers
{
    [Authorize]
    public class AdminReservaController : Controller
    {
        private AppCartaContext context;
        public AdminReservaController(AppCartaContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            if (getlooged().Id_Rol != 2)
            {
                return RedirectToAction("Logaut", "Auth");
            }

            ViewBag.EstadoPedido = context.Estado_Pedidos.ToList();
            var rese = context.reservas.Include(o => o.mesa).Include(o => o.estado_Pedido).Include(o => o.usuario).ToList();
            return View(rese);
        }
        public IActionResult Reservadia()
        {
            if (getlooged().Id_Rol != 2)
            {
                return RedirectToAction("Logaut", "Auth");
            }

            ViewBag.EstadoPedido = context.Estado_Pedidos.ToList();
            var rese = context.reservas.Include(o => o.mesa).Include(o => o.usuario).Include(o=>o.estado_Pedido).Where(o=>o.Fecha==DateTime.Now.Date).ToList();
            return View(rese);
        }
        public bool CambiarEstado(int idreserva, string estadopedido)
        {
            var reserva = context.reservas.FirstOrDefault(o => o.Id == idreserva);
                if (estadopedido == "En atencion")
                {
                   reserva.Id_Estado_Pedido = 3;
                   context.SaveChanges();
                    return true;
                }
            if (estadopedido == "Finalizado")
            {
                reserva.Id_Estado_Pedido = 4;
                context.SaveChanges();
                return true;
            }
            if (estadopedido == "Reservado")
            {
                reserva.Id_Estado_Pedido = 2;
                context.SaveChanges();
                return true;
            }
            if (estadopedido == "No llego")
            {
                reserva.Id_Estado_Pedido = 2;
                context.reservas.Remove(reserva);
                context.SaveChanges();
                return true;
            }
            return false;
        }
        public IActionResult detallepedido(int idreserva)
        {
            if (getlooged().Id_Rol != 2)
            {
                return RedirectToAction("Logaut", "Auth");
            }

            ViewBag.Idreserva = idreserva;
            var dere = context.detalle_Reservas.Where(o => o.Id_Reserva == idreserva).Include(o => o.productos).ToList();
            return View(dere);
        }
        private Usuario getlooged()
        {
            var claims = HttpContext.User.Claims.First();
            string username = claims.Value;
            var user = context.Usuarios.First(o => o.Username == username);
            return user;
        }
    }
}
