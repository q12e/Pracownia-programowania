using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Magazyn1;

namespace TestyJednostkowe
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Dodaj_Towar_test()
        {
            Towar towar = new Towar(19, "Laptop k1", 12, 3500,1);
            Assert.IsNotNull(towar);
        }

        [TestMethod]
        public void Dodaj_Towar_test2()
        {
            Magazyn_wcf.WCFServiceClient client = new Magazyn_wcf.WCFServiceClient();

            string nazwa_towaru = "Komputer PC";
            int ilosc_towaru = 30;
            int cena = 1000;
            Operacje_na_bazie operacja = new Operacje_na_bazie();
            int id_towaru = operacja.getTowarId();
            int nr_magazynu = operacja.getMagazynyId();
            Towar towar = new Towar(id_towaru, nazwa_towaru, ilosc_towaru, cena, nr_magazynu);

            Assert.IsNotNull(towar);

        }

        [TestMethod]
        public void Dodaj_Pracownika_Test()
        {
            Pracownicy pracownicy = new Pracownicy(19, "Jan", "Kowalski", "1234124", 1);
            Assert.IsNotNull(pracownicy);
        }

        [TestMethod]
        public void Dodaj_Pracownika_Test2()
        {
            Magazyn_wcf.WCFServiceClient client = new Magazyn_wcf.WCFServiceClient();

            string imie = "Andrzej";
            string nazwisko = "Nowak";
            string pesel = "21231323";
            int id_magazynu = 2;
            Operacje_na_bazie operacja = new Operacje_na_bazie();
            int id_pracownika = operacja.getPracownicyId();
            Pracownicy utworek = new Pracownicy(id_pracownika, imie, nazwisko, pesel, id_magazynu);

            Assert.IsNotNull(utworek);

        }

        [TestMethod]
        public void Dodaj_Magazyn_Test()
        {
            Magazyny magazyny = new Magazyny(19, "Wilda", "Poznan", "Zagajnikowa 19");
            Assert.IsNotNull(magazyny);
        }

        [TestMethod]
        public void Dodaj_Magazyn_Test2()
        {
            Magazyn_wcf.WCFServiceClient client = new Magazyn_wcf.WCFServiceClient();

            string nazwa = "Antoninek";
            string miasto = "Poznan";
            string adres = "Zagajnikowa 20";
            Operacje_na_bazie operacja = new Operacje_na_bazie();
            int id_magazynu = operacja.getMagazynyId();
            Magazyny magazyny = new Magazyny(id_magazynu, nazwa, miasto, adres);

            Assert.IsNotNull(magazyny);

        }
    }
}
