using Carros.Entities;
using Carros.Entities.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Carros.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CarrosController : ControllerBase {

    private readonly CarrosDbContext _context;

    public CarrosController(CarrosDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetAll() {

        var carros = _context.Carros.Where(x => x.IsDeleted != true).ToList(); 

        return Ok(carros);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(Guid id) {
        var carro = _context.Carros.SingleOrDefault(x => x.Id == id);

        if(carro == null) {
            return NotFound();
        }

        return Ok(carro);
    }

    [HttpPost]
    public IActionResult Post(Carro carro) {
        _context.Carros.Add(carro);

        _context.SaveChanges();

        return CreatedAtAction(nameof(GetById), new {id = carro.Id}, carro);
    }

    [HttpPut("{id}")]
    public IActionResult Update(Guid id, Carro input) {
        var carro = _context.Carros.SingleOrDefault(x => x.Id == id);

        if(carro == null) {
            return NotFound();
        }

        carro.Update(input.Modelo, input.Ano, input.Marca, input.Preco);

        _context.Carros.Update(carro);
        _context.SaveChanges();

        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id) {
        var carro = _context.Carros.SingleOrDefault(x => x.Id == id);


        if(carro == null) {
            return NotFound();
        }

        carro.Delete();
        //_context.Carros.Remove(carro);  
        _context.SaveChanges(); 

        return NoContent(); 
    }
}
