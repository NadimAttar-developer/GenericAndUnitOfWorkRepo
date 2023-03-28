using StartupCompany.DataAccess.Context;
using StartupCompany.Domain.Entities;
using StartupCompany.Domain.Interface;

namespace StartupCompany.DataAccess.Repository;
public class ServiceReposiotry : GenericRepository<Service>, IServiceRepsoitory
{
    public ServiceReposiotry(StartupCompanyDbContext context) : base(context) { }
}
