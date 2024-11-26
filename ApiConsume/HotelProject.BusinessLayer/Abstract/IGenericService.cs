namespace HotelProject.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        Task TAddAsync(T entity); // Asenkron ekleme işlemi
        Task TDeleteAsync(T entity); // Asenkron silme işlemi
        Task TUpdateAsync(T entity); // Asenkron güncelleme işlemi
        Task<List<T>> TGetAllAsync(); // Tüm kayıtları getirme
        Task<T> TGetByIdAsync(int id); // ID'ye göre tek kayıt getirme
    }
}
