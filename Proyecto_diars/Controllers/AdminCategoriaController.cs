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
    public class AdminCategoriaController : Controller
    {
        private AppCartaContext context;

        public AdminCategoriaController(AppCartaContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            if (getlooged().Id_Rol != 2)
            {
                return RedirectToAction("Logaut", "Auth");
            }

            var categorias = context.categorias.ToList();
            return View(categorias);
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
        public IActionResult Create(Categorias categoria)
        {
            if (getlooged().Id_Rol != 2)
            {
                return RedirectToAction("Logaut", "Auth");
            }

            context.categorias.Add(categoria);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Eliminar(int id)
        {
            if (getlooged().Id_Rol != 2)
            {
                return RedirectToAction("Logaut", "Auth");
            }

            var categoria = context.categorias.Find(id);
            context.categorias.Remove(categoria);
            context.SaveChanges();
            return RedirectToAction("Index");
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
