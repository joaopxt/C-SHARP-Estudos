using Album.Entities;
using Album.Entities.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Album.Controllers;
[Route("api/[controller]")]
[ApiController]
public class MusicasController : ControllerBase {
    private readonly MusicasDbContext _context;

    public MusicasController(MusicasDbContext context)
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
        var musica = _context.Musicas.Include(x => x.Artistas).SingleOrDefault(x => x.Id == id);

        if (musica == null) {
            return NotFound();
        }

       

        return Ok(musica);
    }

    [HttpPost]
    public IActionResult Post(Musica musica) {
        _context.Musicas.Add(musica);

        _context.SaveChanges();
        return CreatedAtAction(nameof(GetById), new {id = musica.Id}, musica);
    }

    [HttpPut("{id}")]
    public IActionResult Update(Guid id, Musica input) {
        var musica = _context.Musicas.SingleOrDefault(x => x.Id == id);
        if (musica == null) {
            return NotFound();
        }

        _context.Update(musica);
        _context.SaveChanges();
        musica.Update(input.Nome, input.Artistas, input.Genero);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id) { 
        var musica = _context.Musicas.SingleOrDefault(x => x.Id == id);

        if(musica == null) {
            return NotFound();
        }

        musica.Delete();
        _context.SaveChanges();
        return NoContent(); 
    }

    [HttpPost("{id}")]
    public IActionResult PostArtista(Guid id, Artista artista) {
        artista.ArtistaId = id;

        var musica = _context.Musicas.Any(x => x.Id == id);

        if (!musica) {
            return NotFound();
        }

        _context.Artistas.Add(artista);
        _context.SaveChanges();
        return NoContent();
    }


}
