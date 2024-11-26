using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;

namespace HotelProject.BusinessLayer.Concrete
{
    public class GenericService<T> : IGenericService<T> where T : class
    {
        private readonly IGenericRepository<T> _repository;

        public GenericService(IGenericRepository<T> repository)
        {
            _repository = repository;
        }

        public async Task TAddAsync(T entity)
        {
            await _repository.AddAsync(entity);
        }

        public async Task TDeleteAsync(T entity)
        {
            await _repository.DeleteAsync(entity);
        }

        public async Task<List<T>> TGetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<T> TGetByIdAsync(int id)
        {
           return await _repository.GetByIdAsync(id);
        }

        public async Task TUpdateAsync(T entity)
        {
            await _repository.UpdateAsync(entity);
        }
    }
}
