namespace testm.Validators
{
    using FluentValidation;

    public class TeamValidator : AbstractValidator<TeamViewModel>
    {
        public TeamValidator()
        {
            RuleFor(p => p.Name).NotEmpty();
        }

    }
}
