using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public enum UserType //Bu tipler sayesinde Hangi işlemi kimin yapabileceğini sınırlandırıyoruz.
    {
        ADMIN, //admin
        EXAMINER, //sınav sorumlusu
        CUSTOMER //müşteri-öğrenci
    }
}
