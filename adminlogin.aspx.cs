﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class adminlogin : System.Web.UI.Page
{
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Label1.Text = "";
        ds = DB.ExecuteDataSet("select * from admin where userid='" + TextBox1.Text + "' and pass='" + TextBox2.Text + "'");
        if (ds.Tables[0].Rows.Count > 0)
        {

            Session["admin"] = TextBox1.Text;
            Response.Redirect("admin_home.aspx");
        }
        else
        {

            Label1.Text = "Invalid userid or Password";
        
        }
    }
}