﻿using System;

using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Dodaj_magazyn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("~/Magazyn_form.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string nazwa = naz.Text;
            string miasto = miasto1.Text;
            string adres = adres1.Text;

            Polaczenie.WCFServiceClient klient = new Polaczenie.WCFServiceClient();
            klient.Open();
            klient.dodajMagazyn(nazwa, miasto, adres);

            Response.Write("<script LANGUAGE='JavaScript' >alert('Magazyn dodany pomyślnie')</script>");

            Response.Redirect("~/Dodaj_magzyn.aspx");
            klient.Close();
        }
    }
}