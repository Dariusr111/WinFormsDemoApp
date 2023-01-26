using static System.Net.Mime.MediaTypeNames;
using System.Formats.Asn1;
using Microsoft.Data.Sqlite;
using CsvHelper;
using System;
using System.Collections;
using System.Globalization;
using System.Data.Common;



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

		private void button1_Click(object sender, EventArgs e, string[] args)
		{

			//  SqliteConnection connection = new SqliteConnection("Data Source=C:/test.db;");
			//	connection.Open();
			//	SqliteCommand command = connection.CreateCommand();
			//	command.Transaction = connection.BeginTransaction();
			//	command.CommandText = "INSERT INTO [users] VALUES(@C0,@C1,@C2,@C3,@C4,@C5,@C6)";

			using (var reader = new StreamReader("c:/users.csv"))
			using (var csv = new CsvReader(reader, cultureinfo.invariantculture))
			{
				var records = csv.GetRecords<Columns>();

				for (int i = 0; i < records.Count; i++)
				{
					Console.WriteLine(records[i]);
					break;
				}

			}


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

public class Columns
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