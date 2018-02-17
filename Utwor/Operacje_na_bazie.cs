using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Magazyn1
{
    public class Operacje_na_bazie
    {
        private SqlConnection _connection;
        private string _dbUserId;
        private string _password;

        public void SetUserId(string dbUserId)
        {
            _dbUserId = dbUserId;
        }

        private string GetUserId()
        {
            return _dbUserId;
        }

        public void SetPassword(string password)
        {
            _password = password;
        }

        private string GetPassword()
        {
            return _password;
        }

        public void ConnectToSQL()
        {
            _connection = new SqlConnection();
            _connection.ConnectionString =
                "Data Source=mssql-2016.labs.wmi.amu.edu.pl;" +
                "Initial Catalog=dbad_s426150;" +
                "User id=s426150;" +
                "Password=aAKQe23mv3";
            try
            {
                _connection.Open();
            }
            catch (System.Data.SqlClient.SqlException)
            {
                _connection.Close();
            }
        }

        public SqlConnection GetConnection()
        {
            return _connection;
        }
        public void CloseConnection()
        {
            if (_connection != null && _connection.State == System.Data.ConnectionState.Open)
            {
                _connection.Close();
            }

            if (_connection == null)
            {
                return;
            }
        }


        public void DodajPracownikaDoBazy(Pracownicy Pracownicy)
        {
            Operacje_na_bazie baza = new Operacje_na_bazie();
            baza.ConnectToSQL();
            SqlCommand cmd = new SqlCommand("INSERT INTO [_Pracownicy] (id, imie, nazwisko, pesel, id_magazynu) VALUES "
                + "(@id, @imie, @nazwisko, @pesel, @id_magazynu)", baza.GetConnection());
            cmd.Parameters.Add("@id", Pracownicy.getId_pracownika());
            cmd.Parameters.Add("@imie", Pracownicy.getImie());
            cmd.Parameters.Add("@nazwisko", Pracownicy.getNazwisko());
            cmd.Parameters.Add("@pesel", Pracownicy.getPesel());
            cmd.Parameters.Add("@id_magazynu", Pracownicy.getId_magazynu());


            cmd.ExecuteNonQuery();

            baza.CloseConnection();
        }


        public void DodajTowaryDoBazy(Towar towar)
        {
            Operacje_na_bazie baza = new Operacje_na_bazie();
            baza.ConnectToSQL();

            SqlCommand cmd = new SqlCommand("INSERT INTO [_Towar] (id, nazwa, ilosc, cena, magazyn) VALUES "
                + "(@id, @nazwa, @ilosc, @cena, @magazyn)", baza.GetConnection());
            cmd.Parameters.Add("@id", towar.getId_towaru());
            cmd.Parameters.Add("@nazwa", towar.getNazwa());
            cmd.Parameters.Add("@ilosc", towar.getIlosc_towaru());
            cmd.Parameters.Add("@cena", towar.getCena());
            cmd.Parameters.Add("@magazyn", towar.getNr_magazynu());

            cmd.ExecuteNonQuery();

            baza.CloseConnection();
        }

        public void DodajMagazynDoBazy(Magazyny magazyny)
        {
            Operacje_na_bazie baza = new Operacje_na_bazie();
            baza.ConnectToSQL();

            SqlCommand cmd = new SqlCommand("INSERT INTO [_Magazyny] (id, nazwa, miasto, adres) VALUES "
                + "(@id, @nazwa, @miasto, @adres)", baza.GetConnection());
            cmd.Parameters.Add("@id", magazyny.getId_magazynu());
            cmd.Parameters.Add("@nazwa", magazyny.getNazwa());
            cmd.Parameters.Add("@miasto", magazyny.getMiasto());
            cmd.Parameters.Add("@adres", magazyny.getAdres());

            cmd.ExecuteNonQuery();

            baza.CloseConnection();
        }


        public void UsunPracownika(int id_pracownika)
        {
            Operacje_na_bazie baza = new Operacje_na_bazie();
            baza.ConnectToSQL();

            SqlCommand cmd = new SqlCommand("DELETE FROM [_Pracownicy] WHERE id = " + id_pracownika, baza.GetConnection());

            cmd.ExecuteNonQuery();
            baza.CloseConnection();

        }

        public void UsunTowar(int id_towaru)
        {
            Operacje_na_bazie baza = new Operacje_na_bazie();
            baza.ConnectToSQL();

            SqlCommand cmd = new SqlCommand("DELETE FROM [_Towar] WHERE id = " + id_towaru, baza.GetConnection());

            cmd.ExecuteNonQuery();
            baza.CloseConnection();

        }

        public void UsunMagazyn(int id_magazynu)
        {
            Operacje_na_bazie baza = new Operacje_na_bazie();
            baza.ConnectToSQL();

            SqlCommand cmd = new SqlCommand("DELETE FROM [_Magazyny] WHERE id = " + id_magazynu, baza.GetConnection());

            cmd.ExecuteNonQuery();
            baza.CloseConnection();

        }

        public int getTowarId()
        {
            Operacje_na_bazie baza = new Operacje_na_bazie();
            baza.SetUserId("s426150");
            baza.SetPassword("aAKQe23mv3");
            baza.ConnectToSQL();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = baza.GetConnection();
            cmd.CommandText = "SELECT MAX(id) from [_Towar]";

            SqlDataReader czytaj = cmd.ExecuteReader();
            int x = 0;
            if (czytaj.Read())
            {
                x = czytaj.GetInt32(0);
            }
            czytaj.Close();
            baza.CloseConnection();

            return x + 1;
        }

        public int getPracownicyId()
        {
            Operacje_na_bazie baza = new Operacje_na_bazie();
            baza.SetUserId("s426150");
            baza.SetPassword("aAKQe23mv3");
            baza.ConnectToSQL();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = baza.GetConnection();
            cmd.CommandText = "SELECT MAX(id) from [_Pracownicy]";

            SqlDataReader czytaj = cmd.ExecuteReader();
            int x = 0;
            if (czytaj.Read())
            {
                x = czytaj.GetInt32(0);
            }
            czytaj.Close();
            baza.CloseConnection();

            return x + 1;
        }

        public int getMagazynyId()
        {
            Operacje_na_bazie baza = new Operacje_na_bazie();
            baza.SetUserId("s426150");
            baza.SetPassword("aAKQe23mv3");
            baza.ConnectToSQL();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = baza.GetConnection();
            cmd.CommandText = "SELECT MAX(id) from [_Magazyny]";

            SqlDataReader czytaj = cmd.ExecuteReader();
            int x = 0;
            if (czytaj.Read())
            {
                x = czytaj.GetInt32(0);
            }
            czytaj.Close();
            baza.CloseConnection();

            return x + 1;
        }

    }
}