using static System.Net.Mime.MediaTypeNames;
using System.Formats.Asn1;
using Microsoft.Data.Sqlite;
using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Globalization;


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
			{ textBox1.Text = "You didn't select the file!"; }

		}

		private void button1_Click(object sender, EventArgs e)
		{

			//  SqliteConnection connection = new SqliteConnection("Data Source=C:/test.db;");
			//	connection.Open();
			//	SqliteCommand command = connection.CreateCommand();
			//	command.Transaction = connection.BeginTransaction();
			//	command.CommandText = "INSERT INTO [users] VALUES(@C0,@C1,@C2,@C3,@C4,@C5,@C6)";

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
						System.Diagnostics.Debug.WriteLine($"{value} ");
					}

				}

			}
			else
			{
				textBox1.Text = "You didn't select the file!";
			}


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