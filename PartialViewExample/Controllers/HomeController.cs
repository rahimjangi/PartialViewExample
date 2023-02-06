using Microsoft.AspNetCore.Mvc;
using PartialViewExample.Models;

namespace PartialViewExample.Controllers;

[Route("[controller]")]
public class HomeController : Controller
{
    [Route("/")]
    public IActionResult Index()
    {
        //List<Country>countries= new List<Country>();
        //countries.Add(new Country() { CountryName = "London" });
        //countries.Add(new Country() { CountryName = "Rome" });
        //countries.Add(new Country() { CountryName = "Frankfort" });
        return View();
    }

    [Route("About")]
    public IActionResult About()
    {
        //List<Country> countries = new List<Country>();
        //countries.Add(new Country() { CountryName = "London" });
        //countries.Add(new Country() { CountryName = "Rome" });
        //countries.Add(new Country() { CountryName = "Frankfort" });
        //countries.Add(new Country() { CountryName = "Manchester" });
        //countries.Add(new Country() { CountryName = "Derry" });
        //ViewData[nameof(countries)] = countries;
        return View();
    }

    [Route("firend-list")]
    public IActionResult LoadFirendsList()
    {
        List<Person> persons = new List<Person>();
        persons.Add(new Person() { Name = "firend 1", Description = "description 1" });
        persons.Add(new Person() { Name = "firend 2", Description = "description 2" });
        persons.Add(new Person() { Name = "firend 3", Description = "description 3" });
        persons.Add(new Person() { Name = "firend 4", Description = "description 4" });
        return ViewComponent("Grid",new { persons = persons });
    }
}
