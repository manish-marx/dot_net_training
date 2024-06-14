using System;
using System.Data;
using System.Data.SqlClient;
namespace practiseset
{
    class program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source = C63E93AEA0E2578; Initial Catalog = master; "
                         + "Integrated Security = true";
            // create a Dataset to store data from both customers and orders tables
            DataSet dataset = new DataSet();
            //Read data from custmers table 
            DataTable customersTable = ReadDataFrommaster(connectionString, "select * from customers", "Customers");
            dataset.Tables.Add(customersTable);
            DataTable ordersTable = ReadDataFrommaster(connectionString, "select * from orders", "orders");
            dataset.Tables.Add(ordersTable);
            Console.WriteLine("Customers Data");
            DisplayDatatable(cutomersTable);

        }
    }
}
