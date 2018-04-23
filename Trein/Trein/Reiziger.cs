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

        public Reiziger(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return this.name;
        }

        public Reiziger(int kaartje)
        {
            this.kaartje = kaartje;
        }

        public int getKaartje()
        {
            return this.kaartje;
        }

        
    }
}
