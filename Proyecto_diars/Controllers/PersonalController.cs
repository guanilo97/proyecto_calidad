using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Proyecto_diars.DB;
using Proyecto_diars.Models;

namespace Proyecto_diars.Controllers
{
    [Authorize]
    public class PersonalController : Controller
    {
        private AppCartaContext context;
        private IConfiguration configuration;
        public PersonalController(AppCartaContext context, IConfiguration configuration)
        {
            this.configuration = configuration;
            this.context = context;
        }
        public IActionResult Cocina()
        {
            if (getlooged().Id_Rol != 5)
            {
                return RedirectToAction("Logaut", "Auth");
            }

            ViewBag.Productos = context.cartas.ToList();
            ViewBag.Estados = context.Estado_Pedidos.ToList();
            var re = context.reservas.Where(o => o.Id_Estado_Pedido == 3).Include(o => o.mesa).Include(o => o.usuario).Include(z => z.estado_Pedido).Include(z=>z.detalle_Reservas).ToList();
            return View(re);
        }
        public IActionResult Moso()
        {
            if (getlooged().Id_Rol != 3)
            {
                return RedirectToAction("Logaut", "Auth");
            }

            var re = context.reservas.Where(o =>o.Id_Estado_Pedido==3).Include(o => o.mesa).Include(o => o.usuario).ToList();
            return View(re);
        }
        public IActionResult detallepedido(int id)
        {
            if (getlooged().Id_Rol != 3)
            {
                return RedirectToAction("Logaut", "Auth");
            }

            ViewBag.Idreserva = id;
            var dere = context.detalle_Reservas.Where(o => o.Id_Reserva == id).Include(o => o.productos).Include(a=>a.estado).ToList();
            return View(dere);
        }
        [HttpGet]
        public IActionResult AgregarProducto_Moso(int idreserva)
        {
            if (getlooged().Id_Rol != 3)
            {
                return RedirectToAction("Logaut", "Auth");
            }

            ViewBag.Idreserva = idreserva;
            return View(context.cartas.ToList());
        }
        [HttpPost]
        public IActionResult AgregarProducto_Moso(int idreserva, int idproducto, int cantidad)
        {
            if (getlooged().Id_Rol != 3)
            {
                return RedirectToAction("Logaut", "Auth");
            }

            var producto = context.cartas.FirstOrDefault(a => a.Id_producto == idproducto);
            ViewBag.Idreserva = idreserva;
            var detalles = context.detalle_Reservas.ToList();
            int cant_detalles = detalles.Count();

            Detalle_Reserva detalle_Reserva = new Detalle_Reserva();
            detalle_Reserva.Id = detalles[cant_detalles - 1].Id + 1;
            detalle_Reserva.Id_Reserva = idreserva;
            detalle_Reserva.Id_producto = idproducto;
            detalle_Reserva.Id_Estado = 2;
            detalle_Reserva.Cantidad = cantidad;
            detalle_Reserva.Subtotal = producto.Precio * cantidad;
            context.detalle_Reservas.Add(detalle_Reserva);
            context.SaveChanges();

            return RedirectToAction("detallepedido", "Personal", new{id=idreserva });
        }

        public IActionResult finalizaratencion(int id)
        {
            if (getlooged().Id_Rol != 3)
            {
                return RedirectToAction("Logaut", "Auth");
            }

            var reserva = context.reservas.FirstOrDefault(o => o.Id == id);
            reserva.Id_Estado_Pedido = 4;
            context.SaveChanges();
            return RedirectToAction("Moso", "Personal");
        }
        private Usuario getlooged()
        {
            var claims = HttpContext.User.Claims.First();
            string username = claims.Value;
            var user = context.Usuarios.First(o => o.Username == username);
            return user;
        }
        public bool CambiarEstadoPlato(int iddetalle)
        {

            var detalle = context.detalle_Reservas.FirstOrDefault(a => a.Id == iddetalle);
            detalle.Id_Estado = 5;
            context.SaveChanges();
            return true;
        }
        [HttpGet]
        public IActionResult EliminarDetallePedido(int iddetalle)
        {
            if (getlooged().Id_Rol != 3)
            {
                return RedirectToAction("Logaut", "Auth");
            }
            var detalle = context.detalle_Reservas.FirstOrDefault(a => a.Id == iddetalle);
            context.Remove(detalle);
            context.SaveChanges();
            return RedirectToAction("detallepedido", "Personal", new { id = detalle.Id_Reserva });
        }
        //[HttpGet]
        //public IActionResult AgregarProducto_Moso(int idreserva)
        //{
        //    var lista = context.detalle_Reservas.Where(a => a.Id_Reserva == idreserva).ToList();
        //    return View();
        //}
        public IActionResult IndexCajero()
        {
            if (getlooged().Id_Rol != 4)
            {
                return RedirectToAction("Logaut", "Auth");
            }

            decimal total = 0;
            var reservas = context.reservas.Where(a => a.Id_Estado_Pedido == 4).Include(a=>a.mesa).Include(a=>a.usuario).ToList();
            for(int i = 0; i < reservas.Count; i++)
            {
                var detalle = context.detalle_Reservas.Where(a => a.Id_Reserva == reservas[i].Id).ToList();
                for (int j = 0; j < detalle.Count; j++)
                {
                    total = total + detalle[j].Subtotal;
                }
                reservas[i].Total = total;
                total = 0;
            }
            return View(reservas);
        }
        public IActionResult DetallePedidoCajero(int idreserva)
        {
            if (getlooged().Id_Rol != 4)
            {
                return RedirectToAction("Logaut", "Auth");
            }

            ViewBag.Idreserva = idreserva;
            var dere = context.detalle_Reservas.Where(o => o.Id_Reserva == idreserva).Include(o => o.productos).ToList();
            return View(dere);
        }
        public IActionResult PagarReserva(int idreserva)
        {
            if (getlooged().Id_Rol != 4)
            {
                return RedirectToAction("Logaut", "Auth");
            }
            var reserva = context.reservas.FirstOrDefault(a=>a.Id==idreserva);
            reserva.Id_Estado_Pedido = 7;
            context.SaveChanges();
            return RedirectToAction("IndexCajero", "Personal");
        }
        public IActionResult HistorialReservas()
        {
            if (getlooged().Id_Rol != 2)
            {
                return RedirectToAction("Logaut", "Auth");
            }

            decimal total = 0;
            var reservas = context.reservas.Where(a => a.Id_Estado_Pedido == 7).Include(a => a.mesa).Include(a => a.usuario).ToList();
            for (int i = 0; i < reservas.Count; i++)
            {
                var detalle = context.detalle_Reservas.Where(a => a.Id_Reserva == reservas[i].Id).ToList();
                for (int j = 0; j < detalle.Count; j++)
                {
                    total = total + detalle[j].Subtotal;
                }
                reservas[i].Total = total;
                total = 0;
            }
            return View(reservas);
        }
        public IActionResult DetalleHistorial(int idreserva)
        {
            if (getlooged().Id_Rol != 2)
            {
                return RedirectToAction("Logaut", "Auth");
            }
            ViewBag.Idreserva = idreserva;
            var dere = context.detalle_Reservas.Where(o => o.Id_Reserva == idreserva).Include(o => o.productos).ToList();
            return View(dere);
        }
        public IActionResult listar()
        {

            var listar = context.Usuarios.Where(o => o.Id_Rol == 2|| o.Id_Rol == 3 || o.Id_Rol == 4 || o.Id_Rol == 5).ToList();
            ViewBag.rol = context.Roles.ToList();
            return View(listar);
        }
        [HttpGet]
        public IActionResult create()
        {
            ViewBag.rol = context.Roles.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult create( Usuario usuario)
        {
            usuario.Password = CreateHash(usuario.Password);
            context.Usuarios.Add(usuario);
            context.SaveChanges();
            return View("create","Personal");
        }
        private string CreateHash(string input)
        {
            input += configuration.GetValue<string>("Key");
            var sha = SHA512.Create();
            var bytes = Encoding.Default.GetBytes(input);
            var hash = sha.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }
    }
}
