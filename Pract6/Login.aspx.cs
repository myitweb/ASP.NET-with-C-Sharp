﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text == "anuja" && TextBox2.Text == "aaa")
        {
            Response.Write("<script>alert('Login successfully');</script>");
            Response.Redirect("Customer.aspx");  
           //Response.Write("<script language =\"javascript\" >alert(\"Log in Successful\" );</script>");
               
        }
    }
}