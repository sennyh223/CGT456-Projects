using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;


namespace Assign05
{
    public class DbConn
    {
        public string connStr = "Data Source=ecn-classmssql.ecn.purdue.edu;Initial Catalog=zCGT456_huan1669; Integrated Security=True;";
        public SqlDataAdapter dbSDA;
        public DataSet dbDS;
        public SqlDataReader dbDR;
        public DataTable dbDT;
        public SqlConnection dbConn;
        public SqlCommand dbCmd;
        public string SQL;

        
        
        //This is the constructor for the class DbConn
        public DbConn()
        {

        }
        public System.Data.DataSet createDataSet(string sql) 
        {   
            dbConn = new SqlConnection(connStr);    //connection to the database
            dbConn.Open();                          //open the connection
            dbCmd = new SqlCommand(sql, dbConn);    //Create a command to execute at the database
            dbSDA = new SqlDataAdapter();           //Instantiate an instance of SDA
            dbSDA.SelectCommand = dbCmd;            //Store the command in the SDA
            dbDS = new DataSet();                   //Instantiate an instance of DataSet
            dbSDA.Fill(dbDS);                       //Use the SDA to fill the DataSet
            return dbDS;                            //Return the DataSet

        }

        public System.Data.SqlClient.SqlDataReader createDataReader(string sql)
        {
            dbConn = new SqlConnection(connStr);    //connection to the database
            dbConn.Open();                          //open the connection
            dbCmd = new SqlCommand(sql, dbConn);    //Create a command to execute at the database

            dbDR = dbCmd.ExecuteReader();
            
            return dbDR;
        }
    }
}