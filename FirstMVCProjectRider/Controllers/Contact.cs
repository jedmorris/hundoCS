using Microsoft.AspNetCore.Mvc;

namespace FirstMVCProjectRider.Controllers;

public class Contact : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}