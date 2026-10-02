using Microsoft.AspNetCore.Mvc;

namespace example.com.api.Controllers;

public class ApprovalController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}