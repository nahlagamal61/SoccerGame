namespace SoccerGame.ViewModels
{

    public class PlayerViewModel :BaseViewModel
    {
        public string Name { get; set; }
        public string Nationality { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Byte[] Image { get; set; }
        public Guid TeamId { get; set; }

    }
}
