using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    class Kisi
    {
        private string adSoyad;
        public string AdSoyad
        {
            get { return adSoyad; }
            set { adSoyad = value; }
        }

        private string kullaniciAdi;
        public string KullaniciAdi
        {
            get { return kullaniciAdi; }
            set { kullaniciAdi = value; }
        }

        private string sifre;
        public string Sifre
        {
            get { return sifre; }
            set { sifre = value; }
        }

        private string mail;
        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }
    }
}
