using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trein
{
    public class Wagon
    {
        private string wagonNummer;
        private Dictionary<string, Reiziger> eersteKlas = new Dictionary<string, Reiziger>();
        private Dictionary<string, Reiziger> tweedeKlas = new Dictionary<string, Reiziger>();

        public Wagon(string wagonNummer)
        {
            this.wagonNummer = wagonNummer;
        }

        public string getWagonNummer()
        {
            return this.wagonNummer;
        }
        public void instappenEersteKlas(EersteKlas eerste1, EersteKlas eerste2, EersteKlas eerste3, EersteKlas eerste4, EersteKlas eerste5)
        {
            instappenEerste(eerste1);
            instappenEerste(eerste2);
            instappenEerste(eerste3);
            instappenEerste(eerste4);
            instappenEerste(eerste5);
        }

        public void instappenEerste(EersteKlas eerste)
        {
            string key = eerste.getName();
            EersteKlas value = eerste;
            this.eersteKlas.Add(eerste.getName(), eerste);
        }

        public void instappenTweedeKlas(Tweedeklas tweede1, Tweedeklas tweede2, Tweedeklas tweede3)
        {
            instappenTweede(tweede1);
            instappenTweede(tweede2);
            instappenTweede(tweede3);
        }

        public void instappenTweede(Tweedeklas reiziger)
        {
            string key = reiziger.getName();
            Tweedeklas value = reiziger;
            this.tweedeKlas.Add(reiziger.getName(), reiziger);
        }

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

        public override string ToString()
        {
            return "Er zitten " + getCountEersteKlas() + " mensen in de eerste klas en " + getCountTweedeKlas() + " mensen in de tweede klas";
        }
    }
}
