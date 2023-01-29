using static System.Net.Mime.MediaTypeNames;
using System.Formats.Asn1;
using Microsoft.Data.Sqlite;
using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace WinFormsDemo
{
	public partial class Form1 : Form
	{


		public Form1()
		{
			InitializeComponent();
		}



		private void label1_Click(object sender, EventArgs e)
		{
		}


		

		private string path1;

		private void button2_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Title = "Select File";
			openFileDialog.InitialDirectory = @"C:\";
			openFileDialog.Filter = "All files (*.*)|*.*|Excel File (*.csv)|*.csv";
			openFileDialog.FilterIndex = 2;
			openFileDialog.ShowDialog();
			if (openFileDialog.FileName != "")
			{ 
				textBox1.Text = openFileDialog.FileName;
				path1 = openFileDialog.FileName;
			}
			else
			{ textBox1.Text = "Jûs nepasirinkote failo!"; }

		}

		private void button1_Click(object sender, EventArgs e)
		{

			if (path1 != null)
			{
				var csvConfig = new CsvConfiguration(CultureInfo.CurrentCulture)
				{
					HasHeaderRecord = true
					
				};



				using var streamReader = new StreamReader(path1);
				using var csvReader = new CsvReader(streamReader, csvConfig);

				string value;

				while (csvReader.Read())
				{
					for (int i = 0; csvReader.TryGetField<string>(i, out value); i++)
					{
					//	System.Diagnostics.Debug.WriteLine($"{value} ");


					}

				}

				

			}
			else
			{
				textBox1.Text = "Jûs nepasirinkote failo!";
			}
			
		}

		public static void AddUserToDatabase(User user)
		{
			SqliteConnection con = new SqliteConnection("data source=C:/database/test2.db;");
			SqliteCommand cmd = new SqliteCommand
			{
				Connection = con,
				CommandText =
				"INSERT INTO users (id,username,password,company,email,role,client_code)" +
				"value (@v1,@v2,@v3,v4,@v5,@v6,@v7)"
			};
			cmd.Parameters.AddWithValue("@v1", user.id);
			cmd.Parameters.AddWithValue("@v2", user.username);
			cmd.Parameters.AddWithValue("@v3", user.password);
			cmd.Parameters.AddWithValue("@v4", user.company);
			cmd.Parameters.AddWithValue("@v5", user.email);
			cmd.Parameters.AddWithValue("@v6", user.role);
			cmd.Parameters.AddWithValue("@v7", user.client_code);

			con.Open();
			cmd.ExecuteNonQuery();
			con.Close();

		}

	}

	
	public class User
	{
		public int id { get; set; }
		public string username { get; set; }
		public string password { get; set; }
		public string company { get; set; }
		public string email { get; set; }
		public int role { get; set; }
		public string client_code { get; set; }
	}


}