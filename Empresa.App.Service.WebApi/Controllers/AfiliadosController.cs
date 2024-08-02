using Empresa.App.Application.Dto;
using Empresa.App.Application.Interface.UseCases;
using Empresa.App.Cross.Common;
using Microsoft.AspNetCore.Mvc;

namespace Empresa.App.Service.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AfiliadosController: ControllerBase
    {
        private readonly IAfiliadoApplication _afiliadoApplication;
            
        public AfiliadosController(IAfiliadoApplication afiliadoApplication)
        {
            _afiliadoApplication = afiliadoApplication;
        }
        [HttpGet("ListAfiliados")]
        public async Task<ActionResult<List<AfiliadoDTO>>> ListAfiliados()
        {
            var response = await _afiliadoApplication.ListarAfiliado();
            return response;
        }
    }
}
