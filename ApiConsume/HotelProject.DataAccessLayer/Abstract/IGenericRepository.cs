namespace HotelProject.DataAccessLayer.Abstract
{
    public interface IGenericRepository<T> where T : class
    {
        Task AddAsync(T entity); // Asenkron ekleme işlemi
        Task DeleteAsync(T entity); // Asenkron silme işlemi
        Task UpdateAsync(T entity); // Asenkron güncelleme işlemi
        Task<List<T>> GetAllAsync(); // Tüm kayıtları getirme
        Task<T> GetByIdAsync(int id); // ID'ye göre tek kayıt getirme
    }

}
