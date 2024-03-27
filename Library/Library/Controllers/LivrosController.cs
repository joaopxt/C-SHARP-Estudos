using Library.Entities;
using Library.Entities.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Library.Controllers;
[Route("api/livros")]
[ApiController]
public class LivrosController : ControllerBase {

    private readonly LivrosDbContext _context;

    public LivrosController(LivrosDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetAll() {
        var livros = _context.Livros.Where(x => !x.IsDeleted).ToList();

        return Ok(livros);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(Guid id) {
        var livro = _context.Livros.SingleOrDefault(x => x.Id == id);

        if(livro == null) {
            return NotFound();
        }

        return Ok(livro);
    }

    [HttpPost]
    public IActionResult Post(Livro livro) {
        _context.Livros.Add(livro);

        _context.SaveChanges();
        return CreatedAtAction(nameof(GetById), new {id = livro.Id}, livro);
    }

    [HttpPut("{id}")]
    public IActionResult Update(Guid id, Livro input) {
        var livro = _context.Livros.SingleOrDefault(x => x.Id == id);

        if (livro == null) {
            return NotFound();
        }

        livro.Update(input.Nome, input.Autor, input.Ano);

        _context.Update(livro);
        _context.SaveChanges();

        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id) {
        var livro = _context.Livros.SingleOrDefault(x => x.Id == id);

        if (livro == null) {
            return NotFound();
        }

        livro.Delete();

        _context.SaveChanges();
        return NoContent();
    }
}
