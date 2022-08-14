using FluentValidation;
using MediatrAndCQRSDemo.Entities;

namespace MediatrAndCQRSDemo.Validators
{
    public class PersonalInfoValidator : AbstractValidator<PersonalInfo>
    {
        public PersonalInfoValidator()
        {
            RuleFor(pi => pi.Id).NotNull().NotEmpty();
            RuleFor(pi => pi.Name).NotNull().NotEmpty();
            RuleFor(pi => pi.DoB).NotNull().NotEmpty().GreaterThanOrEqualTo(new DateTime(2010,01,01)).WithMessage("Date of birth must be after 2010/01/01");
            RuleFor(pi => pi.Phone).NotNull().NotEmpty();
            RuleFor(pi => pi.Email).NotEmpty().NotNull();
            RuleFor(pi => pi.Email).EmailAddress().WithMessage("Email address is not valid");
            //RuleFor(pi => pi.IsNew).NotNull().NotEmpty();
        }
    }
}
