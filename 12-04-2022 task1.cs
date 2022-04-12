using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace Data
{

    class _12_04_2022_task1
    {
        SqlConnection con = new SqlConnection("data source = AsHWiN; Database = Trial; user id = sa; password = P@ssw0rd");
        public void insertsp()
        {

            SqlCommand cmd = new SqlCommand("sp_Day_26", con);
            //SqlCommand cmd = new SqlCommand("sp_InsTest", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //cmd.Parameters.Add("@studendId", SqlDbType.Int).Value = 2009;
            cmd.Parameters.Add("@fName", SqlDbType.VarChar).Value = "Vijay";
            cmd.Parameters.Add("@lName", SqlDbType.VarChar).Value = "Kumar";
            cmd.Parameters.Add("@ContactID", SqlDbType.Char).Value = "9626021806";
            cmd.Parameters.Add("@EmailId", SqlDbType.VarChar).Value = "vijay@";
            cmd.Parameters.Add("@Gender", SqlDbType.Char).Value = "M";
            con.Open();
            cmd.ExecuteNonQuery();
            Console.WriteLine("Row Inserted");
            con.Close();
        }
        public void Updatesp(string FName, string LName)
        {

            //SqlConnection con = new SqlConnection("data source = DESKTOP-NE6M66C;database = Newdatabase;user id = sa ;password = P@ssw0rd");
            SqlCommand cmd = new SqlCommand("upd_task1", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@FName", SqlDbType.VarChar).Value =FName;
            cmd.Parameters.Add("@LName", SqlDbType.VarChar).Value = LName;
            con.Open();
            cmd.ExecuteNonQuery();
            Console.WriteLine("Updated Succesfully");
            con.Close();
        }
        public void deletesp(string FName)
        {
            SqlCommand cmd = new SqlCommand("del_task2", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@FName", SqlDbType.VarChar).Value = FName;
            con.Open();
            cmd.ExecuteNonQuery();
            Console.WriteLine("you cannot delete the Instead ");
            con.Close();

        }
        public void ReadData()
        {
            //SqlConnection con = new SqlConnection("data source = AsHWiN; Database = Trial; user id = sa; password = P@ssw0rd");
            SqlCommand cmd = new SqlCommand("Select*from day18t2", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("StudentID : " + dr[0] + " " + "Fname : " + dr[1]+"Lname : " + dr[2] + " " + "Contact : " + dr[3]+ "EmailID: " + dr[4] + " " + "Gender : " + dr[5]);//{0}
            }
            con.Close();
        }
        public static void Main()
        {
            _12_04_2022_task1 obj = new _12_04_2022_task1();
            obj.insertsp();
            Console.WriteLine("Enter the Fname:");
            string FName = Console.ReadLine();
            Console.WriteLine("Enterb the Lname:");
            string LName = Console.ReadLine();
            obj.Updatesp(FName, LName);
            obj.deletesp(FName);
            obj.ReadData();
        }
    }
}
