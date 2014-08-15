using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        Label9.Text = Calendar1.SelectedDate.ToString() ;  
    }
   /* protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
       
        
            for (int i = 0; i < ListBox1.Items.Count; i++)
            {
                if (ListBox1.Items[i].Value == DropDownList1.SelectedValue)
                {
                    ListBox1.Items.Remove(ListBox1.Items[i].Value);
                }
            }
            if (DropDownList1.SelectedIndex > 0 && TextBox6.Text.Length > 0)
            {
                ListBox1.Items.Add(DropDownList1.SelectedValue + "&" + TextBox6.Text);
            }
            else
            {
                Response.Write("Enter Some Quantity"); 
            }
        
           /*foreach(ListItem i in ListBox1.Items)
            {
            if ( i.Value==DropDownList1.SelectedValue )
            {
                     
                ListBox1.Items.Remove( i.Value );
            }
            
        }
    }*/
    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
       
        ListBox1.Items.Remove(ListBox1.SelectedValue);   
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        for (int i = 0; i < ListBox1.Items.Count; i++)
        {
            int j = ListBox1.Items[i].Value.IndexOf("&") + 1;
            String s = ListBox1.Items[i].Value.Substring(0, j - 1); 

            if (s == DropDownList1.SelectedValue)
            {
                ListBox1.Items.Remove(ListBox1.Items[i].Value);
            }
        }
        if (DropDownList1.SelectedIndex > 0 && TextBox6.Text.Length > 0)
        {
            ListBox1.Items.Add(DropDownList1.SelectedValue + "&" + TextBox6.Text);
        }
       

        //CAlculating Bill
        long bill = 0;
        for (int i = 0; i < ListBox1.Items.Count; i++)
        {
            int j=ListBox1.Items[i].Value.IndexOf("&")+1;
            int qty=Convert.ToInt32(ListBox1.Items[i].Value.Substring(j));       
            String s=ListBox1.Items[i].Value.Substring(0,j-1); 
            if ( s== "Steel Rod")
            {
                bill = bill + 5500*qty;
            }
            if (s == "Flat Rolled Prd")
            {
                bill = bill + 1500*qty;
            }
            if (s == "Billets")
            {
                bill = bill + 2000*qty;
            }
            if (s == "Steel Wire")
            {
                bill = bill + 4000*qty;
            }
            
        }
        TextBox5.Text = bill.ToString ();
        
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default2.aspx?name=" + TextBox2.Text + "&oid=" + TextBox1.Text + "&Bill=" + TextBox5.Text);   
    }
   
}