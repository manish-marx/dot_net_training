using System;
using System.Data;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        string conn = "Data Source = C63E93AEA0E2578;Initial Catalog = Excercise;Integrated Security=SSPI;";
        using (SqlConnection connection = new SqlConnection(conn))
        {
            InsertOrder( connection ,4, "Bob Johnson", "D", 4);
            ReadOrder(connection);
           // UpdateOrder(connection,1, "updated Product", 10);
           // ReadOrder(connection);
           // DeleateOrder(connection , 2);
           // ReadOrder(connection);
        }
            
    }
    static void InsertOrder(SqlConnection connection ,int orderID , string CustomerName , string ProductName , int Quantity)
    {
        
            string query = "Insert into OrdersTable (OrderID, CustomerName , ProductName , Quantity) , values (@orderID, @CustomerName,@ProductName,@Quantity)";

            using SqlCommand command = new SqlCommand(query, connection);
        {
            command.Parameters.AddWithValue("@OrderID", orderID);
            command.Parameters.AddWithValue("@CustomerName", CustomerName);
            command.Parameters.AddWithValue("@ProdutName", ProductName);
            command.Parameters.AddWithValue("@Quantity", Quantity);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                Console.WriteLine("order inserted successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
    }
    static void ReadOrder(SqlConnection connection)
    {
        string query = "select * from OrdersTable";
        using( SqlCommand command = new SqlCommand(query,connection))
            {
            try
            {
                SqlDataReader reader = command.ExecuteReader();
                Console.WriteLine("orders");
                while (reader.Read())
                {
                    Console.WriteLine($"OrderID: {reader["OrderID"]}, CustomerName : {reader["CustomerName"]}, ProductName: {reader["ProductName"]},Quantity : {reader["Quantity"]}");
                }
                reader.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
