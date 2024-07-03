using Estudante.Entities;
using Estudante.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Estudante.Controllers;
[Route("api/[controller]")]
[ApiController]
public class EstudanteController : ControllerBase {
    private readonly EstudanteDbContext _context;

    public EstudanteController(EstudanteDbContext contexto) {
        _context = contexto;

    }

    [HttpGet]
    public IActionResult GetAll() {
        var alunos = _context.Alunos.Where(x => x.IsDeleted == false).ToList();

        return Ok(alunos);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(Guid id) {
        var aluno = _context.Alunos.SingleOrDefault(x => x.Id == id);

        if (aluno == null) {
            return NotFound();
        }

        return Ok(aluno);
    }

    [HttpPost]
    public IActionResult Post(Aluno aluno) {
        _context.Alunos.Add(aluno);

        _context.SaveChanges();
        return CreatedAtAction(nameof(GetById), new { id = aluno.Id }, aluno);
    }

    [HttpPut("{id}")]
    public IActionResult Update(Guid id, Aluno input) {
        var aluno = _context.Alunos.SingleOrDefault(x => x.Id == id);

        if (aluno == null) {
            return NotFound();
        }

        aluno.Update(input.Nome, input.Curso, input.Semestre);
        _context.Update(aluno);
        _context.SaveChanges();

        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id) {
        var aluno = _context.Alunos.SingleOrDefault(x => x.Id == id);

        if (aluno == null) {
            return NotFound();
        }

        aluno.Delete();
        _context.SaveChanges();

        return NoContent();
    }


}
