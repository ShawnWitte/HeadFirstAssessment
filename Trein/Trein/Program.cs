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
            //Wagon aanmaken
            Wagon wagon = new Wagon(6);
            Trein trein = new Trein();
            trein.wagonKoppelen(wagon);

            //Instappers aanmaken
            EersteKlas piet = new EersteKlas("Piet");
            Tweedeklas hans = new Tweedeklas("Hans");
            ZwartRijder thomas = new ZwartRijder("Thomas");
            
            //Laten instappen
            wagon.instappenEerste(piet);
            wagon.instappenTweede(hans);
            wagon.instappenZwart(thomas);
            Console.WriteLine(wagon);
            Console.WriteLine(trein);

            

            Console.ReadLine();
        }
    }
}
