using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPGoldaSchoolApp.Pages
{
    public partial class First : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Hello Arthur!");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Second.aspx");
        }

        protected string PrintMessage()
        {
           return  "Welcome " + Request.Form["FirstName"];
        }
    }
}