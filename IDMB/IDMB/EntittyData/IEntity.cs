using IDMB.Models;

namespace IDMB.EntittyData
{
    public interface IEntity
    {
        public Entities Create(Entities entities);

        public List<Entities> GetMovies();
        public Entities GetMovieEntity(Guid Id);

        public Entities Update(Entities entities);
    }
}
