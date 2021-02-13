using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessDataResult_<T> : SuccessDataResult<T>
    {
        public SuccessDataResult_(T data,string message): base(data,true,message)
        {

        }
        public SuccessDataResult_(T data): base(data,true)
        {

        }

        public SuccessDataResult_(string message): base(default,true,message)
        {

        }

        public SuccessDataResult_(): base(default,true)
        {

        }
    }
}
