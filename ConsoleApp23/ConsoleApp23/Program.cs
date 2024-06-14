using System;
using System.Data;
using System.Data.SqlClient;

class SqlCommandDemo
{
    
       // SqlConnection conn = new SqlConnection("Data Source = C63E93AEA0E2578;Initial Catalog = Retail;Integrated Security=SSPI");
       // SqlDataReader rdr = null;
    static void Main()
    {
        string conn = "Data Source = C63E93AEA0E2578;Initial Catalog = Retail;Integrated Security=SSPI";
      //  SqlCommandDemo scd = new SqlCommandDemo();
        Console.WriteLine();
      
        //use Executenonquery method for insert;
        InsertOrder(conn, 4, "Bob johnson", "D", 4);
        Console.WriteLine();
        Console.WriteLine("After insert");
        Console.WriteLine("--------");

        ReadOrders(conn);

        UpdateOrder(conn , 1 , "Updated product",10);
        Console.WriteLine("categories after update");
        Console.WriteLine("--------");

        ReadOrders(conn);

        DeleteData(conn , 2);
        Console.WriteLine("categories after delete");
        Console.WriteLine("--------");

        ReadOrders(conn);
        

    }
    static void InsertData (string connectionstring , int OrderID , string CustomerName ,string ProductName , int Quantity)
    {
        using (SqlConnection connection = new Sqlconnection(con))

            try
            {
                // open the connection
                conn.Open();
                // prepare the command string
                string insetString = @"insert into categories
                             (CategoryName,Description)
                             values('Miscellaneous','whatever doesn't fir elsewhere')";
                // instantiate a new command with a query and connection
                SqlCommand cmd = new SqlCommand(insertstring, conn);
                cmd.ExecuteNonQuery();

            }
            finally
            {
                if (conn != null)
                {
                    conn.close();
                }
            }
    }


}

