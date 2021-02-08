using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Responses;
using AutoMapper;
using Domain.DTOs;
using Domain.Interfaces;
using Entity;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;


namespace Api.Controllers
{
    [EnableCors("Testing")]
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

        [HttpPost]
        public async Task<IActionResult> Post(AcademiaRequestDto AcademiaDto)
        {
            var academia = _mapper.Map<AcademiaRequestDto, Academia>(AcademiaDto);
            await _service.AddAcademia(academia);

            var academiaresponseDto = _mapper.Map<Academia, AcademiaResponseDto>(academia);
            var response = new ApiResponse<AcademiaResponseDto>(academiaresponseDto);

            return Ok(response);
        }

        [HttpGet]
        public IActionResult Get()
        {
            var Academias = _service.GetAcademias();
            var animalsDto = _mapper.Map<IEnumerable<Academia>, IEnumerable<AcademiaResponseDto>>(Academias);

            var response = new ApiResponse<IEnumerable<AcademiaResponseDto>>(animalsDto);
            return Ok(response);
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            var Academias = _service.GetAcademias().FirstOrDefault(x => x.Id == id);
            var animalsDto = _mapper.Map<Academia, AcademiaResponseDto>(Academias);

            var response = new ApiResponse<AcademiaResponseDto>(animalsDto);
            return Ok(response);
        }

        [HttpGet("Accout/{id:int}")]
        public IActionResult AccoutGet(int id)
        {
            var Academias = _service.GetAcademias().FirstOrDefault(x => x.CuentaID == id);
            var animalsDto = _mapper.Map<Academia, AcademiaResponseDto>(Academias);

            var response = new ApiResponse<AcademiaResponseDto>(animalsDto);
            return Ok(response);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateAcademy(int id, AcademiaRequestDto AcademiaDto)
        {
            var update = _mapper.Map<Academia>(AcademiaDto);
            update.Id = id;
            await _service.UpdateAcademia(update);
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteAcademy(int id)
        {
            await _service.DeleteAcademy(id);
            return Ok();
        }


    }
}
