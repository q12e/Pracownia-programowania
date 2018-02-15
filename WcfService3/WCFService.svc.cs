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

        public void dodajPracownika(string imie, string nazwisko, long pesel, int id_magazynu)
        {

                 Operacje_na_bazie operacja = new Operacje_na_bazie();
                 int id_pracownika = operacja.getPracownicyId();
                 Pracownicy pracownicy= new Pracownicy(id_pracownika, imie, nazwisko, pesel, id_magazynu);

                 operacja.DodajPracownikaDoBazy(pracownicy);
                 operacja.CloseConnection();
        }
        public void dodajMagazyn(string nazwa, string miasto, string adres)
        {

                Operacje_na_bazie operacja = new Operacje_na_bazie();
                int id_magazynu = operacja.getMagazynyId();
                Magazyny magazyny = new Magazyny(id_magazynu, nazwa, miasto, adres);

                operacja.DodajMagazynDoBazy(magazyny);
                operacja.CloseConnection();
        }

        public void usunTowar(int id_towaru)
        {
                 Operacje_na_bazie baza = new Operacje_na_bazie();

                 baza.UsunTowar(id_towaru);
        }

        public void usunPracownika(int id_pracownika)
        {
                Operacje_na_bazie baza = new Operacje_na_bazie();

                baza.UsunPracownika(id_pracownika);
        }

        public void usunMagazyn(int id_magazynu)
        {
                Operacje_na_bazie baza = new Operacje_na_bazie();

                baza.UsunMagazyn(id_magazynu);
        }

        
    }
}
