using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class voting : System.Web.UI.Page
{
    DataSet ds = new DataSet();
    int index = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
          
           if (Session["uid"] != null)
            {
                if (DB.ExecuteDataSet("select * from vote where voter_id='" + Session["uid"].ToString() + "'").Tables[0].Rows.Count > 0)
                {
                    Response.Redirect("voterhome.aspx?voteerror=true");
                }
                fillgrid();
            }
        }
    }
    public void fillgrid()
    {
        ds = DB.ExecuteDataSet("select * from votertab where userid='"+Session["uid"].ToString()+"'");
        string city = ds.Tables[0].Rows[0]["City"].ToString();
        DataSet ds1 = new DataSet();
        ds1 = DB.ExecuteDataSet("select * from contab where City='" + city + "' and status='Approve'");

        GridView1.DataSource = ds1;
        GridView1.DataBind();
        ds1.Dispose();
        ds.Dispose();
    
    
    }



    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        //if (e.CommandName == "vote")
        //{

        //    Button b;
        //    b = (Button)GridView1.Rows[int.Parse( e.CommandArgument.ToString()) ].Cells[3].FindControl("Button1");
        //    if (b.Text == "Vote")
        //    {
        //        string id;
        //        id = GridView1.DataKeys[int.Parse(e.CommandArgument.ToString())].Value.ToString();

        //        if (DB.ExecuteReader("select * from vote where Voter_Id='" + Session["uid"].ToString() + "'").Read())
        //        {
        //            Response.Redirect("voting.aspx?voteerror=true");
        //        }
        //        else
        //        {
        //           DB.ExecuteNonQuery("insert into vote (Voter_Id,Con_Id,date) values('" + Session["uid"].ToString() + "','" + id + "','" + DateTime.Now.ToShortDateString() + "')");

        //           Response.Redirect("voterhome.aspx?conf=true");
                
        //        }

               
        //    }
        
        //}
    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        //if (e.Row.RowType == DataControlRowType.DataRow)
        //{
        //    Button b;
        //    b = (Button)e.Row.Cells[3].FindControl("Button1");
        //    b.CommandArgument = index.ToString();
        //    index++;
        //}
    }

    public string logo(string userid)
    {
        string img = "";
        ds = DB.ExecuteDataSet("select image from logos where candid='" + userid + "'");
        if (ds.Tables[0].Rows.Count > 0)
        {
            img = ds.Tables[0].Rows[0]["image"].ToString();
        }
        return img;
    }


    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        string id;
        id = GridView1.DataKeys[e.RowIndex].Value.ToString();

        if (DB.ExecuteReader("select * from vote where Voter_Id='" + Session["uid"].ToString() + "'").Read())
        {
            Response.Redirect("voting.aspx?voteerror=true");
        }
        else
        {
            DB.ExecuteNonQuery("insert into vote (Voter_Id,Con_Id,date) values('" + Session["uid"].ToString() + "','" + id + "','" + DateTime.Now.ToShortDateString() + "')");

            Response.Redirect("voterhome.aspx?conf=true");

        }
    }
}