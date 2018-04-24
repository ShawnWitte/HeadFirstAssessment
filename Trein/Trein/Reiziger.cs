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

        public Reiziger(string name, int kaartje)
        {
            this.name = name;
            this.kaartje = kaartje;
        }

        public string getName()
        {
            return this.name;
        }

        public int getKaartje()
        {
            return this.kaartje;
        }

        
    }
}
