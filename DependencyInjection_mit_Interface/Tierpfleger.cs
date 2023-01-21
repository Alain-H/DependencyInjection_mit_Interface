using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection_mit_Interface
{
    internal class Tierpfleger 
    {
        public string name{ get; set; }
        public ITier h;
        public Tierpfleger()
        {
            h = new Hund();
        }
        public void setHund(Hund hund)
        {
            h = hund;
        }
        public string setName()
        {
            Console.Write("\nGeben Sie den Namen ein : ");
            name = Console.ReadLine();
            return name;
        }



    }
}
