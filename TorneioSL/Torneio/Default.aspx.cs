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

    // verificar se eh potencia de 2
    private bool ePotenciaDois(int num)
    {
        if ((num & (num - 1)) == 0)
        {
            return true;
        }
        return false;
    }

    // verificar se parametros torneio são validos
    private bool confTorneioValida(int num)
    {
        if (ePotenciaDois(num) && (num >= 2))
        {
            return true;
        }
        return false;
    }

    // verificar se num. times torneio eh valida
    private bool numTimesValido(int numTimes, int numChaves)
    {
        if (numTimes >= numChaves)
        {
           return true; 
        }
        return false;
    }

    protected void btnCriarTorneio_Click(object sender, EventArgs e)
    {
        // Response.Redirect("~/CadastroTime.aspx?numChaves="+ numChaves + "&numTimes=" + numTimes);
        int numChaves = Convert.ToInt32(tbNumChaves.Text);
        int numTimes = Convert.ToInt32(tbNumTimes.Text);
        Response.Redirect("~/CadastroTime.aspx?numChaves="+ numChaves + "&numTimes=" + numTimes);
    }
}

