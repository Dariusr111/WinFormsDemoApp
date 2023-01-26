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

		private void button1_Click(object sender, EventArgs e)
		{

			//  SqliteConnection connection = new SqliteConnection("Data Source=C:/test.db;");
			//	connection.Open();
			//	SqliteCommand command = connection.CreateCommand();
			//	command.Transaction = connection.BeginTransaction();
			//	command.CommandText = "INSERT INTO [users] VALUES(@C0,@C1,@C2,@C3,@C4,@C5,@C6)";

			var csvConfig = new CsvConfiguration(CultureInfo.CurrentCulture)
			{
				HasHeaderRecord = false
			};




			using var streamReader = new StreamReader("C:/usersh.csv");
			using var csvReader = new CsvReader(streamReader, csvConfig);

			string value;

			while (csvReader.Read())
			{
				for (int i = 0; csvReader.TryGetField<string>(i, out value); i++)
				{
					System.Diagnostics.Debug.WriteLine($"{value} ");
				}

				Console.WriteLine();

			}


			//var users = csvReader.GetRecords<User>();

			//foreach (var user in users)
			//{
			//	System.Diagnostics.Debug.WriteLine(user);
			//}
			
		}

		private void button2_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Title = "Select File";
			openFileDialog.InitialDirectory = @"C:\";
			openFileDialog.Filter = "All files (*.*)|*.*|Excel File (*.csv)|*.csv";
			openFileDialog.FilterIndex = 2;
			openFileDialog.ShowDialog();
			if (openFileDialog.FileName != "")
			{ textBox1.Text = openFileDialog.FileName; }
			else
			{ textBox1.Text = "You didn't select the file!"; }

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