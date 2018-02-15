using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazyn1
{
    public class Magazyny
    {
        private int id_magazynu;
        private string nazwa;
        private string miasto;
        private string adres;


        public Magazyny(int id_magazynu, string nazwa, string miasto, string adres)
        {
            this.id_magazynu = id_magazynu;
            this.nazwa = nazwa;
            this.miasto = miasto;
            this.adres = adres;
          }

        public void setId_magazynu(int id_magazynu)
        {
            this.id_magazynu = id_magazynu;
        }

        public int getId_magazynu()
        {
            return id_magazynu;
        }
        public void setNazwa(string nazwa)
        {
            this.nazwa = nazwa;
        }
        public string getNazwa()
        {
            return nazwa;
        }
        public void setMiasto(string miasto)
        {
            this.miasto = miasto;
        }
        public string getMiasto()
        {
            return miasto;
        }
        public void setAdres(string adres)
        {
            this.adres = adres;
        }
        public string getAdres()
        {
            return adres;
        }

    }

}
