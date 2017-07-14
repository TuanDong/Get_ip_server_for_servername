using Delete_Tables_PO.FO_Moduel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Delete_Tables_PO.TableModuel
{
    class TableHandling
    {
        #region Property
        private string ConnectionString = "";
        private string query = "";
        public List<string> TableNames, DatabaseList;
	
        #endregion

        #region Method

        //Default contructor
        public TableHandling()
        {
            DatabaseList = new List<string>();	
        }

        //Set connection string
        public void SetConnection(string serverName, string UserName, string Password, string database)
        {
            ConnectionString = "Data Source=" + serverName
               + ";User Id=" + UserName
               + ";Password=" + Password;
            if (database != "")
            {
                ConnectionString += ";Initial Catalog=" + database + ";";
            }
            else
            {
                ConnectionString += ";Initial Catalog=master;";
            }
        }

        //Get databases after login 
        public List<String> GetListData(string type)
        {
            SqlConnection con = new SqlConnection(ConnectionString);

            query = "SELECT name FROM master.dbo.sysdatabases" +
                              " WHERE name NOT IN ('master', 'tempdb', 'model', 'msdb'," +
                              "'ReportServer','ReportServerTempDB')" +
                              " and name like '"+type+"%'";

            con.Open();

            SqlDataReader reader;

            SqlCommand cmd = new SqlCommand(query, con);

            reader = cmd.ExecuteReader();

            DatabaseList = new List<string>();

            while (reader.Read())
            {
                DatabaseList.Add(reader[0].ToString());
            }

            con.Close();

            return DatabaseList;
        }

        // Function : Detele table 
        public void DeleteTable(string type)
        {					
			
            foreach (var item in TableNames)
            {
                SqlConnection con = new SqlConnection(ConnectionString);				
                con.Open();
                string query = "";
                SqlDataReader reader;

				if (type == "FO")
				{
					FO temp = new FO();
					query = temp.Condition(item, query);
				}
                SqlCommand cmd = new SqlCommand(query, con);
                reader = cmd.ExecuteReader();
                con.Close();
            }
        }
		public void DeleteTable_Where(string table,string parameter="")
		{
			SqlConnection con = new SqlConnection(ConnectionString);
			con.Open();
			SqlDataReader reader;
			string query = "";
			if(parameter!="")
			{
				 query = "delete from " + table + " where " + parameter;
			}else
			{
				query = "delete from " + table;
			}
			SqlCommand cmd = new SqlCommand(query, con);
			reader = cmd.ExecuteReader();
			con.Close();
		}
        #endregion
    }
}
