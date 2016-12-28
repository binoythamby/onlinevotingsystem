using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_authcand : System.Web.UI.Page
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
        GridView1.DataSource = DB.ExecuteReader("select * from contab where status='Pending'");
        GridView1.DataBind();

    }
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        string id, uid;
        uid = GridView1.DataKeys[e.RowIndex].Value.ToString();

        DB.ExecuteReader("update contab set status='Approve' where userid='" + uid + "'");

        fun();
    }
}