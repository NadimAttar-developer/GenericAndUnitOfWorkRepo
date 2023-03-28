using Microsoft.EntityFrameworkCore;
using StartupCompany.DataAccess.Context;
using StartupCompany.Domain.Entities;
using StartupCompany.Domain.Interface;

namespace StartupCompany.DataAccess.Repository;
public class TechnologyRepository : GenericRepository<Technology>, ITechnologyRepository
{
    public TechnologyRepository(StartupCompanyDbContext context) : base(context){ }

    public IEnumerable<TeamTechnology> GetTeamWithTheirTechnologies()
    {
        return _context.TeamTechnologySet
            .Include(t => t.Technology)
            .Include(t => t.Team)
            .Select(t => new TeamTechnology
            {
                Team = t.Team,
                Technology = t.Technology
            }).ToList();

    }
}
