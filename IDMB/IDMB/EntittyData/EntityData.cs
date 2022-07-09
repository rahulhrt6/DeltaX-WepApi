using IDMB.Models;

namespace IDMB.EntittyData
{
    public class EntityData : IEntity
    {
        private readonly EntityContext _entityContext;

        public EntityData(EntityContext entityContext)
        {
            _entityContext = entityContext;
        }

        public Entities Create(Entities entities)
        {
            entities.Id = Guid.NewGuid();
            entities.Movie.MovieId = Guid.NewGuid();
            foreach(var item in entities.Movie.Actors)
            {
                item.ActorId = Guid.NewGuid();
            }
            entities.Producer.ProducerId = Guid.NewGuid();
            entities.Actors.ActorId = Guid.NewGuid();
            _entityContext.Entities.Add(entities);
            _entityContext.SaveChanges();
            return entities;
        }

        public Entities GetMovieEntity(Guid Id)
        {
            return _entityContext.Entities.Single(x => x.Id == Id);
        }

        public List<Entities> GetMovies()
        {
            var list = _entityContext.Entities.ToList();
            return list;
        }

        public Entities Update(Entities entities)
        {
            var existing = GetMovieEntity(entities.Id);
            existing.Producer = entities.Producer;
            existing.Actors = entities.Actors;
            existing.Movie = entities.Movie;
            _entityContext.Entities.Update(entities);
            _entityContext.SaveChanges();
            return existing;
        }
    }
}
