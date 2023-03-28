using StartupCompany.Domain.Entities;

namespace StartupCompany.Domain.Interface;
public interface ITechnologyRepository : IGenericRepository<Technology>
{
    IEnumerable<TeamTechnology> GetTeamWithTheirTechnologies();
}
