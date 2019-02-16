using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CadastroTime : System.Web.UI.Page
{
    public IList times;

    protected void Page_Load(object sender, EventArgs e)
    {
        //Response.Write(Request.QueryString["numChaves"] + Request.QueryString["numTimes"]);
        int numChaves = Convert.ToInt32(Request.QueryString["numChaves"]);
        int numTimes = Convert.ToInt32(Request.QueryString["numTimes"]);

        //times = new IList<String>(numTimes);

        for (int i = 1; i <= numTimes; i++)
        {
            ddlTimes.Items.Add("Time " + i);
        }
        //btnCadTime
    }

    protected void btnCadTime_Click(object sender, EventArgs e)
    {
        // times acabaram
        //if ()
    }

}