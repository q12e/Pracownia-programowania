using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazyn1
{
    public class Towar
    {
        private int id_towaru;
        private string nazwa_towaru;
        private int ilosc_towaru;
        private int cena;
        private int nr_magazynu;

        public Towar(int id_towaru, string nazwa_towaru, int ilosc_towaru, int cena, int nr_magazynu)
        {
            this.id_towaru = id_towaru;
            this.nazwa_towaru = nazwa_towaru;
            this.ilosc_towaru = ilosc_towaru;
            this.cena = cena;
            this.nr_magazynu = nr_magazynu;

        }


        public void setId_towaru(int id_towaru)
        {
            this.id_towaru = id_towaru;
        }

        public int getId_towaru()
        {
            return id_towaru;
        }

        public void setNazwa(string nazwa_towaru)
        {
            this.nazwa_towaru = nazwa_towaru;
        }

        public string getNazwa()
        {
            return nazwa_towaru;
        }


        public void setIlosc_towaru(int ilosc_towaru)
        {
            this.ilosc_towaru = ilosc_towaru;

        }
                
        public int getIlosc_towaru()
        {
            return ilosc_towaru;
        }

        public void setCena(int cena)
        {
            this.cena = cena;
        }

        public int getCena()
        {
            return cena;
        }

        public void setNr_magazynu(int nr_magazynu)
        {
            this.nr_magazynu = nr_magazynu;
        }

        public int getNr_magazynu()
        {
            return nr_magazynu;
        }

    }
}
    