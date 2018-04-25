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
            Reiziger piet = new Reiziger("Piet", 1, "Vlissingen");
            Reiziger hans = new Reiziger("Hans", 2, "Vlissingen");
            Reiziger jaap = new Reiziger("Jaap", 2, "Vlissingen");
            Reiziger kees = new Reiziger("Kees", 2, "Vlissingen");
            Reiziger peter = new Reiziger("Peter", 2, "Vlissingen");
            Reiziger timon = new Reiziger("Timon", 2, "Vlissingen");


            //Laten instappen
            wagon.instappen(piet);
            wagon.instappen(hans);
            wagon.instappen(jaap);
            wagon.instappen(kees);
            wagon.instappen(peter);
            wagon.instappen(timon);


            Console.WriteLine(wagon);

            wagon.uitstappen("Peter");
            Console.WriteLine(wagon);
            Console.WriteLine(trein);


            Console.ReadLine();
        }
    }
}
