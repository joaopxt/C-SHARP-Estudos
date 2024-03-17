using Album.Entities;
using Album.Entities.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Album.Controllers;
[Route("api/[controller]")]
[ApiController]
public class MusicasController : ControllerBase {
    private readonly MusicasDBContext _context;

    public MusicasController(MusicasDBContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetAll() { 
    var musicas = _context.Musicas.Where(x => !x.IsDeleted).ToList();

        return Ok(musicas);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(Guid id) {
        var musica = _context.Musicas.SingleOrDefault(x => x.Id == id);

        if (musica == null) {
            return NotFound();
        }

        return Ok(musica);
    }

    [HttpPost]
    public IActionResult Post(Musica musica) {
        _context.Musicas.Add(musica);

        return CreatedAtAction(nameof(GetById), new {id = musica.Id}, musica);
    }

    [HttpPut("{id}")]
    public IActionResult Update(Guid id, Musica input) {
        var musica = _context.Musicas.SingleOrDefault(x => x.Id == id);
        if (musica == null) {
            return NotFound();
        }

        musica.Update(input.Nome, input.Artista, input.Genero);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id) { 
        var musica = _context.Musicas.SingleOrDefault(x => x.Id == id);

        if(musica == null) {
            return NotFound();
        }

        musica.Delete();

        return NoContent(); 
    }
}
