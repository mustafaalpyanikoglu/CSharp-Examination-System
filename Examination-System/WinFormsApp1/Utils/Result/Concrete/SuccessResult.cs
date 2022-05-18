using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    //Generic type ile hem veriyi hemde başarılı olduğunu geri dönderiyoruz.
    class SuccessResult<T>:BaseResult<T>
    {
        public string success;
        public SuccessResult(string success,T data):base(true,data)
        {
            this.success = success;
        }
    }
}
