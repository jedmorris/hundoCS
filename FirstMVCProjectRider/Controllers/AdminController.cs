using Microsoft.AspNetCore.Mvc;

namespace FirstMVCProjectRider.Controllers;

public class AdminController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}