using StartupCompany.DataAccess.Context;
using StartupCompany.Domain.Entities;
using StartupCompany.Domain.Interface;

namespace StartupCompany.DataAccess.Repository;
public class ProductRepository : GenericRepository<Product>, IProductRepository
{
    public ProductRepository(StartupCompanyDbContext context) : base(context) { }
}
