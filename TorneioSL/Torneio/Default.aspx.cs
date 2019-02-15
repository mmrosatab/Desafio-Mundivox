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

    protected void btnCriarTorneio_Click(object sender, EventArgs e)
    {

        int numChaves = Convert.ToInt32(tbNumChaves.Text);
        int numTimes = Convert.ToInt32(tbNumTimes.Text);

        if (numChaves >= 2 && numTimes >= 2 && numTimes >= numChaves)
        {
            if ((numChaves & (numChaves - 1)) == 0 && (numTimes & (numTimes - 1)) == 0)
            {
                Response.Write("Tudo Ok");

            }
            else
            {
                Response.Write("O n° de times e n° de chaves deve ser uma potencia de 2.");
            }
        }
        else
        {
            Response.Write("O n° de times e n° de chaves deve ser maior ou igual a 2. ");
            Response.Write("O n° de times deve ser maior que o n° de chaves.");
        }
    }
}

