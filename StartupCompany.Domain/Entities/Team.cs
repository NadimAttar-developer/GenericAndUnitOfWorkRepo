
namespace StartupCompany.Domain.Entities;
public class Team
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }

    #region Navigation Properties
    public ICollection<TeamTechnology> TeamTechnologies { get; set; }
    #endregion
}
