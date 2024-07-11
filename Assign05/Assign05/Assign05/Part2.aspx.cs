using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assign05
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        public DbConn dbConn;
        public string SQL;
        public SqlDataReader myReader;
        public DataSet ds;
        public DataTable dt;
        public SqlConnection oConn;
        public SqlCommand cmd;


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Select_Click(object sender, EventArgs e)
        {
            dbConn = new DbConn();
            SQL = "SELECT * FROM Assign05Shoes";
            myReader = dbConn.createDataReader(SQL);
            results.DataSource = myReader;
            results.DataBind();

        }

        protected void SelectOne_Click(object sender, EventArgs e)
        {
            dbConn = new DbConn();
            SQL = "SELECT Max (ShoeID) AS MaxID FROM Assign05Shoes";
            ds = new DataSet();
            dt = new DataTable();
            ds = dbConn.createDataSet(SQL);
            dt = ds.Tables[0];

            if (dt.Rows[0][0].ToString() != "")
            {
                oConn = new SqlConnection(dbConn.connStr);
                oConn.Open();

                SQL = "SELECT * FROM Assign05Shoes WHERE ShoeID=@shoeID";
                cmd = new SqlCommand(SQL, oConn);

                cmd.Parameters.Add(new SqlParameter("@shoeID", System.Data.SqlDbType.Int, 4));
                cmd.Parameters["@shoeID"].Value = dt.Rows[0][0].ToString();

                results.DataSource = cmd.ExecuteReader();
                results.DataBind();
                oConn.Close();

            }

        }

        protected void Insert_Click(object sender, EventArgs e)
        {
            dbConn = new DbConn();
            SQL = "INSERT INTO Assign05Shoes(name, description, color, laces)";
            SQL = SQL + "VALUES(@name, @description, @color, @laces)";
            oConn = new SqlConnection(dbConn.connStr);
            cmd = new SqlCommand(SQL, oConn);

            cmd.Parameters.Add(new SqlParameter("@name", System.Data.SqlDbType.VarChar, 50));
            cmd.Parameters.Add(new SqlParameter("@description", System.Data.SqlDbType.VarChar, 200));
            cmd.Parameters.Add(new SqlParameter("@color", System.Data.SqlDbType.VarChar, 25));
            cmd.Parameters.Add(new SqlParameter("@laces", System.Data.SqlDbType.VarChar, 5));


            cmd.Parameters["@name"].Value = "Asics";
            cmd.Parameters["@description"].Value = "Comfy Running shoes";
            cmd.Parameters["@color"].Value = "Black";
            cmd.Parameters["@laces"].Value = "Yes";


            oConn.Open();
            cmd.ExecuteNonQuery();
            oConn.Close();

            Select_Click(sender, e);

        }

        protected void Update_Click(object sender, EventArgs e)
        {
            dbConn = new DbConn();
            SQL = "SELECT Max(ShoeID) AS MaxID FROM Assign05Shoes";
            ds = new DataSet();
            ds = dbConn.createDataSet(SQL);
            dt = new DataTable();
            dt = ds.Tables[0];

            if (dt.Rows[0][0].ToString() != "")
            {
                oConn = new SqlConnection(dbConn.connStr);
                SQL = "UPDATE Assign05Shoes SET Name=@name WHERE ShoeID=@shoeID";
                cmd = new SqlCommand(SQL, oConn);

                cmd.Parameters.Add(new SqlParameter("@shoeID", System.Data.SqlDbType.Int, 4));
                cmd.Parameters.Add(new SqlParameter("@name", System.Data.SqlDbType.VarChar, 100));
                cmd.Parameters["@shoeID"].Value = dt.Rows[0][0].ToString();
                cmd.Parameters["@name"].Value = "HOKA";

                oConn.Open();
                cmd.ExecuteNonQuery();
                oConn.Close();

            }
            Select_Click(sender, e);
        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            dbConn = new DbConn();
            SQL = "SELECT Max(ShoeID) AS MaxID FROM Assign05Shoes";
            ds = new DataSet();
            ds = dbConn.createDataSet(SQL);
            dt = new DataTable();
            dt = ds.Tables[0];

            if (dt.Rows[0][0].ToString() != "")
            {
                oConn = new SqlConnection(dbConn.connStr);
                SQL = "DELETE FROM Assign05Shoes WHERE ShoeID=@shoeID";
                cmd = new SqlCommand(SQL, oConn);

                cmd.Parameters.Add(new SqlParameter("@shoeID", System.Data.SqlDbType.Int, 4));
                cmd.Parameters["@shoeID"].Value = dt.Rows[0][0].ToString();

                oConn.Open();
                cmd.ExecuteNonQuery();
                oConn.Close();
            }
            Select_Click(sender, e);
        }

        protected void DeleteAll_Click(object sender, EventArgs e)
        {
            dbConn = new DbConn();
            SQL = "DELETE FROM Assign05Shoes";
            oConn = new SqlConnection(dbConn.connStr);
            cmd = new SqlCommand(SQL, oConn);

            oConn.Open();
            cmd.ExecuteNonQuery();
            oConn.Close();

            Select_Click(sender, e);
        }

        protected void Truncate_Click(object sender, EventArgs e)
        {
            dbConn = new DbConn();
            SQL = "TRUNCATE TABLE Assign05Shoes";
            oConn = new SqlConnection(dbConn.connStr);
            cmd = new SqlCommand(SQL, oConn);

            oConn.Open();
            cmd.ExecuteNonQuery();
            oConn.Close();

            Select_Click(sender, e);
        }
    }
}