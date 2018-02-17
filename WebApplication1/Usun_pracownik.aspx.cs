using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Usun_pracownik : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            int id_pracownika1 = Convert.ToInt32(id_pracownika.Text);
            Polaczenie.WCFServiceClient klient = new Polaczenie.WCFServiceClient();
            klient.Open();
            klient.usunPracownika(id_pracownika1);
            klient.Close();
            Response.Redirect("~/Usun_pracownik.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Pracownik_form.aspx");
        }

        protected void GridView4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}