namespace SoccerGame.ViewModels
{

    public class TeamViewModel :BaseViewModel
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public DateTime FoundationDate { get; set; }
        public string CoachName { get; set; }
        public byte[] Logo { get; set; }
        public List<Player> Players { get; set; }

    }
}
