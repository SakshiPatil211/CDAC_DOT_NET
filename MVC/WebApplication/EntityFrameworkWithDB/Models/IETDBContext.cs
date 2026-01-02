using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
namespace EntityFrameworkWithDB.Models
{
    public class IETDBContext: DbContext
    {
        public DbSet<Employee4> emps { get; set; }

        public IETDBContext(DbContextOptions options):base(options)
        {
            
        }
    }
}
