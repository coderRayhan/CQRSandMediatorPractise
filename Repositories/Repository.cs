using MediatrAndCQRSDemo.Context;
using Microsoft.EntityFrameworkCore;

namespace MediatrAndCQRSDemo.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public readonly ApplicationDbContext _context;
        public readonly DbSet<T> _entities;
        public Repository(DbSet<T> entities, ApplicationDbContext context)
        {
            _entities = entities;
            _context = context;
        }

        public async Task<List<T>> GetList()
        {
            return await _entities.ToListAsync();
        }

        public async Task<T> GetSingle(int id)
        {
            return await _entities.FindAsync(id);
        }

        public async void Insert(T entity)
        {
            await _entities.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async void Update(T entity)
        {
            _entities.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async void Delete(int id)
        {
            var entry = await _entities.FindAsync(id);
            _entities.Remove(entry);
            await _context.SaveChangesAsync();
        }
    }
}
