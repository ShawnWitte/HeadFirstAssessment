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

        //Wagonnummer
        public Wagon(int wagonNummer)
        {
            this.wagonNummer = wagonNummer;
        }
        public int getWagonNummer()
        {
            return this.wagonNummer;
        }

        //Instappen Eerste Klas
        public void instappenEersteKlas(EersteKlas eerste1, EersteKlas eerste2, EersteKlas eerste3, EersteKlas eerste4, EersteKlas eerste5)
        {
            instappen(eerste1);
            instappen(eerste2);
            instappen(eerste3);
            instappen(eerste4);
            instappen(eerste5);
        }

        public void instappen(EersteKlas eerste)
        {
            string key = eerste.getName();
            EersteKlas value = eerste;
            this.eersteKlas.Add(eerste.getName(), eerste);
        }

        //Instappen Tweede Klas
        public void instappenTweedeKlas(Tweedeklas tweede1, Tweedeklas tweede2, Tweedeklas tweede3)
        {
            instappen(tweede1);
            instappen(tweede2);
            instappen(tweede3);
        }

        public void instappen(Tweedeklas reiziger)
        {
            string key = reiziger.getName();
            Tweedeklas value = reiziger;
            if (getCountTweedeKlas() == 4)
            {
                this.eersteKlas.Add(reiziger.getName(), reiziger);
            }
            else
            {
                this.tweedeKlas.Add(reiziger.getName(), reiziger);
            }
        }

        // Instappen Zwartrijder
        public void instappen(ZwartRijder zwart)
        {
            string key = zwart.getName();
            ZwartRijder value = zwart;
            this.tweedeKlas.Add(zwart.getName(), zwart);

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

        //Aantal mensen in de bus
        public override string ToString()
        {
            return "Er zitten " + getCountEersteKlas() + " mens(en) in de eerste klas en " + getCountTweedeKlas() + " mens(en) in de tweede klas";
        }
    }
}
