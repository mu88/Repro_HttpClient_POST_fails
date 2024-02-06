using Client;

try
{
    HttpResponseMessage result;
    HttpClient httpClient = new() { BaseAddress = new Uri("http://localhost:5254/") };

    var mode = 3;
    result = mode switch
    {
        1 => await Helper.ProcessViaPostAsync(httpClient),
        2 => await Helper.ProcessViaPostAsJsonAsync(httpClient),
        3 => await Helper.CompleteWithNullAsync(httpClient),
        4 => await Helper.CompleteWithEmptyAsync(httpClient),
        5 => await Helper.SayHelloAsync(httpClient),
        _ => throw new ArgumentOutOfRangeException()
    };

    result.EnsureSuccessStatusCode();
}
catch (Exception e)
{
    Console.WriteLine(e);
    throw;
}