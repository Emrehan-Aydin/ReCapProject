using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Result
{
    public class SuccessResult:Result
    {
        public SuccessResult(bool success, string message) : base(true, message)
        {

        }
        public SuccessResult(string message) : base(true, message)
        {

        }
    }
}
