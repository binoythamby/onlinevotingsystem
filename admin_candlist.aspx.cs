using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class admin_candlist : System.Web.UI.Page
{
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {

            fill();
        
        }
    }

    public void fill()
    {
        ds=DB.ExecuteDataSet("select * from contab where status='Approve'");
        if (ds.Tables[0].Rows.Count > 0)
        {

            GridView1.DataSource = ds;
            GridView1.DataBind();
        
        
        }
    
    
    
    }


    public string logo(string userid)
    {
        string img = "";
        SqlParameter[] p = new SqlParameter[1];
        p[0] = new SqlParameter("@id", userid);
        ds = DB.ExecuteDataSet("select image from contab where userid=@id",p,"logos");
        if (ds.Tables["logos"].Rows.Count > 0)
        {
            img = ds.Tables["logos"].Rows[0]["image"].ToString();
        }


        return img;


    }


}