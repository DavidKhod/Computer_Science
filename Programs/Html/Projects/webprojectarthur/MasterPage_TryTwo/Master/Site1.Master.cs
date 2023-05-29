using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterPage_TryTwo.Pages
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((bool)Session["Login"] == false)
            {
                registrationtxt.Style.Add("display", "block");
                logout.Style.Add("display", "none");
                ShopPage.Style.Add("display", "none");
            }

            else 
            {
                registrationtxt.Style.Add("display", "none");
                Login.Style.Add("display", "none");
                Register.Style.Add("display", "none");
                logout.Style.Add("display", "block");
                ShopPage.Style.Add("display", "Block");
            }


            if (!(bool)Session["Admin"])
            {
                admin.Style.Add("display", "none");

            }
            else if ((bool)Session["Admin"])
            {
                admin.Style.Add("display", "block");
                logout.Style.Add("display", "block");
            }
        }
    }
}