using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class admin_authvoter : System.Web.UI.Page
{
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            fun();
        }
    }
    private void fun()
    {
        ds = DB.ExecuteDataSet("select * from votertab where status='Pending'");
        if (ds.Tables[0].Rows.Count > 0)
        {
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        else
        {
            GridView1.DataSource = ds;
            GridView1.EmptyDataText = "No Voter Requests found";
            GridView1.DataBind();
        
        
        }
    }
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        string id, uid;
        uid = GridView1.DataKeys[e.RowIndex].Value.ToString();

        DB.ExecuteReader("update votertab set status='Approve' where userid='" + uid + "'");

        fun();
    }
}