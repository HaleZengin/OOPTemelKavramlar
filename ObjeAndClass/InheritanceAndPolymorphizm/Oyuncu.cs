using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphizm
{
    internal class Oyuncu
    {
        public string Nick { get; set; }

        public Silah OyuncununSilahi { get; set; }

    }

    public class Silah
    {
        public int Agirlik { get; set; }
        public int VurusGucu { get; set; }
        public void Atak()
        {

        }
    }

    public class Bicak : Silah      // bicak silah'a extends yapilmis demek
    {

    }
    public class AtesliSilah : Silah
    {
        public bool SeriMi { get; set; }
        public int MaksimumMermi { get; set; }
    }

    public class Tufek : AtesliSilah
    {
        public bool DurbunVarMi { get; set; }
    }

    public class Ak47 : Tufek
    {

    }
}

