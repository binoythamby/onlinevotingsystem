using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;
public partial class admin_addlogo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
       
       

        string ext;
        ext = System.IO.Path.GetExtension(FileUpload1.FileName);

        if (!(ext == ".jpg" || ext == ".gif" || ext == ".png"))
        {
          //  Label1.Text = "Sorry! this type of file not allowed!";
            Response.Redirect("admin_addlogo.aspx?fileerror='Sorry! this type of file not allowed!'");
           // return;
        }

        if (DB.ExecuteReader("select image from logos where image='" + TextBox1.Text + ext + "'").Read())
        {
           // Label1.Text = "Sorry ! Logo Name already Exist";
            Response.Redirect("admin_addlogo.aspx?logoerror='Sorry ! Logo Name already Exist'");
          //  return;
        }
        DB.ExecuteNonQuery("insert into logos(image) values('" + TextBox1.Text + ext + "')");
        FileUpload1.SaveAs(Server.MapPath("logos/") + TextBox1.Text + ext);
        Response.Redirect("admin_addlogo.aspx?upld=true");
    }
}