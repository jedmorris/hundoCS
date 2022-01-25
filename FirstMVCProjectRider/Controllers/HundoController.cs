using Microsoft.AspNetCore.Mvc;
using FirstMVCProjectRider.Models;
namespace FirstMVCProjectRider.Controllers;

public class HundoController : Controller
{
    // GET
    public IActionResult Index()
    {
        HundoResults hr = new HundoResults();
        return View(hr);
    }

    [HttpPost]
    public IActionResult Index(HundoResults hr)
    {
        int startValue = hr.StartValue;
        int endValue = hr.EndValue;
        var hundoItems = new List<string>();
       
        for (int i = startValue; i < endValue; i++)
        {
            hundoItems.Add(i.ToString());
        }

        hr.HundoNumbers = hundoItems;
        // get a list of numbers
        return View(hr);
    }
}