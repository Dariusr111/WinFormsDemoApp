using System.Data.SQLite;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;


namespace WinFormsDemo
{
	internal class Database
	{
		public SQLiteConnection myConnection;

		public Database()
		{
			myConnection = new SQLiteConnection("Data Source=C:/database/test3.db");
			if (!File.Exists("C:/database/test3.db"))
			{
				SQLiteConnection.CreateFile("C:/database/test3.db");
				System.Console.WriteLine("Database file created");
			}
			else
			{
				System.Console.WriteLine("Database file already created");
			}
		}

		public void OpenConnection()
		{
			if (myConnection.State != System.Data.ConnectionState.Open)
			{
				myConnection.Open();
			}
		}

		// checking if db connection closed
		public void CloseConection()
		{
			if (myConnection.State != System.Data.ConnectionState.Closed)
			{
				myConnection.Close();
			}
		}

	}
}
