using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;


public partial class _Default : System.Web.UI.Page
{
     SqlConnection sqlcon = new SqlConnection("Data Source=.;Initial Catalog=Student;Integrated Security=True");
     SqlCommand sqlcmd = new SqlCommand();
    protected void Page_Load(object sender, EventArgs e)
    {
        display();
    } 
    protected void But_Add_Click(object sender, EventArgs e)
    {
       
        sqlcon.Open();
        sqlcmd.Connection = sqlcon;
        sqlcmd.Parameters.Add("@RollNo", System.Data.SqlDbType.Int);
        sqlcmd.Parameters.Add("@fname", System.Data.SqlDbType.VarChar);
        sqlcmd.Parameters.Add("@lname", System.Data.SqlDbType.VarChar);
        sqlcmd.Parameters.Add("@dob", System. Data.SqlDbType.Date);
        sqlcmd.Parameters["@RollNo"].Value= int.Parse(Txtrollno.Text);
        sqlcmd.Parameters["@fname"].Value=txtfname.Text; 
        sqlcmd.Parameters["@lname"].Value=txtlname.Text; 
        sqlcmd.Parameters["@dob"].Value=DateTime.Parse(txtdob.Text); 
        sqlcmd.CommandText = "Insert into Student_Master(rno,fname,lname,dob) values(@RollNo,@fname,@lname,@dob)";
        sqlcmd.ExecuteNonQuery(); 
        sqlcon.Close();
      //to update DBGrid
        display();
        
    }
    protected void But_Update_Click(object sender, EventArgs e)
    {
        sqlcon.Open();
        sqlcmd.Connection = sqlcon;
        sqlcmd.Parameters.Add("@RollNo", System.Data.SqlDbType.Int);
        sqlcmd.Parameters.Add("@fname", System.Data.SqlDbType.VarChar);
        sqlcmd.Parameters.Add("@lname", System.Data.SqlDbType.VarChar);
        sqlcmd.Parameters.Add("@dob", System.Data.SqlDbType.Date);
        sqlcmd.Parameters["@RollNo"].Value = int.Parse(Txtrollno.Text);
        sqlcmd.Parameters["@fname"].Value = txtfname.Text;
        sqlcmd.Parameters["@lname"].Value = txtlname.Text;
        sqlcmd.Parameters["@dob"].Value = DateTime.Parse(txtdob.Text); 
        sqlcmd.CommandText = "Update Student_Master set fname=@fname,lname=@lname,dob=@dob where rno=@RollNo";
        sqlcmd.ExecuteNonQuery();
        sqlcon.Close();
        //to update DBGrid
        display();
    }
   
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Txtrollno.Text = GridView1.SelectedRow.Cells[1].Text;
        txtfname.Text = GridView1.SelectedRow.Cells[2].Text;
        txtlname.Text = GridView1.SelectedRow.Cells[3].Text;
        txtdob.Text = GridView1.SelectedRow.Cells[4].Text;
    }

    protected void But_Edit_Click(object sender, EventArgs e)
    {
        
        sqlcon.Open();
        sqlcmd.Connection = sqlcon;
        sqlcmd.Parameters.Add("@RollNo", System.Data.SqlDbType.Int);
        sqlcmd.Parameters["@RollNo"].Value = int.Parse(Txtrollno.Text);
        sqlcmd.CommandText = "DELETE FROM Student_Master WHERE rno=@RollNo";
        sqlcmd.ExecuteNonQuery();
        sqlcon.Close();

        //to update DBGrid
        display();
        txtdob.Text = "";
        txtfname.Text = "";
        txtlname.Text = "";
        Txtrollno.Text = "";
    }
    public void display()
    {
        sqlcon.Open();
        sqlcmd.CommandText = "select * from Student_Master";
        SqlDataAdapter sda = new SqlDataAdapter(sqlcmd.CommandText, sqlcon);
        SqlCommandBuilder scb = new SqlCommandBuilder(sda);
        DataSet ds = new DataSet();
        sda.Fill(ds);
        GridView1.DataSource = ds.Tables[0];
        GridView1.DataBind();
        sqlcon.Close();  
    }
}