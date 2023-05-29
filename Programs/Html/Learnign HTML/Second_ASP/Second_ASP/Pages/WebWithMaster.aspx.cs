using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Second_ASP.Pages
{
    public partial class WebWithMaster : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected string PringMassage()
        {
            return $"Welcome {Request.Form["FirstName"]} this is from PrintMassage()";
        }
    }
}