using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encupsulation
{
    internal class Urun
    {

        public string Ad;
        private decimal fiyat;

        public void SetFiyat(decimal deger)
        {
            if (deger > 0)
            {
                fiyat = deger;
            }
            else
            {
                throw new Exception("Değer 0'dan büyük olmalıdır!");
            }

        }

        public decimal GetFiyat()
        {
            return fiyat;
        }

    }
}
