using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    //Cross Cutting Conserns validation,log,cache,transaction,authorization,
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.ProductName).MinimumLength(2);
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.UnitPrice).GreaterThan(0);
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(0).When(p => p.CategoryId == 1);
            RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("A harfi ile başlamalı");
        }
        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
