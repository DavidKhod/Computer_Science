﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterPage_TryTwo.NewPages
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {        
            Session["Login"] = false;
            Session["Admin"] = false;
            Session["UserName"] = "Visitor";
            Session.Abandon();
            Response.Redirect("Home.aspx");
        }
    }
}