using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazyn1
{
    public class Pracownicy
    {
        private int id_pracownika;
        private string imie;
        private string nazwisko;
        private string pesel;
        private int id_magazynu;

        public Pracownicy(int id_pracownika, string imie, string nazwisko, string pesel, int id_magazynu )
        {
            this.id_pracownika = id_pracownika;
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.pesel = pesel;
            this.id_magazynu = id_magazynu;
        }
        

        public void setId_pracownika(int id_pracownika)
        {
            this.id_pracownika = id_pracownika;
        }

        public int getId_pracownika()
        {
            return id_pracownika;
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


        public void setId_magazynu(int id_magazynu)
        {
            this.id_magazynu = id_magazynu;
        }
          
        public int getId_magazynu()
        {
            return id_magazynu;
        }
    }
}
