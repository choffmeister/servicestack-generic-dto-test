using System.Data.Entity;
using ServiceStackRestDemo.Models;

namespace ServiceStackRestDemo
{
    public class DatabaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}