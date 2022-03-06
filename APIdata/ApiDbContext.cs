using APIdata.Models;
using System.Data.Entity;

namespace APIdata
{
    public class ApiDbContext : DbContext , IApiDbContext
    {
        private const string connectionString = "";

        public virtual DbSet<Blogs> Blogs { get; set; }
        public virtual DbSet<BlogActions> BlogsActions { get; set; }
    }
}
