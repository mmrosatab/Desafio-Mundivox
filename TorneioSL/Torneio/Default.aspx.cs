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

    
    // acao botao criar torneio
    protected void btnCriarTorneio_Click(object sender, EventArgs e)
    {

        int numChaves = Convert.ToInt32(tbNumChaves.Text);
        int numTimes = Convert.ToInt32(tbNumTimes.Text);

        if (!confTorneioValida(numTimes))
        {
            Response.Write("O n° de times deve ser uma potencia de 2.");
            
        }else if (!confTorneioValida(numChaves))
        {

            Response.Write("O n° de chaves deve ser uma potencia de 2.");
            
        }else if (!numTimesValido(numTimes, numChaves))
        {
            Response.Write("O n° de times deve ser maior ou igual que o n° de chaves.");

        }else
        {
            // dados validos

            // enviar configuracao torneio para outro form
            Response.Write("Tudo Ok");
            Response.Redirect("~/CadastroTime.aspx?numChaves="+ numChaves + "&numTimes=" + numTimes);
            //return true;
        }
    }
}

