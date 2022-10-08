using Entities.Constrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.ValidationRules.FluentValidation
{
   public class CarImageValidator: AbstractValidator<CarImage>
    {
        public CarImageValidator()
        {
            RuleFor(c => c.CarId).Empty();
        }

    }
}
