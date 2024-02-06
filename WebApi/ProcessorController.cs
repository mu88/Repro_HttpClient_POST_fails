using Microsoft.AspNetCore.Mvc;

namespace WebApi;

[Route("api/processor")]
[ApiController]
public class ProcessorController : ControllerBase
{
    [HttpPost("process")]
    public async Task<IActionResult> ProcessAsync(RunJobCommand runJobCommand, CancellationToken httpRequestCancellationToken)
    {
        await Task.Delay(TimeSpan.FromSeconds(1), httpRequestCancellationToken);
        return NoContent();
    }

    [HttpGet("hello")]
    public async Task GetAsync(CancellationToken httpRequestCancellationToken)
    {
        await Task.Delay(TimeSpan.FromSeconds(1), httpRequestCancellationToken);
    }
}

public class RunJobCommand
{
    public string JobIdentifier { get; set; } = string.Empty;

    public bool ConfirmJobStart { get; set; }
}