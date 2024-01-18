using FluentValidation;
using Project.Data.ViewModels.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Service.FluentValidations.Stores
{
    public class StoreDetailsValidator : AbstractValidator<StoreDetailsViewModel>
    {
        public StoreDetailsValidator()
        {
            RuleFor(x => x.StoreName)
                .NotNull()
                .NotEmpty();
            RuleFor(x => x.StoreDescription)
                .NotNull()
                .NotEmpty();
            RuleFor(x => x.StoreSlogan)
                .NotNull()
                .NotEmpty();
            RuleFor(x => x.CrewSize)
                .NotNull()
                .NotEmpty();
            RuleFor(x => x.OpeningTime)
                .NotNull()
                .NotEmpty();
            RuleFor(x => x.ClosingTime)
                .NotNull()
                .NotEmpty();
        }
    }
}
