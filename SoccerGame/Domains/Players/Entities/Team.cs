namespace SoccerGame.Entities
{

    public class Team : BaseEntity
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public DateTime FoundationDate { get; set; }
        public string CoachName { get; set; }
        public string Logo { get; set; }
        public TeamType TeamType { get; set; }
        public Guid PlayerId { get; set; }
        public List<Player> Players { get; set; }

    }
}
