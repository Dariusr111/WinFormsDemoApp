using static System.Net.Mime.MediaTypeNames;
using System.Formats.Asn1;
using Microsoft.Data.Sqlite;
using CsvHelper;
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

		private void button1_Click(object sender, EventArgs e)
		{
			string databasePath = "Data Source=C:\\Salda/database/test.db; Version=3; New=False; Compress=True";
			SqliteConnection connection = new SqliteConnection(databasePath);
			connection.Open();
			SqliteCommand command = connection.CreateCommand();
			command.Transaction = connection.BeginTransaction();
			command.CommandText = "INSERT INTO [users] VALUES(@C0,@C1,@C2,@C3,@C4,@C5,@C6)";

			using (var fileStream = new FileStream("C:\\Salda/uzduotis/users.csv", FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
			using (StreamReader streamReader = new StreamReader(fileStream))
			{
				using (CsvReader reader = new CsvReader(streamReader))
				{
					reader.ReadHeader();
					while (reader.ReadHeader != null)
					{
						DbDataRecord record = reader.GetRecord;
					}
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


}