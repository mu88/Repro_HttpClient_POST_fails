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
    public async Task SayGoodbyeAsync()
    {
        // Arrange
        var httpClient = new HttpClient { BaseAddress = new Uri("http://localhost:5254/") };

        // Act
        HttpResponseMessage response = await Helper.SayGoodbyeAsync(httpClient);

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
    public async Task ProcessViaPutAsync()
    {
        // Arrange
        var httpClient = new HttpClient { BaseAddress = new Uri("http://localhost:5254/") };

        // Act
        HttpResponseMessage response = await Helper.ProcessViaPutAsync(httpClient);

        // Assert
        response.Should().BeSuccessful();
    }

    [Fact]
    public async Task ProcessViaPutAsJsonAsync()
    {
        // Arrange
        var httpClient = new HttpClient { BaseAddress = new Uri("http://localhost:5254/") };

        // Act
        HttpResponseMessage response = await Helper.ProcessViaPutAsJsonAsync(httpClient);

        // Assert
        response.Should().BeSuccessful();
    }

    [Fact]
    public async Task CompleteViaPostWithEmptyAsync()
    {
        // Arrange
        var httpClient = new HttpClient { BaseAddress = new Uri("http://localhost:5254/") };

        // Act
        HttpResponseMessage response = await Helper.CompleteViaPostWithEmptyAsync(httpClient);

        // Assert
        response.Should().BeSuccessful();
    }

    [Fact]
    public async Task CompleteViaPostWithNullAsync()
    {
        // Arrange
        var httpClient = new HttpClient { BaseAddress = new Uri("http://localhost:5254/") };

        // Act
        HttpResponseMessage response = await Helper.CompleteViaPostWithNullAsync(httpClient);

        // Assert
        response.Should().BeSuccessful();
    }
}