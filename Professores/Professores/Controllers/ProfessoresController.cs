using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Professores.Entities;
using Professores.Persistence;

namespace Professores.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ProfessoresController : ControllerBase {
    private readonly ProfessoresDbContext _context;

    public ProfessoresController(ProfessoresDbContext context) {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetAll() {

        var professores = _context.Professores.Where(x => !x.IsDeleted).ToList();

        return Ok(professores);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(Guid id) {
        var professor = _context.Professores.SingleOrDefault(x => x.Id == id);

        if (professor == null) {
            return NotFound();
        }

        return Ok(professor);
    }

    [HttpPost]
    public IActionResult Post(Professor professor) {
        _context.Professores.Add(professor);

        _context.SaveChanges();

        return CreatedAtAction(nameof(GetById), new { id = professor.Id }, professor);
    }

    [HttpPut("{id}")]
    public IActionResult Update(Guid id, Professor input) {
        var professor = _context.Professores.SingleOrDefault(x => x.Id == id);

        if (professor == null) {
            return NotFound();
        }

        professor.Update(input.Nome, input.Curso);

        _context.Professores.Update(professor);
        _context.SaveChanges();

        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id) {
        var professor = _context.Professores.SingleOrDefault(x => x.Id == id);


        if (professor == null) {
            return NotFound();
        }

        professor.Delete(); //REMOÇÃO LÓGICA
        //_context.Professores.Remove(professor);  REMOÇÃO FUNCIONAL
        _context.SaveChanges();

        return NoContent();
    }
}

