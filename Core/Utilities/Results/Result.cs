using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool isSuccess, string message): this(isSuccess) // iki constructer da çalışsın... tek parametreli ctorda çalışır durumda. base constructer örneği.
        {
            this.Message = message; 
            /* get readonlydir constructerda set edilebilir. 
             * constructer'da set edilmesi için prop sadece get verildi.
             * amaç sınırlamak ve standardize etmektir.*/

        }
        // overloading
        public Result(bool isSuccess)
        {
            Success = isSuccess;
        }
        public bool Success { get; }

        public string Message { get; }
    }
}
