using Microsoft.AspNetCore.Mvc;

namespace WebApi;

[Route("api/processor")]
[ApiController]
public class ProcessorController : ControllerBase
{
    [HttpPost("process")]
    public async Task<IActionResult> ProcessAsPostAsync(RunJobCommand runJobCommand, CancellationToken httpRequestCancellationToken)
    {
        await Task.Delay(TimeSpan.FromSeconds(1), httpRequestCancellationToken);
        return NoContent();
    }

    [HttpPut("process")]
    public async Task<IActionResult> ProcessAsPutAsync(RunJobCommand runJobCommand, CancellationToken httpRequestCancellationToken)
    {
        await Task.Delay(TimeSpan.FromSeconds(1), httpRequestCancellationToken);
        return NoContent();
    }

    [HttpGet("hello")]
    public async Task HelloAsync(CancellationToken httpRequestCancellationToken)
    {
        await Task.Delay(TimeSpan.FromSeconds(1), httpRequestCancellationToken);
    }

    [HttpDelete("goodbye")]
    public async Task GoodbyeAsync(CancellationToken httpRequestCancellationToken)
    {
        await Task.Delay(TimeSpan.FromSeconds(1), httpRequestCancellationToken);
    }
}

public class RunJobCommand
{
    public string JobIdentifier { get; set; } = string.Empty;

    public bool ConfirmJobStart { get; set; }
}