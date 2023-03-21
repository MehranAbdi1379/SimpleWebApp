using System.Data.Entity;
using SimpleWebApp.Domain;

namespace SimpleWebApp.DataBase;

public class DataBaseContext : DbContext
{
    public DataBaseContext() : base("Server=(localdb)\\MSSQLLocalDB;Database=SimpleWebAppDB;Trusted_Connection=True;")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Writer>().HasKey(w => w.Id);
        modelBuilder.Entity<Writer>().Property(w => w.Id).IsRequired();
        modelBuilder.Entity<Writer>().Property(w => w.Password).IsRequired();
        modelBuilder.Entity<Writer>().Property(w => w.FirstName).IsRequired();
        modelBuilder.Entity<Writer>().Property(w => w.LastName).IsRequired();
        modelBuilder.Entity<Writer>().Property(w => w.UserName).IsRequired();
    }

    public DbSet<Writer> Writers { get; set; }
}