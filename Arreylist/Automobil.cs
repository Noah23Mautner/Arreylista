using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreylist
{
    internal class Automobil
    {
        private string marka;
        public Automobil(string marka)
        {
            this.marka = marka;

        }

        public string DajMarku()
        { return marka; }
    }
}
