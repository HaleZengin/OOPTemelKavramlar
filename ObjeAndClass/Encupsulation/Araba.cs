using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encupsulation
{
    internal class Araba
    {

        int hiz = 0;
        bool motorCalisiyorMu = false;
        public void GazaBas()
        {
            if (motorCalisiyorMu)
            {
                hiz++;
            }
        }

        public void Calistir()
        {
            motorCalisiyorMu = true;
        }

    }
}
