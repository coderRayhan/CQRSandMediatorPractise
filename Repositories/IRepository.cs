namespace MediatrAndCQRSDemo.Repositories
{
    public interface IRepository<T> where T : class
    {
        void Delete(int id);
        Task<List<T>> GetList();
        Task<T> GetSingle(int id);
        void Insert(T entity);
        void Update(T entity);
    }
}