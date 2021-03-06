using CoreModal.Data.Entities;
using Microsoft.EntityFrameworkCore;


namespace CoreModal.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
