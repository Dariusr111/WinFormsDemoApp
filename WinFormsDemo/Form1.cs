using System;
using System.Data.SQLite;
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using static System.Net.Mime.MediaTypeNames;
using System.Security.Cryptography;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static SQLite.SQLite3;
using System.Diagnostics;

namespace WinFormsDemo
{
	public partial class Form1 : Form
	{


		public Form1()
		{
			InitializeComponent();
			label1.Hide();
			label3.Hide();
		}


		private void label1_Click(object sender, EventArgs e)
		{
		}


	    // Select Csv File
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
			
		
			// USERS IMPORT
			if (radioButton1.Checked == true)
			{
				label3.Hide();
				if (path1 != null)
				{
					// READING CSV
					using var streamReader = File.OpenText(path1);  // Path to Cvs file
					using var csvReader = new CsvReader(streamReader, CultureInfo.CurrentCulture);


					// CHECKING IF TABLE EXIST
					Database databaseObject = new Database();
					string query = "SELECT name FROM sqlite_master WHERE type='table' AND name='users'";
					SQLiteCommand myCommand = new SQLiteCommand(query, databaseObject.myConnection);
					databaseObject.OpenConnection();
					SQLiteDataReader result = myCommand.ExecuteReader();


					// if table !exist -> creating new
					if (!result.HasRows)
					{
						// CREATE DATABASE		
						string query1 = "CREATE TABLE users (`id` INTEGER, `username` TEXT, `password` TEXT, `company` TEXT, `email` TEXT, `role` INTEGER, `client_code` TEXT, PRIMARY KEY(`id` AUTOINCREMENT));";

						//Database databaseObject = new Database();
						SQLiteCommand myCommand1 = new SQLiteCommand(query1, databaseObject.myConnection);
						//databaseObject.OpenConnection();
						myCommand1.CommandText = query1;
						myCommand1.ExecuteNonQuery();

						// INSERT INTO DATABASE		
						string query2 = "INSERT INTO users (`username`, `password`, `company`, `email`, `role`, `client_code`) VALUES (@v0, @v1, @v2, @v3, @v4, @v5);";

						SQLiteCommand myCommand2 = new SQLiteCommand(query2, databaseObject.myConnection);

						string value;

						while (csvReader.Read())
						{
							for (int i = 0; csvReader.TryGetField<string>(i, out value); i++)
							{

								myCommand2.Parameters.AddWithValue("@v" + i, value);
								Console.WriteLine(value);

							}

							myCommand2.ExecuteNonQuery();

						}

						databaseObject.CloseConection();
						Console.ReadLine();

					}

					else
					{
						// INSERT INTO DATABASE		

						string query2 = "INSERT INTO users (`username`, `password`, `company`, `email`, `role`, `client_code`) VALUES (@v0, @v1, @v2, @v3, @v4, @v5);";

						//Database databaseObject = new Database();
						SQLiteCommand myCommand2 = new SQLiteCommand(query2, databaseObject.myConnection);
						databaseObject.OpenConnection();

						string value;

						while (csvReader.Read())
						{
							for (int i = 0; csvReader.TryGetField<string>(i, out value); i++)
							{

								myCommand2.Parameters.AddWithValue("@v" + i, value);
								Console.WriteLine(value);

							}

							myCommand2.ExecuteNonQuery();

						}

						databaseObject.CloseConection();
						Console.ReadLine();


					}

					label1.Show();

				}

				else
				{
					textBox1.Text = "Jûs nepasirinkote failo!";
				}

			}


			// MATERIALS IMPORT
			else if (radioButton1.Checked == true)
			{
				label3.Hide();



			}

			// COMPONENTS IMPORT
			else if (radioButton3.Checked == true)
			{
				label3.Hide();
				if (path1 != null)
				{
					// READING CSV
					using var streamReader = File.OpenText(path1);  // Path to Cvs file
					using var csvReader = new CsvReader(streamReader, CultureInfo.CurrentCulture);


					// CHECKING IF TABLE EXIST
					Database databaseObject = new Database();
					string query = "SELECT name FROM sqlite_master WHERE type='table' AND name='components'";
					SQLiteCommand myCommand = new SQLiteCommand(query, databaseObject.myConnection);
					databaseObject.OpenConnection();
					SQLiteDataReader result = myCommand.ExecuteReader();


					// if table !exist -> creating new
					if (!result.HasRows)
					{
						// CREATE DATABASE		
						string query1 = "CREATE TABLE components (`id` INTEGER, `in1` TEXT, `in2` TEXT, `in3` TEXT, `in4` TEXT, `in5` TEXT, `quantity` INTEGER, `description` TEXT, `material1` TEXT, `material2` TEXT, `material3` TEXT, `material4` TEXT, PRIMARY KEY(`id` AUTOINCREMENT));";

						//Database databaseObject = new Database();
						SQLiteCommand myCommand1 = new SQLiteCommand(query1, databaseObject.myConnection);
						//databaseObject.OpenConnection();
						myCommand1.CommandText = query1;
						myCommand1.ExecuteNonQuery();

						// INSERT INTO DATABASE		
						string query2 = "INSERT INTO components (`in1`, `in2`, `in3`, `in4`, `in5`, `quantity`, `description`, `material1`, `material2`, `material3`, `material4`) VALUES (@v0, @v1, @v2, @v3, @v4, @v5, @v6, @v7, @v8, @v9, @v10);";

						SQLiteCommand myCommand2 = new SQLiteCommand(query2, databaseObject.myConnection);

						string value;

						while (csvReader.Read())
						{
							for (int i = 0; csvReader.TryGetField<string>(i, out value); i++)
							{

								myCommand2.Parameters.AddWithValue("@v" + i, value);
								Console.WriteLine(value);

							}

							myCommand2.ExecuteNonQuery();

						}

						databaseObject.CloseConection();
						Console.ReadLine();

					}

					else
					{
						// INSERT INTO DATABASE		

						string query2 = "INSERT INTO components (`in1`, `in2`, `in3`, `in4`, `in5`, `quantity`, `description`, `material1`, `material2`, `material3`, `material4`) VALUES (@v0, @v1, @v2, @v3, @v4, @v5, @v6, @v7, @v8, @v9, @v10);";

						//Database databaseObject = new Database();
						SQLiteCommand myCommand2 = new SQLiteCommand(query2, databaseObject.myConnection);
						databaseObject.OpenConnection();

						string value;

						while (csvReader.Read())
						{
							for (int i = 0; csvReader.TryGetField<string>(i, out value); i++)
							{

								myCommand2.Parameters.AddWithValue("@v" + i, value);
								Console.WriteLine(value);

							}

							myCommand2.ExecuteNonQuery();

						}

						databaseObject.CloseConection();
						Console.ReadLine();


					}

					label1.Show();

				}

				else
				{
					textBox1.Text = "Jûs nepasirinkote failo!";
				}

			}

			else
			{

				label3.Show();

			}






		}


		private void label1_Click_1(object sender, EventArgs e)
		{

		}


		// USERS IMPORT
		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			radioButton1.Checked = true;
			
		}


		// MATERIALS IMPORT
		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{

		}


		// COMPONENTS IMPORT
		private void radioButton3_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		// Jûs nepasirinkote lentelës
		private void label3_Click(object sender, EventArgs e)
		{

		}
	}
}