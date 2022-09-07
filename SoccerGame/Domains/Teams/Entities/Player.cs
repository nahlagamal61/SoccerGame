namespace SoccerGame.Entities
{

    public class Player : BaseEntity
    {
        public string Name { get; set; }
        public string Nationality { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Image { get; set; }
        public Guid TeamId { get; set; }

    }
}
