using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trein
{
    public class Station
    {
        private Stack<Reiziger> perron = new Stack<Reiziger>();

        public void rijdtBinnen(Wagon wagon)
        {
            leegWagon(wagon);
            vulWagon(wagon);
            
        }

        public void leegWagon(Wagon wagon)
        {
            foreach(string name in wagon.getNamesEerste())
            {
                Reiziger uitgestapte = wagon.uitstappen(name);
                perron.Push(uitgestapte);
                wagon.uitstappen(name);
            }
        }

        public void vulWagon(Wagon wagon)
        {
            while (perron.Any())
            {
                Reiziger opgestapelde = perron.Pop();
                wagon.instappen(opgestapelde);
            }
        }
    }
}
