using Microsoft.EntityFrameworkCore;
using OneCheck.Repository.Model;

namespace OneCheck.Repository.DBContext;
public class CorrespondenceTableContext : DbContext
{
    public CorrespondenceTableContext() : base()
    {
        
    }
    public CorrespondenceTableContext(DbContextOptions options)
        : base(options)
    {

    }
    public DbSet<CorrespondenceULDShipmentModel> correspondenceULDShipmentModel { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("data source=SWISS-SIEE-38;initial catalog=master;user id=Admin;password=@Password123;TrustServerCertificate=True");
        base.OnConfiguring(optionsBuilder);
    }
}

