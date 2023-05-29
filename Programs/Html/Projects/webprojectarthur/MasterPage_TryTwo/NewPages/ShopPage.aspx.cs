using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterPage_TryTwo.NewPages
{
    public partial class ShopPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect($"~/DonkeyPages/UsDonkey.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect($"~/DonkeyPages/VecationDonkey.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect($"~/DonkeyPages/ArmyDonkey.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect($"~/DonkeyPages/JustDonkey.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect($"~/DonkeyPages/LazyDonkey.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect($"~/DonkeyPages/FlyingDonkey.aspx");
        }
    }
}