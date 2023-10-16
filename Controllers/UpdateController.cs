using cellularSystem.Schemas;
using cellularSystem.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace cellularSystem.Controllers;


[ApiController]
[Route("v1")]
[Authorize]
public class UpdateController : ControllerBase
{
    [HttpPut]
    [Route("cel/update")]
    public Task<
        IActionResult> UpdateCel(UpdateSchema prop)
    {
        var service = new UpdateService();
        var status = service.Update(prop).Result;
        
        if (!status) return Task.FromResult<IActionResult>(BadRequest("operation not performed"));

        return Task.FromResult<IActionResult>(Ok($"operation carried out successfully"));
    }
}