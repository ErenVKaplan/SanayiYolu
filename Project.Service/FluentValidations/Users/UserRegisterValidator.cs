using FluentValidation;
using Project.Data.ViewModels.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Service.FluentValidations.Users
{
    public class UserRegisterValidator : AbstractValidator<UserRegisterViewModel>
    {
        public UserRegisterValidator()
        {
            RuleFor(x => x.FirstName)
                .NotEmpty()
                .NotNull();
            RuleFor(x => x.LastName)
                .NotEmpty()
                .NotNull();

            RuleFor(x => x.Email)
                .NotEmpty()
                .NotNull()
                .EmailAddress();

            RuleFor(x => x.Password)
                .NotEmpty()
                .NotNull();

            RuleFor(x => x.PasswordConfirm)
                .NotEmpty()
                .NotNull()
                .Equal(x => x.Password);
        }
    }
}
