using Empresa.App.Application.Dto;
using Empresa.App.Cross.Common;

namespace Empresa.App.Application.Interface.UseCases
{
    public interface IAfiliadoApplication
    {
        //Task<ResponseT<List<AfiliadoDTO>>> ListarAfiliado();

        Task<List<AfiliadoDTO>> ListarAfiliado();
    }
}
