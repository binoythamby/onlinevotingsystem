using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class admin : System.Web.UI.MasterPage
{
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        notice.Visible = false;
        if (Request.QueryString["logoerror"] != null)
        {

            notice.Visible = true;
            notice.Attributes.Add("class", "error");
            notice.InnerText = "This Signature is already exists";
        
        }
        if (Request.QueryString["fileerror"] != null)
        {

            notice.Visible = true;
            notice.Attributes.Add("class", "error");
            notice.InnerText = "file type error! .please upload *.jpg /*.png/*.gif files";

        }
        if (Request.QueryString["upld"] != null)
        {

            notice.Visible = true;
            notice.InnerText = "Signature is successfully saved!";

        }

        if (!Page.IsPostBack)
        {
            if (Session["admin"] != null)
            {

                ds = DB.ExecuteDataSet("select fname+' '+lname as name from admin where userid='" + Session["admin"].ToString() + "'");
                if (ds.Tables[0].Rows.Count > 0)
                {

                    Label1.Text = ds.Tables[0].Rows[0]["name"].ToString();
                
                }
            
            
            
            }
        
        
        
        
        }

    }
}
