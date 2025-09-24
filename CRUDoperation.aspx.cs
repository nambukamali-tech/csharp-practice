using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace aspProj
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-EHPCDIL\SQLEXPRESS02;Initial Catalog=ASPExercise;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter = da;
        DataTable dt;
        DataSet ds;
        protected void Button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("insert into students values('" + TextBox1.Text + "', " +TextBox2.Text+ ", '" +TextBox3.Text+ "')",conn);
            cmd.ExecuteNonQuery();
            Response.Write("INSERTION SUCCESSFULL!");
            conn.Close();
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("update students set studentName = '" + TextBox1.Text + "', course =  '" + TextBox3.Text + "' where studentID = "+TextBox2.Text+"",conn);
            cmd.ExecuteNonQuery();
            Response.Write("UPDATE SUCCESSFULL!");
            conn.Close();


        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("Delete from students where studentID = " + TextBox2.Text + "", conn);
            cmd.ExecuteNonQuery();
            Response.Write("DELETED SUCCESSFULL!");
            conn.Close();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("select * from students", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            GridView1.DataSource = dr;
            GridView1.DataBind();
            conn.Close();

        }
        Protected void Button5_Click(object sender, EventArgs e)
        {
        conn.Open();
        cmd = new SqlCommand("select * from students where studentID = " + TextBox2.Text + "  and course = '" + TextBox3.Text + "'", conn);
        da = new SqlDataAdapter();
        dt = new DataTable();
        da.Fill(dt);
        if(dt.Rows.Count > 0)
        {
        Response.Write("Login Successfully");
        }
        else
        {
        Response.Write("Login Fails");
        }
    }

}
