namespace SoccerGame.Controllers
{
    using AutoMapper;
    using BaseLibrary.UnitOfWorks;
    using Microsoft.AspNetCore.Mvc;
    using SoccerGame.Entities;
    using SoccerGame.UnitOfWorks;
    using SoccerGame.ViewModels;

    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : BaseController<Team, TeamViewModel>
    {
        public TeamController(ITeamUnitOfWork unitOfWork, IMapper mapper) :
            base(unitOfWork, mapper)
        {
        }
    }
}
