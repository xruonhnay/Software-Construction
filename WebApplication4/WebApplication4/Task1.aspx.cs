using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class Task1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Add_Click(object sender, EventArgs e)
        {
            string server = "localhost";
            string database = "lab4";
            string uid = "root";
            string password = "bitch135";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            MySqlConnection conn = new MySqlConnection(connectionString);
            
            MySqlCommand command = conn.CreateCommand();
            MySqlDataReader Reader;
            string ID = TextBox1.Text;
            string username = TextBox2.Text;
            string Name = TextBox3.Text;
            string Age = TextBox4.Text;
            
            
            conn.Open();
            try
            {
           
                //command.ExecuteNonQuery();

             
                MySqlCommand cmd = new MySqlCommand("INSERT INTO users (ID,UserName,Age,Email) values ('" + TextBox1.Text.ToString() + "','" + TextBox2.Text.ToString() + "','" + TextBox3.Text.ToString() + "','" + TextBox4.Text.ToString() + "')", conn);


                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                MySqlDataReader dr1 = null;
                
                dr1 = cmd.ExecuteReader();
                //if (dr1 == null)
                //{
                //    Response.Write(Pass);
                //}
                Response.Write(" Added");
                dr1.Close();
               
                conn.Close();
            }
            catch (Exception)
            {
                Response.Write("Not Added");
            }
        }


    }
}