using Microsoft.AspNetCore.Mvc;

namespace WebApi;

[Route("internal-api/dataset")]
[ApiController]
public class DatasetController : ControllerBase
{
    [HttpPost("complete")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public async Task<IActionResult> ActivateAsync(CancellationToken httpRequestCancellationToken)
    {
        await Task.Delay(TimeSpan.FromSeconds(1), httpRequestCancellationToken);
        return NoContent();
    }
}