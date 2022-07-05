using Microsoft.EntityFrameworkCore;
using NewApp.Entities;

namespace NewApp.DB
{
    public class DBContext :DbContext
    {
        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        {
        }
        public DbSet<Persons> Persons { get; set; }
    }
}
