using MediatrAndCQRSDemo.Entities;

namespace MediatrAndCQRSDemo.Repositories
{
    public interface IService
    {
        Task<List<PersonalInfo>> GetAllAsync();
        Task<PersonalInfo> GetAsync(int id);
        void CreateAsync(PersonalInfo personalInfo);
    }
}