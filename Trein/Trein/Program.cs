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
            Reiziger piet = new Reiziger("Piet", 1);
            Reiziger hans = new Reiziger("Hans", 2);
            
            
            //Laten instappen
            wagon.instappen(piet);
            wagon.instappen(hans);

            Console.WriteLine(wagon);

            wagon.uitstappen(piet);
            wagon.uitstappen(hans);
            
            Console.WriteLine(wagon);
            Console.WriteLine(trein);

            

            Console.ReadLine();
        }
    }
}
