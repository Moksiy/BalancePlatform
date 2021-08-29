using BalancePlatform.Backend.Infrastructure.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace BalancePlatform.Backend.Infrastructure.Contexts
{
    /// <summary>
    /// EF DbContext для подключения к БД 
    /// </summary>
    public class BalancePlatformContext : BaseDbContext
    {
        /// <summary>
        /// EF DbContext для подключения к БД
        /// </summary>
        public BalancePlatformContext(DbContextOptions options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {          
            modelBuilder.Entity<RoleDao>().ToTable("Roles", "dbo");         
            modelBuilder.Entity<UserDao>().ToTable("Users", "dbo");
            modelBuilder.Entity<UserTokenDao>().ToTable("UserTokens", "dbo");

            modelBuilder.Entity<RoleDao>()
                .Property(p => p.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<RoleDao>()
                .Property(p => p.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<UserDao>()
                .Property(p => p.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<UserTokenDao>()
                .HasKey(p => p.Token);

            modelBuilder.Entity<UserDao>()
                .HasOne(x => x.Role)
                .WithMany()
                .HasForeignKey(x => x.RoleId);

            modelBuilder.Entity<UserTokenDao>()
                .HasOne(x => x.User)
                .WithMany()
                .HasForeignKey(x => x.UserId);

            base.OnModelCreating(modelBuilder);
        }

        public static readonly ILoggerFactory MatchingLoggerFactory = LoggerFactory.Create(builder =>
        {
            //builder.AddDebug();
            //builder.AddConsole();
        });

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLoggerFactory(MatchingLoggerFactory);
            if (optionsBuilder.IsConfigured == false)
            {
                base.OnConfiguring(optionsBuilder);
            }
        }
    }
}
