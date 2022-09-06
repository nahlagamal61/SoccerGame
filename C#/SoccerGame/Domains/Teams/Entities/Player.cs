namespace SoccerGame.Entities
{
    using BaseLibrary.BaseEntities;


    public class Player : BaseEntity
    {
        public string Name { get; set; }
        public string Nationality { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Byte[] Image { get; set; }
       // public Team Team { get; set; }
        public Guid TeamId { get; set; }

    }
}
