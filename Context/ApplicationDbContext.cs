using MediatrAndCQRSDemo.Entities;
using Microsoft.EntityFrameworkCore;

namespace MediatrAndCQRSDemo.Context
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<PersonalInfo> PersonalInfos { get; set; }
        public DbSet<EducationalInfo> EducationalInfos { get; set; }
    }
}
