using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public abstract class Spor
    {

        public abstract void AntrenmanYap();
    }

    public abstract class DovusSporu : Spor
    {
        public abstract bool NakavtMi();
    }

    public class Boks : DovusSporu
    {
        public override void AntrenmanYap()
        {
            throw new NotImplementedException();
        }

        public override bool NakavtMi()
        {
            throw new NotImplementedException();
        }

    }
}
