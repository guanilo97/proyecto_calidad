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
    public class ReservaController : Controller
    {
        private AppCartaContext context;
        public ReservaController(AppCartaContext context)
        {
            this.context = context;
        }
        [Authorize]
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.mesa = context.mesas.ToList();

            var reserva = context.reservas.ToList();
            return View(reserva);
        }
        [Authorize]
        [HttpPost]
        public IActionResult Create(Reserva reserva)
        {
            if (getlooged().Id_Rol != 1)
            {
                return RedirectToAction("Logaut", "Auth");
            }
            if (ModelState.IsValid)
            {
                reserva.Id_Usuario = getlooged().Id;
                reserva.Id_Estado_Pedido = 2;
                context.reservas.Add(reserva);
                context.SaveChanges();

                var carrito = context.carritos.Where(o => o.Id_Usuario == getlooged().Id).ToList();
                var detalle_reserva = new Detalle_Reserva();
                var reservas = context.reservas.Where(o => o.Id_Usuario == getlooged().Id).ToList();
                var numreserva = reservas.Count();
                for (int i = 0; i < carrito.Count(); i++)
                {
                    detalle_reserva.Id = context.detalle_Reservas.Count() + 1;
                    detalle_reserva.Id_Reserva = reservas[numreserva - 1].Id;
                    detalle_reserva.Id_producto = carrito[i].Id_producto;
                    detalle_reserva.Cantidad = carrito[i].Cantidad;
                    detalle_reserva.Subtotal = carrito[i].Subtotal;
                    detalle_reserva.Id_Estado = 2;//pasar a string
                    context.detalle_Reservas.Add(detalle_reserva);
                    context.SaveChanges();
                    var car = context.carritos.Where(o => o.Id == carrito[i].Id);
                    context.carritos.Remove(carrito[i]);
                    context.SaveChanges();
                }
                Estado_Mesa estado_mesa = new Estado_Mesa();
                estado_mesa.Id_mesa = reserva.Id_Mesa;
                estado_mesa.Fecha = reserva.Fecha;
                estado_mesa.Hora = reserva.Hora;
                context.estado_mesas.Add(estado_mesa);
                context.SaveChanges();
                return RedirectToAction("reservas", "Inicio");
            }
            return RedirectToAction("carrito", "carrito");
        }
        [HttpGet]
        public IActionResult AgregarProducto(int id)
        {
            if (getlooged().Id_Rol != 1)
            {
                return RedirectToAction("Logaut", "Auth");
            }
            ViewBag.Idreserva = id;
            var carta = context.cartas.ToList();
            return View(carta);
        }
        [HttpPost]
        public IActionResult AgregarProducto(Detalle_Reserva detalle)
        {
            if (getlooged().Id_Rol != 1)
            {
                return RedirectToAction("Logaut", "Auth");
            }
            var detalles = context.detalle_Reservas.ToList();
            var detallepe = context.detalle_Reservas.Count();
            var numerodetalle = detalles[detallepe-1].Id;
            detalle.Id =numerodetalle+1;
            var producto = context.cartas.Where(o => o.Id_producto == detalle.Id_producto).First();
            detalle.Subtotal = producto.Precio * detalle.Cantidad;
            detalle.Id_Estado = 2;
            context.detalle_Reservas.Add(detalle);
            context.SaveChanges();
            return RedirectToAction("detallepedido", "Inicio", new { id=detalle.Id_Reserva }
);
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
