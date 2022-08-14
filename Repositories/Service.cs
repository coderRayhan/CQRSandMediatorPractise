using MediatrAndCQRSDemo.Context;
using MediatrAndCQRSDemo.Entities;
using Microsoft.EntityFrameworkCore;

namespace MediatrAndCQRSDemo.Repositories
{
    public class Service : IService
    {
        private readonly ApplicationDbContext context;

        public Service(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void CreateAsync(PersonalInfo personalInfo)
        {
            //context.PersonalInfos.Add(personalInfo);
            context.Add<PersonalInfo>(personalInfo);
            context.SaveChanges();
        }

        public async Task<List<PersonalInfo>> GetAllAsync()
        {
            return await context.PersonalInfos.ToListAsync();
        }

        public async Task<PersonalInfo> GetAsync(int id)
        {
            return await context.PersonalInfos.FindAsync(id);
        }
    }
}
