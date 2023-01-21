using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection_mit_Interface
{
    internal interface ITier
    {
        string Name { get; set;}
        Hund getTier();
        void setTier(Hund h);
        string ToString();
        
    }
}
