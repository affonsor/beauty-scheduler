using BeautyScheduler.Application.Services;
using BeautyScheduler.Domain.Contracts.Service;
using BeautyScheduler.Domain.DTO.Cliente;
using BeautyScheduler.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BeautyScheduler.Api.Controllers
{
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _clienteService;

        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var clientes = await _clienteService.GetAllAsync();
            return Ok(clientes);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var cliente = await _clienteService.GetByIdAsync(id);
            if (cliente == null) return NotFound();
            return Ok(cliente);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody]Cliente cliente)
        {
            await _clienteService.AddAsync(cliente);
            return CreatedAtAction(nameof(GetById), new { id = cliente.Id }, cliente);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody]ClienteUpdateModel cliente)
        {            
            var clienteUpdate = new Cliente(cliente.Nome,cliente.Cpf, cliente.Telefone, cliente.Email);
            await _clienteService.UpdateAsync(clienteUpdate);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _clienteService.DeleteAsync(id);
            return NoContent();
        }
    }    
}
