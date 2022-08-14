using MediatrAndCQRSDemo.Entities;
using Microsoft.EntityFrameworkCore;

namespace MediatrAndCQRSDemo.Context
{
    public interface IApplicationDbContext
    {
        DbSet<EducationalInfo> EducationalInfos { get; set; }
        DbSet<PersonalInfo> PersonalInfos { get; set; }
    }
}