using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPGoldaSchoolApp
{
    public partial class Main : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((bool)Session["Login"]==false)
            {
                registrationTxt.Style.Add("display", "block");
                logout.Style.Add("display", "none");
            }

            else if((bool)Session["Login"] == true)
            {
                registrationTxt.Style.Add("display", "none");
                login.Style.Add("display", "none");
                register.Style.Add("display", "none");
                logout.Style.Add("display", "block");
            }

            if (!(bool)Session["Admin"])
            {
                admin.Style.Add("display", "none");
               
            }
            else if((bool)Session["Admin"])
            {
                admin.Style.Add("display", "block");
                logout.Style.Add("display", "block");
            }

        }
    }
}