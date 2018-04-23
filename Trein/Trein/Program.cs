using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trein
{
    class Program
    {
        static void Main(string[] args)
        {
            Wagon wagon = new Wagon();
            EersteKlas piet = new EersteKlas("Piet");
            Tweedeklas hans = new Tweedeklas("Hans");
            
            wagon.instappenEerste(piet);
            wagon.instappenTweede(hans);
            Console.WriteLine(wagon);

            Console.ReadLine();
        }
    }
}
