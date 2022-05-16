using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    //Bu tipler sayesinde Hangi işlemi kimin yapabileceğini sınırlandırıyoruz.
    public enum UserType 
    {
        ADMIN, //admin
        EXAMINER, //sınav sorumlusu
        CUSTOMER //müşteri-öğrenci
    }
}
