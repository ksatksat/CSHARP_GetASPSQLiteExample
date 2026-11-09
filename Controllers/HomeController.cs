using Microsoft.AspNetCore.Mvc;

namespace SimpleMessageApp.Controllers;

public class HomeController : Controller
{
    public IActionResult Index() => View();
}
