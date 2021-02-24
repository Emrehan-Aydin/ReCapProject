using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Result
{
    public class ErrorDataResult<T>:DataResult<T>
    {
        public ErrorDataResult(T data, string message) : base(data, true, message)
        {

        }
        public ErrorDataResult(T data) : base(data, true, default)
        {

        }
        public ErrorDataResult(string message) : base(default, true, message)
        {

        }
        public ErrorDataResult() : base(default, true)
        {

        }
    }
}
