using BeautyScheduler.Domain.Entities;

namespace BeautyScheduler.Domain.Contracts.Service
{
    public interface IClienteService
    {
        Task<IEnumerable<Cliente>> GetAllAsync();
        Task<Cliente> GetByIdAsync(Guid id);
        Task AddAsync(Cliente cliente);
        Task UpdateAsync(Cliente cliente);
        Task DeleteAsync(Guid id);
    }
}
