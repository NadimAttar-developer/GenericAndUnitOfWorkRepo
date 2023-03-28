using StartupCompany.DataAccess.Context;
using StartupCompany.Domain.Interface;

namespace StartupCompany.DataAccess.Repository;
public class UnitOfWork : IUnitOfWork
{
    private readonly StartupCompanyDbContext _context;
    public UnitOfWork(StartupCompanyDbContext context)
    {
        _context = context;
        ServiceRepository = new ServiceReposiotry(context);
        ProductRepository = new ProductRepository(context);
        TeamRepository = new TeamRepository(context);
        TechnologyRepository = new TechnologyRepository(context);
    }
    public IServiceRepsoitory ServiceRepository { get; }
    public IProductRepository ProductRepository { get; }
    public ITeamRepository TeamRepository { get; }
    public ITechnologyRepository TechnologyRepository { get; }
    public void Dispose()
    {
        _context.Dispose();
    }
    public int SaveInDb()
    {
        return _context.SaveChanges();
    }
}
