using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection_mit_Interface
{
    internal class Hund : ITier
    {
        Hund hund;

        public string Name{get; set;}

        public override string ToString()
        {
            return $"Hund [name = " + Name + "]";
        }

        public void setTier(Hund h)
        {
            hund = h;
        }

        public Hund getTier()
        {
            return hund;
        }

    }
}
