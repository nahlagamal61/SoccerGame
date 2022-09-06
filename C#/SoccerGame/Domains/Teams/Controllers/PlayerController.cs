namespace SoccerGame.Controllers
{
    using AutoMapper;
    using BaseLibrary.UnitOfWorks;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using SoccerGame.Entities;
    using SoccerGame.UnitOfWorks;
    using SoccerGame.ViewModels;

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
