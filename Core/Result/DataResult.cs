using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Result
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T data,bool success,string message):base(success,message)
        {
            Data = data;
        }
        public DataResult(T data ,bool success):base(success,default)
        {
            Data = data;
        }
        public T Data { get; set; }
    }
}
