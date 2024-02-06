using Client;
using FluentAssertions;

namespace Tests;

public class WebApiTests
{
    [Fact]
    public async Task SayHelloAsync()
    {
        // Arrange
        var httpClient = new HttpClient { BaseAddress = new Uri("http://localhost:5254/") };

        // Act
        HttpResponseMessage response = await Helper.SayHelloAsync(httpClient);

        // Assert
        response.Should().BeSuccessful();
    }

    [Fact]
    public async Task ProcessViaPostAsync()
    {
        // Arrange
        var httpClient = new HttpClient { BaseAddress = new Uri("http://localhost:5254/") };

        // Act
        HttpResponseMessage response = await Helper.ProcessViaPostAsync(httpClient);

        // Assert
        response.Should().BeSuccessful();
    }

    [Fact]
    public async Task ProcessViaPostAsJsonAsync()
    {
        // Arrange
        var httpClient = new HttpClient { BaseAddress = new Uri("http://localhost:5254/") };

        // Act
        HttpResponseMessage response = await Helper.ProcessViaPostAsJsonAsync(httpClient);

        // Assert
        response.Should().BeSuccessful();
    }

    [Fact]
    public async Task CompleteWithEmptyAsync()
    {
        // Arrange
        var httpClient = new HttpClient { BaseAddress = new Uri("http://localhost:5254/") };

        // Act
        HttpResponseMessage response = await Helper.CompleteWithEmptyAsync(httpClient);

        // Assert
        response.Should().BeSuccessful();
    }

    [Fact]
    public async Task CompleteWithNullAsync()
    {
        // Arrange
        var httpClient = new HttpClient { BaseAddress = new Uri("http://localhost:5254/") };

        // Act
        HttpResponseMessage response = await Helper.CompleteWithNullAsync(httpClient);

        // Assert
        response.Should().BeSuccessful();
    }
}