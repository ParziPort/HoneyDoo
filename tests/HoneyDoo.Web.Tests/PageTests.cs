using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace HoneyDoo.Web.Tests;

public class PageTests(WebApplicationFactory<Program> factory) : IClassFixture<WebApplicationFactory<Program>>
{
    [Fact]
    public async Task HomeShowsTheDevelopmentPreview()
    {
        using var client = factory.CreateClient();
        var html = await client.GetStringAsync("/");

        Assert.Contains("<title>HoneyDoo | Household Task Management</title>", html);
        Assert.Contains("Development Preview", html);
        Assert.Contains("Initial development build. Household accounts and task management are planned for future iterations.", html);
    }

    [Fact]
    public async Task AboutShowsTheTeamSection()
    {
        using var client = factory.CreateClient();
        var html = await client.GetStringAsync("/About");

        Assert.Contains("id=\"team\"", html);
        Assert.Contains("id=\"team-title\">Fourward Solutions</h2>", html);
    }

    [Theory]
    [InlineData("/")]
    [InlineData("/About")]
    public async Task SharedFooterCreditsTheWholeTeam(string path)
    {
        using var client = factory.CreateClient();
        var html = await client.GetStringAsync(path);

        var footerStart = html.IndexOf("<footer", StringComparison.Ordinal);
        var footerEnd = html.IndexOf("</footer>", StringComparison.Ordinal);
        Assert.True(footerStart >= 0 && footerEnd > footerStart, "Expected a shared footer.");
        var footer = html[footerStart..footerEnd];

        Assert.Contains("Developed by Fourward Solutions", footer);
        Assert.Contains("Cris Brown-Renteria", footer);
        Assert.Contains("Jacob Lasley", footer);
        Assert.Contains("Christopher Lawrence", footer);
        Assert.Contains("Matt Newport", footer);
    }
}
