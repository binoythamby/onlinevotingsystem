using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class candidate : System.Web.UI.MasterPage
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        notice.Visible = false;
        if (Request.QueryString["logoerror"] != null)
        {
            notice.Visible = true;
            notice.Attributes.Add("class", "error");
            notice.InnerText = "Sign is already choosed,Can' select another sign ";
        
        }
        if (Request.QueryString["sign"] != null)
        {

            notice.Visible = true;
            notice.InnerText = "Signature is successfully choosen"; 
        
        }

        if (!Page.IsPostBack)
        {
            DataSet ds = new DataSet();
            ds = DB.ExecuteDataSet("select fname+' '+lname as name from contab where userid='" + Session["cid"].ToString() + "'");
            Label1.Text = ds.Tables[0].Rows[0]["name"].ToString();
            ds.Dispose();
        }
        
    }

    

}
