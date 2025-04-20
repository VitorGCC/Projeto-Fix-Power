using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProjetoDs.Models;
using ProjetoDs.Data;

namespace ProjetoDs.Controllers;

public class FixPowerController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public FixPowerController(ILogger<HomeController> logger)
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
}
