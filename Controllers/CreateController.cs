using cellularSystem.Schemas;
using cellularSystem.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace cellularSystem.Controllers;


[ApiController]
[Route("v1")]
[AllowAnonymous]
public class CreateController : ControllerBase
{
    [HttpPost]
    [Route("cel/create")]
    public Task<IActionResult> CreateCel(CellphoneSchema prop)
    {
        var service = new CreateService();
        var status = service.Create(prop).Result;
        
        if (status is false) return Task.FromResult<IActionResult>(BadRequest("operation not performed"));

        return Task.FromResult<IActionResult>(Ok($"operation carried out successfully"));
    }
}