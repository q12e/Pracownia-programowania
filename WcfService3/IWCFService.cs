using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Magazyn1;

namespace Wcf_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWCFService" in both code and config file together.
    [ServiceContract]
    public interface IWCFService
    {

        //Dodawanie
        [OperationContract]
        void dodajPracownika(string imie, string nazwisko, string pesel, int nr_magazynu);



        [OperationContract]
        void dodajTowar(string nazwa_towaru, int ilosc_towaru, int cena, int nr_magazynu);



        [OperationContract]
        void dodajMagazyn(string nazwa, string miasto, string adres);



        //Usuwanie
        [OperationContract]
        void usunMagazyn(int id_magazynu);


         
        [OperationContract]
        void usunPracownika(int id_pracownika);



        [OperationContract]
        void usunTowar(int id_towaru);



    }
}
