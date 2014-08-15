using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = "NAME is=" + Request.QueryString["name"];
        Label2.Text = " ORDER ID IS=" + Request.QueryString["oid"];
        Label3.Text = " ORDER BILL IS=" + Request.QueryString["Bill"];   
    }
}