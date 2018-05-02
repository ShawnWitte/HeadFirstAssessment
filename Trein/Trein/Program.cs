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
            Wagon wagon = new Wagon(1);
            Wagon wagon2 = new Wagon(2);
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
            Reiziger johan = new Reiziger("Johan", 2, "Vlissingen-Souburg");
            Reiziger joost = new Reiziger("Joost", 2, "Vlissingen-Souburg");
            Reiziger thijs = new Reiziger("Thijs", 1, "Vlissingen");


            //Laten instappen
            wagon.instappen(piet);
            wagon.instappen(hans);
            wagon.instappen(jaap);
            wagon.instappen(kees);
            wagon.instappen(klaas);
            wagon.instappen(peter);
            wagon.instappen(timon);

            Console.WriteLine("Allemaal ingestapt? De trein vertrekt nu!");
            Console.WriteLine(wagon);

            Console.WriteLine("Tijdens de reis naar Arnemuiden worden de kaartjes gecontroleerd:");
            wagon.controle(piet);
            wagon.controle(hans);
            wagon.controle(jaap);
            wagon.controle(kees);
            wagon.controle(klaas);
            wagon.controle(peter);
            wagon.controle(timon);

            Console.WriteLine("");
            Console.WriteLine("De trein is aangekomen in Arnemuiden");

            wagon.aankomen(piet, arnemuiden);
            wagon.aankomen(hans, arnemuiden);
            wagon.aankomen(jaap, arnemuiden);
            wagon.aankomen(kees, arnemuiden);
            wagon.aankomen(klaas, arnemuiden);
            wagon.aankomen(peter, arnemuiden);

            wagon.instappen(johan);
            wagon.instappen(joost);

            Console.WriteLine("Ingestapt? We vertrekken naar Middelburg");
            Console.WriteLine("");
            Console.WriteLine("De trein is aangekomen in Middelburg");

            wagon.aankomen(piet, middelburg);
            wagon.aankomen(hans, middelburg);
            wagon.aankomen(jaap, middelburg);
            wagon.aankomen(kees, middelburg);
            wagon.aankomen(klaas, middelburg);
            wagon.aankomen(peter, middelburg);
            wagon.aankomen(johan, middelburg);
            wagon.aankomen(joost, middelburg);

            wagon.instappen(thijs);

            Console.WriteLine("En op naar Vlissingen-Souburg!");
            Console.WriteLine("");
            Console.WriteLine("De trein is aangekomen in Vlissingen-Souburg");

            wagon.aankomen(piet, vlissingensouburg);
            wagon.aankomen(hans, vlissingensouburg);
            wagon.aankomen(jaap, vlissingensouburg);
            wagon.aankomen(kees, vlissingensouburg);
            wagon.aankomen(klaas, vlissingensouburg);
            wagon.aankomen(peter, vlissingensouburg);
            wagon.aankomen(johan, vlissingensouburg);
            wagon.aankomen(joost, vlissingensouburg);
            wagon.aankomen(thijs, vlissingensouburg);

            Console.WriteLine("En we vertrekken naar Vlissingen!");
            Console.WriteLine("");
            Console.WriteLine("De trein is aangekomen in Vlissingen");

            wagon.aankomen(piet, vlissingen);
            wagon.aankomen(hans, vlissingen);
            wagon.aankomen(jaap, vlissingen);
            wagon.aankomen(kees, vlissingen);
            wagon.aankomen(klaas, vlissingen);
            wagon.aankomen(peter, vlissingen);
            wagon.aankomen(johan, vlissingen);
            wagon.aankomen(joost, vlissingen);
            wagon.aankomen(thijs, vlissingen);

            Console.WriteLine(trein);
            Console.ReadLine();
        }
    }
}
