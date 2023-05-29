using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterPage_TryTwo.NewPages
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                string SQL = $"SELECT Admin FROM UsersTbl " +
                    $"WHERE UserName='{Request.Form["UserName"]}' AND password = '{Request.Form["Password"]}'";

                object scalar = GetScalar(SQL); // מחזיר רק את הערך של Admin

                if (scalar != null)
                {
                    Session["UserName"] = Request.Form["UserName"];
                    Session["Login"] = true;
                    Session["Admin"] = (bool)scalar;
                    Response.Redirect("Home.aspx");
                }
                else
                {
                    Session["UserName"] = "Visitor";
                    Session["Login"] = false;
                    Session["Admin"] = false;
                    errMsg.InnerHtml = "Unknown Username or Password";
                }
            }
        }
        public object GetScalar(string SQL)
        {
            // התחברות למסד הנתונים
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            // בניית פקודת SQL
            SqlCommand cmd = new SqlCommand(SQL, con);

            // ביצוע השאילתא
            con.Open();
            object scalar = cmd.ExecuteScalar();
            con.Close();

            return scalar;
        }


    }
}