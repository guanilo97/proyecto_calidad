using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Proyecto_diars.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Session;
using System.Threading.Tasks;
using Proyecto_diars.Models;

namespace Proyecto_diars.Controllers
{
    public class AuthController : Controller
    {
        private AppCartaContext context;
        private IConfiguration configuration;
        public AuthController(AppCartaContext context, IConfiguration configuration)
        {
            this.context = context;
            this.configuration = configuration;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            var user = context.Usuarios
               .FirstOrDefault(o => o.Username == username && o.Password == CreateHash(password));
            //  var user = context.Usuarios.FirstOrDefault(o => o.Username == usernme && o.Password == CreateHash(password));
            if (user == null)
            {
                TempData["AuthMessaje"] = "Usuario o password incorrectos";
                return RedirectToAction("Login");
            }
            else
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.Username),

                };
                //session[];

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                HttpContext.SignInAsync(claimsPrincipal);

                if (user.Id_Rol == 1)
                {
                    return RedirectToAction("Index","Inicio");
                }
                if (user.Id_Rol == 2)
                {
                    return RedirectToAction("Reservadia", "AdminReserva");
                }
                if (user.Id_Rol == 3)
                {
                    return RedirectToAction("Moso", "Personal");
                }
                if (user.Id_Rol == 4)
                {
                    return RedirectToAction("IndexCajero", "Personal");
                }
                if (user.Id_Rol == 5)
                {
                    return RedirectToAction("Cocina", "Personal");
                }
            }
            
            return View();

        }
        [HttpGet]
        public IActionResult Logaut()
        {
            HttpContext.SignOutAsync();
            return RedirectToAction("Login");
        }
        [HttpGet]
        public IActionResult Create()
        {
            var user = context.Usuarios.ToList();
            return View(user);
            //return CreateHash(password);
        }
        [HttpPost]
        public IActionResult Create(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                usuario.Password = CreateHash(usuario.Password);
                usuario.Id_Rol = 1;
                context.Usuarios.Add(usuario);
                context.SaveChanges();
                return RedirectToAction("Login");
            }
            return View();
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
