namespace SoccerGame.Controllers
{
    using AutoMapper;
    using BaseLibrary.BaseEntities;
    using BaseLibrary.UnitOfWorks;
    using BaseLibrary.ViewModels;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    

    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<TEntity , TViewModel> : ControllerBase 
        where TEntity : BaseEntity
        where TViewModel: BaseViewModel
    {
        private readonly IBaseUnitOfWork<TEntity > _unitOfWork;
        private readonly IMapper _mapper;

        public BaseController(IBaseUnitOfWork<TEntity> unitOfWork , IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<TEntity>> GettAll()
        {
            return Ok(await _unitOfWork.ReadAsync());

            //List<TEntity> entities = await _unitOfWork.ReadAsync();
            //var tViewModel= entities.Select(tEntity => _mapper.Map<TViewModel>(tEntity));
            //return Ok(tViewModel);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<TEntity>> GetById(Guid id)
        {
            var entity = await _unitOfWork.ReadByIdAsync(id);
            if(entity == null) 
                return NotFound();
            return Ok(entity);
            //var entity = await _unitOfWork.ReadByIdAsync(id);
            //if (entity == null)
            //    return NotFound();
            //TViewModel viewModel = _mapper.Map<TViewModel>(entity);
            //return Ok(viewModel);
        }

        [HttpPost]
        public async Task<ActionResult<TEntity>> Post(TViewModel viewModel)
        {
            var entity = _mapper.Map<TEntity>(viewModel);
            return await _unitOfWork.CreateAsync(entity);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteTeam(Guid id)
        {
            var entity = await _unitOfWork.ReadByIdAsync(id);
            if (entity == null)
                return NotFound();
            await _unitOfWork.DeleteAsync(entity.Id);
            return Ok();
        }

    }
}
