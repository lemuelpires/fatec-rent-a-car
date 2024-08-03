using Dapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace fatec_rent.API
{
    public class VeiculoRepository : IVeiculoRepository
    {
        private readonly IDBContext _db;

        public VeiculoRepository(IDBContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Veiculo>> GetAll()
        {
            using (var conexao = _db.GetConnection())
            {
                return await conexao.QueryAsync<Veiculo>("SELECT * FROM Veiculo");
            }
        }
    }
}
