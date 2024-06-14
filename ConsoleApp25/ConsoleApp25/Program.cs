using System;
using System.Data;
using System.Data.SqlClient;


class Program
{
    static void Main()
    {
        string connectionString = "Data Source= C63E93AEA0E2578; Initial Catalog = Retail;"
            + "Integrated Security = True";
        // provide the query string with a parameter placeholder.
       // string queryString = "UPDATE OrdersTable SET Quantity = @Newquantity WHERE OrderID = @OrderID ";
            

        // specify the parameter value;
        int Newquantity = 8;
        // create and open the connection in a using block this 
        //ensures that all resource will be closed and disposed when the code exits.
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string queryString = "UPDATE OrdersTable SET Quantity = @Newquantity WHERE OrderID = @OrderID ";

            //create the command and parameter objects.
            SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@qunat", Newquantity);
            command.Parameters.AddWithValue("OrderID", 2);
            //open the connection in a try /catch block 
            //create and execute the data reader ,writing the result 
            //set to the console window.
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("\t{0}\t{1}\t{2}", reader[0], reader[1], reader[2]);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();


            //string selectquery = "SELECT * FROM OrdersTable";
            //SqlCommand selectcommand = new SqlCommand(selectquery, connection);
            //using (SqlDataReader reader = selectcommand.ExecuteReader())
            //{
            //    Console.WriteLine("updated Orderstable");
            //    while (reader.Read())
            //    {
            //        Console.WriteLine($"OrderID: {reader["OrderID"]} , ProductName: {reader["ProductName"]} , CustomerName : {reader["CustomerName"]}, Quantity: {reader["Quantity"]}");
            //    }
            //}

            connection.Close();
        }
        
    }
}
