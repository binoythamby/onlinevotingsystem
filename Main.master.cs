using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class Main : System.Web.UI.MasterPage
{
    
    
    protected void Page_Load(object sender, EventArgs e)
    {
        notice.Visible = false;
        if (Request.QueryString["voteerror"] != null)
        {

            notice.Visible = true;
            notice.Attributes.Add("class", "error");
            notice.InnerText = "You already voted"; 
        
        }
        
        if (Request.QueryString["conf"] != null)
        {
            notice.Visible = true;
            notice.InnerText = "You successfully voted on this candidate"; 
        }
        if (!Page.IsPostBack)
        {
            DataSet ds = new DataSet();
            ds = DB.ExecuteDataSet("select fname+' '+lname as name from votertab where userid='" + Session["uid"].ToString() + "'");
            if (ds.Tables[0].Rows.Count > 0)
            {
                Label1.Text = ds.Tables[0].Rows[0]["name"].ToString();
            }

            ds.Dispose();
        }
    }

    

}
