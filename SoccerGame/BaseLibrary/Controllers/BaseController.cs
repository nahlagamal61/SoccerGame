namespace SoccerGame.Controllers
{
    using AutoMapper;
    using BaseLibrary.BaseEntities;
    using BaseLibrary.UnitOfWorks;
    using BaseLibrary.ViewModels;
    using FluentValidation;
    using Microsoft.AspNetCore.Mvc;
    using System.ComponentModel.DataAnnotations;

    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<TEntity , TViewModel> : ControllerBase 
        where TEntity : BaseEntity
        where TViewModel: BaseViewModel
    {
        private readonly IBaseUnitOfWork<TEntity > _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IValidator<TViewModel> _validator;

        public BaseController(IBaseUnitOfWork<TEntity> unitOfWork ,
            IMapper mapper,
            IValidator<TViewModel> validator)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _validator = validator;
        }

        [HttpGet]
        public virtual async Task<ActionResult<TViewModel>> Get()
        {
            List<TEntity> entities = await _unitOfWork.ReadAsync();
            return Ok( entities.Select(entity => _mapper.Map<TViewModel>(entity)));

        }


        [HttpGet("{id}")]
        public virtual async Task<ActionResult<TViewModel>> Get(Guid id)
        {
            var entity = await _unitOfWork.ReadByIdAsync(id);
            if(entity == null) 
                return NotFound();
            TViewModel viewModel = _mapper.Map<TViewModel>(entity);
            return Ok(viewModel);
        }


        [HttpPost]
        public async Task<IActionResult> Post([FromBody] TViewModel viewModel)
        {
        //    ValidationResult validationResult =  _validator.ValidateAsync(viewModel);
        //    if (! validationResult.IsValid)
        //        return BadRequest();

            var entity = _mapper.Map<TEntity>(viewModel);
            entity = await _unitOfWork.CreateAsync(entity);
            return CreatedAtAction(nameof(Get), new { id = entity.Id }, _mapper.Map<TViewModel>(entity));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromBody] TViewModel viewModel)
        {
            var entity = _mapper.Map<TEntity>(viewModel);
            entity = await _unitOfWork.UpdateAsync(entity);
            return Ok(_mapper.Map<TViewModel>(entity));
        }

        [HttpDelete("{id}")]
        public virtual async Task<ActionResult> DeleteTeam(Guid id)
        {
            var entity = await _unitOfWork.ReadByIdAsync(id);
            if (entity == null)
                return NotFound();
            await _unitOfWork.DeleteAsync(entity.Id);
            return Ok();
        }

    }
}