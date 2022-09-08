using KevinRuizAPI.Context;
using KevinRuizAPI.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KevinRuizAPI.Controllers
{
    [ApiController]
    [Route("api/humanos")]
    public class HumanosController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public HumanosController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Humano>>> Get()
        {
            var entidad = await context.Humanos.ToListAsync();
            return Ok(entidad);
        }

        [HttpGet("{id:int}", Name = "obtenerHumano")]
        public async Task<ActionResult<Humano>> GetById(int id)
        {
            var entidad = await context.Humanos.FirstOrDefaultAsync(x => x.Id == id);
            if (entidad == null)
            {
                return NotFound();
            }
            return Ok(entidad);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Humano humano)
        {
            context.Humanos.Add(humano);
            await context.SaveChangesAsync();
            return new CreatedAtRouteResult("obtenerHumano", new { id = humano.Id }, humano);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Humano humano)
        {
            var entidadDb = await context.Humanos.FirstOrDefaultAsync(x => x.Id == id);
            if (entidadDb == null)
            {
                return BadRequest();
            }

            entidadDb.Nombre = humano.Nombre;
            entidadDb.Sexo = humano.Sexo;
            entidadDb.Altura = humano.Altura;
            entidadDb.Peso = humano.Peso;

            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}
