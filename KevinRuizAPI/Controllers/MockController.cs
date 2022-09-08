using KevinRuizAPI.Entidades;
using KevinRuizAPI.Repository;
using KevinRuizAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KevinRuizAPI.Controllers
{
    [ApiController]
    [Route("api/mock")]
    public class MockController : ControllerBase
    {
        readonly IPersonRepository _personRepository;

        public MockController()
        {
            _personRepository = new IUserData();
        }

        [HttpGet]
        public async Task<ActionResult<List<Humano>>> Get()
        {
            var entidad = await _personRepository.Get();
            return Ok(entidad);
        }

        [HttpPost("args")]
        public int Operacion(int n1, int n2, char operador)
        {
            int resultado = 0;
            switch (operador)
            {
                case '+':
                    resultado = n1 + n2;
                    break;
                case '-':
                    resultado = n1 - n2;
                    break;
                case '*':
                    resultado = n1 * n2;
                    break;
                case '/':
                    resultado = n1 / n2;
                    break;

            }
            return resultado;
        }

        [HttpGet("header")]
        public int HeaderOperation([FromHeader] int n1, [FromHeader] int n2, [FromHeader] char operacion)
        {
            int resultado = 0;
            switch (operacion)
            {
                case '+':
                    resultado = n1 + n2;
                    break;
                case '-':
                    resultado = n1 - n2;
                    break;
                case '*':
                    resultado = n1 * n2;
                    break;
                case '/':
                    resultado = n1 / n2;
                    break;

            }
            return resultado;
        }
    }
}
