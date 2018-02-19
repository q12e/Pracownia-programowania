using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Magazyn1;


namespace Wcf_Service
{


    public class WCFService : IWCFService
    {
        public void dodajTowar(string nazwa_towaru, int ilosc_towaru, int cena, int nr_magazynu)
        {
        
                Operacje_na_bazie operacja = new Operacje_na_bazie();
                int id_towaru = operacja.getTowarId();
                Towar towar = new Towar(id_towaru, nazwa_towaru, ilosc_towaru, cena, nr_magazynu);

                operacja.DodajTowaryDoBazy(towar);
                operacja.CloseConnection();


        }

        public void dodajPracownika(string imie, string nazwisko, string pesel, int id_magazynu)
        {

                 Operacje_na_bazie operacja = new Operacje_na_bazie();
                 int id = operacja.getPracownicyId();
                 Pracownicy pracownicy= new Pracownicy(id, imie, nazwisko, pesel, id_magazynu);

                 operacja.DodajPracownikaDoBazy(pracownicy);
                 operacja.CloseConnection();
        }
        public void dodajMagazyn(string nazwa, string miasto, string adres)
        {

                Operacje_na_bazie operacja = new Operacje_na_bazie();
                int id = operacja.getMagazynyId();
                Magazyny magazyny = new Magazyny(id, nazwa, miasto, adres);

                operacja.DodajMagazynDoBazy(magazyny);
                operacja.CloseConnection();
        }

        public void usunTowar(int id)
        {
                 Operacje_na_bazie baza = new Operacje_na_bazie();

                 baza.UsunTowar(id);
        }

        public void usunPracownika(int id)
        {
                Operacje_na_bazie baza = new Operacje_na_bazie();

                baza.UsunPracownika(id);
        }

        public void usunMagazyn(int id)
        {
                Operacje_na_bazie baza = new Operacje_na_bazie();

                baza.UsunMagazyn(id);
        }

        
    }
}
