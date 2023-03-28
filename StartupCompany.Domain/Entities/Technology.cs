
namespace StartupCompany.Domain.Entities;
public class Technology
{
    public int Id { get; set; }
    public string Name { get; set; }

    #region Navigation Properties
    public ICollection<TeamTechnology> TeamTechnologies { get; set; }
    #endregion
}
