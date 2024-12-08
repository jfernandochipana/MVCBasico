using AspNetCoreGeneratedDocument;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCBasico.Models;
using System.Diagnostics;

namespace MVCBasico.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Pagar(string nombre, double precio)
        {
            //var producto = new Auricular { nombre = nombre, precio = precio };
            ViewBag.Nombre = nombre;
            ViewBag.Precio = precio;
            // retorna una vista e indico el nombre de la vista
            return View("Carrito");
        }

        public IActionResult Confirmacion()
        {
            //var producto = new Auricular { nombre = nombre, precio = precio };

            // retorna una vista e indico el nombre de la vista
            return View("Pagado");
        }

    }
}
