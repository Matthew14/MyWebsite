using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MySite2.Runs.Data;
using MySite2.Runs.Dtos;
using MySite2.Runs.Models;

namespace MySite2.Runs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RunsController : ControllerBase
    {
        private readonly IRunRepository _repository;
        private readonly IMapper _mapper;


        public RunsController(IRunRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        
        [HttpGet]
        public ActionResult<IEnumerable<RunReadDto>> GetRuns()
        {
            var allRuns = _repository.GetAllRuns();
            return Ok(_mapper.Map<IEnumerable<RunReadDto>>(allRuns));
        }

        [HttpGet("{id:int}", Name = "GetRunById")]
        public ActionResult<RunReadDto> GetRunById(int id)
        {
            var theRun = _repository.GetRunById(id);
            if (theRun != null)
            {
                return Ok(_mapper.Map<RunReadDto>(theRun));
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult AddRun(RunWriteDto run)
        {
            var runModel = _mapper.Map<Run>(run);
            _repository.CreateRun(runModel);
            _repository.SaveChanges();
            var readDto = _mapper.Map<RunReadDto>(runModel);
            return CreatedAtRoute(nameof(GetRunById), new { readDto.Id }, run);
        }
    }
}
