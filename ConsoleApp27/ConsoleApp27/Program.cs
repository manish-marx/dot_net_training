using System;
using System.Data;
using System.Data.SqlClient;

namespace Adonet
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString =  "Data Source = C63E93AEA0E2578; Initial Catalog = master; "
                           + "Integrated Security = true";
            DateTime startDate = new DateTime(1996, 07, 04);
            DateTime endDate = new DateTime(1996, 07, 15);
            int employeeID = 3;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("GetOrderByEmployeesAndDateRange", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@StartDate", startDate);
                command.Parameters.AddWithValue("EndDate", endDate);
                command.Parameters.AddWithValue("EmployeeID", employeeID);
                SqlDataReader read = command.ExecuteReader();
                while(read.Read())
                {
                    Console.WriteLine($"Order ID: {read["OrderID"]} , Employee Name :{read["EmployeeName"]}, Order Date{read["OrderDate"]}");
                }
            }
        }
    }
}
