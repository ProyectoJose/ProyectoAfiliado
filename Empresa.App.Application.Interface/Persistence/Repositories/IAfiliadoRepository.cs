using Empresa.App.Domain;

namespace Empresa.App.Application.Interface.Persistence.Repositories
{
    public interface IAfiliadoRepository
    {
        Task<List<Afiliado>> ListarAfiliado();
    }
}
