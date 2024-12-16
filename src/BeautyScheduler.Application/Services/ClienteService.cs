using BeautyScheduler.Domain.Contracts.Repositories;
using BeautyScheduler.Domain.Contracts.Service;
using BeautyScheduler.Domain.Entities;

namespace BeautyScheduler.Application.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task<IEnumerable<Cliente>> GetAllAsync()
        {
            return await _clienteRepository.GetAllAsync();
        }

        public async Task<Cliente> GetByIdAsync(Guid id)
        {
            return await _clienteRepository.GetByIdAsync(id);
        }

        public async Task AddAsync(Cliente cliente)
        {
            await _clienteRepository.AddAsync(cliente);
        }

        public async Task UpdateAsync(Cliente cliente)
        {
            await _clienteRepository.UpdateAsync(cliente);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _clienteRepository.DeleteAsync(id);
        }
    }
}
