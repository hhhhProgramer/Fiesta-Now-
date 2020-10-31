using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Responses;
using AutoMapper;
using Domain.DTOs;
using Domain.Interfaces;
using Entity;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CuentaController : ControllerBase
    {
        private readonly ICuentaServices _service;
        private readonly IMapper _mapper;
        public CuentaController(ICuentaServices service, IMapper mapper)
        {
            this._service = service;
            this._mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> Post(CuentaRequestDto CuentaDto)
        {
            var cuenta = _mapper.Map<CuentaRequestDto, Cuenta>(CuentaDto);
            await _service.AddCuenta(cuenta);

            var cuentaresponseDto = _mapper.Map<Cuenta, CuentaResponseDto>(cuenta);
            var response = new ApiResponse<CuentaResponseDto>(cuentaresponseDto);

            return Ok(response);
        }

        [HttpGet]
        public IActionResult Get()
        {
            var Cuentas = _service.GetCuentas();
            var animalsDto = _mapper.Map<IEnumerable<Cuenta>, IEnumerable<CuentaResponseDto>>(Cuentas);

            var response = new ApiResponse<IEnumerable<CuentaResponseDto>>(animalsDto);
            return Ok(response);
        }

    }
}