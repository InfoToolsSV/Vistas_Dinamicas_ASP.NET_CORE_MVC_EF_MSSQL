using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using VistasDinamicas.Data;
using VistasDinamicas.Models;
using VistasDinamicas.ViewModels;

namespace VistasDinamicas.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly AppDbContext _context;

    public HomeController(ILogger<HomeController> logger, AppDbContext contexto)
    {
        _logger = logger;
        _context = contexto;
    }

    public IActionResult Detalles(int id)
    {
        var productos = _context.Productos.ToList();

        var productoSeleccionado = productos.FirstOrDefault(p => p.Id == id);

        var viewModel = new ProductosViewModel
        {
            Productos = productos,
            ProductoSeleccionado = productoSeleccionado
        };

        return View(viewModel);
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
}
