using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace MasterPage_TryTwo.NewPages
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string SQLstr = "SELECT * From UsersTbl";
                DataSet ds = RetriveSQL(SQLstr);
                DataTable dt = ds.Tables["UsersTbl"];
                string Table = BuildTbl(dt);
                TableDiv.InnerHtml = Table;
            }
        }
        public DataSet RetriveSQL(string SQLStr)
        {
            // Connect
            string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);

            // New Querry
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = SQLStr;
            cmd.Connection = con;

            //Build Adapter
            SqlDataAdapter ad = new SqlDataAdapter(cmd);

            //Place Holder to store the data within
            DataSet ds = new DataSet();

            //fill the place holder with data
            ad.Fill(ds, "UsersTbl");
            return ds;
        }


        public string BuildTbl(DataTable dt)
        {
            string str = "<table Class'UsersTbl' align='center' border='3px solid black'>";
            str += "<tr>";
            str += "<td> </td>";
            foreach (DataColumn column in dt.Columns)
            {
                str += $"<td> {column.ColumnName}  </td>";
            }

            foreach (DataRow row in dt.Rows)
            {
                str += "<tr>";
                str += "<td>" + CreateRadioBtn(row["id"].ToString()) + "</td>";
                foreach (DataColumn column in dt.Columns)
                {
                    str += $"<td> {row[column]} </td>";
                }
                str += "</tr>";
            }
            str += "</table>";
            return str;
        }
        public void Click_Filter1(object sender, EventArgs e)
        {
            string SQLStr = BuildSQLStr(Request.Form["filter"]);
            DataSet ds = RetriveSQL(SQLStr);
            string table = BuildTbl(ds.Tables[0]);
            TableDiv.InnerHtml = table;
        }

        public string CreateRadioBtn(string id)
        {
            return $"<input type='checkbox' name='chk{id}' runat='server' />";
        }

        public string BuildSQLStr(string str)
        {
            if (str.Length == 0)
            {
                return "SELECT * FROM UsersTbl";
            }
            //string SQLStr = $"SELECT * FROM tblUsers WHERE firstName='{str}'";
            //string SQLStr = $"SELECT * FROM tblUsers WHERE firstName LIKE '%{str}%'";
            string SQLStr = $"SELECT * FROM UsersTbl WHERE" +
                $" FirstName LIKE '%{str}%' OR" +
                $" SecondName LIKE '%{str}%' ";
            return SQLStr;
        }


        public void Add(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }

        public void Edit(object sender, EventArgs e)
        {
            for (int i = 0; i < Request.Form.Count; i++)
            {
                if (Request.Form.AllKeys[i].Contains("chk"))
                {
                    Session["userToUpdate"] = int.Parse(Request.Form.AllKeys[i].Remove(0, 3));
                    Response.Redirect("Edit.aspx");
                }
            }
            
        }

        public void Delete(object sender, EventArgs e)
        {
            // בניית מערך של משתמשים למחיקה
            List<int> usersList = new List<int>();
            for (int i = 1; i < Request.Form.Count; i++)
            {
                if (Request.Form.AllKeys[i].Contains("chk"))
                {
                    int userId = int.Parse(Request.Form.AllKeys[i].Remove(0, 3));
                    usersList.Add(userId);
                }
            }
            int[] userIdToDelete = usersList.ToArray();

            DeleteUser(userIdToDelete);

            // הדפסת הטבלה המעודכנת
            DataSet ds = RetriveSQL(BuildSQLStr(""));
            string table = BuildTbl(ds.Tables["UsersTbl"]);
            TableDiv.InnerHtml = table;
        }

        private void DeleteUser(int[] userIdToDelete)
        {
            // The Array "userIdToDelete" contain the id of the users to delete. 
            // Delets all the users in the array "userIdToDelete".
            {
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
                // התחברות למסד הנתונים
                SqlConnection con = new SqlConnection(connectionString);

                // טעינת הנתונים
                string SQL = "SELECT * FROM UsersTbl";
                SqlCommand cmd = new SqlCommand(SQL, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "UsersTbl");

                // מחיקת שורות שנבחרו מתוך הדאטה סט
                for (int i = 0; i < userIdToDelete.Length; i++)
                {
                    {
                        DataRow[] dr = ds.Tables["UsersTbl"].Select($"Id = {userIdToDelete[i]}");
                        dr[0].Delete();
                    }
                }

                // עדכון הדאטה סט בבסיס הנתונים
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.UpdateCommand = builder.GetDeleteCommand();
                adapter.Update(ds, "UsersTbl");

            }
        }
    }
}