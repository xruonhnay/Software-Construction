using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string user = username.Text;
            string password = pass.Text;

            if (user == "admin" && password == "admin")
            {
                Response.Redirect("Data.aspx");
        }
            else {
            }

        }
    } }