using Microsoft.AspNetCore.Mvc;
using ITMApi.Models;

namespace ITMApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentasController : ControllerBase
    {
        private readonly MyDbContext _context;

        public VentasController(MyDbContext context)
        {
            _context = context;
        }

        // GET: api/Ventas
        [HttpGet]
        public ActionResult<IEnumerable<Venta>> GetVentas()
        {
            return _context.Ventas.ToList();
        }

        // GET: api/Ventas/{id}
        [HttpGet("{id}")]
        public ActionResult<Venta> GetVenta(int id)
        {
            var venta = _context.Ventas.Find(id);

            if (venta == null)
            {
                return NotFound();
            }

            return venta;
        }

        // POST: api/Ventas
        [HttpPost]
        public ActionResult<Venta> PostVenta(Venta venta)
        {
            _context.Ventas.Add(venta);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetVenta), new { id = venta.Id }, venta);
        }

        // PUT: api/Ventas/5
        [HttpPut("{id}")]
        public IActionResult PutVenta(int id, Venta venta)
        {
            if (id != venta.Id)
            {
                return BadRequest();
            }

            _context.Entry(venta).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();

            return NoContent();
        }

        // DELETE: api/Ventas/5
        [HttpDelete("{id}")]
        public IActionResult DeleteVenta(int id)
        {
            var venta = _context.Ventas.Find(id);
            if (venta == null)
            {
                return NotFound();
            }

            _context.Ventas.Remove(venta);
            _context.SaveChanges();

            return NoContent();
        }
    }
}