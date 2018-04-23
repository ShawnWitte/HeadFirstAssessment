using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trein
{
    public class Trein
    {
        private Dictionary<string, Wagon> wagons = new Dictionary<string, Wagon>();
        public void wagonKoppelen(Wagon wagon)
        {
            string key = wagon.getWagonNummer();
            Wagon value = wagon;
            this.wagons.Add(wagon.getWagonNummer(), wagon);
        }
    }
}
