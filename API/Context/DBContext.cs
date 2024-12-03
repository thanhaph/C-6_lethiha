using Data;
using Microsoft.EntityFrameworkCore;

namespace API.Context
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions options) : base(options)
        {
        }

      public DbSet<SinhVien> sinhViens { get; set; }    
    }
}
