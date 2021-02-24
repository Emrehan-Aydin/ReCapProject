using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Result
{
    public class Result : IResult
    {
        public Result(bool success,string message):this(message)
        {
            Success = success;
        }
        public Result(string message)
        {
            Message = message;
        }
        public bool Success { get; }
        public string Message { get; }
    }
}
