using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConserns.Validator
{
    public static class ValidationTool
    {
        public static void Validate(IValidator validator,object entity)
        {
            var context = new ValidationContext<Object>(entity);
            //ProductValidator productValidator = new ProductValidator();
            var result = validator.Validate(context);

            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
