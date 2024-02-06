using System.Net.Http.Json;
using System.Text;

namespace Client;

public static class Helper
{
    public static async Task<HttpResponseMessage> SayHelloAsync(HttpClient httpClient) =>
        await httpClient.GetAsync(
            "api/processor/hello",
            CancellationToken.None);

    public static async Task<HttpResponseMessage> ProcessViaPostAsync(HttpClient httpClient) =>
        await httpClient.PostAsync(
            "api/processor/process",
            new StringContent("{\"JobIdentifier\": \"mu88\", \"ConfirmJobStart\": true}", Encoding.UTF8, "application/json"),
            CancellationToken.None);

    public static async Task<HttpResponseMessage> ProcessViaPostAsJsonAsync(HttpClient httpClient) =>
        await httpClient.PostAsJsonAsync(
            "api/processor/process",
            new { JobIdentifier = "mu88", ConfirmJobStart = true },
            CancellationToken.None);

    public static async Task<HttpResponseMessage> CompleteWithNullAsync(HttpClient httpClient) =>
        await httpClient.PostAsync(
            "internal-api/dataset/complete",
            null,
            CancellationToken.None);

    public static async Task<HttpResponseMessage> CompleteWithEmptyAsync(HttpClient httpClient) =>
        await httpClient.PostAsync(
            "internal-api/dataset/complete",
            new StringContent(string.Empty),
            CancellationToken.None);
}