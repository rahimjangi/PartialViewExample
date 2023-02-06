using Microsoft.AspNetCore.Mvc;
using PartialViewExample.Models;

namespace PartialViewExample.VIewComponents;

[ViewComponent]
public class GridViewComponent:ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        List<Person>people= new List<Person>();
        people.Add(new Person() { Name="Rahim",Description="Developer"});
        people.Add(new Person() { Name = "ll", Description = "Jende" });
        return View(people);
    }
}
