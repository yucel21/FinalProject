using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //2 parametre gönderen biri yukardaki çalışıyor
        //this ile aşağıdaki metodu da kapsadığı için aşağıdaki kodu da çalıştırıyoruz
        public Result(bool success, string message):this(success)
        {
            Message = message;
        }

        public Result(bool success)
        {            
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
