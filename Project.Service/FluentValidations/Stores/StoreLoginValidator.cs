using FluentValidation;
using Project.Data.ViewModels.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Service.FluentValidations.Stores
{
    public class StoreLoginValidator : AbstractValidator<StoreLoginViewModel>
    {
        public StoreLoginValidator()
        {
            RuleFor(x => x.Email)
                .NotEmpty()
                .NotNull()
                .EmailAddress();

            RuleFor(x => x.Password)
                .NotEmpty()
                .NotNull();
        }
    }
}
