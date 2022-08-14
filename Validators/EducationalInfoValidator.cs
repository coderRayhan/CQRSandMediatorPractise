using FluentValidation;
using MediatrAndCQRSDemo.Entities;

namespace MediatrAndCQRSDemo.Validators
{
    public class EducationalInfoValidator : AbstractValidator<EducationalInfo>
    {
        public EducationalInfoValidator()
        {
            RuleFor(ei => ei.Id).NotNull().NotEmpty();
            RuleFor(ei => ei.HighestDegree).NotNull().NotEmpty();
            RuleFor(ei => ei.CGPA).NotNull().NotEmpty().LessThanOrEqualTo(5);
            RuleFor(ei => ei.PassingYear).NotNull().NotEmpty();
            RuleFor(ei => ei.Institution).NotEmpty().NotNull();
        }
    }
}
