namespace Players.Validators
{
    using FluentValidation;

    public class PlayerValidator : AbstractValidator<PlayerViewModel>
    {
        public PlayerValidator()
        {
            RuleFor(p => p.Name).NotEmpty();
        }

    }
}
