using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VeterinariaAPI.Data;
using VeterinariaAPI.Models;
using VeterinariaAPI.DTO.Cliente.AgregarCliente;
using VeterinariaAPI.DTO.Cliente.ListarClientes;

namespace VeterinariaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly VeterinariaContext _contexto;

        public ClientesController(VeterinariaContext contexto)
        {
            _contexto = contexto;
        }

        //GET: api/clientes
        [HttpGet]
        public async Task<ActionResult<ICollection<ListarClientesOutput>>> GetClientes()
        {
            var clientes = await _contexto.Clientes
                .Select(c => new ListarClientesOutput
                {
                    ClienteId = c.ClienteId,
                    Nombre = c.Nombre,
                    Telefono = c.Telefono
                })
                .ToListAsync();

            return Ok(clientes);
        }

        //GET: api/clientes/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Cliente>> GetCliente(int id)
        {
            var cliente = await _contexto.Clientes.FindAsync(id);

            if (cliente == null)
                return NotFound();

            return Ok(cliente);
        }

        //POST: api/clientes
        [HttpPost]
        public async Task<ActionResult<AgregarClienteOutput>> CreateCliente([FromBody] AgregarClienteInput cliente)
        {
            var entrada = new Cliente
            {
                Nombre = cliente.Nombre,
                Telefono = cliente.Telefono,
                Direccion = cliente.Direccion,
                Email = cliente.Email
            };

            _contexto.Clientes.Add(entrada);
            await _contexto.SaveChangesAsync();

            var salida = new AgregarClienteOutput
            {
                ClienteId = entrada.ClienteId,
                Nombre = entrada.Nombre,
                Telefono = entrada.Telefono,
                Direccion = entrada.Direccion,
                Email = entrada.Email
            };

            return CreatedAtAction(nameof(GetCliente), new { id = salida.ClienteId }, salida);
        }

        //PUT: api/clientes/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCliente(int id, [FromBody] Cliente cliente)
        {
            if (id != cliente.ClienteId)
                return BadRequest("El ID no coincide.");

            var existing = await _contexto.Clientes.FindAsync(id);
            if (existing == null)
                return NotFound();

            existing.Nombre = cliente.Nombre;
            existing.Telefono = cliente.Telefono;
            existing.Direccion = cliente.Direccion;
            existing.Email = cliente.Email;

            await _contexto.SaveChangesAsync();
            return NoContent();
        }

        //DELETE: api/clientes/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCliente(int id)
        {
            var cliente = await _contexto.Clientes.FindAsync(id);
            if (cliente == null)
                return NotFound();

            _contexto.Clientes.Remove(cliente);
            await _contexto.SaveChangesAsync();
            return NoContent();
        }
    }
}
