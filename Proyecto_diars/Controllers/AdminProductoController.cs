using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proyecto_diars.DB;
using Proyecto_diars.Models;

namespace Proyecto_diars.Controllers
{
    [Authorize]
    public class AdminProductoController : Controller
    {
        private AppCartaContext context;
        private IWebHostEnvironment hosting;
        public AdminProductoController(AppCartaContext context, IWebHostEnvironment hosting)
        {
            this.context = context;
            this.hosting = hosting;
        }
        public IActionResult Index( int IdCategoria)
        {
            if (getlooged().Id_Rol != 2)
            {
                return RedirectToAction("Logaut", "Auth");
            }

            List<Producto> productos = null;
            if(IdCategoria==0)
            {
               productos= context.cartas.Include(o => o.categorias).ToList();
            }
            else
            {
                productos= context.cartas.Include(o => o.categorias).Where(o=>o.Id_Categoria==IdCategoria).ToList();
            }
            ViewBag.categorias = context.categorias.ToList();
            return View(productos);
        }
        [HttpGet]
        public IActionResult Create()
        {
            if (getlooged().Id_Rol != 2)
            {
                return RedirectToAction("Logaut", "Auth");
            }

            ViewBag.categorias = context.categorias.ToList();
            return View(new Producto());
        }
        [HttpPost]
        public IActionResult Create(Producto producto, IFormFile file)
        {
            if (getlooged().Id_Rol != 2)
            {
                return RedirectToAction("Logaut", "Auth");
            }

            if (ModelState.IsValid)
            {
                producto.Imagen = SaveFile(file);
                context.cartas.Add(producto);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.categorias = context.categorias.ToList();
            return View("Create");
        }
        private string SaveFile(IFormFile file)
        {
            string relativePaht = null;
            if (file.Length > 0)
            {
                relativePaht = Path.Combine("files", file.FileName);
                var filePaht = Path.Combine(hosting.WebRootPath, relativePaht);
                var stream = new FileStream(filePaht, FileMode.Create);
                file.CopyTo(stream);
                stream.Close();

            }
            return "/" + relativePaht.Replace('\\', '/');

        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            if (getlooged().Id_Rol != 2)
            {
                return RedirectToAction("Logaut", "Auth");
            }

            var produ = context.cartas.FirstOrDefault(o => o.Id_producto == id);
            return View(produ);
        }
        [HttpPost]
        public IActionResult Edit(Producto producto, IFormFile file)
        {
            if (getlooged().Id_Rol != 2)
            {
                return RedirectToAction("Logaut", "Auth");
            }

            var produ_db = context.cartas.Find(producto.Id_producto);
            produ_db.Nombre = producto.Nombre;
            if(producto.Imagen!= null)
            {
                produ_db.Imagen = producto.Imagen;
            }
            produ_db.Precio = producto.Precio;
            produ_db.Descripcion = producto.Descripcion;
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
