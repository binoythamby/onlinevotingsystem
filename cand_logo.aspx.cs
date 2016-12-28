using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cand_logo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            fun();
        }
    }
    private void fun()
    {
        GridView1.DataSource = DB.ExecuteDataSet ("select * from logos where candid is null or candid=''");
        GridView1.DataBind();
    }
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        if (DB.ExecuteDataSet("select candid from logos where candid='" + Session["cid"].ToString() + "'").Tables[0].Rows.Count>0)
        {
            Response.Redirect("cand_logo.aspx?logoerror=true");
        }
        string s;
        s = GridView1.DataKeys[e.RowIndex].Value.ToString();

        DB.ExecuteNonQuery("update logos set candid='" + Session["cid"].ToString() + "' where image='" + s + "'");

        Response.Redirect("candidatehome.aspx?sign=true");
    }
    
}