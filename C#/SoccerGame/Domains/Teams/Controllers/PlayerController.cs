namespace SoccerGame.Controllers
{
    using AutoMapper;
    using BaseLibrary.Auth;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using SoccerGame.Entities;
    using SoccerGame.UnitOfWorks;
    using SoccerGame.ViewModels;
  

    [Authorize(Roles = UserRoles.Admin)]
   // [Authorize(Roles = UserRoles.User)]

    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : BaseController<Player, PlayerViewModel>
    {
        public PlayerController(IPlayerUnitOfWork unitOfWork, IMapper mapper)
            : base(unitOfWork, mapper)
        {
        }
    }
}
