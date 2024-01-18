using FluentValidation;
using Project.Data.ViewModels.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Service.FluentValidations.Stores
{
    public class StoreRegisterValidator : AbstractValidator<StoreRegisterViewModel>
    {
        public StoreRegisterValidator()
        {
            RuleFor(x => x.Email)
                .NotEmpty()
                .NotNull()
                .EmailAddress();

            RuleFor(x => x.FirstName)
                .NotEmpty()
                .NotNull();

            RuleFor(x => x.LastName)
                .NotEmpty()
                .NotNull();
            
            RuleFor(x => x.StoreName)
                .NotEmpty()
                .NotNull();

            RuleFor(x => x.Password)
                .NotEmpty()
                .NotNull();
            RuleFor(x => x.PasswordConfirm)
                .NotEmpty()
                .NotNull()
                .Equal(x => x.Password);

            RuleFor(x => x.CountryId)
                .NotEmpty()
                .NotNull();
            RuleFor(x => x.CityId)
                .NotEmpty()
                .NotNull();
            RuleFor(x => x.DistrictId)
                .NotEmpty()
                .NotNull();
        }
    }
}
