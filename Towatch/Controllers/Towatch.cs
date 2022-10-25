using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Towatch.Models;

namespace Towatch.Controllers;

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

    
}
