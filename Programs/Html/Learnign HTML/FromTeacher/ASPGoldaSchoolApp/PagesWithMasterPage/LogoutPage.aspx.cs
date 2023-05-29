using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPGoldaSchoolApp.PagesWithMasterPage
{
    public partial class LogoutPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["Login"] = false;
            Session["Admin"] = false;
            Session["UserName"] = "Visitor";
            Session.Abandon();
            Response.Redirect("HomePage.aspx");
         
        }
    }
}