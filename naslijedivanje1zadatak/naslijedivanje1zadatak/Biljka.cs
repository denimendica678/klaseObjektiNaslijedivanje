using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace naslijedivanje1zadatak
{
    class Biljka
    {
        //Klasa može naslijediti samo jednu klasu.
        //Konstruktor je posebna metoda koja se koristi za
        //inicijalizaciju objekata. Prednost konstruktora je što 
        //se poziva kada se kreira objekt klase. Može se koristiti 
        //za postavljanje početnih vrijednosti za polja.

        class Stablo : Biljka
        {
            bool opadajuListovi;

            private string polje; //polje

            public string OpadajuListovi  //svojstvo
            {
                get { return polje; }
                set { polje = value; }
            }

            public Stablo()
            {
                this.polje = Convert.ToString(opadajuListovi);

            }

            class Bijelogoricno : Stablo
            {
                Bijelogoricno Hrast = new Bijelogoricno();
                Bijelogoricno Bor = new Bijelogoricno();

              
            }

            class Crnogoricno : Stablo
            {
                Crnogoricno Hrast = new Crnogoricno();
                Crnogoricno Bor = new Crnogoricno();

            }

            
        }

        class Cvijet : Biljka
        {

        }

        

    }
}
