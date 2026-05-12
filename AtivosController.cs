using Microsoft.AspNetCore.Mvc;
using PetroAtivos324133695.Data;
using PetroAtivos324133695.Models;

namespace PetroAtivos324133695.Controllers
{
    [ApiController]
    [Route("ativos")]
    public class AtivosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AtivosController(AppDbContext context)
        {
            _context = context;
        }

    
        [HttpGet]
        public ActionResult<List<Ativo>> Get()
        {
            return Ok(_context.Ativos.ToList());
        }

        
        [HttpPost]
        public ActionResult Post(Ativo ativo)
        {
            _context.Ativos.Add(ativo);

            _context.SaveChanges();

            return Ok(ativo);
        }
    }
}   
