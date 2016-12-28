using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class admin_canpro : System.Web.UI.Page
{
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["admin"] != null)
        {
            if (Request.QueryString["uid"] != null)
            {
                ViewState["uid"] = Request.QueryString["uid"].ToString();

                filldata();
            }
        }
    }
    public void filldata()
    {
        ds = DB.ExecuteDataSet("select * from contab where userid='" +ViewState["uid"].ToString()  + "'");

        if (ds.Tables[0].Rows.Count > 0)
        {

            Label2.Text = ds.Tables[0].Rows[0]["userid"].ToString();
            Label4.Text = ds.Tables[0].Rows[0]["email"].ToString();
            Label5.Text = ds.Tables[0].Rows[0]["fname"].ToString();
            Label6.Text = ds.Tables[0].Rows[0]["lname"].ToString();
            Label7.Text = ds.Tables[0].Rows[0]["fnm"].ToString();
            Label8.Text = ds.Tables[0].Rows[0]["dob"].ToString();
            Label9.Text = ds.Tables[0].Rows[0]["gender"].ToString();
            Label10.Text = ds.Tables[0].Rows[0]["contact"].ToString();
            Label11.Text = ds.Tables[0].Rows[0]["address"].ToString();
            Label12.Text = ds.Tables[0].Rows[0]["city"].ToString();



        }



    }
}