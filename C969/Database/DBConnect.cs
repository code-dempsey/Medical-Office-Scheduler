using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfficeScheduler.Database
{
	public class DBConnect
	{
		public static MySqlConnection dbConnection { get; set; }


		public static void openConnection() 
		{
			try
			{
				string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;

				dbConnection = new MySqlConnection(constr);

				dbConnection.Open();
			}
			catch (MySqlException ex)
			{
				MessageBox.Show(ex.Message);
			}
		}


		public static void closeConnection()
		{
			try
			{
				if (dbConnection != null)
				{
					dbConnection.Close();
				}
				dbConnection = null;
			}
			catch (MySqlException ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
