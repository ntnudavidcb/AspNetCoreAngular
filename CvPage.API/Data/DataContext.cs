using CvPage.API.Models;
using Microsoft.EntityFrameworkCore;

namespace CvPage.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base
        (options){}

        public DbSet<Value> Values { get; set; }
    }
}