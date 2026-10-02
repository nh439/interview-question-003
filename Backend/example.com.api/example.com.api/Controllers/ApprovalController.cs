using example.com.api.Services;
using Microsoft.AspNetCore.Mvc;

namespace example.com.api.Controllers;

[ApiController]
[Route("[controller]")]
public class ApprovalController(IApprovalService approvalService) : Controller
{
    // GET
    public async Task<IActionResult> Index(string? search, int page = 1, int pageSize = 20)
    {
        var result = await approvalService.ListApprovalAsync(search, page, pageSize);
        return Ok(result);
    }
}