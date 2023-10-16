using cellularSystem.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace cellularSystem.Controllers;


[ApiController]
[Route("v1")]
[AllowAnonymous]
public class ReadController : ControllerBase
{

    [HttpGet]
    [Route("cel/read")]
    public Task<IActionResult> ReadCel()
    {
        var service = new Readservice();
        var status = service.Read();
        
        if (status is null) return Task.FromResult<IActionResult>(BadRequest("operation not performed"));

        return Task.FromResult<IActionResult>(Ok(status));
    }
}