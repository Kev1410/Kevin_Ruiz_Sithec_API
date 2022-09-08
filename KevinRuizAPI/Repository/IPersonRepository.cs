using KevinRuizAPI.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KevinRuizAPI.Repository
{
    public interface IPersonRepository
    {
        Task<IList<Humano>> Get();
    }
}
