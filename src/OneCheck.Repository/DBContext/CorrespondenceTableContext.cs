using Microsoft.EntityFrameworkCore;
using OneCheck.Repository.Model;

namespace OneCheck.Repository.DBContext;
public class CorrespondenceTableContext : DbContext
{
    public CorrespondenceTableContext(DbContextOptions<CorrespondenceTableContext> options)
        : base(options)
    {

    }
    public DbSet<CorrespondenceULDShipmentModel> correspondenceULDShipmentModel { get; set; }
}

