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
    public partial class Data : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public string getWhileLoopData()
        {
            string htmlStr = "";
            string server = "localhost";
            string database = "lab4";
            string uid = "root";
            string password = "bitch135";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            MySqlConnection cnn = new MySqlConnection(connectionString);

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM  users ", cnn);
            cnn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string id = reader.GetString(0);
                string Name = reader.GetString(1);
                string Age = reader.GetString(2);
                string Email = reader.GetString(3);

                htmlStr += "<tr><td>" + id + "</td><td>" + Name + "</td><td>" + Age + "</td><td>"+Email+ "</td></tr>";
            }

            cnn.Close();
            return htmlStr;
        }
    }
}