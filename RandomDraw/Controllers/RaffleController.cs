using Microsoft.AspNetCore.Mvc;
using RandomDraw.Models;
using RandomDraw.Repositories;

namespace RandomDraw.Controllers
{
    [Route("Api/[Controller]")]
    [ApiController]
    public class RaffleController : ControllerBase
    {
        private readonly IRaffleRepository _repo;

        public RaffleController(IRaffleRepository repo)
        {
            _repo = repo;
        }
        [HttpPost]
        public ActionResult Create(Raffle raffle)
        {
            if (_repo.Generate(raffle))
            {
                return Ok("Draw Held");
            }
            return BadRequest();
        }

        [HttpGet]
        public ActionResult Get()
        {
            var get = _repo.ReadAll();
            return Ok(get);
        }

        [HttpGet("SearchId/{id}")]
        public ActionResult GetById(int id)
        {
            var getById = _repo.ReadById(id);
            return Ok(getById);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (_repo.Delete(id))
            {
                return Ok("Raffle Excluded");
            }
            return BadRequest();
        }

    }
}
