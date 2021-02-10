using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T> :Result, IDataResult<T>
    {
        public SuccessDataResult(T data, bool isSuccess, string message): base(isSuccess,message)
        {
            Data = data;

        }
        public SuccessDataResult(T data,bool isSuccess) : base(isSuccess)
        {
            Data = data;

        }
        public T Data { get; }

    }
}
