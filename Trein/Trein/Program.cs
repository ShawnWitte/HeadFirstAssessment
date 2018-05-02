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
            //Stations aanmaken
            Station goes = new Station("Goes");
            Station arnemuiden = new Station("Arnemuiden");
            Station middelburg = new Station("Middelburg");
            Station vlissingensouburg = new Station("Vlissingen-Souburg");
            Station vlissingen = new Station("Vlissingen");

            //Wagon aanmaken
            Wagon wagon = new Wagon(6);
            Trein trein = new Trein();
            trein.wagonKoppelen(wagon);

            //Instappers aanmaken
            Reiziger piet = new Reiziger("Piet", 2, "Vlissingen");
            Reiziger hans = new Reiziger("Hans", 2, "Vlissingen");
            Reiziger jaap = new Reiziger("Jaap", 2, "Vlissingen");
            Reiziger kees = new Reiziger("Kees", 2, "Vlissingen");
            Reiziger klaas = new Reiziger("Klaas", 2, "Vlissingen");
            Reiziger peter = new Reiziger("Klaas", 1, "Vlissingen");
            Reiziger timon = new Reiziger("Timon", 0, "Middelburg");
            Reiziger johan = new Reiziger("Johan", 2, "Middelburg");
            Reiziger joost = new Reiziger("Joost", 2, "Vlissingen");
            Reiziger thijs = new Reiziger("Thijs", 1, "Vlissingen");


            //Laten instappen
            wagon.instappen(piet);
            wagon.instappen(hans);
            wagon.instappen(jaap);
            wagon.instappen(kees);
            wagon.instappen(peter);
            wagon.instappen(timon);
            wagon.instappen(johan);


            Console.WriteLine(wagon);

            wagon.aankomen(peter, vlissingen);
            Console.WriteLine(wagon);
            Console.WriteLine(trein);


            Console.ReadLine();
        }
    }
}
