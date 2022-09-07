namespace SoccerGame.Mappers
{
    using AutoMapper;

    public class TeamMapper : Profile
    {
        public TeamMapper( )
        {
            CreateMap<Team, TeamViewModel>().ReverseMap();
        }
    }
}
