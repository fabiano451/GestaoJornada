using Jornada.contracts.IService;
using Jornada.Entities.DTO;
using Microsoft.AspNetCore.Mvc;

namespace JornadaAcademica.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        private readonly IAlunoService _alunoService;

        public AlunoController(IAlunoService alunoService)
        {
            _alunoService = alunoService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var alunos = await _alunoService.GetAllAlunos();
            return Ok(alunos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var aluno = await _alunoService.GetAlunoById(id);
            if (aluno == null) return NotFound();

            return Ok(aluno);
        }

        [HttpPost]
        public async Task<IActionResult> Create(AlunoDTO aluno)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _alunoService.CreateAluno(aluno);
            return CreatedAtAction(nameof(GetById), new { id = aluno.AlunoId }, aluno);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, AlunoDTO aluno)
        {
            if (id != aluno.AlunoId) return BadRequest();

            await _alunoService.UpdateAluno(aluno);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var aluno = await _alunoService.GetAlunoById(id);
            if (aluno == null) return NotFound();

            await _alunoService.DeleteAluno(id);
            return NoContent();
        }
    }
}
