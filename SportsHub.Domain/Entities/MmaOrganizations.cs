namespace SportsHub.Domain.Entities;

public class MmaOrganizations
{
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;
    public string? Country { get; set; }
    public string? WebsiteUrl { get; set; }
    public string? LogoUrl { get; set; }

    public ICollection<MmaFights> Fights { get; set; }
        = new List<MmaFights>();
}