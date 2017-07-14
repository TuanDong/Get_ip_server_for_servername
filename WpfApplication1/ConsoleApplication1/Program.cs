using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Net;

namespace ConsoleApplication1
{
	class Program
	{
		static void Main(string[] args)
		{
			//DataTable table = System.Data.Sql.SqlDataSourceEnumerator.Instance.GetDataSources();
			//foreach (DataRow row in table.Rows)
			//{
			//	foreach (DataColumn dataColumn in table.Columns)
			//	{
			//		if (dataColumn.ColumnName == "ServerName")
			//		{
			//			Console.Write("{0} ={1}", row[dataColumn.ColumnName].ToString(), ";");
			//		}
			//	}
			//}

			DataTable table = System.Data.Sql.SqlDataSourceEnumerator.Instance.GetDataSources();
			foreach (DataRow row in table.Rows)
			{
				IPHostEntry host;
				host = Dns.GetHostByName(row["ServerName"].ToString());
				Console.WriteLine("{0} : {1}", row["ServerName"].ToString(),host.AddressList[0]);
			}
			Console.ReadKey();
		}
		
	}
}
