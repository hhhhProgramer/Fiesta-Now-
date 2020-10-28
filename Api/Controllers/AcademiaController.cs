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
    public class AcademiaController : ControllerBase
    {
        private readonly IAcademiaServices _service;
        private readonly IMapper _mapper;

        public AcademiaController(IAcademiaServices service, IMapper mapper)
        {
            this._service = service;
            this._mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var Academias = _service.GetAcademias();
            var animalsDto = _mapper.Map<IEnumerable<Academia>,IEnumerable<AcademiaResponseDto>>(Academias);

            var response = new ApiResponse<IEnumerable<AcademiaResponseDto>>(animalsDto);
            return Ok(response);
        }

    }
}