using KevinRuizAPI.Entidades;
using KevinRuizAPI.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KevinRuizAPI.Services
{
    public class IUserData : IPersonRepository
    {
        readonly List<Humano> humanos;

        public IUserData()
        {
            humanos = new List<Humano>()
            {
                new Humano{Id = 1, Nombre="Victoria", Sexo='F', Altura = 1.80, Peso = 66.7 },
                new Humano{Id = 1, Nombre="Axel", Sexo='M', Altura = 1.76, Peso = 62.5 }
            };
        }
        public async Task<IList<Humano>> Get()
        {
            humanos.ToArray();
            return await Task.FromResult(humanos);
        }
    }
}
