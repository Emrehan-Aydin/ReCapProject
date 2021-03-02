using Entities.Abstract;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentVValidation
{
    class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.DailyPrice).NotEmpty();
            RuleFor(c => c.Description).MinimumLength(2);
            RuleFor(c => c.BrandId).NotEmpty();
            RuleFor(c => c.DailyPrice).GreaterThan(0);
        }
    }
}
