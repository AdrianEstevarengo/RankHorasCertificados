using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RankHorasCertificados.Data;
using RankHorasCertificados.Models;
using System.Diagnostics;

namespace RankHorasCertificados.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly RankHorasCertificadosContext _context;

        public HomeController(ILogger<HomeController> logger, RankHorasCertificadosContext context)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var usuarios = await _context.UsuarioModel.Include(u => u.Cursos).ToListAsync();
            return View(usuarios);
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
    }
}
