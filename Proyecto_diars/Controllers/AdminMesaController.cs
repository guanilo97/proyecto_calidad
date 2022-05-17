using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Proyecto_diars.DB;
using Proyecto_diars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_diars.Controllers
{
    [Authorize]
    public class AdminMesaController : Controller
    {
        private AppCartaContext context;
        public AdminMesaController(AppCartaContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            if (getlooged().Id_Rol != 2)
            {
                return RedirectToAction("Logaut", "Auth");
            }

            var mesas = context.mesas.ToList();
            return View(mesas);
        }

        public IActionResult Create()
        {
            if (getlooged().Id_Rol != 2)
            {
                return RedirectToAction("Logaut", "Auth");
            }

            return View();
        }

        [HttpPost]
        public IActionResult Create(Mesa mesa)
        {
            if (getlooged().Id_Rol != 2)
            {
                return RedirectToAction("Logaut", "Auth");
            }

            //mesa.Disponible = true;
            context.mesas.Add(mesa);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Mesas_libres(DateTime Fecha, TimeSpan hora)
        {
            List<Mesa> mesas=new List<Mesa>();
           var mesa = context.mesas.ToList();
            for (int i = 0; i < mesa.Count(); i++)
            {
                var esta_ocupado = context.estado_mesas.Any(o => o.Fecha == Fecha & o.Hora == hora & o.Id_mesa == mesa[i].Id);

                if (esta_ocupado == false)
                {
                    Mesa mesa1 = mesa[i];
                    mesas.Add(mesa1);
                }
            }
            return View(mesas);
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
