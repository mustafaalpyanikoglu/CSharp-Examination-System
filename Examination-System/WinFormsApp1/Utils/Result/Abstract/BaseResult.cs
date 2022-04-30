using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    abstract class BaseResult<T> //Generic type
    {
        public bool isSuccess;

        public T data;

        public BaseResult(bool isSuccess,T data)
        {
            this.isSuccess = isSuccess;
            this.data = data;
        }
    }
}
