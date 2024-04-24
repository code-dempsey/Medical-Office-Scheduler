using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace C969
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnConnect_Click(object sender, EventArgs e)
		{
			//get connection string
			string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;

			//make connection
			MySqlConnection conn = null;

			try
			{
				//initialize mysql connection
				conn = new MySqlConnection(constr);

				//open mysql connection
				conn.Open(); //this is a socket call to a db
				MessageBox.Show("Connection is open.");
			}
			catch (MySqlException ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally //do this whether try is successful or catch occurs
			{
				//close the connection
				if (conn != null)
				{
					conn.Close();
					MessageBox.Show("Connection is closed.");
				}
			}

		}
	}
}
