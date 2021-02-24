using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Business
{
    public interface IBusinessRules
    {
        IResult Run(params IResult[] logics);
    }
}
