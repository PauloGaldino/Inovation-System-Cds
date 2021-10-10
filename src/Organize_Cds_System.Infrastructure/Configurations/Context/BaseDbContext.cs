using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Organize_Cds_System.Entity.Entities.Persons.UserCds;
using Organize_Cds_System.Entity.Entities.Persons.Users.Indentity;
using Organize_Cds_System.Entity.Entities.Products.Cds;

namespace Organize_Cds_System.Infrastructure.Configurations.Context
{
    public class BaseDbContext : IdentityDbContext<ApplicationUser>
    {
        public BaseDbContext(DbContextOptions<BaseDbContext> options) : base(options) { }

        public DbSet<Cd> Cds { get; set; }
        public DbSet<UserCd> UserCds { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(GetStringConectionConfig());
                base.OnConfiguring(optionsBuilder);
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ApplicationUser>().ToTable("AspNetUsers").HasKey(t => t.Id);

            base.OnModelCreating(builder);
        }


        private string GetStringConectionConfig()
        {
            string strCon = "Data Source=DESKTOP-PAULO\\SQLEXPRESS;Initial Catalog=Smart_Cd.db_2021;Integrated Security=False;User ID=sa;Password=toor;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
            return strCon;
        }


    }
}

