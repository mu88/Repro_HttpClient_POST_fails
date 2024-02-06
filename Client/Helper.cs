using System.Net.Http.Json;
using System.Text;

namespace Client;

public static class Helper
{
    public static async Task<HttpResponseMessage> SayHelloAsync(HttpClient httpClient) =>
        await httpClient.GetAsync(
            "api/processor/hello",
            CancellationToken.None);

    public static async Task<HttpResponseMessage> SayGoodbyeAsync(HttpClient httpClient) =>
        await httpClient.DeleteAsync(
            "api/processor/goodbye",
            CancellationToken.None);

    public static async Task<HttpResponseMessage> ProcessViaPutAsync(HttpClient httpClient) =>
        await httpClient.PutAsync(
            "api/processor/process",
            new StringContent("{\"JobIdentifier\": \"mu88\", \"ConfirmJobStart\": true}", Encoding.UTF8, "application/json"),
            CancellationToken.None);

    public static async Task<HttpResponseMessage> ProcessViaPutAsJsonAsync(HttpClient httpClient) =>
        await httpClient.PutAsJsonAsync(
            "api/processor/process",
            new { JobIdentifier = "mu88", ConfirmJobStart = true },
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

    public static async Task<HttpResponseMessage> CompleteViaPostWithNullAsync(HttpClient httpClient) =>
        await httpClient.PostAsync(
            "internal-api/dataset/complete",
            null,
            CancellationToken.None);

    public static async Task<HttpResponseMessage> CompleteViaPostWithEmptyAsync(HttpClient httpClient) =>
        await httpClient.PostAsync(
            "internal-api/dataset/complete",
            new StringContent(string.Empty),
            CancellationToken.None);
}