using StartupCompany.DataAccess.Context;
using StartupCompany.Domain.Entities;
using StartupCompany.Domain.Interface;

namespace StartupCompany.DataAccess.Repository;
public class TeamRepository : GenericRepository<Team>, ITeamRepository
{
    public TeamRepository(StartupCompanyDbContext context) : base(context) { }
}
