using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterPage_TryTwo.NewPages
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GoToShop_Click(object sender, EventArgs e)
        {
            Response.Redirect("ShopPage.aspx");
        }
    }
}