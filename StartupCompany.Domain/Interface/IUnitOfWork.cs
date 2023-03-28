namespace StartupCompany.Domain.Interface;

public interface IUnitOfWork : IDisposable
{
    IServiceRepsoitory ServiceRepository { get; }
    IProductRepository ProductRepository { get; }
    ITeamRepository TeamRepository { get; }
    ITechnologyRepository TechnologyRepository { get; }
    int SaveInDb();
}
