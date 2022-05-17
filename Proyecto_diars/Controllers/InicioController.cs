using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proyecto_diars.DB;
using Proyecto_diars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_diars.Controllers
{
    public class InicioController : Controller
    {
        private AppCartaContext context;
        public InicioController(AppCartaContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {

            return View();
        }
        public IActionResult carta()
        {
            var carta = context.cartas.ToList();
            return View(carta);
        }
        public IActionResult detallepedido(int id)
        {
            if (getlooged().Id_Rol != 1)
            {
                return RedirectToAction("Logaut", "Auth");
            }

            ViewBag.Idreserva = id;
            var dere = context.detalle_Reservas.Where(o => o.Id_Reserva ==id).Include(o => o.productos).ToList();
            return View(dere);
        }
        [Authorize]
        public IActionResult reservas()
        {
            if (getlooged().Id_Rol != 1)
            {
                return RedirectToAction("Logaut", "Auth");
            }

            var re = context.reservas.Where(o=>o.Id_Usuario==getlooged().Id).Include(o => o.mesa).ToList();
            return View(re);
        }
        public IActionResult menus()
        {
            var re = context.cartas.Where(o => o.Id_Categoria == 3).ToList();
            return View(re);
        }
        public IActionResult Detalle(int id)
        {
            if (getlooged().Id_Rol != 1)
            {
                return RedirectToAction("Logaut", "Auth");
            }

            var carta = context.cartas;

            Producto carta1 = carta.FirstOrDefault(item => item.Id_producto == id);
            return View(carta1);
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
