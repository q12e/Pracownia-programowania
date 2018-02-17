﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Dodaj_pracownik : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Menu_form.aspx");
        }

     

        protected void Button6_Click(object sender, EventArgs e)
        {
            string imie1 = imie.Text;
            string nazwisko1 = nazwisko.Text;
            long pesel1 = Convert.ToInt64(pesel.Text);
            int nr_magazynu = Convert.ToInt32(nr_magazynuu.Text);
  


            Polaczenie.WCFServiceClient klient = new Polaczenie.WCFServiceClient();
            klient.Open();
            klient.dodajPracownika(imie1, nazwisko1, pesel1, nr_magazynu);

            Response.Write("<script LANGUAGE='JavaScript' >alert('Pracownik dodany pomyślnie')</script>");

            Response.Redirect("~/Dodaj_pracownik.aspx");
            klient.Close();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Pracownik_form.aspx");
        }
    }
}