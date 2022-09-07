namespace SoccerGame.Mappers
{
    using AutoMapper;

    public class PlayerMapper : Profile
    {
        public PlayerMapper()
        {
            CreateMap<Player, PlayerViewModel>().ReverseMap();
        }
    }
}
