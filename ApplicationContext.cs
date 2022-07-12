using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


public class ApplicationContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=User;Trusted_Connection=True;");
    }
    public DbSet<UserData> Users { get; set; } = null!;
    public DbSet<LoginData> Logins { get; set; } = null!;
}
