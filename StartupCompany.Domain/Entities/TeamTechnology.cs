
namespace StartupCompany.Domain.Entities;
public class TeamTechnology
{
    public int Id { get; set; }
    public Team Team { get; set; }
    public int TeamId { get; set; }
    public Technology Technology { get; set; }
    public int TechnologyId { get; set; }
}

