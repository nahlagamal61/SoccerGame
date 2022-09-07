namespace SoccerGame.Controllers
{
    using AutoMapper;
    using BaseLibrary.Auth;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using testm.Validators;


    [Authorize(Roles = UserRoles.Admin)]
    [Authorize(Roles = UserRoles.User)]

    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : BaseController<Team, TeamViewModel>
    {
        public TeamController(ITeamUnitOfWork unitOfWork,
            IMapper mapper,
            TeamValidator validations)
            : base(unitOfWork, mapper, validations) { 
        
        }

    }
}
