using Dapper;
using Empresa.App.Application.Interface.Persistence.Repositories;
using Empresa.App.Domain;
using Empresa.App.Infraestructure.Persistencia.Context.Dapper;
using System.Data;

namespace Empresa.App.Infraestructure.Persistencia.Repositories
{
    public class AfiliadoRepository: IAfiliadoRepository
    {
        private readonly DapperContext _context;

        public AfiliadoRepository(DapperContext context)
        {
            _context = context;
        }
        public async Task<List<Afiliado>> ListarAfiliado()
        {
            try
            {
                using (var connection = _context.GetConnection())
                {
                    var query = "LISTA_AFILIADO";

                    var afiliadoList = await connection.QueryAsync<Afiliado>(query, commandType: CommandType.StoredProcedure);
                    return (List<Afiliado>)afiliadoList;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la capa de datos.", ex);
            }
        }
    }
}
