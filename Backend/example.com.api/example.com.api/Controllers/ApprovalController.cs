using example.com.api.Services;
using example.com.shared.SharedModel;
using Microsoft.AspNetCore.Mvc;

namespace example.com.api.Controllers;

[ApiController]
[Route("[controller]")]
public class ApprovalController(
    IApprovalService approvalService,
    ILogger<ApprovalController> logger
    ) : Controller
{
    // GET
    public async Task<IActionResult> Index(string? search, int page = 1, int pageSize = 20)
    {
        try
        {
            var result = await approvalService.ListApprovalAsync(search, page, pageSize);
            return Ok(result);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, ex.Message);
            return StatusCode(500, ex.Message);
        }
    }

    [HttpPut("approve")]
    public async Task<IActionResult> Approve([FromBody] ApprovalRequest request)
    {
        if (!request.ApprovalIds.Any())
            return BadRequest("Approval Id Required");
        try
        {
            return Ok(
                await approvalService.ApproveAsync(request.ApprovalIds, request.IsApproved, request.ApproveReason));
        }
        catch (Exception ex)
        {
            logger.LogError(ex, ex.Message);
            return StatusCode(500, ex.Message);
        }
    }
    
}