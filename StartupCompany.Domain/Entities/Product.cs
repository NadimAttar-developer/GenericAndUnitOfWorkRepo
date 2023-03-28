
namespace StartupCompany.Domain.Entities;
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double Cost { get; set; }
    public int UsersCounts { get; set; }
}
