using Microsoft.AspNetCore.Mvc;

namespace PartialViewExample.Controllers;

[Route("[controller]")]
public class ProductsController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [Route("About")]
    public IActionResult About()
    {
        return View();
    }

}
