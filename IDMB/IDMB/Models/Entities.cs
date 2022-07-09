using System.ComponentModel.DataAnnotations;

namespace IDMB.Models
{
    public class Entities
    {
        [Key]
        public Guid Id { get; set; }

        public Movie Movie { get; set; } = new();

        public Producer Producer { get; set; } = new();

        public Actor Actors { get; set; } = new();
    }

    public class Movie
    {
        [Key]
        public Guid MovieId { get; set; }
        public string MovieName { get; set; }
        public string Plot { get; set; }
        public string ProducerName { get; set; }
        public DateTime DateOfRelease { get; set; }
        public List<Actor> Actors { get; set; } = new();
    }

    public class Producer
    {
        [Key]
        public Guid ProducerId { get; set; }
        public string ProducerName { get; set; }
        public string Bio { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
    }

    public class Actor
    {
        [Key]
        public Guid ActorId { get; set; }
        public string ActorName { get; set; }
        public string Bio { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
    }   
}
