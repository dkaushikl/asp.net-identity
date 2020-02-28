namespace Demo.API.Models
{
    using FluentValidation;

    public class ChangePasswordModelValidator : AbstractValidator<ChangePasswordModel>
    {
        public ChangePasswordModelValidator(ChangePasswordModel model)
        {
            this.RuleFor(x => x.OldPassword).NotEmpty().NotNull().WithMessage("Old password is required.");

            this.RuleFor(x => x.NewPassword).NotEmpty().NotNull().WithMessage("New password is required.");
        }
    }
}