using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CadastroTime : System.Web.UI.Page
{
    private List <Tuple<string, string>> times;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)  // faz ddl nao repretir valores
        {
            //Response.Write(Request.QueryString["numChaves"] + Request.QueryString["numTimes"]);
            int numChaves = Convert.ToInt32(Session["numChaves"].ToString());
            int numTimes = Convert.ToInt32(Session["numTimes"].ToString());

            for (int i = 1; i <= numTimes; i++)
            {
                ddlTimes.Items.Add("Time " + i);
            }   
        }
    }

    protected void btnCadTime_Click(object sender, EventArgs e)
    {

        // enquanto times acabaram
        /*
        if (ddlTimes.Items.Count > 0 && tbNomeTime.Text.Length > 0)
        {
            string nomeTime = tbNomeTime.Text;
            Response.Write(nomeTime);

        }
        */
    }
}