using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Result
{
    public class ErrorResult:Result
    {
        public ErrorResult(bool success,string message):base(false,message)
        {
                
        }
        public ErrorResult(string message):base(false,default)
        {
                
        }
    }
}
