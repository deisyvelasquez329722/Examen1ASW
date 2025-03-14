using Microsoft.AspNetCore.Mvc;
using ITMApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace ITMApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComputadoresController : ControllerBase
    {
        private readonly MyDbContext _context;

        public ComputadoresController(MyDbContext context)
        {
            _context = context;
        }

        // GET: api/Computadores
        [HttpGet]
        public ActionResult<IEnumerable<Computador>> GetComputadores()
        {
            return _context.Computadores.ToList();
        }

        // GET: api/Computadores/5
        [HttpGet("{id}")]
        public ActionResult<Computador> GetComputador(int id)
        {
            var computador = _context.Computadores.Find(id);

            if (computador == null)
            {
                return NotFound();
            }

            return computador;
        }

        // POST: api/Computadores
        [HttpPost]
        public ActionResult<Computador> PostComputador(Computador computador)
        {
            _context.Computadores.Add(computador);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetComputador), new { id = computador.Id }, computador);
        }

        // PUT: api/Computadores/5
        [HttpPut("{id}")]
        public IActionResult PutComputador(int id, Computador computador)
        {
            if (id != computador.Id)
            {
                return BadRequest();
            }

            _context.Entry(computador).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();

            return NoContent();
        }

        // DELETE: api/Computadores/5
        [HttpDelete("{id}")]
        public IActionResult DeleteComputador(int id)
        {
            var computador = _context.Computadores.Find(id);
            if (computador == null)
            {
                return NotFound();
            }

            _context.Computadores.Remove(computador);
            _context.SaveChanges();

            return NoContent();
        }
    }
}