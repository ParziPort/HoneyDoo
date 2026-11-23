namespace HoneyDoo.Web.Models;

public static class TeamInfo
{
    public const string Name = "Fourward Solutions";
    public const string Course = "Purdue Global · IT488 Software Product Development Using Agile · Group 3";

    public static IReadOnlyList<string> Members { get; } = Array.AsReadOnly(new[]
    {
        "Cris Brown-Renteria - Preferred Name: Cris",
        "Jacob Lasley",
        "Christopher Lawrence - Preferred name: Chris",
        "Matt Newport (Port)"
    });
}
