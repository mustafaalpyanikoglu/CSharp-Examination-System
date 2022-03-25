using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    class SuccessResult<T>:BaseResult<T>
    {
        public SuccessResult(T data):base(true,data)
        {

        }
    }
}
