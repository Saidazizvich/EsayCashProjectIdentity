using EsayCashProjectIdentity_Dto.Dtos.AppUsersDto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsayCashProjectIdentity_Business.ValidationRules.AppUser.AppUserValidation
{
    public class AppUserValidator : AbstractValidator<AppUserRegisterDto>
    {
        public AppUserValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name is not empty");
            RuleFor(x => x.SurName).NotEmpty().WithMessage("SurName is not empty");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("UserName is not empty");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email is not empty");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password is not empty");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("ConfirmPassword is not empty");
            RuleFor(z => z.Name).MaximumLength(30).WithMessage("Plese you write 30 character login");
            RuleFor(z => z.Name).MaximumLength(30).WithMessage("Plese you write 30 character login");
            RuleFor(z => z.Name).MaximumLength(2).WithMessage("Plese you write 2 character login");
            RuleFor(z => z.ConfirmPassword).Equal(z => z.Password).WithMessage("Password is not equal");
            RuleFor(z => z.Email).EmailAddress().WithMessage("Plesea you write email login");


        }
    }
}
