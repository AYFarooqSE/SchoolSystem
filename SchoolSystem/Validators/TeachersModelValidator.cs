using FluentValidation;
using SchoolSystem.Models;

namespace SchoolSystem.Validators
{
    public class TeachersModelValidator:AbstractValidator<TeachersModel>
    {
        public TeachersModelValidator()
        {
            // Name Valiations
            RuleFor(x=>x.Name).NotNull().NotEmpty();
            //RuleFor(x => x.Name).MinimumLength(10).MaximumLength(20);
            RuleFor(x => x.Name).Length(10, 20);

            // TeacherID Valiations
            RuleFor(x=>x.TeacherID).NotNull().NotEmpty();
            RuleFor(x=>x.TeacherID).Length(5, 10);

            // Hire Date Validation.
            RuleFor(x => x.HireDate).NotNull().NotEmpty();
            var TodaysDate=DateTime.UtcNow;
            RuleFor(x => x.HireDate).LessThanOrEqualTo(TodaysDate);

            // 
            RuleFor(x=>x.DOB).NotNull().NotEmpty();
            // Age is 
            //RuleFor(x=>x.DOB)
        }
    }
}
