using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Data
{
    class _12_04_2022_Task_Sql
    {
        SqlConnection con = new SqlConnection("data source = AsHWiN; Database = Trial; user id = sa; password = P@ssw0rd");
        public void insert()
        {
            string sql= "insert day18t2(Fname,Lname,Contactno,emailId,Gender) values('Giri','M','4765342932','giri1234@','M')";
            SqlCommand cmd = new SqlCommand(sql,con);
            con.Open();
            cmd.ExecuteNonQuery();
            Console.WriteLine("Inserted succesfully");
            con.Close();
        }
        public void update()
        {
            string sql = "update day18t2  set Lname='B' where Fname='ivak' ";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();
            Console.WriteLine("Updated succesfully");
            con.Close();
        }
        public void delete()
        {
            string dsql = "delete from day18t2 where Fname='ivak' ";
            SqlCommand cmd = new SqlCommand(dsql, con);
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
                Console.WriteLine("StudentID : " + dr[0] + " " + "Fname : " + dr[1] + "Lname : " + dr[2] + " " + "Contact : " + dr[3] + "EmailID: " + dr[4] + " " + "Gender : " + dr[5]);//{0}
            }
            con.Close();
        }
        public static void Main()
        {
            _12_04_2022_Task_Sql obj = new _12_04_2022_Task_Sql();
            obj.insert();
            obj.update();
            obj.delete();
            obj.ReadData();
        }
    }
}
