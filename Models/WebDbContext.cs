using Microsoft.EntityFrameworkCore;

namespace Falcon.Models
{
    public class WebDbContext:DbContext
    {
        public WebDbContext(DbContextOptions<WebDbContext> options):base(options)
        {

        }
        public DbSet<DataModel> Data { get; set; }
    }
}
