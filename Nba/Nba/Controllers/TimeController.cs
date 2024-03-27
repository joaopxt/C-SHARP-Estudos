using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nba.Entities;
using Nba.Entities.Persistence;

namespace Nba.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TimeController : ControllerBase {
    private readonly TimeDbContext _context;

    public TimeController(TimeDbContext context )
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetAll() {
        var times = _context.Times.Where(t => t.IsDeleted == false).ToList();

        return Ok(times);   
    }

    [HttpGet("{id}")] 
    public IActionResult GetById(Guid id) {
        var time = _context.Times.SingleOrDefault(x => x.Id == id);

        if (time == null) {
            return NotFound();
        }

        return Ok(time);
    }

    [HttpPost]
    public IActionResult Post(Time time ) {

        _context.Times.Add(time);

        _context.SaveChanges();
        return CreatedAtAction(nameof(GetById), new { id = time.Id }, time);
    }

    [HttpPut("{id}")]
    public IActionResult Update(Guid id, Time input) {
        var time = _context.Times.SingleOrDefault(t => t.Id == id);

        if(time == null) { 
        return NotFound();
        }

        time.Update(input.Nome, input.Trofeus, input.Conferencia, input.Star);
        _context.Update(time);
        _context.SaveChanges();

        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id) {
        var time = _context.Times.SingleOrDefault(t => t.Id == id);

        if (time == null) {
            return NotFound();
        }

        time.Delete();
        _context.SaveChanges();
        return NoContent();
    }
}
