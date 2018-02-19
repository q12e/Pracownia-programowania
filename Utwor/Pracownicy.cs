using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazyn1
{
    public class Pracownicy
    {
        private int id;
        private string imie;
        private string nazwisko;
        private string pesel;
        private int magazyn;

        public Pracownicy(int id, string imie, string nazwisko, string pesel, int magazyn )
        {
            this.id = id;
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.pesel = pesel;
            this.magazyn = magazyn;
        }
        

        public void setId_pracownika(int id)
        {
            this.id = id;
        }

        public int getId_pracownika()
        {
            return id;
        }


        public void setImie(string imie)
        {
            this.imie = imie;
        }

        public string getImie()
        {
            return imie;
        }


        public void setNazwisko(string nazwisko)
        {
            this.nazwisko = nazwisko;
        }

        public string getNazwisko()
        {
            return nazwisko;
        }


        public void setPesel(string pesel)
        {   
            this.pesel = pesel;
        }

        public string getPesel()
        {

            return pesel;
        }


        public void setId_magazynu(int magazyn)
        {
            this.magazyn = magazyn;
        }
          
        public int getId_magazynu()
        {
            return magazyn;
        }
    }
}
