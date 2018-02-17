using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Dodaj_towar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string nazwa = naz.Text;
            int ilosc1 = Convert.ToInt32(ilosc.Text);
            int cena1 = Convert.ToInt32(cena.Text);
            int nr_magazynu1 = Convert.ToInt32(nr_magazynu.Text);


            Polaczenie.WCFServiceClient klient = new Polaczenie.WCFServiceClient();
            klient.Open();
            klient.dodajTowar(nazwa, ilosc1, cena1, nr_magazynu1);

            Response.Write("<script LANGUAGE='JavaScript' >alert('Towar dodany pomyślnie')</script>");

            Response.Redirect("~/Dodaj_towar.aspx");
            klient.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Towar_form.aspx");
        }
    }
}