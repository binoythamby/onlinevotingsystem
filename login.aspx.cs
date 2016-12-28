using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class login : System.Web.UI.Page
{
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (RadioButtonList1.SelectedItem.Text == "Candidate")
        {
            ds = DB.ExecuteDataSet("select * from contab where userid='" + TextBox1.Text + "' and pass='" + TextBox2.Text + "' and status='Approve'");
            if (ds.Tables[0].Rows.Count > 0)
            {
                Session["cid"] = TextBox1.Text;
                Response.Redirect("candidatehome.aspx");


            }
            else
            {
                Label1.Text = "Invalid User ID / Password Or UnApproved"; 
            
            }


        }
        else
        {

            ds = DB.ExecuteDataSet("select * from votertab where userid='" + TextBox1.Text + "' and pass='" + TextBox2.Text + "'  and status='Approve'");
            if (ds.Tables[0].Rows.Count > 0)
            {
                Session["uid"] = TextBox1.Text;
                Response.Redirect("voterhome.aspx");


            }
            else
            {
                Label1.Text = "Invalid User ID / Password Or UnApproved";

            }
        
        
        
        
        }
        
    }
}