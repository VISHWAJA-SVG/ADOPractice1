using System;
using System.Data.SqlClient;
using System.Data;
namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.Connecting();
            Console.ReadKey();
        }
        public static void Connecting()
        {
            string ConnectionString = "data source=INLEN8520076178\\SQLEXPRESS; database=StudentDB; integrated security=SSPI";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                //SqlCommand cm= new SqlCommand("Select* from Student",con);
                //SqlCommand cm = new SqlCommand("Select count(id) from Student", con);
                //SqlCommand cm = new SqlCommand("insert into Student values (105, 'Ramesh', 'Ramesh@dotnettutorial.net', '1122334455')", con);
                //con.Open();


                //Console.WriteLine("Connection Established Successfully");


                //SqlDataReader sdr = cm.ExecuteReader();
                //while (sdr.Read())
                //{
                //  Console.WriteLine(sdr["Id"] + ",  " +sdr["Name"] + ",  " + sdr["Email"] + ",  " + sdr["Mobile"]);
                //}


                //int Totalrows = (int)cm.ExecuteScalar();
                //Console.WriteLine("TotalRows in Student Table :  " + Totalrows);


                //int rowsaffected = cm.ExecuteNonQuery();
                //Console.WriteLine("Inserted Rows = " + rowsaffected);

                //cm.CommandText="Update Student set Name ='Ramesh Changed' where Id=104";
                //int rowsaffected = cm.ExecuteNonQuery();
                //Console.WriteLine("Updated Rows = " + rowsaffected);


                SqlDataAdapter da = new SqlDataAdapter("Select * from Student", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Console.WriteLine("Using DataTable");
                foreach (DataRow row in dt.Rows)
                {
                    Console.WriteLine(row["Name"] + ", " + row["Email"] + ", " + row["Mobile"]);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Student");
                    //Console.WriteLine("Using dataset");
                    //foreach(DataRow row in ds.Tables["Student"].Rows)
                    //{
                      //  Console.WriteLine(row["Name"] + ",  " + row["Email"] + ",  " + row["Mobile"]);
                    //}
                }
            }
        }
    }
}
