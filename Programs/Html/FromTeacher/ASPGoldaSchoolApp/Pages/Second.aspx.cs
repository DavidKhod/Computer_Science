using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPGoldaSchoolApp.Pages
{
    public partial class Second : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string user = "Arthur";
            string pass = "1234";

            if(Request.Form["UserName"]==user && Request.Form["password"] == pass)
            {
                Response.Redirect("First.aspx");
            }

            else
            {
                Response.Write("Username or Password doesn't match, Try Again!");
            }
        }
    }
}