using System;
using System.Data;
using System.Data.SqlClient;

namespace Adonet
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source = C63E93AEA0E2578; Initial Catalog = master; "
                          + "Integrated Security = true";
            DataTable customersDataTable = ReadDataFrommaster(connectionString, "select * from Customers");
            Console.WriteLine(customersDataTable);
            DisplayDataTable(customersDataTable);
            

            DataTable frenchCustomersDataTable = FilterData(customersDataTable, "Country = 'France'");
            Console.WriteLine("\n french customer name");
            DisplayDataTable(frenchCustomersDataTable);
      
        }
        static DataTable ReadDataFrommaster(string connectionString , string query)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error reading data from master database:{ex.Message}");
            }
            return dataTable;
        }
        static void DisplayDataTable (DataTable dataTable)
        {
            foreach(DataRow row in dataTable.Rows)
            {
                foreach(DataColumn column in dataTable.Columns)
                {
                    Console.WriteLine($"{row[column]}\t");
                }
                Console.WriteLine();
            }
        }
        static DataTable FilterData(DataTable dataTable , string filterexpression)
        {
            DataTable filteredData = dataTable.Clone();
            DataRow[] filteredRows = dataTable.Select(filterexpression);
            foreach(DataRow row in filteredRows)
            {
                filteredData.ImportRow(row);
            }
            return filteredData;
        }
        
    }
}

