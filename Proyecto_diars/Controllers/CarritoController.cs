using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proyecto_diars.DB;
using Proyecto_diars.Models;

namespace Proyecto_diars.Controllers
{
    [Authorize]
    public class CarritoController : Controller
    {
        private AppCartaContext context;
        public CarritoController(AppCartaContext context)
        {
            this.context = context;
        }
        public IActionResult Carrito()
        {
            if (getlooged().Id_Rol != 1)
            {
                return RedirectToAction("Logaut", "Auth");
            }

            ViewBag.mesa = context.mesas.ToList();
            var pro= context.carritos.Include(o=>o.producto).Where(o=>o.Id_Usuario==getlooged().Id).ToList();
            return View(pro);
        }
       
        [HttpPost]
        public IActionResult Create(Carrito carrito)
        {
            if (getlooged().Id_Rol != 1)
            {
                return RedirectToAction("Logaut", "Auth");
            }
            if (ModelState.IsValid)
            {
                var producto = context.cartas.Where(o => o.Id_producto == carrito.Id_producto).First();
                carrito.Subtotal = producto.Precio * carrito.Cantidad;
                carrito.Id_Usuario = getlooged().Id;
                context.carritos.Add(carrito);
                context.SaveChanges();
                return RedirectToAction("carta", "Inicio");
            }
            return RedirectToAction("carta", "Inicio");
          
        }
        public IActionResult Eliminar(int id)
        {
            context.carritos.Remove(context.carritos.FirstOrDefault(o=>o.Id==id));
            context.SaveChanges();
            return RedirectToAction("carrito","carrito");
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
