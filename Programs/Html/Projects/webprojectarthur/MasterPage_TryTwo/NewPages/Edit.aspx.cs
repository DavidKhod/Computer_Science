using System;
using System.Data;
using System.Data.SqlClient;

namespace MasterPage_TryTwo.NewPages
{

    public partial class Edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["About"] = false;

            if (Session["userToUpdate"] == null)
            {
                Session["userToUpdate"] = 1;
            }

            if (!IsPostBack) // משיכת פרטי המשתמש מבסיס הנתונים
            {
                // התחברות למסד הנתונים
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
                SqlConnection con = new SqlConnection(connectionString);

                // בניית פקודת SQL
                string SQLStr = $"SELECT * FROM UsersTbl Where Id={(int)Session["userToUpdate"]}";
                SqlCommand cmd = new SqlCommand(SQLStr, con);

                // בניית DataSet
                DataSet ds = new DataSet();

                // טעינת הנתונים
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds, "UsersTbl");


                // בניית השורה להוספה
                DataRow dr = ds.Tables["UsersTbl"].Rows[0];

                FirstName.Value = dr["FirstName"].ToString();
                LastName.Value = dr["SecondName"].ToString();
                UserName.Value = dr["UserName"].ToString();
                Password.Value = dr["Password"].ToString();
                Email.Value = dr["Email"].ToString();


            }
        }


        public void UpdateUser(object sender, EventArgs e)
        {
            // התחברות למסד הנתונים
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);

            // בניית פקודת SQL
            string SQLStr = $"SELECT * FROM UsersTbl Where Id={(int)Session["userToUpdate"]}";
            SqlCommand cmd = new SqlCommand(SQLStr, con);

            // בניית DataSet
            DataSet ds = new DataSet();

            // טעינת הנתונים
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds, "UsersTbl");



            // בניית השורה להוספה
            DataRow dr = ds.Tables["UsersTbl"].Rows[0];


            dr["Firstname"] = FirstName.Value;
            dr["SecondName"] = LastName.Value;
            dr["UserName"] = UserName.Value;
            dr["Password"] = Password.Value;

            dr["Email"] = Email.Value;


            // עדכון הדאטה סט בבסיס הנתונים
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.UpdateCommand = builder.GetUpdateCommand();
            adapter.Update(ds, "UsersTbl");

            Response.Redirect("Admin.aspx");
        }

    }
}