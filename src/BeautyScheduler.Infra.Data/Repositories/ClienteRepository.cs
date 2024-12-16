using BeautyScheduler.Domain.Contracts.Repositories;
using BeautyScheduler.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BeautyScheduler.Infra.Data.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly BeautySchedulerDbContext _context;

        public ClienteRepository(BeautySchedulerDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Cliente>> GetAllAsync()
        {
            return await _context.Cliente.ToListAsync();
        }

        public async Task<Cliente> GetByIdAsync(Guid id)
        {
            return await _context.Cliente.FindAsync(id);
        }

        public async Task AddAsync(Cliente cliente)
        {
            await _context.Cliente.AddAsync(cliente);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Cliente cliente)
        {
            _context.Cliente.Update(cliente);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var cliente = await _context.Cliente.FindAsync(id);
            if (cliente != null)
            {
                _context.Cliente.Remove(cliente);
                await _context.SaveChangesAsync();
            }
        }
    }
}
