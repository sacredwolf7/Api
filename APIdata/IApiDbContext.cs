using APIdata.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIdata
{
    public interface IApiDbContext
    {
        DbSet<Blogs> Blogs { get; set; }
        DbSet<BlogActions> BlogsActions { get; set; }
    }
}
