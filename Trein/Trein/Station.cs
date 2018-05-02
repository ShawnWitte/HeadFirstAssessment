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
        private string stad;

        public Station(string stad)
        {
            this.stad = stad;
        }

        public string getStad()
        {
            return stad;
        }

        

    }
}
