using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trein
{
    public class Reiziger
    {
        private string name;
        private int kaartje;
        private string bestemming;

        public Reiziger(string name, int kaartje, string bestemming)
        {
            this.name = name;
            this.kaartje = kaartje;
            this.bestemming = bestemming;
        }

        public string getName()
        {
            return this.name;
        }

        public int getKaartje()
        {
            return this.kaartje;
        }

        public string getBestemming()
        {
            return this.bestemming;
        }

        
    }
}
