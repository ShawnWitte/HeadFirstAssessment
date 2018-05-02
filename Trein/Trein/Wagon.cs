using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trein
{
    public class Wagon
    {
        //Plaatsen aanmaken
        private int wagonNummer;
        private Dictionary<string, Reiziger> eersteKlas = new Dictionary<string, Reiziger>(3);
        private Dictionary<string, Reiziger> tweedeKlas = new Dictionary<string, Reiziger>(4);
        private Dictionary<string, Reiziger> zwartRijder = new Dictionary<string, Reiziger>();

        //Wagonnummer
        public Wagon(int wagonNummer)
        {
            this.wagonNummer = wagonNummer;
        }
        public int getWagonNummer()
        {
            return this.wagonNummer;
        }

        //Instappen
        public void instappen(Reiziger reiziger)
        {
            if (reiziger.getKaartje() == 1)
            {
                string key = reiziger.getName();
                Reiziger value = reiziger;
                this.eersteKlas.Add(reiziger.getName(), reiziger);
                showInfo(reiziger, " is ingestapt in de eerste klas");
            }
            else if (reiziger.getKaartje() == 2)
            {
                string key = reiziger.getName();
                Reiziger value = reiziger;
                this.tweedeKlas.Add(reiziger.getName(), reiziger);
                if (tweedeKlas.Count().Equals(4))
                {
                    this.eersteKlas.Add(reiziger.getName(), reiziger);
                    showInfo(reiziger, " is ingestapt in de tweede klas");
                }
            }
            else
            {
                this.zwartRijder.Add(reiziger.getName(), reiziger);
                showInfo(reiziger, " is ingestapt als zwartrijder en heeft zich verstopt in de trein.");
            }

        }
        //Uitstappen
        
        public Reiziger uitstappen(string name)
        {
            if (eersteKlas.ContainsKey(name))
            {
                Reiziger uitgestapte = eersteKlas[name];
                eersteKlas.Remove(name);
                showInfo(uitgestapte, " is uitgestapt");
                return uitgestapte;
            }
            if (tweedeKlas.ContainsKey(name))
            {
                Reiziger uitgestapte = tweedeKlas[name];
                tweedeKlas.Remove(name);
                showInfo(uitgestapte, " is uitgestapt");
                return uitgestapte;
            }
            else
            {
                return null;
            }
        }

        //Get Names
        public string[] getNamesEerste()
        {
            return (string[])eersteKlas.Keys.ToArray();
        }

        public string[] getNamesTweede()
        {
            return (string[])tweedeKlas.Keys.ToArray();
        }

        // Show info
        public void showInfo(Reiziger reiziger, string actie)
        {
            Console.WriteLine(reiziger.getName() + actie);
        }

        private int getCountEersteKlas()
        {
            return eersteKlas.Count();
        }

        private int getCountTweedeKlas()
        {
            return tweedeKlas.Count();
        }

        private int getCountZwartRijder()
        {
            return zwartRijder.Count();
        }

        //Aantal mensen in de bus
        public override string ToString()
        {
            return "Er zitten " + getCountEersteKlas() + " mens(en) in de eerste klas en " + getCountTweedeKlas() + " mens(en) in de tweede klas en er rijdt/rijden er " + getCountZwartRijder() + " zwart";
        }
    }
}
