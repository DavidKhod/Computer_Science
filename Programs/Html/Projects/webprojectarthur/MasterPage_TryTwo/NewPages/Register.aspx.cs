using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterPage_TryTwo.NewPages
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                // התחברות למסד הנתונים
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
                SqlConnection con = new SqlConnection(connectionString);

                // בניית פקודת SQL
                string SQLStr = $"SELECT * FROM UsersTbl WHERE 0=1";
                SqlCommand cmd = new SqlCommand(SQLStr, con);

                // בניית DataSet
                DataSet ds = new DataSet();

                // טעינת הנתונים
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds, "UsersTbl");



                // בניית השורה להוספה
                DataRow dr = ds.Tables["UsersTbl"].NewRow();
                dr["Username"] = Request.Form["UserName"];
                dr["Password"] = Request.Form["Password"];
                dr["Firstname"] = Request.Form["FirstName"];
                dr["SecondName"] = Request.Form["SecondName"];
                dr["Admin"] = false;
                dr["Email"] = Request.Form["Email"];


                string selectSQL = $"SELECT Firstname FROM UsersTbl " +
                  $"WHERE Username='{Request.Form["UserName"]}' OR Password = '{Request.Form["Password"]}'";

                SqlCommand selectCmd = new SqlCommand(selectSQL, con);
                con.Open();
                object scalar = selectCmd.ExecuteScalar();
                if (scalar != null)
                {
                    regError.InnerHtml = "Invalid Username or Password, Choose Different Ones";
                }
                else
                {
                    ds.Tables["UsersTbl"].Rows.Add(dr);

                    // עדכון הדאטה סט בבסיס הנתונים
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    adapter.UpdateCommand = builder.GetInsertCommand();
                    adapter.Update(ds, "UsersTbl");

                    Response.Redirect("Home.aspx");
                }
                con.Close();
            }


        }

    }
}
