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
    
    public class EstudianteController : ControllerBase
    {
        private readonly IEstudianteServices _service;
        private readonly IMapper _mapper;

        public EstudianteController(IEstudianteServices service, IMapper mapper)
        {
            this._service = service;
            this._mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> Post(EstudianteRequestDto EstudianteDto)
        {
            var estudiante = _mapper.Map<EstudianteRequestDto, Estudiante>(EstudianteDto);
            await _service.AddEstudiante(estudiante);

            var estudianteresponseDto = _mapper.Map<Estudiante, EstudianteResponseDto>(estudiante);
            var response = new ApiResponse<EstudianteResponseDto>(estudianteresponseDto);

            return Ok(response);
        }

        [HttpGet]
        public IActionResult Get()
        {
            var Estudiantes = _service.GetEstudiantes();
            var estudiantesDto = _mapper.Map<IEnumerable<Estudiante>, IEnumerable<EstudianteResponseDto>>(Estudiantes);

            var response = new ApiResponse<IEnumerable<EstudianteResponseDto>>(estudiantesDto);

            return Ok(response);
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            var Estudiantes = _service.GetEstudiantes().FirstOrDefault(x => x.Id == id);
            var estudiantesDto = _mapper.Map<Estudiante, EstudianteResponseDto>(Estudiantes);

            var response = new ApiResponse<EstudianteResponseDto>(estudiantesDto);

            return Ok(response);
        }

        [HttpGet("Accout/{id:int}")]
        public IActionResult AccoutGet(int id)
        {
            var Estudiantes = _service.GetEstudiantes().FirstOrDefault(x => x.CuentaID == id);
            var estudiantesDto = _mapper.Map<Estudiante, EstudianteResponseDto>(Estudiantes);

            var response = new ApiResponse<EstudianteResponseDto>(estudiantesDto);

            return Ok(response);
        }
    }
}