using AutoMapper;
using Empresa.App.Application.Dto;
using Empresa.App.Application.Interface.Persistence.Repositories;
using Empresa.App.Application.Interface.UseCases;
using Empresa.App.Cross.Common;
using Microsoft.Extensions.Configuration;

namespace Empresa.App.Application.UseCases
{
    public class AfiliadoApplication : IAfiliadoApplication
    {
        private readonly IAfiliadoRepository _afiliadoRepository;   

        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public AfiliadoApplication(IAfiliadoRepository afiliadoRepository, IMapper mapper)
        {
            _afiliadoRepository = afiliadoRepository;
            _mapper = mapper;
        }

        //public async Task<ResponseT<List<AfiliadoDTO>>> ListarAfiliado()
        //{
        //    var response = new ResponseT<List<AfiliadoDTO>>();
        //    try
        //    {
        //        var userEntity = await _afiliadoRepository.ListarAfiliado();

        //        response.Data = _mapper.Map<List<AfiliadoDTO>>(userEntity);
        //        if (response.Data != null)
        //        {
        //            response.IsSuccess = true;
        //            response.Message = "Consulta Exitosa!!!";
        //        }
        //        else
        //        {
        //            response.IsSuccess = false;
        //            response.Message = "No se encuentra";
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        response.Message = ex.Message;
        //    }
        //    return response;
        //}

        public async Task<List<AfiliadoDTO>> ListarAfiliado()
        {
            var response = new List<AfiliadoDTO>();
            try
            {
                var userEntity = await _afiliadoRepository.ListarAfiliado();

                response = _mapper.Map<List<AfiliadoDTO>>(userEntity);
                 return response;
            }
            catch (Exception ex)
            {
                throw (new Exception());               
            }
            return response;
        }
    }
}
