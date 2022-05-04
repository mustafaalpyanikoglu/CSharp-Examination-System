using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    class ErrorResult<T>:BaseResult<T>
    {
        //Generic type ile hem veriyi hemde hatalı olduğunu geri dönderiyoruz.
        public string error;
        public ErrorResult(string error,T data):base(false,data)
        {
            this.error = error;
        }
    }
}
