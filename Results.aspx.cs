using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class Results : System.Web.UI.Page
{
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {

            fillgrid();
          //  winner();
        }
    }

    public void fillgrid()
    {

       
        GridView1.DataSource= DB.ExecuteDataSet("select * from voteview order by vote desc");
        GridView1.DataBind();
    
    
    }

    //public void winner()
    //{
    //    ds = DB.ExecuteDataSet("select * from voteview");
    //    if (ds.Tables[0].Rows.Count > 0)
    //    {
    //        Label2.Text = ds.Tables[0].Rows[0]["name"].ToString();
    //        Label3.Text = ds.Tables[0].Rows[0]["vote"].ToString();
    //    }
    //    else
    //    {
    //        Label2.Visible = false;
    //        Label3.Visible = false;
    //    }
    //}

    public string username(string userid)
    {
        string name = "";
        ds = DB.ExecuteDataSet("select fname+' '+lname as name from contab where userid='" + userid + "'");
        if (ds.Tables[0].Rows.Count > 0)
        {

            name = ds.Tables[0].Rows[0]["name"].ToString();
        
        }

        return name;
    
    }
    public string logos(string userid)
    {
        string logo = "";

        ds = DB.ExecuteDataSet("select image from logos where candid='" + userid + "'");

        if (ds.Tables[0].Rows.Count > 0)
        {

            logo = ds.Tables[0].Rows[0]["image"].ToString();
        
        }

        return logo;
    
    }

}