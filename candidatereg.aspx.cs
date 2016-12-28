using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class candidatereg : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        notice.Visible = false;
        if (Request.QueryString["regerror"] != null)
        {

            notice.Visible = true;
            notice.InnerText = "UserID already exist.Please Choose Different UserID";
        
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (DB.ExecuteReader("select userid from contab where userid='" + TextBox1.Text + "'").Read())
        {
            Response.Redirect("candidatereg.aspx?regerror=true");


        }
        else
        {
            SqlParameter[] p = new SqlParameter[12];
            p[0] = new SqlParameter("@fname", TextBox4.Text);
            p[1] = new SqlParameter("@lname", TextBox5.Text);
            p[2] = new SqlParameter("@fnm", TextBox6.Text);
            p[3] = new SqlParameter("@dob", TextBox7.Text);
            p[4] = new SqlParameter("@address", TextBox9.Text);
            p[5] = new SqlParameter("@email", TextBox3.Text);
            p[6] = new SqlParameter("@gender", DropDownList1.SelectedItem.Text);
            p[7] = new SqlParameter("@city", TextBox10.Text);
            p[8] = new SqlParameter("@userid", TextBox1.Text);
            p[9] = new SqlParameter("@pass", TextBox2.Text);
            p[10] = new SqlParameter("@image", FileUpload1.FileName);
            p[11] = new SqlParameter("@contact", TextBox8.Text);
            DB.ExecuteNonQuery("insert into contab (fname,lname,fnm,dob,address,email,gender,city,userid,pass,image,contact,status ) values(@fname,@lname,@fnm,@dob,@address,@email,@gender,@city,@userid,@pass,@image,@contact,'Pending')",p);
            FileUpload1.SaveAs(Server.MapPath("conimage/") + FileUpload1.FileName);
            Session["cid"] = TextBox1.Text;
            Response.Redirect("candidatehome.aspx");
        
        }
    }
}