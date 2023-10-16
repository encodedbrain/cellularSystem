using cellularSystem.Schemas;
using cellularSystem.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace cellularSystem.Controllers;


[ApiController]
[Route("v1")]
[Authorize]
public class DeleteController : ControllerBase
{
    [HttpDelete]
    [Route("cel/delete")]
    public Task<IActionResult> DeleteCel(DeleteSchema prop)
    {
        var service = new DeleteService();
        var status = service.Delete(prop).Result;
        
        if (!status) return Task.FromResult<IActionResult>(BadRequest("operation not performed"));

        return Task.FromResult<IActionResult>(Ok($"operation carried out successfully"));
    }
}