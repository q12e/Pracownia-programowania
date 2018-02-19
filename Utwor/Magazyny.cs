using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazyn1
{
    public class Magazyny
    {
        private int id;
        private string nazwa;
        private string miasto;
        private string adres;


        public Magazyny(int id, string nazwa, string miasto, string adres)
        {
            this.id = id;
            this.nazwa = nazwa;
            this.miasto = miasto;
            this.adres = adres;
          }

        public void setId_magazynu(int id)
        {
            this.id = id;
        }

        public int getId_magazynu()
        {
            return id;
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
