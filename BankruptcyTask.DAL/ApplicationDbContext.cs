using BankruptcyTask.Domain;
using BankruptcyTask.Domain.Entity;
using BankruptcyTask.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace BankruptcyTask.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            Database.EnsureCreated();
        }
        
        public DbSet<Estate> Estates { get; set; }
        public DbSet<Debtor> Debtors { get; set; }
        public DbSet<Arbitrator> Arbitrators { get; set; }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Debtor>(builder =>
        //    {
        //        builder.HasData(new Debtor
        //        {
        //            Id = 1,
        //            Name = "DebName",
        //            SurName = "DebSurName",
        //            EstateList = new List<Estate>()
        //            //Arbitrator = new Arbitrator()
        //            //{
        //            //    Id = 1,
        //            //    Name = "ArbName",
        //            //    SurName = "ArbSurName"
        //            //},
        //            //ArbitratorId = 1
        //        });
        //        builder.ToTable("Debtors").HasKey(x=> x.Id);
        //        builder.Property(x => x.Id).ValueGeneratedOnAdd();
        //        builder.Property(x => x.Name).HasMaxLength(50).IsRequired();
        //    });

        //    modelBuilder.Entity<Estate>(builder =>
        //    {
        //        builder.HasData(new Estate
        //        {
        //            Id = 1,
        //            Name = "Name",
        //            Price = 100,
        //            CreationDate = DateTime.Now,                   
        //            IsRealize = false
        //        });
        //        builder.ToTable("Estates").HasKey(x => x.Id);
        //        builder.Property(x => x.Id).ValueGeneratedOnAdd();
        //        builder.Property(x => x.Name).HasMaxLength(100).IsRequired();
        //    });
        //}
    }
}