using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using OneCheck.Repository.Model;

namespace OneCheck.Repository.DBContext;
public class CorrespondenceTableContext : DbContext
{
    public CorrespondenceTableContext() : base()
    {
        
    }
    public CorrespondenceTableContext(DbContextOptions options, IConfiguration configuration)
        : base(options)
    {
        Configuration = configuration;
    }
    public DbSet<CorrespondenceULDShipmentModel> correspondenceULDShipmentModel { get; set; }
    public IConfiguration Configuration { get; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(Configuration.GetConnectionString("myDB"));
        base.OnConfiguring(optionsBuilder);
    }
}

