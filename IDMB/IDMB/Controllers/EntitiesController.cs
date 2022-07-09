using IDMB.EntittyData;
using IDMB.Models;
using Microsoft.AspNetCore.Mvc;

namespace IDMB.Controllers
{
    [Route("api/entities")]
    [ApiController]
    public class EntitiesController : Controller
    {
        private readonly IEntity _entity;

        public EntitiesController(IEntity entity)
        {
            _entity = entity;
        }

        [HttpGet("movies")]
        public List<Entities> GetMovies()
        {
            return _entity.GetMovies();
        }

        [HttpPost("movie")]
        public Entities CreateMovie([FromBody] Entities entities)
        {
            return _entity.Create(entities);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateMovie(Guid id,Entities entities)
        {
            var existingEntites = _entity.GetMovieEntity(id);
            if(existingEntites != null)
            {
                entities.Id = existingEntites.Id;
                entities.Movie.MovieId = existingEntites.Movie.MovieId;
                entities.Producer.ProducerId = existingEntites.Producer.ProducerId;
                entities.Actors.ActorId = existingEntites.Actors.ActorId;
                _entity.Update(entities);
            }
            return Ok(entities);

        }
    }
}
