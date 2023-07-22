using System.Data.SqlClient;

namespace WorkingWithDatabase
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//new Program().CreateTable();   //Had I used "public static void CreateTable()", I couldn't make this a method of the Program instance
			//simply, CreateTable(); would have sufficed
			//AddRecord();
			RetrieveRecords();
			//DeleteRecords(101);
		}

		public void CreateTable()
		{
			SqlConnection conn = null;

			try
			{
				//Creating db connection
				conn = new SqlConnection("Data Source=BIPLAV\\SQLEXPRESS; Database=Student; Integrated Security=SSPI");
				//. means sql server is in local machine; replace with IP address for server in different device
				//SSPI allows the application to connect to the database using the current Windows user's credentials, without explicitly providing a username and password.

				//SQL Query
				SqlCommand cmd = new SqlCommand("Create table student(id int primary key not null, name varchar(100), email varchar(50), join_date date)", conn);

				//Opening Connection
				conn.Open();

				//Executing SQL Query
				cmd.ExecuteNonQuery();

				Console.WriteLine("Table 'student' successfully created.");

			}
			catch(Exception e)
			{
				Console.WriteLine("Something is wrong"+ e.Message);
			}
			finally
			{
				conn?.Close();
			}

		}

		public static void AddRecord()
		{
			SqlConnection? conn = null;

			try
			{

				conn = new SqlConnection("Data Source=BIPLAV\\SQLEXPRESS; Database=Student; Integrated Security=SSPI");

				SqlCommand cmd = new SqlCommand("Insert into student(id,name,email,join_date) values('102','Eloise Waters','ellewaters12@gmail.com','2001-09-23')", conn);

				conn.Open();

				cmd.ExecuteNonQuery();

				Console.WriteLine("Record inserted successfully.");

			}
			catch (Exception e)
			{
				Console.WriteLine("Something is wrong" + e.Message);
			}
			finally
			{
				conn?.Close();
			}

		}
		public static void RetrieveRecords()
		{
			SqlConnection? conn = null;
			try
			{
				conn = new SqlConnection("Data Source=BIPLAV\\SQLEXPRESS; Database=Student; Integrated Security=SSPI");
				SqlCommand cmd = new SqlCommand("Select * from Student",conn);
				conn.Open();
				
				SqlDataReader reader = cmd.ExecuteReader();

				while (reader.Read())
				{
					Console.WriteLine(reader["id"]+" " + reader["name"] +" "+ reader["email"]);
				}

				Console.WriteLine("Record successfully retrieved.");

			}
			catch (Exception e)
			{
				Console.WriteLine("Oops! There was an error." + e.Message);
			}

			finally
			{
				conn.Close();
			}

		}

		public static void DeleteRecords(int id)
		{
			SqlConnection? conn = null;
			try
			{
				conn = new SqlConnection("Data Source=BIPLAV\\SQLEXPRESS; Database=Student; Integrated Security=SSPI");
				SqlCommand cmd = new SqlCommand($"Delete from Student Where id ={id}",conn);
				conn.Open();
				cmd.ExecuteNonQuery();
				Console.WriteLine($"Record with id={id} successfully deleted!");
			}

			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			finally
			{
				conn?.Close();
			}
		}
	}
}