using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    class ErrorResult<T>:BaseResult<T>
    {
        public ErrorResult(T data):base(false,data)
        {
        }
    }
}
