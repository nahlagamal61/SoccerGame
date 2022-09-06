namespace SoccerGame.Mappers
{
    using AutoMapper;
    using SoccerGame.Entities;
    using SoccerGame.ViewModels;

    public class PlayerMapper : Profile
    {
        public PlayerMapper()
        {
            CreateMap<Player, PlayerViewModel>().ReverseMap();
        }
    }
}
