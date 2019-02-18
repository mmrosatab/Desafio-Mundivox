using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //btnCriarTorneio.Attributes.Add("onClick", "return validar()");

    }

    protected void btnCriarTorneio_Click(object sender, EventArgs e)
    {
        // int numChaves = Convert.ToInt32(tbNumChaves.Text);
        //int numTimes = Convert.ToInt32(tbNumTimes.Text);
        //Response.Redirect("~/CadastroTime.aspx?numChaves="+ numChaves + "&numTimes=" + numTimes);
        Session["numChaves"] = tbNumChaves.Text;
        Session["numTimes"] = tbNumTimes.Text;
        Response.Redirect("~/CadastroTime.aspx");
    }
}

