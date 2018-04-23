using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trein
{
    public class Trein
    {
        private Dictionary<int, Wagon> wagons = new Dictionary<int, Wagon>();
        public void wagonKoppelen(Wagon wagon)
        {
            int key = wagon.getWagonNummer();
            Wagon value = wagon;
            this.wagons.Add(wagon.getWagonNummer(), wagon);
        }

        private int wagonCount()
        {
            return wagons.Count();
        }

        public override string ToString()
        {
            return "Er zit(ten) " + wagonCount() + " wagon(s) aan de trein";
        }
    }


}
