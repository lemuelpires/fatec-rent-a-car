using System.Collections.Generic;
using System.Threading.Tasks;

namespace fatec_rent.API
{
    public interface IVeiculoRepository
    {
        Task<IEnumerable<Veiculo>> GetAll();
    }
}
