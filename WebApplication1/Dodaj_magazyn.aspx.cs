using System;

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
            string miasto1 = miasto.Text;
            string adres1 = adres.Text;

            Polaczenie.WCFServiceClient klient = new Polaczenie.WCFServiceClient();
            klient.Open();
            klient.dodajMagazyn(nazwa, miasto1, adres1);

            Response.Write("<script LANGUAGE='JavaScript' >alert('Magazyn dodany pomyślnie')</script>");

            Response.Redirect("~/Dodaj_magzyn.aspx");
            klient.Close();
        }
    }
}