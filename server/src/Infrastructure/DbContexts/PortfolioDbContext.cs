using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Infrastructure.DbContexts
{
    public class PortfolioDbContext : DbContext
    {
        public PortfolioDbContext(DbContextOptions<PortfolioDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<SocialLink> SocialLinks { get; set; }
        public DbSet<Message> Messages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            // Seed
            modelBuilder.Entity<Profile>().HasData(
                new Profile
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Awad EmadAldin",
                    LastName = "MohammedFoad",
                    Email = "awademad19977@hotmail.com",
                    Headline = "Software Developer",
                    About = "Software Developer with Experience in He althcare IT | Improving Patient Outcomes t hrough Innovative Technology Solutions",
                }
                );

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "admin",
                    Password = "199E656t24h89@53r$",
                    Email = "awademad19977@hotmail.com"
                }
                );

            modelBuilder.Entity<Experience>().HasData(
                new Experience
                {
                    Id = Guid.NewGuid(),
                    CompanyName = "Scabs Engineering Co",
                    StartYear = "2014",
                    EndYear = "2017",
                    Description = ""
                },
                                new Experience
                                {
                                    Id = Guid.NewGuid(),
                                    CompanyName = "Aliaa Specialized Hospital",
                                    StartYear = "2017",
                                    EndYear = "2023",
                                    Description = ""
                                }
                );

            modelBuilder.Entity<Education>().HasData(
                new Education
                {
                    Id = Guid.NewGuid(),
                    Degree = "Bachelor's degree",
                    FieldOfStudy = "Computer Science",
                    School = "Omdurman Islamic University",
                    StartYear = "2012",
                    EndYear = "2016",
                    Description = ""
                }
                );

            modelBuilder.Entity<SocialLink>().HasData(
                new SocialLink
                {
                    Id = Guid.NewGuid(),
                    Name = "Github",
                    URL = "https://github.com/awad19977",
                },
                new SocialLink
                {
                    Id = Guid.NewGuid(),
                    Name = "LinkedIn",
                    URL = "https://www.linkedin.com/in/awad-emad-81089118b",
                }
                );
        }
    }
}
