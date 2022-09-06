namespace SoccerGame.Mappers
{
    using AutoMapper;
    using SoccerGame.Entities;
    using SoccerGame.ViewModels;

    public class TeamMapper : Profile
    {
        public TeamMapper( )
        {
            CreateMap<Team, TeamViewModel>().ReverseMap();
        }
    }
}
