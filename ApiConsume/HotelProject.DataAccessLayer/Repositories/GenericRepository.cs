using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace HotelProject.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly Context _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(Context context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity); // Veriyi DbSet'e ekler
            await _context.SaveChangesAsync(); // Değişiklikleri veritabanına kaydeder
        }

        public async Task DeleteAsync(T entity)
        {
            _dbSet.Remove(entity); // Veriyi DbSet'ten çıkarır
            await _context.SaveChangesAsync(); // Değişiklikleri kaydeder
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync(); // Tüm kayıtları getirir
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id); // Verilen ID'ye göre kaydı getirir
        }

        public async Task UpdateAsync(T entity)
        {
            _dbSet.Update(entity); // Veriyi günceller
            await _context.SaveChangesAsync(); // Değişiklikleri kaydeder
        }
    }
}
