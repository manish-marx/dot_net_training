using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

class program
{
    static void Main()
    {
        string connectionString = "Data Source = C63E93AEA0E2578; Initial Catalog = Practisesp; "
                           + "Integrated Security = true";
        string createTableQuery = @"CREATE TABLE Students (
                                   StudentID int primary key,
                                   FirstName nvarchar(50),
                                   LastName nvarchar(50),
                                   Age int)";
        string insertQuery = @"insert into Students1 (StudentID , FirstName , LastName , Age)
                                         values     (1, 'John' , 'Brown' , 18)
                                                    (2, 'David', 'dad'   , 20)
                                                    (3, 'sir'  , 'jadu'  , 22)";
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            using (SqlCommand command = new SqlCommand(createTableQuery, connection))
            {
                command.ExecuteNonQuery();
            }
            using (SqlCommand command = new SqlCommand(insertQuery, connection))
            {
                command.ExecuteNonQuery();
            }
            string selectQuery = "select * from Students1";
            using (SqlCommand command = new SqlCommand(selectQuery, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if(reader.HasRows)
                    {
                        Console.WriteLine("StudentID\tFirstName\tLastName\tAge");
                        while(reader.Read())
                        {
                            Console.WriteLine($"{reader.GetInt32(0)}\t{reader.GetString(1)}\t{reader.GetString(2)}\t{reader.GetInt32(3)}");

                        }
                    }
                    else
                    {
                        Console.WriteLine("no response found");
                    }
                }
            }
  
        }
    }
}
