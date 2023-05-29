using System;

namespace Second_ASP.Pages
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("AnotherPage.aspx");
        }
        protected string PringMassage()
        {
            return $"Welcome {Request.Form["FirstName"]} this is from PrintMassage()";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string User = "David";
            string Pass = "123456789";
            if (Request.Form["FirstName"] == User && Request.Form["Password"] == Pass)
            {
                Response.Redirect("AnotherPage.aspx");
            }
            else
            {
                Response.Write("Username or Password doesn't match!,Try again");
            }
        }
    }
}